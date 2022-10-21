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
    public partial class MainMenuForm : Form
    {
        private ShoppingListLogic _shoppingLists = new ShoppingListLogic();
        public MainMenuForm()
        {
            InitializeComponent();
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btnViewList_Click(object sender, EventArgs e)
        {
            var ViewAListForm = new ViewAList();
            ViewAListForm.ShowDialog();
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            var CreateNewForm = new CreateNewForm();
            CreateNewForm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
