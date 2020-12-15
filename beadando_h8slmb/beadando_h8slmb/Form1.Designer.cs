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
            this.addButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeButton = new System.Windows.Forms.Button();
            this.removeCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.removeText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(65, 15);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(178, 20);
            this.searchText.TabIndex = 0;
            this.searchText.TextChanged += new System.EventHandler(this.searchText_TextChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(15, 192);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(84, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add to your list";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_,
            this.Type,
            this.Price,
            this.SubType});
            this.dataGridView1.Location = new System.Drawing.Point(15, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 133);
            this.dataGridView1.TabIndex = 5;
            // 
            // Name_
            // 
            this.Name_.DataPropertyName = "name";
            this.Name_.HeaderText = "Name";
            this.Name_.Name = "Name_";
            // 
            // Type
            // 
            this.Type.DataPropertyName = "type";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // SubType
            // 
            this.SubType.DataPropertyName = "subtype";
            this.SubType.HeaderText = "SubType";
            this.SubType.Name = "SubType";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView2.Location = new System.Drawing.Point(15, 254);
            this.dataGridView2.MaximumSize = new System.Drawing.Size(10000, 136);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(443, 22);
            this.dataGridView2.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "type";
            this.dataGridViewTextBoxColumn2.HeaderText = "Type";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "subtype";
            this.dataGridViewTextBoxColumn4.HeaderText = "SubType";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(286, 411);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(117, 23);
            this.removeButton.TabIndex = 8;
            this.removeButton.Text = "Remove from your list";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // removeCombo
            // 
            this.removeCombo.FormattingEnabled = true;
            this.removeCombo.Items.AddRange(new object[] {
            "Name",
            "Type"});
            this.removeCombo.Location = new System.Drawing.Point(15, 413);
            this.removeCombo.Name = "removeCombo";
            this.removeCombo.Size = new System.Drawing.Size(121, 21);
            this.removeCombo.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Remove by:";
            // 
            // removeText
            // 
            this.removeText.Location = new System.Drawing.Point(142, 414);
            this.removeText.Name = "removeText";
            this.removeText.Size = new System.Drawing.Size(100, 20);
            this.removeText.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Your liist:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(18, 473);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(81, 23);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Save your list";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 511);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.removeText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.removeCombo);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.searchText);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubType;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ComboBox removeCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox removeText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveButton;
    }
}

