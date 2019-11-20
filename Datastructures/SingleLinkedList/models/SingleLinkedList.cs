using System;
using System.Collections.Generic;
using System.Text;

namespace SingleLinkedList.models
{
    //generic
    class SingleLinkedList<T> where T : class
    {

        private SingleLinkedListItem<T> _firstItem;
        private SingleLinkedListItem<T> _lastItem;

        public SingleLinkedList() {
            this._firstItem = null;
            this._lastItem = null;
        }

        public SingleLinkedList(T item)
        {
            this._firstItem = new SingleLinkedListItem<T>(item, null);
            this._lastItem = _firstItem;
        }
        public SingleLinkedList(SingleLinkedList<T> sll)
        {
            this._firstItem = sll._firstItem;
            this._lastItem = sll._lastItem;
        }

        //Methode Add
        public bool Add(T itemToAdd)
        {
            //1. Parameter überprüfen
            if(itemToAdd == null)
            {
                return false;
            }

            //1.Fall: die SLL ist leer
            if(this._firstItem == null)
            {
                this._firstItem = new SingleLinkedListItem<T>(itemToAdd, null);
                this._lastItem = this._firstItem;
            }

            //2. Fall die SLL ist nicht leer
            else
            {
                this._lastItem.NextItem = new SingleLinkedListItem<T>(itemToAdd, null);
                this._lastItem = this._lastItem.NextItem;
            }
            return true;
        }

        public bool AddItemAfterItem(T itemToAdd, T itemBefore)
        {
            if (itemToAdd == null || itemBefore == null)
            {
                return false;
            }

            if (this._firstItem == null)
            {
                return Add(itemToAdd);
            }

            SingleLinkedListItem<T> actItem = this._firstItem;
            while (actItem != null)
            {
                if(actItem.Item == itemBefore)
                {
                    actItem.NextItem = new SingleLinkedListItem<T>(itemToAdd, actItem.NextItem);
                }
                actItem = actItem.NextItem;
            }

            return true;

        }

        public bool Remove(T itemToRemove)
        {
            if(itemToRemove == null)
            {
                return false;
            }
            //es existiert noch kein Eintrag in der Liste
            if(this._firstItem == null)
            {
                return false;
            }

            bool isFirstItem;
            SingleLinkedListItem<T> itemBeforeItemToRemove = this.FindItemBeforeItem(itemToRemove, out isFirstItem);

            if((itemBeforeItemToRemove == null) && !isFirstItem)
            {
                return false;
            }

            //1ter Fall: 1ter Eintrag
            //1ter Eintrag ist der gesuchte Eintrag
            if(isFirstItem)
            {
                this._firstItem = this._firstItem.NextItem;
                return true;
            }

            //2ter Fall: es handelt sich um den letzten Eintrag
            if(itemBeforeItemToRemove.NextItem == null)
            {
                this._lastItem = itemBeforeItemToRemove;
                this._lastItem.NextItem = null;
                return true;
            }

            else
            {
                itemBeforeItemToRemove.NextItem = itemBeforeItemToRemove.NextItem.NextItem;
                return true;
            }
        }

        public SingleLinkedListItem<T> Find(T itemToFind)
        {
            if(itemToFind == null)
            {
                return null;
            }
            if(this._firstItem == null)
            {
                return null;
            }

            SingleLinkedListItem<T> actItem = _firstItem;

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

        public SingleLinkedListItem<T> FindItemBeforeItem(T itemToFind, out bool isStartItem)
        {
            isStartItem = false;
            if (itemToFind == null)
            {
                return null;
            }
            //es existiert noch kein Eintrag in der Liste
            if (this._firstItem == null)
            {
                return null;
            }
            if (this._firstItem.Item.Equals(itemToFind))
            {
                isStartItem = true;
                return null;
            }

            SingleLinkedListItem<T> actItem = this._firstItem;
            while(actItem != null)
            {
                if((actItem.NextItem !=null) && (actItem.NextItem.Item.Equals(itemToFind)))
                {
                    return actItem;
                }
                actItem = actItem.NextItem;
            }

            return null;
        }

        public bool ChangeItem(T itemToFind, T newData )
        {
            if(newData == null)
            {
                return false;
            }

            SingleLinkedListItem<T> foundItem = Find(itemToFind);

            if(foundItem == null)
            {
                return false;
            }

            foundItem.Item = newData;

            return true;

        }



        public override string ToString()
        {
            string s = "";

            if(this._firstItem != null)
            {
                SingleLinkedListItem<T> actItem = this._firstItem;
                while (actItem != null)
                {
                    s += actItem.Item.ToString() + "\n";
                    actItem = actItem.NextItem;
                }
            }
            if(s == "")
            {
                return "no Item";
            }

            return s;
        }
        

    }
}
