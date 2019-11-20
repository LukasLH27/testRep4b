using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleLinkedList.models
{
    class DoubleLinkedList<T> where T : class
    {
        private DoubleLinkedListItem<T> _firstItem;
        private DoubleLinkedListItem<T> _lastItem;

        public DoubleLinkedList()
        {
            this._firstItem = null;
            this._lastItem = null;
        }
        public DoubleLinkedList(T item)
        {
            this._firstItem = new DoubleLinkedListItem<T>(item, null, null);
            this._lastItem = null;
        }
        public DoubleLinkedList(DoubleLinkedList<T> list)
        {
            this._firstItem = list._firstItem;
            this._lastItem = list._lastItem;
        }


        //other Methods:
        public bool Add(T itemToAdd)
        {
            if(itemToAdd == null)
            {
                return false;
            }

            if(_firstItem == null)
            {
                _firstItem = new DoubleLinkedListItem<T>(itemToAdd, null, null);
                _lastItem = _firstItem;
                return true;
            }

            else{
                DoubleLinkedListItem<T> toAdd = new DoubleLinkedListItem<T>(itemToAdd, null, _lastItem);
                _lastItem.NextItem = toAdd;
                _lastItem = toAdd;
                return true;
            }
        }

        public DoubleLinkedListItem<T> Find(T itemToFind)
        {
            if (itemToFind == null)
            {
                return null;
            }

            if (_firstItem == null)
            {
                return null;
            }

            DoubleLinkedListItem<T> actItem = _firstItem;

            while (actItem != null)
            {
                if (actItem.Item.Equals(itemToFind))
                {
                    return actItem;
                }

                actItem = actItem.NextItem;
            }

            return null;

        }

        public bool AddItemAfterItem(T itemToAdd, T itemToSearche)
        {
            if (itemToAdd == null || itemToSearche == null)
            {
                return false;
            }

            if (this._firstItem == null)
            {
                return Add(itemToAdd);
            }

            DoubleLinkedListItem<T> found = Find(itemToSearche);

            if (found == null)
            {
                return Add(itemToAdd);
            }

            DoubleLinkedListItem<T> toAdd = new DoubleLinkedListItem<T>(itemToAdd, found.NextItem, found);
            found.NextItem.PreviousItem = toAdd;
            found.NextItem = toAdd;

            return true;



        }

        public bool Remove(T itemToRemove)
        {
            if(itemToRemove == null)
            {
                return false;
            }

            if (this._firstItem == null)
            {
                return false;
            }

            DoubleLinkedListItem<T> found = Find(itemToRemove);

            if (found == null)
            {
                return false;
            }

            if (found.Equals(_firstItem.Item))
            {
                _firstItem = _firstItem.NextItem;
                _firstItem.PreviousItem = null;
                return true;
            }

            if (found == _lastItem)
            {
                _lastItem = _lastItem.PreviousItem;
                _lastItem.NextItem = null;
                return true;
            }

            found.NextItem.PreviousItem = found.PreviousItem;
            found.PreviousItem.NextItem = found.NextItem;
            return true;
        }

        public bool ChangeItem(T itemToFind, T newData)
        {
            if (newData == null)
            {
                return false;
            }

            DoubleLinkedListItem<T> foundItem = Find(itemToFind);

            if (foundItem == null)
            {
                return false;
            }

            foundItem.Item = newData;

            return true;

        }


        public override string ToString()
        {
            string s = "";

            if (this._firstItem != null)
            {
                DoubleLinkedListItem<T> actItem = this._firstItem;
                while (actItem != null)
                {
                    s += actItem.Item.ToString() + "\n";
                    actItem = actItem.NextItem;
                }
            }
            if (s == "")
            {
                return "no Item";
            }

            return s;
        }

    }
}
