namespace RecipeBook
{
    partial class searchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSearcnName = new System.Windows.Forms.Button();
            this.buttonSearchIngradiends = new System.Windows.Forms.Button();
            this.buttonLeave = new System.Windows.Forms.Button();
            this.searchName = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.textBoxRecipes = new System.Windows.Forms.TextBox();
            this.recipeIcon = new System.Windows.Forms.PictureBox();
            this.right = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.ingSearch = new System.Windows.Forms.Button();
            this.buttonback = new System.Windows.Forms.Button();
            this.buttonCategoris = new System.Windows.Forms.Button();
            this.comboBoxCategoris = new System.Windows.Forms.ComboBox();
            this.categSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.recipeIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSearcnName
            // 
            this.buttonSearcnName.Font = new System.Drawing.Font("Segoe Print", 10.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonSearcnName.Location = new System.Drawing.Point(337, 350);
            this.buttonSearcnName.Name = "buttonSearcnName";
            this.buttonSearcnName.Size = new System.Drawing.Size(478, 80);
            this.buttonSearcnName.TabIndex = 0;
            this.buttonSearcnName.Text = "Пошук за назвою";
            this.buttonSearcnName.UseVisualStyleBackColor = true;
            this.buttonSearcnName.Click += new System.EventHandler(this.buttonSearcnName_Click);
            // 
            // buttonSearchIngradiends
            // 
            this.buttonSearchIngradiends.Font = new System.Drawing.Font("Segoe Print", 10.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonSearchIngradiends.Location = new System.Drawing.Point(337, 465);
            this.buttonSearchIngradiends.Name = "buttonSearchIngradiends";
            this.buttonSearchIngradiends.Size = new System.Drawing.Size(478, 84);
            this.buttonSearchIngradiends.TabIndex = 1;
            this.buttonSearchIngradiends.Text = "Пошук за інградієнтами";
            this.buttonSearchIngradiends.UseVisualStyleBackColor = true;
            this.buttonSearchIngradiends.Click += new System.EventHandler(this.buttonSearchIngradiends_Click);
            // 
            // buttonLeave
            // 
            this.buttonLeave.Font = new System.Drawing.Font("Segoe Print", 10.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonLeave.Location = new System.Drawing.Point(337, 721);
            this.buttonLeave.Name = "buttonLeave";
            this.buttonLeave.Size = new System.Drawing.Size(478, 85);
            this.buttonLeave.TabIndex = 2;
            this.buttonLeave.Text = "Повернутись";
            this.buttonLeave.UseVisualStyleBackColor = true;
            this.buttonLeave.Click += new System.EventHandler(this.buttonLeave_Click);
            // 
            // searchName
            // 
            this.searchName.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchName.Location = new System.Drawing.Point(818, 79);
            this.searchName.Name = "searchName";
            this.searchName.Size = new System.Drawing.Size(150, 55);
            this.searchName.TabIndex = 3;
            this.searchName.Text = "пошук";
            this.searchName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.searchName.UseVisualStyleBackColor = true;
            this.searchName.Click += new System.EventHandler(this.searchName_Click);
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.searchBox.Location = new System.Drawing.Point(354, 95);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(398, 50);
            this.searchBox.TabIndex = 4;
            this.searchBox.Leave += new System.EventHandler(this.searchBox_Leave);
            // 
            // textBoxRecipes
            // 
            this.textBoxRecipes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRecipes.BackColor = System.Drawing.Color.BurlyWood;
            this.textBoxRecipes.Location = new System.Drawing.Point(102, 490);
            this.textBoxRecipes.Multiline = true;
            this.textBoxRecipes.Name = "textBoxRecipes";
            this.textBoxRecipes.Size = new System.Drawing.Size(911, 597);
            this.textBoxRecipes.TabIndex = 5;
            this.textBoxRecipes.TextChanged += new System.EventHandler(this.textBoxRecipes_TextChanged);
            // 
            // recipeIcon
            // 
            this.recipeIcon.BackgroundImage = global::RecipeBook.Properties.Resources._1617827429_9_p_fon_starii_list_bumagi_11;
            this.recipeIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.recipeIcon.Location = new System.Drawing.Point(254, 29);
            this.recipeIcon.Name = "recipeIcon";
            this.recipeIcon.Size = new System.Drawing.Size(607, 435);
            this.recipeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.recipeIcon.TabIndex = 6;
            this.recipeIcon.TabStop = false;
            // 
            // right
            // 
            this.right.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.right.Location = new System.Drawing.Point(1048, 760);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(38, 46);
            this.right.TabIndex = 7;
            this.right.Text = ">";
            this.right.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.right.UseVisualStyleBackColor = true;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(30, 760);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(42, 46);
            this.left.TabIndex = 8;
            this.left.Text = "<";
            this.left.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.left.UseVisualStyleBackColor = true;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // ingSearch
            // 
            this.ingSearch.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ingSearch.Location = new System.Drawing.Point(818, 94);
            this.ingSearch.Name = "ingSearch";
            this.ingSearch.Size = new System.Drawing.Size(150, 47);
            this.ingSearch.TabIndex = 9;
            this.ingSearch.Text = "пошук";
            this.ingSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ingSearch.UseVisualStyleBackColor = true;
            this.ingSearch.Click += new System.EventHandler(this.ingSearch_Click);
            // 
            // buttonback
            // 
            this.buttonback.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.buttonback.Location = new System.Drawing.Point(478, 1124);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(198, 46);
            this.buttonback.TabIndex = 10;
            this.buttonback.Text = "назад";
            this.buttonback.UseVisualStyleBackColor = true;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // buttonCategoris
            // 
            this.buttonCategoris.Font = new System.Drawing.Font("Segoe Print", 10.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonCategoris.Location = new System.Drawing.Point(337, 587);
            this.buttonCategoris.Name = "buttonCategoris";
            this.buttonCategoris.Size = new System.Drawing.Size(478, 89);
            this.buttonCategoris.TabIndex = 11;
            this.buttonCategoris.Text = "Пошук за Категоріями";
            this.buttonCategoris.UseVisualStyleBackColor = true;
            this.buttonCategoris.Click += new System.EventHandler(this.buttonCategoris_Click);
            // 
            // comboBoxCategoris
            // 
            this.comboBoxCategoris.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.comboBoxCategoris.FormattingEnabled = true;
            this.comboBoxCategoris.Location = new System.Drawing.Point(448, 94);
            this.comboBoxCategoris.Name = "comboBoxCategoris";
            this.comboBoxCategoris.Size = new System.Drawing.Size(242, 50);
            this.comboBoxCategoris.TabIndex = 12;
            this.comboBoxCategoris.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategoris_SelectedIndexChanged);
            // 
            // categSearch
            // 
            this.categSearch.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.categSearch.Location = new System.Drawing.Point(818, 88);
            this.categSearch.Name = "categSearch";
            this.categSearch.Size = new System.Drawing.Size(141, 50);
            this.categSearch.TabIndex = 13;
            this.categSearch.Text = "пошук";
            this.categSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.categSearch.UseVisualStyleBackColor = true;
            this.categSearch.Click += new System.EventHandler(this.categSearch_Click);
            // 
            // searchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RecipeBook.Properties.Resources._1617827429_9_p_fon_starii_list_bumagi_11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1134, 1198);
            this.Controls.Add(this.categSearch);
            this.Controls.Add(this.comboBoxCategoris);
            this.Controls.Add(this.buttonCategoris);
            this.Controls.Add(this.buttonback);
            this.Controls.Add(this.ingSearch);
            this.Controls.Add(this.left);
            this.Controls.Add(this.right);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchName);
            this.Controls.Add(this.buttonLeave);
            this.Controls.Add(this.buttonSearchIngradiends);
            this.Controls.Add(this.buttonSearcnName);
            this.Controls.Add(this.textBoxRecipes);
            this.Controls.Add(this.recipeIcon);
            this.Name = "searchForm";
            this.Text = "searchForm";
            this.Load += new System.EventHandler(this.searchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recipeIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSearcnName;
        private Button buttonSearchIngradiends;
        private Button buttonLeave;
        private Button searchName;
        private TextBox searchBox;
        private TextBox textBoxRecipes;
        private PictureBox recipeIcon;
        private Button right;
        private Button left;
        private Button ingSearch;
        private Button buttonback;
        private Button buttonCategoris;
        private ComboBox comboBoxCategoris;
        private Button categSearch;
    }
}