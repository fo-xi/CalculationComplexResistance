using System;
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
			SegmentTreeNode mainCircuitNode= new SegmentTreeNode
			{
				Text = circuit.Name,
			};
			CircuitsTreeView.Nodes.Add(mainCircuitNode);
			foreach (var subSegment in circuit.SubSegments)
			{
				SegmentTreeNode subSegmentNode = new SegmentTreeNode
				{
					Text = subSegment is IElement ? subSegment.ToString(): subSegment.Name,
					Segment = subSegment
				};
				if(!(subSegmentNode.Segment is IElement))
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
			
            //TODO: RSDN (?)
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
			//TODO: Дубль
			var selectedIndex = CircuitsTreeView.SelectedNode as SegmentTreeNode;
			if (selectedIndex == null)
			{
				MessageBox.Show("Select a element from the list", "Warning",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (selectedIndex == CircuitsTreeView.Nodes[0])
			{
                //TODO: Дубль
				var element = CreateElement();
				if (element == null)
				{
					return;
				}
				_project.SelectedCircuit.SubSegments.Add(element);
				selectedIndex.Nodes.Add(new SegmentTreeNode
				{
					Text = element.ToString(),
					Segment = element
				});
			}
			else if (selectedIndex.Segment is IElement)
			{
				var parent = selectedIndex.Parent as SegmentTreeNode;
				//TODO: Дубль
				var element = CreateElement();
				if (element == null)
				{
					return;
				}

				parent.Segment.SubSegments.Add(element);
				parent.Nodes.Add(new SegmentTreeNode
				{
					Text = element.ToString(),
					Segment = element
				});
			}
			else
			{
                //TODO: Дубль
				var element = CreateElement();
				if (element == null)
				{
					return;
				}
				selectedIndex.Segment.SubSegments.Add(element);
				selectedIndex.Nodes.Add(new SegmentTreeNode
				{
					Text = element.ToString(),
					Segment = element
				});
			}
			TypeComboBox.Text = "";
			NameTextBox.Text = "";
			ValueTextBox.Text = "";
			Calculate();
		}

        private void EditElementButton_Click(object sender, EventArgs e)
        {
            //TODO: Дубль
			var selectedIndex = CircuitsTreeView.SelectedNode as SegmentTreeNode;
            if (selectedIndex == null)
            {
                MessageBox.Show("Select a element from the list", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var parent = selectedIndex.Parent as SegmentTreeNode;
            //TODO: Дубль
			var element = CreateElement();
            if (element == null)
            {
                return;
            }
            parent.Segment.SubSegments.Remove(selectedIndex.Segment);
            parent.Segment.SubSegments.Add(element);
            parent.Nodes.Remove(selectedIndex);
            parent.Nodes.Add(new SegmentTreeNode
            {
                Text = element.ToString(),
                Segment = element
            });
            Calculate();
        }

        private void RemoveElementButton_Click(object sender, EventArgs e)
		{
            //TODO: Дубль
			var selectedIndex = CircuitsTreeView.SelectedNode as SegmentTreeNode;
			if (selectedIndex == null)
			{
				MessageBox.Show("Select a element from the list", "Warning",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (selectedIndex == CircuitsTreeView.Nodes[0])
			{
				MessageBox.Show("Can't delete root element", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
                //TODO: Дубль
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

		private IElement CreateElement()
		{
			IElement segment = null;
			try
			{
				var name = NameTextBox.Text;
				var value = double.Parse(ValueTextBox.Text);

				switch (TypeComboBox.SelectedIndex)
				{
					case 1:
					{
						segment = new Resistor(name, value);
						break;
					}
					case 2:
					{
						segment = new Inductor(name, value);
						break;
					}
					case 3:
					{
						segment = new Capacitor(name, value);
						break;
					}
				}
			}
			catch (FormatException exception)
			{
				MessageBox.Show(exception.Message, "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return segment;
		}

		private void CircuitsTreeView_AfterSelect(object sender, TreeViewEventArgs e)
		{
            //TODO: Дубль
			var selectedIndex = CircuitsTreeView.SelectedNode as SegmentTreeNode;
			if (selectedIndex == null)
			{
				MessageBox.Show("Select a element from the list", "Warning",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

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
			}
			else
			{
				TypeComboBox.Text = "";
				NameTextBox.Text = "";
				ValueTextBox.Text = "";
				EditElementButton.Enabled = false;
			}
		}

		private void ShowMessage(object sender, EventArgs e)
		{
			var message = e as ElementEventArgs;
			MessageBox.Show(message.Message, "Information",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void AddSegmentButton_Click(object sender, EventArgs e)
        {
            var segmentForm = new SegmentForm();
            segmentForm.ShowDialog();
            if (segmentForm.DialogResult == DialogResult.OK)
            {
                //TODO: Дубль
				var selectedIndex = CircuitsTreeView.SelectedNode as SegmentTreeNode;
                if (selectedIndex == null)
                {
                    MessageBox.Show("Select a element from the list", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (selectedIndex == CircuitsTreeView.Nodes[0])
                {
                    //TODO: Дубль
					var segment = segmentForm.NewSegment;
                    _project.SelectedCircuit.SubSegments.Add(segment);
                    selectedIndex.Nodes.Add(new SegmentTreeNode
                    {
                        Text = segmentForm.NewSegment.Name,
                        Segment = segment
                    });
                }
                else if (selectedIndex.Segment is IElement)
                {
                    MessageBox.Show("NewSegment cannot be created from element", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    //TODO: Дубль
					var segment = segmentForm.NewSegment;
                    selectedIndex.Segment.SubSegments.Add(segment);
                    selectedIndex.Nodes.Add(new SegmentTreeNode
                    {
                        Text = segmentForm.NewSegment.Name,
                        Segment = segment
                    });
                }
            }
        }

        private void UpdateComboBox()
        {
	        CircuitSelectionComboBox.DataSource = null;
	        CircuitSelectionComboBox.DataSource = _project.Circuits;
	        CircuitSelectionComboBox.DisplayMember = "Name";
		}
	}
}

