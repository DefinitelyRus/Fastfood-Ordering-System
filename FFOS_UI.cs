namespace FastfoodOrderingSystem
{
    public partial class FFOS_UI : Form
    {
        public FFOS_UI()
        {
            InitializeComponent();
        }

        public void addToCartButton_Click(object sender, EventArgs e)
        {
            //I have no idea where the event activation is.
            Console.WriteLine("Hello!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void selectedCartItemLabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Console.WriteLine(FFOS_UI.ActiveForm.Controls.Count);
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
    }
}