using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeApp.models
{
    class BinaryTree
    {
        private BinaryTreeItem _root;
        private int _count;

        public BinaryTree()
        {
            this._root = null;
        }
        public BinaryTree(int? item)
        {
            this._root = new BinaryTreeItem(item, 0, null, null);
        }
        public BinaryTree(BinaryTree list)
        {
            this._root = list._root;
        }

        //Methoden
        public int Count
        {
            get
            {
                return _count;
            }
        }
        
        public int Count2
        {
            get
            {
                return _count;
            }
        }
        

        public int Count3
        {
            get
            {
                // Kommentar Lokal
                return _count;
            }
        }



        public void Add(int? itemToAdd)
        {
            if (itemToAdd == 0)
            {
                return;
            }

            //1.Fall: Tree ist leer:
            if (_root == null)
            {
                _root = new BinaryTreeItem(itemToAdd, 1, null, null);
                _count++;
            }
            else
            {
                BinaryTreeItem actItemPrevious = null;
                BinaryTreeItem actItem = _root;


                while (actItem != null)
                {
                    //2.Fall: ItemToAdd = actItem
                    if (itemToAdd == actItem.Item)
                    {
                        actItem.Counter++;
                        _count++;
                        return;
                    }

                    actItemPrevious = actItem;

                    //3.Fall: itemToAdd > actItem
                    if (itemToAdd > actItem.Item)
                    {
                        actItem = actItem.ItemRight;
                    }
                    //4.Fall: itemToAdd <= actItem
                    else
                    {
                        actItem = actItem.ItemLeft;
                    }
                }

                if (actItemPrevious.Item < itemToAdd)
                {
                    actItemPrevious.ItemRight = new BinaryTreeItem(itemToAdd, 1, null, null);
                    _count++;
                }
                else
                {
                    actItemPrevious.ItemLeft = new BinaryTreeItem(itemToAdd, 1, null, null);
                    _count++;
                }


            }



            //ToString()


        }
        public BinaryTreeItem Find(int? itemToFind)
        {
            BinaryTreeItem actItem = _root;

            while(actItem != null)
            {
                if(actItem.Item == itemToFind)
                {
                    return actItem;
                }
               
                if(itemToFind > actItem.Item)
                {
                    actItem = actItem.ItemRight;
                }
                else if(itemToFind < actItem.Item)
                {
                    actItem = actItem.ItemLeft;
                }

            }

            return null;
        }
        public BinaryTreeItem Minimum(int? itemToFind=null)
        {
            BinaryTreeItem actItem = _root;
            if(actItem == null)
            {
                return null;
            }

            if (itemToFind != null)
            {
                actItem = Find(itemToFind);
            }

            while (actItem != null)
            {
                if (actItem.ItemLeft == null)
                {
                    return actItem;
                }
                actItem = actItem.ItemLeft;
            }

            return null;

        }
        public BinaryTreeItem Maximum(int? itemToFind)
        {
            BinaryTreeItem actItem = _root;
            if (actItem == null)
            {
                return null;
            }

            if (itemToFind != null)
            {
                actItem = Find(itemToFind);
            }

            while (actItem != null)
            {
                if (actItem.ItemRight == null)
                {
                    return actItem;
                }
                actItem = actItem.ItemRight;
            }

            return null;

        }

        //Kommentar hinzugefügt


    }
}
