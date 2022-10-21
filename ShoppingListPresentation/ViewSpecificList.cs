using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoppingListObjects;
using ShoppingListLogicLayer;

namespace ShoppingListPresentation
{
    public partial class ViewSpecificList : Form
    {
        ShoppingListLogic _shoppingList;
        int _shoppingListItem;
        ListItems _items;
        public ViewSpecificList(ShoppingListLogic shoppingList, int listItem)
        {
            InitializeComponent();
            _shoppingList = shoppingList;
            _shoppingListItem = listItem;
        }

        private void ViewSpecificList_Load(object sender, EventArgs e)
        {
            showShoppingList();
        }
        
        private void showShoppingList()
        {
            try
            {
                _items = _shoppingList.GetListItems(_shoppingListItem);
                this.lblListName.Text = _items.Listname;
                this.txtListItems.Text = _items.ItemName;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void getShoppingList()
        {
            try
            {
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  
    }
}
