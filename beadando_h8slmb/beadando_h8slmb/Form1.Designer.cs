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
            this.searchList = new System.Windows.Forms.ListView();
            this.addButton = new System.Windows.Forms.Button();
            this.addedList = new System.Windows.Forms.ListView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(62, 15);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(178, 20);
            this.searchText.TabIndex = 0;
            this.searchText.TextChanged += new System.EventHandler(this.searchText_TextChanged);
            // 
            // searchList
            // 
            this.searchList.HideSelection = false;
            this.searchList.HoverSelection = true;
            this.searchList.Location = new System.Drawing.Point(13, 229);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 507);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addedList);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.searchList);
            this.Controls.Add(this.searchText);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.ListView searchList;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListView addedList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}

