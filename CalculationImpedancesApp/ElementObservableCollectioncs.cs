using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CalculationImpedancesApp
{
    public sealed class ElementObservableCollectioncs<T>: Collection<T>
        where T: ISegment
    {
        public event EventHandler CollectionChanged;
        protected override void InsertItem(int index, T item)
        {
            base.InsertItem(index, item);
            item.ValueChanged += item_ValueChanged;
            CollectionChanged?.Invoke(this, 
                new ElementEventArgs($"Added element to the circuit"));
        }

        protected override void RemoveItem(int index)
        {
            var item = this[index];
            base.RemoveItem(index);
            item.ValueChanged -= item_ValueChanged;
            CollectionChanged?.Invoke(this,
                new ElementEventArgs($"Removed element to the circuit"));
        }

        private void item_ValueChanged(object sender, EventArgs e)
        {
            CollectionChanged?.Invoke(sender, e);
        }
    }
}
