using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoppingListLogicLayer;
using ShoppingListObjects;

namespace ShoppingListPresentation
{
    public partial class ViewAList : Form
    {
        private ShoppingListLogic ShoppingListLogic = new ShoppingListLogic();
        public ViewAList()
        {
            InitializeComponent();
        }

        private ShoppingListLogic generateShoppingList = new ShoppingListLogic();
        private void generateLists()
        {
            lstLists.Items.Clear();
            for (int i = 0; i < generateShoppingList.ShoppingLists.Count; i++)
            {
                this.lstLists.Items.Add(generateShoppingList.ShoppingLists[i].ListName);
                this.lstLists.Items[this.lstLists.Items.Count - 1].SubItems.Add(generateShoppingList.ShoppingLists[i].Author);
                this.lstLists.Items[this.lstLists.Items.Count - 1].SubItems.Add(generateShoppingList.ShoppingLists[i].FileName);
                this.lstLists.Items[this.lstLists.Items.Count - 1].SubItems.Add(generateShoppingList.ShoppingLists[i].DatedCreated);
            }
        }

        private void ViewAList_Load(object sender, EventArgs e)
        {
            generateLists();
        }

        private void btnCloseView_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstLists_ColumnClick(object sender, ColumnClickEventArgs e)
        {

        }

        private void btnReadList_Click(object sender, EventArgs e)
        {

            if (lstLists.SelectedItems.Count > 0)
            {
                var specificlist = new ViewSpecificList(generateShoppingList, lstLists.SelectedIndices[0]);
                
                specificlist.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Please Select a List", "Select something", MessageBoxButtons.OK);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstLists.SelectedItems.Count  > 0)
            {
                var editListForm = new CreateNewForm(lstLists.SelectedIndices[0], ShoppingListLogic);
                this.Close();
                editListForm.ShowDialog();
                generateLists();
            }
            else
            {
                MessageBox.Show("Please Select a List", "Select something", MessageBoxButtons.OK);
            }
        }
    }
}
