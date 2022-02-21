using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailBlog
{
    class Cocktail
    {
        public string CreatorName { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Image { get; private set; }

        public List<string> Tools = new List<string>();
        public List<string> Ingredients = new List<string>();

        public List<Review> Reviews = new List<Review>();

        public Cocktail(string CocktailCreatorName, string CocktailName, string CocktailDesc, 
            string Img, List<string> CocktailTools, List<string> CocktailIngredients)
        {
            CreatorName = CocktailCreatorName;
            Name = CocktailName;
            Description = CocktailDesc;
            Image = Img;
            Tools = CocktailTools;
            Ingredients = CocktailIngredients;
        }
    }
}
