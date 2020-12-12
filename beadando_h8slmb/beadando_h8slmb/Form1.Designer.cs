namespace beadando_h8slmb
{
    partial class Form1
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
            this.searchText = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchList = new System.Windows.Forms.ListView();
            this.addButton = new System.Windows.Forms.Button();
            this.addedList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(13, 13);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(137, 20);
            this.searchText.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(156, 10);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchList
            // 
            this.searchList.HideSelection = false;
            this.searchList.HoverSelection = true;
            this.searchList.Location = new System.Drawing.Point(13, 57);
            this.searchList.Name = "searchList";
            this.searchList.Size = new System.Drawing.Size(218, 218);
            this.searchList.TabIndex = 2;
            this.searchList.UseCompatibleStateImageBehavior = false;
            this.searchList.View = System.Windows.Forms.View.List;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(314, 13);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addedList
            // 
            this.addedList.HideSelection = false;
            this.addedList.HoverSelection = true;
            this.addedList.Location = new System.Drawing.Point(314, 57);
            this.addedList.Name = "addedList";
            this.addedList.Size = new System.Drawing.Size(218, 218);
            this.addedList.TabIndex = 4;
            this.addedList.UseCompatibleStateImageBehavior = false;
            this.addedList.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 507);
            this.Controls.Add(this.addedList);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.searchList);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListView searchList;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListView addedList;
    }
}

