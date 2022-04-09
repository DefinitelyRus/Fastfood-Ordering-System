using FFOS_Backend_Library;
using static FFOS_Backend_Library.MasterClass;

namespace FastfoodOrderingSystem
{
    public partial class formUI : Form
    {
        #region Declaration and Initialization of objects and variables.
        MenuItem[] menuItems;
        LinkedList<MenuItem> cartItems = new();
        MenuItem? selectedItem = null;
        private DataGridViewCell activeCartCell = null;
        public formUI()
        {
            InitializeComponent();
        }
        #endregion

        #region UI Events


        //Updates the preview when a row in the menu is selected.
        private void menuDataGrid_RowSelected(object sender, EventArgs e)
        {
            if (menuDataGrid.SelectedRows.Count == 0) return;

            int index = menuDataGrid.SelectedRows[0].Index;
            selectedItem = menuItems[index];
            Console.WriteLine("\nMenu row selected. (Index: " + index + ")");

            //Changes the preview contents.
            itemNameLabel.Text = selectedItem.ItemName;
            itemPriceLabel.Text = "Php" + selectedItem.Price.ToString();
            try { itemImage.Image = Image.FromFile(selectedItem.getImgFilePath()); }
            catch { itemImage.Image = null; }
            
            itemCountCounter.Value = 1;

            //Makes the item counter and add to cart buttons clickable.
            itemCountCounter.Enabled = true;
            addToCartButton.Enabled = true;
        }


        //Updates the price preview when the Item count is changed.
        private void itemCount_ValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine("\nItem counter changed to " + itemCountCounter.Value + ".");

            if (selectedItem == null) { return; } //Helps avoid crashes.
            itemPriceLabel.Text = "Php" +
                (Convert.ToDecimal(selectedItem.Price) * itemCountCounter.Value);
        }


        //Adds the item to cart when the "Add to Cart" button is clicked.
        private void addToCartButton_OnClick(object sender, EventArgs e)
        {
            Console.WriteLine("\nClicked addToCartButton; added " + selectedItem.ID + " to list.");

            //Adds a new empty row.
            cartDataGrid.RowCount += 1;

            //Selects the new row.
            cartDataGrid.CurrentCell = cartDataGrid[1, cartDataGrid.RowCount - 1];

            //Updates the values for each cell in the row.
            cartDataGrid.CurrentRow.Cells[0].Value = itemCountCounter.Value.ToString();
            cartDataGrid.CurrentRow.Cells[1].Value = selectedItem.ItemName;
            cartDataGrid.CurrentRow.Cells[2].Value = (Convert.ToDecimal(selectedItem.Price) * itemCountCounter.Value).ToString();
            cartDataGrid.CurrentRow.Cells[3].Value = selectedItem.ID; // This one is hidden.

            //Makes the purchase button clickable.
            purchaseButton.Enabled = true;

            //Adds the item to the internal list.
            cartItems.AddLast(selectedItem);
            
            //Updates the total price and resets the item preview.
            UpdateTotal();
            ResetPreview();
        }


        //Clears the cart when the "Place Order" button is clicked.
        private void purchaseButton_OnClick(object sender, EventArgs e)
        {
            cartItems.Clear(); //Clears the internal list.
            cartDataGrid.RowCount = 0; //Sets the number of rows to 0. (Emptying the list)
            selectedItem = null; //Marks no item as selected.
            purchaseButton.Enabled = false; //Makes the purchase button unclickable.

            //Updates the total price and resets the item preview.
            ResetPreview();
            UpdateTotal();
        }


