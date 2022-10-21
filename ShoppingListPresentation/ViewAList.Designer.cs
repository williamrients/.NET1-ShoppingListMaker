
namespace ShoppingListPresentation
{
    partial class ViewAList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstLists = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCloseView = new System.Windows.Forms.Button();
            this.btnReadList = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstLists
            // 
            this.lstLists.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstLists.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLists.GridLines = true;
            this.lstLists.HideSelection = false;
            this.lstLists.Location = new System.Drawing.Point(33, 7);
            this.lstLists.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstLists.Name = "lstLists";
            this.lstLists.Size = new System.Drawing.Size(578, 266);
            this.lstLists.TabIndex = 0;
            this.lstLists.UseCompatibleStateImageBehavior = false;
            this.lstLists.View = System.Windows.Forms.View.Details;
            this.lstLists.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstLists_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "List Name";
            this.columnHeader1.Width = 117;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Author";
            this.columnHeader2.Width = 125;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "File Name";
            this.columnHeader3.Width = 151;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date Created";
            this.columnHeader4.Width = 270;
            // 
            // btnCloseView
            // 
            this.btnCloseView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseView.Location = new System.Drawing.Point(446, 291);
            this.btnCloseView.Name = "btnCloseView";
            this.btnCloseView.Size = new System.Drawing.Size(163, 51);
            this.btnCloseView.TabIndex = 1;
            this.btnCloseView.Text = "Main Menu";
            this.btnCloseView.UseVisualStyleBackColor = true;
            this.btnCloseView.Click += new System.EventHandler(this.btnCloseView_Click);
            // 
            // btnReadList
            // 
            this.btnReadList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadList.Location = new System.Drawing.Point(33, 291);
            this.btnReadList.Name = "btnReadList";
            this.btnReadList.Size = new System.Drawing.Size(161, 51);
            this.btnReadList.TabIndex = 2;
            this.btnReadList.Text = "Read List";
            this.btnReadList.UseVisualStyleBackColor = true;
            this.btnReadList.Click += new System.EventHandler(this.btnReadList_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(232, 291);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(161, 51);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit List";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // ViewAList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 404);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnReadList);
            this.Controls.Add(this.btnCloseView);
            this.Controls.Add(this.lstLists);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ViewAList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose a List to View";
            this.Load += new System.EventHandler(this.ViewAList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstLists;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnCloseView;
        private System.Windows.Forms.Button btnReadList;
        private System.Windows.Forms.Button btnEdit;
    }
}