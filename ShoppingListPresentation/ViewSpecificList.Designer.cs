
namespace ShoppingListPresentation
{
    partial class ViewSpecificList
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
            this.lblListName = new System.Windows.Forms.Label();
            this.txtListItems = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblListName
            // 
            this.lblListName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListName.Location = new System.Drawing.Point(226, 5);
            this.lblListName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblListName.Name = "lblListName";
            this.lblListName.Size = new System.Drawing.Size(184, 59);
            this.lblListName.TabIndex = 0;
            this.lblListName.Text = "List Name";
            this.lblListName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtListItems
            // 
            this.txtListItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListItems.Location = new System.Drawing.Point(137, 66);
            this.txtListItems.Margin = new System.Windows.Forms.Padding(2);
            this.txtListItems.Multiline = true;
            this.txtListItems.Name = "txtListItems";
            this.txtListItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtListItems.Size = new System.Drawing.Size(375, 218);
            this.txtListItems.TabIndex = 2;
            this.txtListItems.Text = "List Items";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(231, 289);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(179, 51);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ViewSpecificList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 404);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtListItems);
            this.Controls.Add(this.lblListName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewSpecificList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewSpecificList";
            this.Load += new System.EventHandler(this.ViewSpecificList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListName;
        private System.Windows.Forms.TextBox txtListItems;
        private System.Windows.Forms.Button btnClose;
    }
}