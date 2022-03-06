namespace FastfoodOrderingSystem
{
    public partial class formUI : Form
    {
        public formUI()
        {
            InitializeComponent();
        }

        public void addToCartButton_Click(object sender, EventArgs e)
        {
            //I have no idea where the event activation is.
            //Found it lol
            Console.WriteLine("Hello!");
        }

        private void selectedCartItemLabel_Click(object sender, EventArgs e)
        {

        }

        private void itemCountPlusOneButton_OnClick(object sender, EventArgs e)
        {

        }

        private void itemCountMinusOneButton_OnClick(object sender, EventArgs e)
        {

        }

        private void purchaseButton_OnClick(object sender, EventArgs e)
        {

        }

        private void addToCartButton_OnClick(object sender, EventArgs e)
        {

        }

        private void itemCount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void menuDataGrid_RowSelected(object sender, EventArgs e)
        {
            Console.WriteLine("ROW SELECTED");
        }

        private void cartDataGrid_RowSelected(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuDataGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("ROW ENTERED");
        }

        private void formUI_Shown(object sender, EventArgs e)
        {
            menuDataGrid.RowCount = 100;
            //Make this scalable with the number of actual menu items.

            Console.WriteLine(menuDataGrid.RowCount);
            //menuDataGrid[0, 0] = null;
            //menuDataGrid[1, 0] = null;
            //menuDataGrid[2, 0] = null;
            for (int rowIndex = 0; rowIndex < menuDataGrid.Rows.Count; rowIndex++)
            {
                /* 
                 * Column Index guide:
                 * 0: Image
                 * 1: Name
                 * 2: Price
                 */
                string imgPath = Environment.ProcessPath;
                Console.WriteLine(imgPath);
                //Image img = Image.FromFile(imgPath);
                DataGridViewCell imgCell = menuDataGrid[0, rowIndex];
                DataGridViewCell nameCell = menuDataGrid[1, rowIndex];
                DataGridViewCell priceCell = menuDataGrid[2, rowIndex];

                Console.WriteLine("");
                Console.WriteLine(imgCell.ValueType);
                Console.WriteLine(nameCell.ValueType);
                Console.WriteLine(priceCell.ValueType);
            }
            //menuDataGrid[1,4] = null;
        }
    }
}