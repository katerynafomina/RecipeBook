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
    public partial class searchForm : Form
    {
        RecipesList recipeList = new RecipesList("..\\..\\..\\recipes.txt");
        RecipesList nameSearch = new RecipesList();
        RecipesList ingradientsSearch = new RecipesList(); 
        RecipesList CategorisSearch = new RecipesList();
        int name_index = 0;
        int ingradient_index = 0;
        int Categoris_index = 0;
        string Name = "";
        string category = "";
        int name_ing = -1;
        
        public searchForm()
        {
            InitializeComponent();
            Controls.Remove(searchName);
            Controls.Remove(searchBox);
            Controls.Remove(textBoxRecipes);
            Controls.Remove(recipeIcon);
            Controls.Remove(right);
            Controls.Remove(left);
            Controls.Remove(ingSearch);
            Controls.Remove(buttonLeave);
            Controls.Remove(comboBoxCategoris);
            Controls.Remove(categSearch);
            comboBoxCategoris.Items.Add("Основна страва");
            comboBoxCategoris.Items.Add("Суп");
            comboBoxCategoris.Items.Add("Салат");
            comboBoxCategoris.Items.Add("Десерт");
        }

        private void buttonSearcnName_Click(object sender, EventArgs e)
        {
            name_ing = 1;
            Controls.Remove(buttonSearcnName);
            Controls.Remove(buttonSearchIngradiends);
            Controls.Remove(buttonLeave);            
            Controls.Remove(buttonCategoris);            
            Controls.Add(searchBox);
            Controls.Add(searchName);
        }

        private void searchBox_Leave(object sender, EventArgs e)
        {
            TextBox box = sender as TextBox;
            Name = box.Text;
        }

        private void searchName_Click(object sender, EventArgs e)
        {
            nameSearch = new RecipesList(recipeList.SearchByName(Name));

            Controls.Remove(searchBox);
            Controls.Remove(searchName);
            Controls.Add(recipeIcon);
            Controls.Add(textBoxRecipes);
            Controls.Add(right);
            Controls.Add(left);
            Controls.Add(buttonback);
            if (nameSearch.isEmpty())
            {
                textBoxRecipes.Text = "рецептів не знайдено";
                Image image = Image.FromFile("..\\..\\..\\photos\\sad.png");
                recipeIcon.Image = image;
                Controls.Remove(right);
                Controls.Remove(left);
                return;
            }
            showImage(nameSearch, name_index);
            showRecipe(nameSearch, name_index);

        }
        private void showImage(RecipesList recipeList,  int index)
        {
            string imagePath = recipeList.recipes[index].Icon;
            try
            {
                Image image = Image.FromFile(imagePath);
                recipeIcon.Image = image;
            }
            catch (FileNotFoundException)
            {
                Image image = Image.FromFile("..\\..\\..\\photos\\plate.png");
                recipeIcon.Image = image;
            }
           
        }
        private void showRecipe(RecipesList recipeList,int index)
        {
            textBoxRecipes.Text = $"Назва: {recipeList.recipes[index].Name}";
            textBoxRecipes.AppendText($"\r\nОпис:{recipeList.recipes[index].Description}");
            textBoxRecipes.AppendText($"\r\nІнградієнти:{recipeList.recipes[index].showIngradients()}");
            textBoxRecipes.AppendText($"\r\nСпосіб приготування:{recipeList.recipes[index].Instruction}");
        }

        private void right_Click(object sender, EventArgs e)
        {
            if (name_ing == 1)
            {
                
                if (name_index == nameSearch.recipes.Count-1)
                {
                    name_index = 0;
                }
                else if (nameSearch.recipes.Count!=1)
                {
                    name_index += 1;
                }
                
                showImage(nameSearch, name_index);
                showRecipe(nameSearch, name_index);
            }
            else if (name_ing == 0)
            {
                if (ingradient_index < ingradientsSearch.recipes.Count-1)
                {
                    ingradient_index += 1;
                }
                else
                {
                    ingradient_index = 0;
                }
                showImage(ingradientsSearch, ingradient_index);
                showRecipe(ingradientsSearch, ingradient_index);
            }
            else if (name_ing == 2)
            {
                if (Categoris_index < CategorisSearch.recipes.Count-1)
                {
                    Categoris_index += 1;
                }
                else
                {
                    Categoris_index = 0;
                }
                showImage(CategorisSearch, Categoris_index);
                showRecipe(CategorisSearch, Categoris_index);
            }
        }
        private void left_Click(object sender, EventArgs e)
        {
            if (name_ing == 1)
            {
                if (name_index > 0)
                {
                    name_index -= 1;
                }
                else
                {
                    name_index = nameSearch.recipes.Count-1;
                }
                showImage(nameSearch, name_index);
                showRecipe(nameSearch, name_index);
            }
            else if (name_ing == 0)
            {
                if (ingradient_index > 0)
                {
                    ingradient_index -= 1;
                }
                else
                {
                    ingradient_index = ingradientsSearch.recipes.Count - 1;
                }
                showImage(ingradientsSearch, ingradient_index);
                showRecipe(ingradientsSearch, ingradient_index);
            }
            else if (name_ing == 2)
            {
                if (Categoris_index > 0)
                {
                    Categoris_index -= 1;
                }
                else
                {
                    Categoris_index = CategorisSearch.recipes.Count - 1;
                }
                showImage(CategorisSearch, Categoris_index);
                showRecipe(CategorisSearch, Categoris_index);
            }
        }

        private void buttonSearchIngradiends_Click(object sender, EventArgs e)
        {
            name_ing = 0;
            Controls.Remove(buttonSearcnName);
            Controls.Remove(buttonSearchIngradiends);
            Controls.Remove(buttonLeave);
            Controls.Remove(buttonCategoris);
            Controls.Add(searchBox);
            Controls.Add(ingSearch);
        }

        private void ingSearch_Click(object sender, EventArgs e)
        {
            string[] ing = Name.Split(',');
            List<string> ingList = new List<string>();
            foreach (string ing_ in ing)
            {
                ingList.Add(ing_);
            }
            ingradientsSearch = new RecipesList(recipeList.SearchByIngredients(ingList));
            Controls.Remove(searchBox);
            Controls.Remove(ingSearch);
            Controls.Add(recipeIcon);
            Controls.Add(textBoxRecipes);
            Controls.Add(right);
            Controls.Add(left);
            Controls.Add(buttonLeave);
            if (ingradientsSearch.isEmpty())
            {
                textBoxRecipes.Text = "рецептів не знайдено";
                Image image = Image.FromFile("..\\..\\..\\photos\\sad.png");
                recipeIcon.Image = image;
                Controls.Remove(right);
                Controls.Remove(left);
                return;
            }
            ingradient_index = 0;
            showImage(ingradientsSearch, ingradient_index);
            showRecipe(ingradientsSearch, ingradient_index);
        }

        private void buttonLeave_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            Controls.Add(buttonLeave);
            Controls.Add(buttonSearchIngradiends);
            Controls.Add(buttonSearcnName);
            Controls.Add(buttonCategoris);
        }

        private void buttonCategoris_Click(object sender, EventArgs e)
        {
            name_ing = 2;
            Controls.Remove(buttonSearcnName);
            Controls.Remove(buttonSearchIngradiends);
            Controls.Remove(buttonLeave);
            Controls.Remove(buttonCategoris);
            Controls.Add(comboBoxCategoris);
            Controls.Add(categSearch);

        }

        private void categSearch_Click(object sender, EventArgs e)
        {
            CategorisSearch = new RecipesList(recipeList.SearchByName(category));
            Controls.Remove(comboBoxCategoris);
            Controls.Remove(categSearch);
            Controls.Add(recipeIcon);
            Controls.Add(textBoxRecipes);
            Controls.Add(right);
            Controls.Add(left);
            Controls.Add(buttonback);
            if (CategorisSearch.isEmpty())
            {
                textBoxRecipes.Text = "рецептів не знайдено";
                Image image = Image.FromFile("..\\..\\..\\photos\\sad.png");
                recipeIcon.Image = image;
                Controls.Remove(right);
                Controls.Remove(left);
                return;
            }
            showImage(CategorisSearch, Categoris_index);
            showRecipe(CategorisSearch, Categoris_index);
        }

        private void comboBoxCategoris_SelectedIndexChanged(object sender, EventArgs e)
        {
            category = comboBoxCategoris.SelectedItem.ToString();            
        }

        private void textBoxRecipes_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchForm_Load(object sender, EventArgs e)
        {

        }
    }
}
