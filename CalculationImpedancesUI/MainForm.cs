﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculationImpedancesApp;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

namespace CalculationImpedancesUI
{
	public partial class MainForm : Form
	{
		//TODO: RSDN (+)
		/// <summary>
		/// All program data
		/// </summary>
		private Project _project = new Project();

		//TODO: Зачем публично? (+)
		/// <summary>
		/// Type of circuit element.
		/// </summary>
		private readonly List<string> Type = new List<string>
		{
			"",
			"Resistor",
			"Inductor",
			"Capacitor",
		};

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			UpdateComboBox();

			TypeComboBox.DataSource = Type;

			foreach (var i in _project.Circuits)
			{
				i.SegmentChanged += ShowMessage;
			}
		}

		private void FillCircuitNodes()
		{
			CircuitsTreeView.Nodes.Clear();
			var circuit = _project.SelectedCircuit;
			SegmentTreeNode mainCircuitNode = new SegmentTreeNode
			{
				Text = circuit.Name,
			};
			CircuitsTreeView.Nodes.Add(mainCircuitNode);
			foreach (var subSegment in circuit.SubSegments)
			{
				SegmentTreeNode subSegmentNode = new SegmentTreeNode
				{
					Text = subSegment is IElement ? subSegment.ToString() : subSegment.Name,
					Segment = subSegment
				};
				if (!(subSegmentNode.Segment is IElement))
				{
					FillTreeNode(subSegmentNode, subSegment);
				}

				CircuitsTreeView.Nodes[0].Nodes.Add(subSegmentNode);
			}

			CircuitsTreeView.ExpandAll();
		}

		private void FillTreeNode(SegmentTreeNode circuitNode, ISegment segment)
		{
			if (segment is IElement)
			{
				SegmentTreeNode elementNode = new SegmentTreeNode
				{
					Text = segment.ToString(),
					Segment = segment
				};
				circuitNode.Nodes.Add(elementNode);
			}
			else
			{
				foreach (var subSegment in segment.SubSegments)
				{
					SegmentTreeNode segmentNode = new SegmentTreeNode
					{
						Text = subSegment is IElement ? subSegment.ToString() : subSegment.Name,
						Segment = subSegment
					};
					circuitNode.Nodes.Add(segmentNode);
					if (!(subSegment is IElement))
					{
						FillTreeNode(segmentNode, subSegment);
					}
				}
			}
		}

