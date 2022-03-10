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

        //Code here runs when a row in the menu is selected.
        private void menuDataGrid_RowSelected(object sender, EventArgs e)
        {
            int index = menuDataGrid.SelectedRows[0].Index;
            selectedItem = menuItems[index];
            Console.WriteLine("\nMenu row selected. (Index: " + index + ")");
            //selectedItem = new MenuItem("cheeseburger", "Cheese Burger", 30, "cheeseburger.jpg");
            /* 
             * TODO:
             *     - Add code that updates these elements when a row is selected:
             *         - itemNameLabel
             *         - itemPriceLabel
             *         - itemImage
             *         - itemCountCounter (set to 1)
             *     - Enable the addToCartButton.
             * 
             * Hints:
             *     - You can change element values with this: "<element name>.Value = <value>"
             *     - For text elements like labels, use this: "<element name>.Text = <text>"
             *     - You can get the values you need from "selectedItem".
             *     - "Enable" is an attribute of any UI element. It can be set to true or false.
             *       Disabled elements are typically grayed-out and cannot be clicked.
             */

            //WRITE CODE HERE

        }

        //Code here runs when the Item count is changed.
        private void itemCount_ValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Item counter changed to " + itemCountCounter.Value + ".");
            /*
             * TODO: Get the item count value, then multiply the price by that value.
             * 
             * Example:
             *     The value is set to 3 items, and the price is P40.
             *     The displayed price should then be "P120".
             *     
             * Hints:
             *     - You can also get the element values with this: "<element name>.Value",
             *       then assign it to a variable or use it directly.
             *     - You can convert the FLOATs to STRINGs using "<float>.ToString()".
             *     - The only elements involved are itemCountCounter and itemPriceLabel.
             */

            //WRITE CODE HERE
            
        }

        //Code here runs when the "Add to Cart" button is clicked.
        private void addToCartButton_OnClick(object sender, EventArgs e)
        {
            Console.WriteLine("Clicked addToCartButton; added " + selectedItem.ID + " to list.");
            cartDataGrid.RowCount += 1;
            cartDataGrid.CurrentCell = cartDataGrid[1, cartDataGrid.RowCount - 1];

            /*
             * TODO:
             *     - Get these values, then put them in cartDataGrid.
             *         - item count
             *         - ItemName
             *         - Price
             *         - ID (Hidden from UI)
             *     - Add the selectedItem to the cartItems list.
             * 
             * Hints:
             *     - To put the values into the cartDataGrid, you first need to make an array.
             *       In this array, there will be 3 strings in order: The quantity, name, then price.
             *     - You can get the item count from itemCountCounter, the ItemName from selectedItem,
             *       and the price by multiplying the Price from selectedItem by the item count.
             *     - You have to get the current row first, then set its values to the array you made.
             */
            
            //WRITE CODE HERE
            
        }

        //Code here runs when a row in the cart is selected.
        private void cartDataGrid_RowSelected(object sender, DataGridViewCellEventArgs e)
        {

            Console.WriteLine("Cart row selected.");// (Index: " + cartDataGrid.CurrentRow.Index + ")");
            /*
             * TODO:
             *     - Enable itemCountPlusOneButton and itemCountMinusOneButton.
             *     - Assign the current cell to "activeCartCell".
             */

            //WRITE CODE HERE

        }
        private void purchaseButton_OnClick(object sender, EventArgs e)
        {
            //Code here runs when the "Place Order" button is clicked.
        }

        #region [Hidden Region] Pre-done stuff.
        //Code here runs when a row in cartDataGrid is no longer selected
        private void cartDataGrid_RowLeft(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("\nLeft cartDataGrid's focus.");
            //Re-hides the +1 and -1 buttons.
            //itemCountPlusOneButton.Enabled = false;
            //itemCountMinusOneButton.Enabled = false;

            //Displays the total amount when no cart item is selected.
            float total = 0.00f;
            foreach (MenuItem item in cartItems) total += item.Price;

            selectedCartItemLabel.Text = "Total: Php" + total.ToString();
        }

        //Code here runs when the "+1" button is clicked.
        private void itemCountPlusOneButton_OnClick(object sender, EventArgs e)
        {
            Console.WriteLine("\nClicked +1 Button.");

            DataGridViewRow row = cartDataGrid.CurrentRow;
            int count = int.Parse((string) row.Cells[0].Value);
            if (count < 100)
            {
                count++;
                row.Cells[0].Value = count.ToString();
                row.Cells[2].Value = Convert.ToDecimal(row.Cells[2].Value) * count;
            }
        }

        //Code here runs when the "-1" button is clicked.
        private void itemCountMinusOneButton_OnClick(object sender, EventArgs e)
        {
            Console.WriteLine("\nClicked -1 Button.");
            DataGridViewRow row = cartDataGrid.CurrentRow;
            int count = int.Parse((string) row.Cells[0].Value);

            if (count > 1)
            {
                Console.WriteLine("Decreased count by 1.");
                count--;
                row.Cells[0].Value = count.ToString();
                row.Cells[2].Value = Convert.ToDecimal(row.Cells[2].Value) * count;
            }
            else
            {
                Console.WriteLine("Count already at minimum; removing item.");
                LinkedList<DataGridViewRow> newCart = new();

                //Decrease count by 1.
                count--;
                row.Cells[0].Value = count.ToString();

                //Iterates through all rows.
                for (int i = 0; i < cartDataGrid.Rows.Count; i++)
                {
                    DataGridViewRow innerRow = cartDataGrid.Rows[i];

                    if (Convert.ToInt16(innerRow.Cells[0].Value) != 0) newCart.AddLast(innerRow);
                    else
                    {
                        foreach (MenuItem item in cartItems)
                        {
                            //If the ID matches, remove from internal list.
                            if (item.ID == (string) innerRow.Cells[3].Value) cartItems.Remove(item);
                        }
                    }
                }

                //Resets cart then assigns newCart.
                cartDataGrid.Rows.Clear();
                cartDataGrid.Rows.AddRange(newCart.ToArray());
            }
        }


        //Code here will run once the form is displayed on the screen.
        //No need to edit this part.
        private void formUI_Shown(object sender, EventArgs e)
        {
            Console.WriteLine("Windows Forms UI shown.\n");
            //Force-test; checks if JSON file and directory exists.
            ReadFile(GetDirectory("json"));

            //Imports MenuItems from JSON file.
            menuItems = ParseJson(ReadJson(GetDirectory("json")));

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
                itemCountPlusOneButton.Enabled = false;
                itemCountMinusOneButton.Enabled = false;
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
            //Changes the selected cart item label to display the default value.
            selectedCartItemLabel.Text = "Total: Php" + 0.00f.ToString();

            //TEMP
        }
        #endregion
    }
}