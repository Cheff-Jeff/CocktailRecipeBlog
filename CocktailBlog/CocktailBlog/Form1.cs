using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CocktailBlog
{
    public partial class CocktailView : Form
    {
        DatabaseHelper DB = new DatabaseHelper();
        Cocktail cocktail;

        public CocktailView()
        {
            InitializeComponent();

            cocktail = DB.GetCocktail(2);

            lblCocktailName.Text = cocktail.Name;
            lblCocktailInfo.Text = cocktail.Description;

            for (int i = 0; i < cocktail.Ingredients.Length; i++)
            {
                LbIngre.Items.Add(cocktail.Ingredients[i]);
            }
            
            for (int i = 0; i < cocktail.Tools.Count; i++)
            {
                LbTools.Items.Add(cocktail.Tools[i]);
            }

            ImgCocktail.Load($"../../src/img/{cocktail.Image}");

            LblUserName.Text = cocktail.CreatorName;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateCocktail updateCocktail = new UpdateCocktail(cocktail, 2);
            updateCocktail.Show();
        }
    }
}
