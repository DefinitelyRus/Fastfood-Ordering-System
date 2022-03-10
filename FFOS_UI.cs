using FFOS_Backend_Library;
using static FFOS_Backend_Library.MasterClass;
namespace FastfoodOrderingSystem
{
    public partial class formUI : Form
    {
        MenuItem[] menuItems;
        MenuItem? selectedItem = null;
        public formUI()
        {
            InitializeComponent();
        }

        private void menuDataGrid_RowSelected(object sender, EventArgs e)
        {
            //Code here runs when a row in the menu is selected.

            selectedItem = menuItems[menuDataGrid.SelectedRows[0].Index];
            /* 
             * TODO: Add code that updates these elements when a row is selected:
             *     - itemNameLabel
             *     - itemPriceLabel
             *     - itemImage
             *     - itemCountCounter (set to 1)
             * 
             * Hints:
             *     - You can change element values with this: "<element name>.Value = <value>"
             *     - For text elements like labels, use this: "<element name>.Text = <text>"
             *     - You can get the values you need from "selectedItem".
             */

            //WRITE CODE HERE

        }

        private void itemCount_ValueChanged(object sender, EventArgs e)
        {
            //Code here runs when the Item count is changed.

            /*
             * TODO: Get the item count value, then multiply the price by that value.
             * 
             * Example:
             *     The value is set to 3 items, and the price is P40.
             *     The displayed price should then be 3x40, or simply "P120".
             *     
             * Hints:
             *     - You can also get the element values with this: "<element name>.Value",
             *       then assign it to a variable or use it directly.
             *     - You can convert the FLOATs to STRINGs using "<float>.ToString()".
             *     - The only elements involved are itemCountCounter and itemPriceLabel.
             */

            //WRITE CODE HERE

        }

        private void addToCartButton_OnClick(object sender, EventArgs e)
        {
            //Code here runs when the "Add to Cart" button is clicked.
            #region [Hidden Region] Inserts a new row, then selects that row as the active row.
            cartDataGrid.RowCount += 1;
            try { cartDataGrid.CurrentCell = cartDataGrid[1, cartDataGrid.RowCount - 1]; }
            catch { }
            #endregion

            /*
             * TODO:
             *     - Get these values, then put them in cartDataGrid.
             *         - item count
             *         - ItemName
             *         - Price
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

        private void cartDataGrid_RowSelected(object sender, DataGridViewCellEventArgs e)
        {
            //Code here runs when a row in the cart is selected.
        }

        private void itemCountPlusOneButton_OnClick(object sender, EventArgs e)
        {
            //Code here runs when the "+1" button is clicked.
        }

        private void itemCountMinusOneButton_OnClick(object sender, EventArgs e)
        {
            //Code here runs when the "-1" button is clicked.
        }

        private void purchaseButton_OnClick(object sender, EventArgs e)
        {
            //Code here runs when the "Place Order" button is clicked.
        }

        //Code here will run once the form is displayed on the screen.
        //No need to edit this part.
        private void formUI_Shown(object sender, EventArgs e)
        {
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
                menuDataGrid.CurrentRow.Height = 64;

                Console.WriteLine("Attempting to add " + item.ID + "...");
            }
        }
    }
}