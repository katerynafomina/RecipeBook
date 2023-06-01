namespace RecipeBook
{
    partial class FormAllRecipes
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAllRecipes));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewRecipes = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxRecipes = new System.Windows.Forms.TextBox();
            this.recipeIcon = new System.Windows.Forms.PictureBox();
            this.button_left = new System.Windows.Forms.Button();
            this.button_right = new System.Windows.Forms.Button();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.guna2Transition1.SetDecoration(this.button1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.button1.Location = new System.Drawing.Point(415, 900);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRecipes
            // 
            this.dataGridViewRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guna2Transition1.SetDecoration(this.dataGridViewRecipes, Guna.UI2.AnimatorNS.DecorationType.None);
            this.dataGridViewRecipes.Location = new System.Drawing.Point(74, 317);
            this.dataGridViewRecipes.Name = "dataGridViewRecipes";
            this.dataGridViewRecipes.RowHeadersWidth = 82;
            this.dataGridViewRecipes.RowTemplate.Height = 41;
            this.dataGridViewRecipes.Size = new System.Drawing.Size(845, 542);
            this.dataGridViewRecipes.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Transition1.SetDecoration(this.button2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.button2.Location = new System.Drawing.Point(425, 1254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(353, 46);
            this.button2.TabIndex = 0;
            this.button2.Text = "повернутись";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxRecipes
            // 
            this.textBoxRecipes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRecipes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2Transition1.SetDecoration(this.textBoxRecipes, Guna.UI2.AnimatorNS.DecorationType.None);
            this.textBoxRecipes.Location = new System.Drawing.Point(158, 546);
            this.textBoxRecipes.Multiline = true;
            this.textBoxRecipes.Name = "textBoxRecipes";
            this.textBoxRecipes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRecipes.Size = new System.Drawing.Size(883, 702);
            this.textBoxRecipes.TabIndex = 1;
            // 
            // recipeIcon
            // 
            this.recipeIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Transition1.SetDecoration(this.recipeIcon, Guna.UI2.AnimatorNS.DecorationType.BottomMirror);
            this.recipeIcon.Location = new System.Drawing.Point(303, 43);
            this.recipeIcon.Name = "recipeIcon";
            this.recipeIcon.Size = new System.Drawing.Size(572, 472);
            this.recipeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.recipeIcon.TabIndex = 2;
            this.recipeIcon.TabStop = false;
            this.recipeIcon.Click += new System.EventHandler(this.recipeIcon_Click);
            // 
            // button_left
            // 
            this.button_left.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Transition1.SetDecoration(this.button_left, Guna.UI2.AnimatorNS.DecorationType.None);
            this.button_left.Location = new System.Drawing.Point(62, 919);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(60, 48);
            this.button_left.TabIndex = 3;
            this.button_left.Text = "<";
            this.button_left.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_left.UseVisualStyleBackColor = true;
            this.button_left.Click += new System.EventHandler(this.button_left_Click);
            // 
            // button_right
            // 
            this.button_right.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Transition1.SetDecoration(this.button_right, Guna.UI2.AnimatorNS.DecorationType.None);
            this.button_right.Location = new System.Drawing.Point(1076, 919);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(60, 48);
            this.button_right.TabIndex = 4;
            this.button_right.Text = ">";
            this.button_right.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_right.UseVisualStyleBackColor = true;
            this.button_right.Click += new System.EventHandler(this.button_right_Click);
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation1;
            // 
            // FormAllRecipes
            // 
            this.ClientSize = new System.Drawing.Size(1167, 1342);
            this.Controls.Add(this.button_right);
            this.Controls.Add(this.button_left);
            this.Controls.Add(this.recipeIcon);
            this.Controls.Add(this.textBoxRecipes);
            this.Controls.Add(this.button2);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Name = "FormAllRecipes";
            this.Load += new System.EventHandler(this.FormAllRecipes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private DataGridView dataGridViewRecipes;
        private Button button2;
        private TextBox textBoxRecipes;
        private PictureBox recipeIcon;
        private Button button_left;
        private Button button_right;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
    }
}