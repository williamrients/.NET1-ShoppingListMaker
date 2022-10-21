using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingListAccess;
using ShoppingListObjects;

namespace ShoppingListLogicLayer
{
    public class ShoppingListLogic
    {
       
        List<ShoppingLists> _shoppingLists;
        public ShoppingListLogic()
        {
            try
            {
                _shoppingLists = ShoppingListData.GetShoppingLists();
                    
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<ShoppingLists> ShoppingLists
        {
            get { return _shoppingLists; }
        }

        public ListItems GetListItems(int listItems)
        {
            try
            {
                return ShoppingListData.GetShoppingListItems(_shoppingLists[listItems]);
            }
            catch (Exception)
            {

                throw new ApplicationException("Can't find that file.");
            }
        }
     
        
        public List<ShoppingLists> AddNewList(ListItems listItems, ShoppingLists shoppingLists)
        {
            try
            {
                if (ShoppingListData.AddNewList(listItems, shoppingLists))
                {
                    _shoppingLists = ShoppingListData.GetShoppingLists();
                }
                return _shoppingLists;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ShoppingLists> EditList(ListItems listItems, ShoppingLists shoppingLists, int listIndex)
        {
            try
            {
                _shoppingLists[listIndex] = shoppingLists;
                if (ShoppingListData.EditList(listIndex, listItems, _shoppingLists))
                {
                    _shoppingLists = ShoppingListData.GetShoppingLists();
                    return _shoppingLists;
                }
                return _shoppingLists;
            }
            catch (Exception)
            {

                throw;
            }
        }






    }
}