        //Code here will run once the form is displayed on the screen.
        private void formUI_Shown(object sender, EventArgs e)
        {
            Console.WriteLine("Windows Forms UI shown.\n");

            //Force-test; checks if JSON file and directory exists.
            ReadFile(GetDirectory("json"));

            //Imports MenuItems from JSON file.
            menuItems = ParseJson(ReadJson(GetDirectory("json")));

            MessageBox.Show("Rules to be observed in a table service:\n\n" +
				"- Never reach in front of a guest, nor across one person in order to\n" +
				"  serve another.\n\n" +
				"- Place and remove all food from the left of the guest.\n\n" +
				"- Go clockwise (if possible) when you are covering the table and when\n" +
				"  you are serving and clearing and that always forwards.\n\n" +
				"- Women are usually served first. If it is an honorary dinner, of course,\n" +
				"  the guest of honor is served first. Otherwise, age and status of the\n" +
				"  guest determine the sequence, with older or more distinguished\n" +
				"  guests served first. The host is always served after his or her guests.\n" +
				"  When children are present at the table, serve them as quickly\n" +
				"  as possible to maintain peace.\n\n" +
				"- Place a milk glass at the right of and below the water glass.\n\n" +
				"- In order to reach a guest, never stretch in front of them or across one\n" +
				"  person to assist someone else.\n\n" +
				"- Serve the main dish or entrée at the center of the cover in front of the\n" +
				"  guest.\n\n" +
				"- Always carry the cultery items, glasses, cuos, and small serving with\n" +
				"  the tray not with the hand.\n\n" +
				"- Set fruit juice and cocktail glasses, cereal dishes, soup bowls, and\n" +
				"  dessert dishes on small plates before placing them in the center of the\n" +
				"  cover between the knife and the fork.\n\n" +
				"- Place individual serving trays of bread and rolls above and to the left\n" +
				"  of the forks. Place a tray or basket of bread for the use of several\n" +
				"  guests toward the center of the table.", "Rules");

            //Sets the data grid's size to match the menuItem array.
            if (menuItems != null) menuDataGrid.RowCount = menuItems.Length;
            else menuDataGrid.RowCount = 0;

            //Changes the form's title if the menu is empty.
            //Also disables all interactable elements.
            if (menuDataGrid.Rows.Count == 0)
            {
                formUI.ActiveForm.Text =
                    "THE MENU IS EMPTY. Please use \"Menu Editor.exe\" to add new items.";
                addToCartButton.Enabled = false;
                purchaseButton.Enabled = false;
                itemCountCounter.Enabled = false;
                return;
            }

            //Iterates through all rows on the Menu Data Grid.
            for (int rowIndex = 0; rowIndex < menuDataGrid.Rows.Count; rowIndex++)
            {
                /* 
                 * Column Index guide:
                 * 0: Image
                 * 1: Name
                 * 2: Price
                 */
                MenuItem item = menuItems[rowIndex];

                //Assigns each cell to a variable.
                DataGridViewCell imgCell = menuDataGrid[0, rowIndex];
                DataGridViewCell nameCell = menuDataGrid[1, rowIndex];
                DataGridViewCell priceCell = menuDataGrid[2, rowIndex];

                //Changes the value of each cell to match the internal menu.
                try { imgCell.Value = Image.FromFile(item.getImgFilePath()); }
                catch { imgCell.Value = null; }
                nameCell.Value = item.ItemName; ;
                priceCell.Value = item.Price.ToString(); ;

                //Selects the current name cell, then sets its row height to 64px.
                menuDataGrid.CurrentCell = nameCell;
                menuDataGrid.CurrentRow.Height = menuDataGrid.CurrentRow.Cells[0].Size.Width;

                Console.WriteLine("Attempting to add " + item.ID + "...");
            }
            Console.WriteLine("\nFFOS Ready.");

            //Changes the selected cart item label to display the default value (Php0).
            UpdateTotal();

            //Selects the first cell from the first row, then deselects it.
            menuDataGrid.CurrentCell = menuDataGrid[0, 0];
            menuDataGrid.ClearSelection();
            ResetPreview();
        }


        #endregion

        #region Shortcut functions
        //Resets the item preview to become blank and unclickable.
        private void ResetPreview()
        {
            Console.WriteLine("Preview reset.");
            itemNameLabel.Text = null;
            itemPriceLabel.Text = "Php0";
            itemCountCounter.Value = 0;
            itemImage.Image = null;

            itemCountCounter.Enabled = false;
            addToCartButton.Enabled = false;
        }

        //Updates the total price of all items in the cart.
        private void UpdateTotal()
        {
            Console.WriteLine("Total updated.");
            decimal total = 0;

            //For every item in the internal list...
            foreach (MenuItem item in cartItems)
            {
                //For every item in the displayed list...
                foreach (DataGridViewRow row in cartDataGrid.Rows)
                {
                    //If the displayed list's item's ID matches the internal one...
                    if ((string)row.Cells[3].Value == item.ID)
                    {
                        //total price = item price * number of items
                        total += Convert.ToDecimal(item.Price) * Convert.ToDecimal(row.Cells[0].Value);
                    }
                }
            }

            //Changes the text on the total price label.
            selectedCartItemLabel.Text = "Total: Php" + total.ToString();
        }
        #endregion
    }
}