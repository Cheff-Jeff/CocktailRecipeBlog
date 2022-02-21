using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
 
namespace CocktailBlog
{
    /*
    * TODO
    * 
    * get cocktails
    * get cocktail
    * 
    * add review
    * update review
    * delete review
    * get reviews
    * 
    * add user
    * update user
    * delete user
    * get user
    * 
    * denken manier tools toevoegen.
    * 
    */

    class DatabaseHelper
    {
        private string connenctionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\1999j\Documents\School\CocktailRecipeBlog\CocktailBlog\CocktailBlog\CocktailBlogDB.mdf;Integrated Security=True";
        private SqlConnection cnn;
        private string query;
        private SqlCommand cmd;

        private void OpenDbConnenction()
        {
            cnn = new SqlConnection(connenctionString);
            cnn.Open();
        }

        private void CloseDbConnection()
        {
            cnn.Close();
        }
 
        public void AddCocktail(int UserId, string name, string desc, string img, string ingre) 
        {
            UserId = 1;
            int toolid = 1;
            query = "INSERT INTO Cocktails (UserId, Name, Description, Photo, Ingredients, CocktailToolsId) " +
                "VALUES (@userID, @name, @desc, @img, @ing, @toolID)";

            try
            {
                OpenDbConnenction();

                cmd = new SqlCommand(query, cnn);

                cmd.Parameters.AddWithValue("@userID", UserId);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@desc", desc);
                cmd.Parameters.AddWithValue("@img", img);
                cmd.Parameters.AddWithValue("@ing", ingre);
                cmd.Parameters.AddWithValue("@toolID", toolid);

                cmd.ExecuteNonQuery();

                CloseDbConnection();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Inner Exception: " + ex.Message);
                Console.WriteLine();
                Console.WriteLine("Query Executed: " + query);
                Console.WriteLine();
                throw;
            }
        }

        public void UpdateCocktail(int CocktailId, string name, string desc, string img, string ingre)
        {
            CocktailId = 1;
            int toolid = 1;
            query = "UPDATE Cocktails (Name, Description, Photo, Ingredients, CocktailToolsId) " +
                "VALUES (@name, @desc, @img, @ing, @toolID) WHERE Id = '" + CocktailId + "'";

            try
            {
                OpenDbConnenction();

                cmd = new SqlCommand(query, cnn);

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@desc", desc);
                cmd.Parameters.AddWithValue("@img", img);
                cmd.Parameters.AddWithValue("@ing", ingre);
                cmd.Parameters.AddWithValue("@toolID", toolid);

                cmd.ExecuteNonQuery();

                CloseDbConnection();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Inner Exception: " + ex.Message);
                Console.WriteLine();
                Console.WriteLine("Query Executed: " + query);
                Console.WriteLine();
                throw;
            }
        }

        public void DeleteCocktail(int CocktailId) 
        {
            CocktailId = 1;
            query = "Delete FROM Cocktails WHERE (@ID)";

            try
            {
                OpenDbConnenction();

                cmd = new SqlCommand(query, cnn);

                cmd.Parameters.AddWithValue("@ID", CocktailId);

                cmd.ExecuteNonQuery();

                CloseDbConnection();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Inner Exception: " + ex.Message);
                Console.WriteLine();
                Console.WriteLine("Query Executed: " + query);
                Console.WriteLine();
                throw;
            }
        }

        public void GetCocktails(int userID)
        {
            
        }

        public void GetCocktail(int cocktailId)
        {

        }
    }
}
