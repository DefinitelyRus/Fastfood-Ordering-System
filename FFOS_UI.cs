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

        }
    }
}