		private void CircuitSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)

		{
			var selectedIndexCircuit = CircuitSelectionComboBox.SelectedIndex;
			if (selectedIndexCircuit != -1)
			{
				_project.SelectedCircuit = _project.Circuits[selectedIndexCircuit];
			}

			Calculate();
			FillCircuitNodes();
		}

		private void AddCircuitButton_Click(object sender, EventArgs e)
		{
			var circuit = new CircuitForm();
			circuit.ShowDialog();
			if (circuit.DialogResult == DialogResult.OK)
			{
				_project.Circuits.Add(circuit.NewCirciut);
				//TODO: Дубль (+)
				UpdateComboBox();
			}
		}

		private void EditCircuitButton_Click(object sender, EventArgs e)
		{
			var selectedIndex = CircuitSelectionComboBox.SelectedIndex;
			if (selectedIndex == -1)
			{
				MessageBox.Show("Select a circuit from the list", "Warning",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{

				var circuit = new CircuitForm();
				var selectedCircuit = _project.Circuits[selectedIndex];
				circuit.NewCirciut = selectedCircuit;
				circuit.ShowDialog();
				if (circuit.DialogResult == DialogResult.OK)
				{
					_project.Circuits[selectedIndex].Name = circuit.NewCirciut.Name;
					//TODO: Дубль (+)
					UpdateComboBox();
				}
			}

			Calculate();
		}

		private void RemoveCircuitButton_Click(object sender, EventArgs e)
		{
			var selectedIndex = CircuitSelectionComboBox.SelectedIndex;
			if (selectedIndex == -1)
			{
				MessageBox.Show("Select a circuit from the list", "Warning",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			//TODO: RSDN (+)
			var result = MessageBox.Show("Do you really want to remove this circuit?",
				"Remove Circuit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (result == DialogResult.OK)
			{
				var selectedCircuit = _project.Circuits[selectedIndex];
				_project.Circuits.Remove(selectedCircuit);
				//TODO: Дубль (+)
				UpdateComboBox();
			}
		}

		private void CalculateButton_Click(object sender, EventArgs e)
		{
			if (FrequencyTextBox.Text.Length != 0)
			{
				try
				{
					_project.Frequencies.Add(double.Parse(FrequencyTextBox.Text));
					FrequenciesListBox.Items.Add(double.Parse(FrequencyTextBox.Text));
				}
				catch
				{
					MessageBox.Show("Incorrect Value", "Warning",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			Calculate();
		}

		private void Calculate()
		{
			_project.Results = _project.SelectedCircuit.CalculateZ(_project.Frequencies);
			ImpedanceValues();
			ResultsListBox.DataSource = null;
			ResultsListBox.DataSource = _project.ImpedanceValues;
		}

		private void RemoveFrequencyButton_Click(object sender, EventArgs e)
		{
			var selectedIndex = FrequenciesListBox.SelectedIndex;
			if (selectedIndex == -1)
			{
				MessageBox.Show("Select a frequency from the list", "Warning",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var result = MessageBox.Show("Do you really want to remove this frequency?",
				"Remove Frequency", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (result == DialogResult.OK)
			{
				var selectedFrequency = _project.Frequencies[selectedIndex];
				_project.Frequencies.Remove(selectedFrequency);
				FrequenciesListBox.Items.RemoveAt(selectedIndex);
			}
		}

		private void AddElementButton_Click(object sender, EventArgs e)
		{
			//TODO: Дубль (+)
			try
			{
				var selectedIndex = CheckElementSelection();
				var elementForm = new AddEditSegmentForm();
				elementForm.ShowDialog();
				if (elementForm.DialogResult != DialogResult.OK)
				{
					return;
				}

				if (selectedIndex == CircuitsTreeView.Nodes[0])
				{
					//TODO: Дубль (+)

					_project.SelectedCircuit.SubSegments.Add(elementForm.NewElement);
				}

				if (selectedIndex.Segment is IElement)
				{
					selectedIndex = selectedIndex.Parent as SegmentTreeNode;
					//TODO: Дубль (+)

					selectedIndex.Segment.SubSegments.Add(elementForm.NewElement);
				}

				if (selectedIndex.Segment is ISegment)
				{
					//TODO: Дубль (+)

					selectedIndex.Segment.SubSegments.Add(elementForm.NewElement);
				}

				selectedIndex.Nodes.Add(new SegmentTreeNode
				{
					Text = elementForm.NewElement.ToString(),
					Segment = elementForm.NewElement
				});

				TypeComboBox.Text = "";
				NameTextBox.Text = "";
				ValueTextBox.Text = "";
				Calculate();
			}
			catch (ArgumentNullException exception)
			{
				MessageBox.Show(exception.ParamName, "Warning",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void EditElementButton_Click(object sender, EventArgs e)
		{
			//TODO: Дубль (+)
			try
			{
				var selectedIndex = CheckElementSelection();
				//TODO: Дубль (+)
				var elementForm = new AddEditSegmentForm{NewElement = selectedIndex.Segment as IElement};
				elementForm.ShowDialog();
				if (elementForm.DialogResult == DialogResult.OK)
				{
					var parent = selectedIndex.Parent as SegmentTreeNode;
					parent.Segment.SubSegments.Remove(selectedIndex.Segment);
					parent.Segment.SubSegments.Add(elementForm.NewElement);
					FillCircuitNodes();
					Calculate();
				}
			}
			catch (ArgumentNullException exception)
			{
				MessageBox.Show(exception.ParamName, "Warning",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void RemoveElementButton_Click(object sender, EventArgs e)
		{
			//TODO: Дубль (+)
			try
			{
				var selectedIndex = CheckElementSelection();
				if (selectedIndex == CircuitsTreeView.Nodes[0])
				{
					MessageBox.Show("Can't delete root element", "Error",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					//TODO: Дубль (+)
					var parent = selectedIndex.Parent as SegmentTreeNode;
					var element = selectedIndex.Segment;
					if (parent.Segment == null)
					{
						_project.SelectedCircuit.SubSegments.Remove(element);
					}
					else
					{
						parent.Segment.SubSegments.Remove(element);
					}

					parent.Nodes.Remove(selectedIndex);
				}
				Calculate();
			}
			catch (ArgumentNullException exception)
			{
				MessageBox.Show(exception.ParamName, "Warning",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void CircuitsTreeView_AfterSelect(object sender, TreeViewEventArgs e)
		{
			//TODO: Дубль (+)
			var selectedIndex = CheckElementSelection();

			if (selectedIndex.Segment is Resistor)
			{
				TypeComboBox.Text = "Resistor";
			}
			else if (selectedIndex.Segment is Inductor)
			{
				TypeComboBox.Text = "Inductor";
			}
			else if (selectedIndex.Segment is Capacitor)
			{
				TypeComboBox.Text = "Capacitor";
			}
			else
			{
				TypeComboBox.Text = "";
			}

			if (selectedIndex.Segment is IElement element)
			{
				NameTextBox.Text = selectedIndex.Segment.Name;
				ValueTextBox.Text = element.Value.ToString();
				EditElementButton.Enabled = true;
				EditSegmentButton.Enabled = false;
			}
			else
			{
				TypeComboBox.Text = "";
				NameTextBox.Text = "";
				ValueTextBox.Text = "";
				EditElementButton.Enabled = false;
				EditSegmentButton.Enabled = true;
			}
		}

		private void ShowMessage(object sender, EventArgs e)
		{
			//var message = e as ElementEventArgs;
			//MessageBox.Show(message.Message, "Information",
			//	MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void ImpedanceValues()
		{
			_project.ImpedanceValues = new List<string>();
			foreach (var i in _project.Results)
			{
				_project.ImpedanceValues.Add($"{Math.Round(i.Real, 3)} " +
											$"+ {Math.Round(i.Imaginary, 3)}*j");
			}
		}

		private void CircuitsTreeView_ItemDrag(object sender, ItemDragEventArgs e)
		{
			DoDragDrop(e.Item, DragDropEffects.Move);
		}

		private void CircuitsTreeView_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Move;
		}

		private void CircuitsTreeView_DragDrop(object sender, DragEventArgs e)
		{
			//TODO: Подозрительно много комментариев... (+)
			Point targetPoint = CircuitsTreeView.PointToClient(new Point(e.X, e.Y));

			// Куда перетаскиваем
			SegmentTreeNode targetNode = CircuitsTreeView.GetNodeAt(targetPoint) as SegmentTreeNode;

			// Что перетаскиваем
			SegmentTreeNode draggedNode = e.Data.GetData(typeof(SegmentTreeNode)) as SegmentTreeNode;

			if (draggedNode == null)
			{
				return;
			}

			if (targetNode == null)
			{
				UpdateTreeView(draggedNode, targetNode);
				draggedNode.Remove();
				CircuitsTreeView.Nodes[0].Nodes.Add(draggedNode);
				draggedNode.Expand();
			}
			else
			{
				TreeNode parentNode = targetNode;

				if (!draggedNode.Equals(targetNode) && targetNode != null)
				{
					bool canDrop = true;

					// Поднимаемся вверх от узла, на который мы упали,
					// чтобы узнать, является ли targetNode нашим родителем
					while (canDrop && (parentNode != null))
					{
						canDrop = !Object.ReferenceEquals(draggedNode, parentNode);
						parentNode = parentNode.Parent;
					}

					if (canDrop)
					{
						if (targetNode.Segment is IElement)
						{
							return;
						}
						UpdateTreeView(draggedNode, targetNode);
						draggedNode.Remove();
						targetNode.Nodes.Add(draggedNode);

					}
					targetNode.Expand();

				}
			}
			CircuitsTreeView.SelectedNode = draggedNode;
		}

		private void AddSegmentButton_Click(object sender, EventArgs e)
		{
			var segmentForm = new SegmentForm();
			segmentForm.ShowDialog();
			if (segmentForm.DialogResult == DialogResult.OK)
			{
				//TODO: Дубль (+)
				var selectedIndex = CheckElementSelection();
				var segment = segmentForm.NewSegment;

				if (selectedIndex.Segment is IElement)
				{
					MessageBox.Show("Segment cannot be created from element", "Error",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (selectedIndex == CircuitsTreeView.Nodes[0])
				{
					//TODO: Дубль (+)
					_project.SelectedCircuit.SubSegments.Add(segment);

				}
				else
				{
					//TODO: Дубль (+)
					selectedIndex.Segment.SubSegments.Add(segment);
				}

				selectedIndex.Nodes.Add(new SegmentTreeNode
				{
					Text = segmentForm.NewSegment.Name,
					Segment = segment
				});
			}
		}

		private void EditSegmentButton_Click(object sender, EventArgs e)
		{
			try
			{
				var selectedIndex = CheckElementSelection();
				if (selectedIndex == CircuitsTreeView.Nodes[0])
				{
					return;
				}
				var segmentForm = new SegmentForm {NewSegment = selectedIndex.Segment};
				segmentForm.ShowDialog();
				if (segmentForm.DialogResult == DialogResult.OK)
				{
					var parent = selectedIndex.Parent as SegmentTreeNode;
					if (parent == CircuitsTreeView.Nodes[0])
					{
						_project.SelectedCircuit.SubSegments.Remove(selectedIndex.Segment);
						_project.SelectedCircuit.SubSegments.Add(segmentForm.NewSegment);
					}
					else
					{
						parent.Segment.SubSegments.Remove(selectedIndex.Segment);
						parent.Segment.SubSegments.Add(segmentForm.NewSegment);
					}
					FillCircuitNodes();
					Calculate();
				}
			}
			catch (ArgumentNullException exception)
			{
				MessageBox.Show(exception.ParamName, "Warning",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

		}

		private void UpdateTreeView(SegmentTreeNode draggedNode, SegmentTreeNode targetNode)
		{
			var parent = draggedNode.Parent as SegmentTreeNode;
			if (parent.Segment == null)
			{
				_project.SelectedCircuit.SubSegments.Remove(draggedNode.Segment);
			}
			else
			{
				parent.Segment.SubSegments.Remove(draggedNode.Segment);
			}

			if ((targetNode == null) || (targetNode.Segment == null))
			{
				_project.SelectedCircuit.SubSegments.Add(draggedNode.Segment);
			}
			else
			{
				targetNode.Segment.SubSegments.Add(draggedNode.Segment);
			}
		}

		private void UpdateComboBox()
		{
			CircuitSelectionComboBox.DataSource = null;
			CircuitSelectionComboBox.DataSource = _project.Circuits;
			CircuitSelectionComboBox.DisplayMember = "Name";
		}

		private SegmentTreeNode CheckElementSelection()
		{
			SegmentTreeNode element = CircuitsTreeView.SelectedNode as SegmentTreeNode;
			if (element == null)
			{
				throw new ArgumentNullException("Select a tree segment");
			}
			else
			{
				return element;
			}
		}
	}
}

