using FFOS_Backend_Library;
using static FFOS_Backend_Library.MasterClass;
namespace FastfoodOrderingSystem
{
    public partial class formUI : Form
    {
        MenuItem[] menuItems;
        public formUI()
        {
            InitializeComponent();
        }

        private void menuDataGrid_RowSelected(object sender, EventArgs e)
        {
            //Code here runs when a row in the menu is selected.
        }

        private void itemCount_ValueChanged(object sender, EventArgs e)
        {
            //Code here runs when the Item count is changed.
        }

        private void addToCartButton_OnClick(object sender, EventArgs e)
        {
            //Code here runs when the "Add to Cart" button is clicked.
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
                imgCell.Value = Image.FromFile(item.getImgFilePath());
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