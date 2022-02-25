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
    public partial class UpdateCocktail : Form
    {
        DatabaseHelper DB = new DatabaseHelper();
        Cocktail cocktail;
        int cocktailId = 0;

        public UpdateCocktail(Cocktail oldCocktail, int Id)
        {
            cocktail = oldCocktail;
            InitializeComponent();

            cocktailId = Id;
            TxtName.Text = cocktail.Name;
            TxtInfo.Text = cocktail.Description;
            ImgCocktail.Load($"../../src/img/{cocktail.Image}");
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            bool cocktailUpdated = DB.UpdateCocktail(cocktailId, TxtName.Text, TxtInfo.Text);

            if (cocktailUpdated)
            {
                this.Hide();
                CocktailView view = new CocktailView();
                view.Show();
            }
        }
    }
}
