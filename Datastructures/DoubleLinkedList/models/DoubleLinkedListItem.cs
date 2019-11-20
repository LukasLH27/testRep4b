using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleLinkedList.models
{
    class DoubleLinkedListItem<T> where T:class
    {
        public T Item { get; set; }
        public DoubleLinkedListItem<T> NextItem { get; set; } //verweis auf das nächste Item
        public DoubleLinkedListItem<T> PreviousItem { get; set; } //verweis auf das vorherige Item

        public DoubleLinkedListItem() : this(null, null, null) {}
        public DoubleLinkedListItem(T p, DoubleLinkedListItem<T> nextItem, DoubleLinkedListItem<T> previousItem)
        {
            this.Item = p;
            this.NextItem = nextItem;
            this.PreviousItem = previousItem;
        }

        public override string ToString()
        {
            return this.Item.ToString();
        }

    }
}
