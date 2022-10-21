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
    public partial class CreateNewForm : Form
    {
        string dataPath = Application.StartupPath + @"\listdata";
        ShoppingListLogic ShoppingListLogic;
        int _listIndex;
        bool editMode;
        public CreateNewForm()
        {
            InitializeComponent();
            ShoppingListLogic = new ShoppingListLogic();
            editMode = false;
        }

        public CreateNewForm(int listindex, ShoppingListLogic shoppingListLogic)
        {
            editMode = true;
            ShoppingListLogic = shoppingListLogic;
            _listIndex = listindex;
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var closeResult = MessageBox.Show("All data will be lost.", "Really cancel?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (closeResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(dataPath + "\\" + txtNewFileName.Text) && editMode == false)
            {
                MessageBox.Show("This file name is already used");
                txtNewFileName.Focus();
                return;
            }
            if ((txtNewFileName.Text).ToLower().EndsWith(".txt") == false)
            {
                MessageBox.Show("Please enter a valid file name, ending with '.txt'");
                txtNewFileName.Focus();
                return;
            }
            if (txtNewFileName.Text == "")
            {
                MessageBox.Show("Enter a file name");
                txtNewFileName.Focus();
                return;
            }
            if (txtNewListItems.Text == "")
            {
                MessageBox.Show("Enter some list items");
                txtNewListItems.Focus();
                return;
            }
            if (txtNewListName.Text == "")
            {
                MessageBox.Show("Enter a title for your list");
                txtNewListName.Focus();
                return;
            }
            if (txtNewFileName.Text.Length < 5)
            {
                MessageBox.Show("File name too short");
                txtNewFileName.Focus();
                return;
            }
            if (txtNewAuthor.Text == "")
            {
                MessageBox.Show("Enter an Author for this list");
                txtNewAuthor.Focus();
                return;
            }
            if (txtNewDateCreated.Text == "")
            {
                MessageBox.Show("Please enter a data created");
                txtNewDateCreated.Focus();
                return;
            }
            var newList = new ListItems();
            newList.Listname = txtNewListName.Text;
            newList.ItemName = txtNewListItems.Text;  
            var newShoppingList = new ShoppingLists();
            newShoppingList.ListName = txtNewListName.Text;
            newShoppingList.Author = txtNewAuthor.Text;
            newShoppingList.FileName = txtNewFileName.Text;
            newShoppingList.DatedCreated = txtNewDateCreated.Text;
            if (editMode == true)
            {
                ShoppingListLogic.EditList(newList, newShoppingList, _listIndex);
                this.Close();
            } 
            else
            {
                int listItemsCount = ShoppingListLogic.ShoppingLists.Count;
                var makeNewList = ShoppingListLogic.AddNewList(newList, newShoppingList);
                if (makeNewList.Count > listItemsCount)
                {
                    MessageBox.Show("New list creatd!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Adding your list failed.");
                    this.Close();
                }
            }
            
        }

        private void CreateNewForm_Load(object sender, EventArgs e)
        {
            if (editMode == true)
            {
                this.txtNewListItems.Text = ShoppingListLogic.ShoppingLists[_listIndex].ListName;
                this.txtNewAuthor.Text = ShoppingListLogic.ShoppingLists[_listIndex].Author;
                this.txtNewFileName.Text = ShoppingListLogic.ShoppingLists[_listIndex].FileName;
                this.txtNewDateCreated.Text = ShoppingListLogic.ShoppingLists[_listIndex].DatedCreated;
                this.txtNewFileName.Text = ShoppingListLogic.ShoppingLists [_listIndex].FileName;
                ListItems listItems = ShoppingListLogic.GetListItems(_listIndex);
                this.txtNewListName.Text = listItems.Listname;
                this.txtNewListItems.Text = listItems.ItemName;
                this.txtNewFileName.Enabled = false;
                this.Text = "Edit your list";
            } else
            {
                this.Text = "Create a list";
            }
        }
    }
}
