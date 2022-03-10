namespace FastfoodOrderingSystem
{
    partial class formUI
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
            this.itemImage = new System.Windows.Forms.PictureBox();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.itemPriceLabel = new System.Windows.Forms.Label();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.itemCountCounter = new System.Windows.Forms.NumericUpDown();
            this.menuDataGrid = new System.Windows.Forms.DataGridView();
            this.selectedCartItemLabel = new System.Windows.Forms.Label();
            this.itemCountMinusOneButton = new System.Windows.Forms.Button();
            this.itemCountPlusOneButton = new System.Windows.Forms.Button();
            this.purchaseButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cartDataGrid = new System.Windows.Forms.DataGridView();
            this.cartItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.ItemNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.itemImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemCountCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // itemImage
            // 
            this.itemImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.itemImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemImage.Image = global::Fastfood_Ordering_System.Properties.Resources.burger;
            this.itemImage.Location = new System.Drawing.Point(622, 12);
            this.itemImage.Name = "itemImage";
            this.itemImage.Size = new System.Drawing.Size(150, 150);
            this.itemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.itemImage.TabIndex = 7;
            this.itemImage.TabStop = false;
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.itemNameLabel.Location = new System.Drawing.Point(402, 12);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(214, 65);
            this.itemNameLabel.TabIndex = 8;
            this.itemNameLabel.Text = "Item Label Goes Here with 2nd line";
            this.itemNameLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // itemPriceLabel
            // 
            this.itemPriceLabel.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.itemPriceLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itemPriceLabel.Location = new System.Drawing.Point(402, 77);
            this.itemPriceLabel.Name = "itemPriceLabel";
            this.itemPriceLabel.Size = new System.Drawing.Size(214, 41);
            this.itemPriceLabel.TabIndex = 9;
            this.itemPriceLabel.Text = "PRICEPRICE";
            // 
            // addToCartButton
            // 
            this.addToCartButton.Location = new System.Drawing.Point(513, 121);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(103, 41);
            this.addToCartButton.TabIndex = 10;
            this.addToCartButton.Text = "Add to cart";
            this.addToCartButton.UseVisualStyleBackColor = true;
            this.addToCartButton.Click += new System.EventHandler(this.addToCartButton_OnClick);
            // 
            // itemCountCounter
            // 
            this.itemCountCounter.Location = new System.Drawing.Point(402, 132);
            this.itemCountCounter.Name = "itemCountCounter";
            this.itemCountCounter.Size = new System.Drawing.Size(105, 23);
            this.itemCountCounter.TabIndex = 11;
            this.itemCountCounter.ValueChanged += new System.EventHandler(this.itemCount_ValueChanged);
            // 
            // menuDataGrid
            // 
            this.menuDataGrid.AllowUserToAddRows = false;
            this.menuDataGrid.AllowUserToDeleteRows = false;
            this.menuDataGrid.AllowUserToResizeColumns = false;
            this.menuDataGrid.AllowUserToResizeRows = false;
            this.menuDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.menuDataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.menuDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemImageColumn,
            this.ItemNameColumn,
            this.ItemPriceColumn});
            this.menuDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.menuDataGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuDataGrid.Location = new System.Drawing.Point(12, 12);
            this.menuDataGrid.MultiSelect = false;
            this.menuDataGrid.Name = "menuDataGrid";
            this.menuDataGrid.ReadOnly = true;
            this.menuDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.menuDataGrid.RowHeadersVisible = false;
            this.menuDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.menuDataGrid.RowTemplate.Height = 25;
            this.menuDataGrid.RowTemplate.ReadOnly = true;
            this.menuDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.menuDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.menuDataGrid.ShowCellErrors = false;
            this.menuDataGrid.ShowCellToolTips = false;
            this.menuDataGrid.ShowEditingIcon = false;
            this.menuDataGrid.ShowRowErrors = false;
            this.menuDataGrid.Size = new System.Drawing.Size(384, 417);
            this.menuDataGrid.StandardTab = true;
            this.menuDataGrid.TabIndex = 12;
            this.menuDataGrid.SelectionChanged += new System.EventHandler(this.menuDataGrid_RowSelected);
            // 
            // selectedCartItemLabel
            // 
            this.selectedCartItemLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedCartItemLabel.Location = new System.Drawing.Point(78, 232);
            this.selectedCartItemLabel.Name = "selectedCartItemLabel";
            this.selectedCartItemLabel.Size = new System.Drawing.Size(198, 23);
            this.selectedCartItemLabel.TabIndex = 1;
            this.selectedCartItemLabel.Text = "Menu Item Name Here";
            this.selectedCartItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // itemCountMinusOneButton
            // 
            this.itemCountMinusOneButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemCountMinusOneButton.Location = new System.Drawing.Point(42, 232);
            this.itemCountMinusOneButton.Name = "itemCountMinusOneButton";
            this.itemCountMinusOneButton.Size = new System.Drawing.Size(30, 23);
            this.itemCountMinusOneButton.TabIndex = 2;
            this.itemCountMinusOneButton.Text = "-1";
            this.itemCountMinusOneButton.UseVisualStyleBackColor = true;
            this.itemCountMinusOneButton.Click += new System.EventHandler(this.itemCountMinusOneButton_OnClick);
            // 
            // itemCountPlusOneButton
            // 
            this.itemCountPlusOneButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemCountPlusOneButton.Location = new System.Drawing.Point(6, 232);
            this.itemCountPlusOneButton.Name = "itemCountPlusOneButton";
            this.itemCountPlusOneButton.Size = new System.Drawing.Size(30, 23);
            this.itemCountPlusOneButton.TabIndex = 3;
            this.itemCountPlusOneButton.Text = "+1";
            this.itemCountPlusOneButton.UseVisualStyleBackColor = true;
            this.itemCountPlusOneButton.Click += new System.EventHandler(this.itemCountPlusOneButton_OnClick);
            // 
            // purchaseButton
            // 
            this.purchaseButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.purchaseButton.Location = new System.Drawing.Point(282, 232);
            this.purchaseButton.Name = "purchaseButton";
            this.purchaseButton.Size = new System.Drawing.Size(82, 23);
            this.purchaseButton.TabIndex = 4;
            this.purchaseButton.Text = "Place Order";
            this.purchaseButton.UseVisualStyleBackColor = true;
            this.purchaseButton.Click += new System.EventHandler(this.purchaseButton_OnClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cartDataGrid);
            this.groupBox1.Controls.Add(this.purchaseButton);
            this.groupBox1.Controls.Add(this.selectedCartItemLabel);
            this.groupBox1.Controls.Add(this.itemCountPlusOneButton);
            this.groupBox1.Controls.Add(this.itemCountMinusOneButton);
            this.groupBox1.Location = new System.Drawing.Point(402, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 261);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cart";
            // 
            // cartDataGrid
            // 
            this.cartDataGrid.AllowUserToAddRows = false;
            this.cartDataGrid.AllowUserToDeleteRows = false;
            this.cartDataGrid.AllowUserToResizeColumns = false;
            this.cartDataGrid.AllowUserToResizeRows = false;
            this.cartDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.cartDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cartItemQuantity,
            this.cartItemName,
            this.cartItemPrice});
            this.cartDataGrid.Location = new System.Drawing.Point(6, 22);
            this.cartDataGrid.MultiSelect = false;
            this.cartDataGrid.Name = "cartDataGrid";
            this.cartDataGrid.ReadOnly = true;
            this.cartDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.cartDataGrid.RowHeadersVisible = false;
            this.cartDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.cartDataGrid.RowTemplate.Height = 25;
            this.cartDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cartDataGrid.ShowCellErrors = false;
            this.cartDataGrid.ShowCellToolTips = false;
            this.cartDataGrid.Size = new System.Drawing.Size(358, 204);
            this.cartDataGrid.TabIndex = 5;
            this.cartDataGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.cartDataGrid_RowSelected);
            // 
            // cartItemQuantity
            // 
            this.cartItemQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cartItemQuantity.FillWeight = 30F;
            this.cartItemQuantity.HeaderText = "Quantity";
            this.cartItemQuantity.Name = "cartItemQuantity";
            this.cartItemQuantity.ReadOnly = true;
            this.cartItemQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cartItemName
            // 
            this.cartItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cartItemName.HeaderText = "Name";
            this.cartItemName.Name = "cartItemName";
            this.cartItemName.ReadOnly = true;
            this.cartItemName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cartItemPrice
            // 
            this.cartItemPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cartItemPrice.FillWeight = 40F;
            this.cartItemPrice.HeaderText = "Price";
            this.cartItemPrice.Name = "cartItemPrice";
            this.cartItemPrice.ReadOnly = true;
            this.cartItemPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ItemImageColumn
            // 
            this.ItemImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemImageColumn.FillWeight = 30F;
            this.ItemImageColumn.HeaderText = "Image";
            this.ItemImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ItemImageColumn.Name = "ItemImageColumn";
            this.ItemImageColumn.ReadOnly = true;
            this.ItemImageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ItemNameColumn
            // 
            this.ItemNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemNameColumn.FillWeight = 86.80203F;
            this.ItemNameColumn.HeaderText = "Item Name";
            this.ItemNameColumn.Name = "ItemNameColumn";
            this.ItemNameColumn.ReadOnly = true;
            this.ItemNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ItemPriceColumn
            // 
            this.ItemPriceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemPriceColumn.FillWeight = 40F;
            this.ItemPriceColumn.HeaderText = "Price";
            this.ItemPriceColumn.Name = "ItemPriceColumn";
            this.ItemPriceColumn.ReadOnly = true;
            this.ItemPriceColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // formUI
            // 
            this.AcceptButton = this.addToCartButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuDataGrid);
            this.Controls.Add(this.itemCountCounter);
            this.Controls.Add(this.addToCartButton);
            this.Controls.Add(this.itemPriceLabel);
            this.Controls.Add(this.itemNameLabel);
            this.Controls.Add(this.itemImage);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "formUI";
            this.Text = "Fastfood Ordering System";
            this.Shown += new System.EventHandler(this.formUI_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.itemImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemCountCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public PictureBox itemImage;
        public Label itemNameLabel;
        public Label itemPriceLabel;
        public NumericUpDown itemCountCounter;
        private Button addToCartButton;
        public DataGridView menuDataGrid;
        public Label selectedCartItemLabel;
        public Button itemCountMinusOneButton;
        public Button itemCountPlusOneButton;
        public Button purchaseButton;
        private GroupBox groupBox1;
        public DataGridView cartDataGrid;
        private DataGridViewImageColumn ItemImageColumn;
        private DataGridViewTextBoxColumn ItemNameColumn;
        private DataGridViewTextBoxColumn ItemPriceColumn;
        private DataGridViewTextBoxColumn cartItemQuantity;
        private DataGridViewTextBoxColumn cartItemName;
        private DataGridViewTextBoxColumn cartItemPrice;
    }
}