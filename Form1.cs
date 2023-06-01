namespace RecipeBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button5_Click(object sender, EventArgs e)
        {
            
            FormAllRecipes newWindow = new FormAllRecipes();
            newWindow.Show();

        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {
            
            searchForm newWindow = new searchForm();
            newWindow.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}