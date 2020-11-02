using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CalculationImpedancesApp
{
    /// <summary>
    /// Own collection of segmentsObservable.
    /// </summary>
    public sealed class SegmentsObservableCollection: ObservableCollection<ISegment>
    {
        /// <summary>
        /// Event that fires when the collection changes.
        /// </summary>
        public event EventHandler CollectionChanged;

        /// <summary>
        /// Overridden method for adding item to collection.
        /// </summary>
        /// <param name="index">Element index.</param>
        /// <param name="item">Element.</param>
        protected override void InsertItem(int index, ISegment item)
        {
            base.InsertItem(index, item);
            item.SegmentChanged += OnSegmentChanged;
            CollectionChanged?.Invoke(this, 
                new ElementEventArgs($"Added element to the circuit"));
        }

        /// <summary>
        /// Overridden method for removing item to collection.
        /// </summary>
        /// <param name="index">Element index.</param>
        protected override void RemoveItem(int index)
        {
            var item = this[index];
            base.RemoveItem(index);
            item.SegmentChanged -= OnSegmentChanged;
            CollectionChanged?.Invoke(this,
                new ElementEventArgs($"Removed element to the circuit"));
        }

        //TODO: RSDN - именование (+)
        /// <summary>
        /// CollectionChanged event registration.
        /// </summary>
        /// <param name="sender">Object.</param>
        /// <param name="e">EventArgs.</param>
        private void OnSegmentChanged(object sender, EventArgs e)
        {
            CollectionChanged?.Invoke(sender, e);
        }
    }
}
