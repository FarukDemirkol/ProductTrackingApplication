namespace RecapProject
{
    partial class ProductPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbxCategory = new GroupBox();
            cbxCategory = new ComboBox();
            lblCategory = new Label();
            gbxProductName = new GroupBox();
            tbxProductName = new TextBox();
            label1 = new Label();
            dgwProduct = new DataGridView();
            gbxCategory.SuspendLayout();
            gbxProductName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwProduct).BeginInit();
            SuspendLayout();
            // 
            // gbxCategory
            // 
            gbxCategory.Controls.Add(cbxCategory);
            gbxCategory.Controls.Add(lblCategory);
            gbxCategory.Location = new Point(12, 12);
            gbxCategory.Name = "gbxCategory";
            gbxCategory.Size = new Size(776, 74);
            gbxCategory.TabIndex = 0;
            gbxCategory.TabStop = false;
            gbxCategory.Text = "Kategoriye Göre Sırala";
            gbxCategory.Enter += gbxCategory_Enter;
            // 
            // cbxCategory
            // 
            cbxCategory.FormattingEnabled = true;
            cbxCategory.Location = new Point(115, 29);
            cbxCategory.Name = "cbxCategory";
            cbxCategory.Size = new Size(185, 23);
            cbxCategory.TabIndex = 1;
            cbxCategory.SelectedIndexChanged += cbxCategory_SelectedIndexChanged;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(52, 32);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(57, 15);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Kategori :";
            // 
            // gbxProductName
            // 
            gbxProductName.Controls.Add(tbxProductName);
            gbxProductName.Controls.Add(label1);
            gbxProductName.Location = new Point(12, 92);
            gbxProductName.Name = "gbxProductName";
            gbxProductName.Size = new Size(776, 74);
            gbxProductName.TabIndex = 1;
            gbxProductName.TabStop = false;
            gbxProductName.Text = "Ürün Adına Göre Ara";
            // 
            // tbxProductName
            // 
            tbxProductName.Location = new Point(115, 29);
            tbxProductName.Name = "tbxProductName";
            tbxProductName.Size = new Size(185, 23);
            tbxProductName.TabIndex = 1;
            tbxProductName.TextChanged += tbxProductName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 32);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Ürün Adı :";
            // 
            // dgwProduct
            // 
            dgwProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwProduct.Location = new Point(12, 172);
            dgwProduct.Name = "dgwProduct";
            dgwProduct.Size = new Size(776, 215);
            dgwProduct.TabIndex = 2;
            // 
            // ProductPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgwProduct);
            Controls.Add(gbxProductName);
            Controls.Add(gbxCategory);
            Name = "ProductPage";
            Text = "Ürünler";
            Load += ProductPage_Load;
            gbxCategory.ResumeLayout(false);
            gbxCategory.PerformLayout();
            gbxProductName.ResumeLayout(false);
            gbxProductName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxCategory;
        private ComboBox cbxCategory;
        private Label lblCategory;
        private GroupBox gbxProductName;
        private Label label1;
        private DataGridView dgwProduct;
        private TextBox tbxProductName;
    }
}
