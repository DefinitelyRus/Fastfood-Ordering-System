using FFOS_Backend_Library;
namespace FastfoodOrderingSystem
{
    public partial class formUI : Form
    {
        public formUI()
        {
            InitializeComponent();
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

        private void addToCartButton_OnClick(object sender, EventArgs e)
        {
            //Code here runs when the "Add to Cart" button is clicked.
        }

        private void itemCount_ValueChanged(object sender, EventArgs e)
        {
            //Code here runs when the Item count is changed.
        }

        private void menuDataGrid_RowSelected(object sender, EventArgs e)
        {
            //Code here runs when a row in the menu is selected.
            Console.WriteLine("test");
        }

        private void cartDataGrid_RowSelected(object sender, DataGridViewCellEventArgs e)
        {
            //Code here runs when a row in the cart is selected.
        }

        private void formUI_Shown(object sender, EventArgs e)
        {
            //TODO: Import MenuItems from JSON file.
            
            menuDataGrid.RowCount = 2;
            //Make this scalable with the number of actual menu items.

            for (int rowIndex = 0; rowIndex < menuDataGrid.Rows.Count; rowIndex++)
            {
                /* 
                 * Column Index guide:
                 * 0: Image
                 * 1: Name
                 * 2: Price
                 */
                MenuItem[] menuItemArray = FFOS_Backend_Library.MasterClass.ReadFile(jsonFilePath);
                string menuItemImagePath = "chicken.jpg"; //TEMP

                string imgPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                    "/Images/" + menuItemImagePath;
                Console.WriteLine(imgPath);
                //Image img = Image.FromFile(imgPath);
                DataGridViewCell imgCell = menuDataGrid[0, rowIndex];
                DataGridViewCell nameCell = menuDataGrid[1, rowIndex];
                DataGridViewCell priceCell = menuDataGrid[2, rowIndex];

                //imgCell.Value = Image.FromFile(imgPath);

                Console.WriteLine("");
                Console.WriteLine(imgCell.ValueType);
                Console.WriteLine(nameCell.ValueType);
                Console.WriteLine(priceCell.ValueType);
            }
            //menuDataGrid[1,4] = null;
        }
    }
}