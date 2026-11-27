namespace InventoryManagementSystem
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblParts = new System.Windows.Forms.Label();
            this.btnSearchPart = new System.Windows.Forms.Button();
            this.btnPartsAdd = new System.Windows.Forms.Button();
            this.btnProductsAdd = new System.Windows.Forms.Button();
            this.btnPartsModify = new System.Windows.Forms.Button();
            this.btnProductsModify = new System.Windows.Forms.Button();
            this.btnPartsDelete = new System.Windows.Forms.Button();
            this.btnProductsDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dataGridParts = new System.Windows.Forms.DataGridView();
            this.dataGridProducts = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.lblProducts = new System.Windows.Forms.Label();
            this.txtPartsSearch = new System.Windows.Forms.TextBox();
            this.txtProductsSearch = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(314, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Inventory Management System";
            // 
            // lblParts
            // 
            this.lblParts.AutoSize = true;
            this.lblParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParts.Location = new System.Drawing.Point(20, 80);
            this.lblParts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParts.Name = "lblParts";
            this.lblParts.Size = new System.Drawing.Size(63, 26);
            this.lblParts.TabIndex = 1;
            this.lblParts.Text = "Parts";
            // 
            // btnSearchPart
            // 
            this.btnSearchPart.Location = new System.Drawing.Point(369, 72);
            this.btnSearchPart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchPart.Name = "btnSearchPart";
            this.btnSearchPart.Size = new System.Drawing.Size(112, 35);
            this.btnSearchPart.TabIndex = 2;
            this.btnSearchPart.Text = "Search";
            this.btnSearchPart.UseVisualStyleBackColor = true;
            this.btnSearchPart.Click += new System.EventHandler(this.btnSearchPart_Click);
            // 
            // btnPartsAdd
            // 
            this.btnPartsAdd.Location = new System.Drawing.Point(530, 546);
            this.btnPartsAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPartsAdd.Name = "btnPartsAdd";
            this.btnPartsAdd.Size = new System.Drawing.Size(72, 48);
            this.btnPartsAdd.TabIndex = 3;
            this.btnPartsAdd.Text = "Add";
            this.btnPartsAdd.UseVisualStyleBackColor = true;
            this.btnPartsAdd.Click += new System.EventHandler(this.btnPartsAdd_Click);
            // 
            // btnProductsAdd
            // 
            this.btnProductsAdd.Location = new System.Drawing.Point(1290, 546);
            this.btnProductsAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProductsAdd.Name = "btnProductsAdd";
            this.btnProductsAdd.Size = new System.Drawing.Size(72, 48);
            this.btnProductsAdd.TabIndex = 4;
            this.btnProductsAdd.Text = "Add";
            this.btnProductsAdd.UseVisualStyleBackColor = true;
            this.btnProductsAdd.Click += new System.EventHandler(this.btnProductsAdd_Click);
            // 
            // btnPartsModify
            // 
            this.btnPartsModify.Location = new System.Drawing.Point(610, 546);
            this.btnPartsModify.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPartsModify.Name = "btnPartsModify";
            this.btnPartsModify.Size = new System.Drawing.Size(72, 48);
            this.btnPartsModify.TabIndex = 5;
            this.btnPartsModify.Text = "Modify";
            this.btnPartsModify.UseVisualStyleBackColor = true;
            this.btnPartsModify.Click += new System.EventHandler(this.btnPartsModify_Click);
            // 
            // btnProductsModify
            // 
            this.btnProductsModify.Location = new System.Drawing.Point(1371, 546);
            this.btnProductsModify.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProductsModify.Name = "btnProductsModify";
            this.btnProductsModify.Size = new System.Drawing.Size(72, 48);
            this.btnProductsModify.TabIndex = 6;
            this.btnProductsModify.Text = "Modify";
            this.btnProductsModify.UseVisualStyleBackColor = true;
            this.btnProductsModify.Click += new System.EventHandler(this.btnProductsModify_Click);
            // 
            // btnPartsDelete
            // 
            this.btnPartsDelete.Location = new System.Drawing.Point(692, 546);
            this.btnPartsDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPartsDelete.Name = "btnPartsDelete";
            this.btnPartsDelete.Size = new System.Drawing.Size(72, 48);
            this.btnPartsDelete.TabIndex = 7;
            this.btnPartsDelete.Text = "Delete";
            this.btnPartsDelete.UseVisualStyleBackColor = true;
            this.btnPartsDelete.Click += new System.EventHandler(this.btnPartsDelete_Click);
            // 
            // btnProductsDelete
            // 
            this.btnProductsDelete.Location = new System.Drawing.Point(1452, 546);
            this.btnProductsDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProductsDelete.Name = "btnProductsDelete";
            this.btnProductsDelete.Size = new System.Drawing.Size(72, 48);
            this.btnProductsDelete.TabIndex = 8;
            this.btnProductsDelete.Text = "Delete";
            this.btnProductsDelete.UseVisualStyleBackColor = true;
            this.btnProductsDelete.Click += new System.EventHandler(this.btnProductsDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1452, 631);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 48);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGridParts
            // 
            this.dataGridParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridParts.Location = new System.Drawing.Point(24, 117);
            this.dataGridParts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridParts.Name = "dataGridParts";
            this.dataGridParts.RowHeadersVisible = false;
            this.dataGridParts.RowHeadersWidth = 62;
            this.dataGridParts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridParts.Size = new System.Drawing.Size(740, 420);
            this.dataGridParts.TabIndex = 10;
            this.dataGridParts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPartsCell_Click);
            // 
            // dataGridProducts
            // 
            this.dataGridProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridProducts.Location = new System.Drawing.Point(790, 117);
            this.dataGridProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridProducts.Name = "dataGridProducts";
            this.dataGridProducts.RowHeadersVisible = false;
            this.dataGridProducts.RowHeadersWidth = 62;
            this.dataGridProducts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridProducts.Size = new System.Drawing.Size(734, 420);
            this.dataGridProducts.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Product ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Inventory";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Min";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Max";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Location = new System.Drawing.Point(1134, 72);
            this.btnSearchProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(112, 35);
            this.btnSearchProduct.TabIndex = 12;
            this.btnSearchProduct.Text = "Search";
            this.btnSearchProduct.UseVisualStyleBackColor = true;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.Location = new System.Drawing.Point(786, 80);
            this.lblProducts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(98, 26);
            this.lblProducts.TabIndex = 13;
            this.lblProducts.Text = "Products";
            this.lblProducts.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtPartsSearch
            // 
            this.txtPartsSearch.Location = new System.Drawing.Point(490, 80);
            this.txtPartsSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPartsSearch.Name = "txtPartsSearch";
            this.txtPartsSearch.Size = new System.Drawing.Size(271, 26);
            this.txtPartsSearch.TabIndex = 14;
            // 
            // txtProductsSearch
            // 
            this.txtProductsSearch.Location = new System.Drawing.Point(1256, 75);
            this.txtProductsSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProductsSearch.Name = "txtProductsSearch";
            this.txtProductsSearch.Size = new System.Drawing.Size(271, 26);
            this.txtProductsSearch.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PartID";
            this.Column1.HeaderText = "Part ID";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "InStock";
            this.Column3.HeaderText = "Inventory";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Price";
            this.Column4.HeaderText = "Price";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Min";
            this.Column5.HeaderText = "Min";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Max";
            this.Column6.HeaderText = "Max";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1551, 692);
            this.Controls.Add(this.txtProductsSearch);
            this.Controls.Add(this.txtPartsSearch);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.btnSearchProduct);
            this.Controls.Add(this.dataGridProducts);
            this.Controls.Add(this.dataGridParts);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnProductsDelete);
            this.Controls.Add(this.btnPartsDelete);
            this.Controls.Add(this.btnProductsModify);
            this.Controls.Add(this.btnPartsModify);
            this.Controls.Add(this.btnProductsAdd);
            this.Controls.Add(this.btnPartsAdd);
            this.Controls.Add(this.btnSearchPart);
            this.Controls.Add(this.lblParts);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.Button btnSearchPart;
        private System.Windows.Forms.Button btnPartsAdd;
        private System.Windows.Forms.Button btnProductsAdd;
        private System.Windows.Forms.Button btnPartsModify;
        private System.Windows.Forms.Button btnProductsModify;
        private System.Windows.Forms.Button btnPartsDelete;
        private System.Windows.Forms.Button btnProductsDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataGridParts;
        private System.Windows.Forms.DataGridView dataGridProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.TextBox txtPartsSearch;
        private System.Windows.Forms.TextBox txtProductsSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}

