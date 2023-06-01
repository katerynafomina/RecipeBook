using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeBook
{
    public partial class FormAllRecipes : Form
    {
        RecipesList recipeList = new RecipesList("..\\..\\..\\recipes.txt");
        int recipIndex = 0;
        public FormAllRecipes()
        {
            
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void showImage(int index)
        {
            string imagePath = recipeList.recipes[index].Icon;
            Image image = Image.FromFile(imagePath);
            recipeIcon.Image = image;
        }
        private void swowRecipe(int index)
        {
            textBoxRecipes.Text = $"Назва: {recipeList.recipes[index].Name}";
            textBoxRecipes.AppendText($"\r\nОпис:{recipeList.recipes[index].Description}");
            textBoxRecipes.AppendText($"\r\nІнградієнти:{recipeList.recipes[index].showIngradients()}");
            textBoxRecipes.AppendText($"\r\nСпосіб приготування:{recipeList.recipes[index].Instruction}");
        }

        private void button_left_Click(object sender, EventArgs e)
        {
            if (recipIndex>0)
            {
                recipIndex -= 1;
            }
            else
            {
                recipIndex = recipeList.recipes.Count-1;
            }
            showImage(recipIndex);
            swowRecipe(recipIndex);
        }

        private void FormAllRecipes_Load(object sender, EventArgs e)
        {
            showImage(recipIndex);
            swowRecipe(recipIndex);
        }

        private void button_right_Click(object sender, EventArgs e)
        {
            if (recipIndex  < recipeList.recipes.Count - 1)
            {
                recipIndex += 1;
            }
            else
            {
                recipIndex = 0;
            }
            showImage(recipIndex);
            swowRecipe(recipIndex);
        }

        private void recipeIcon_Click(object sender, EventArgs e)
        {

        }
        
    }
}
