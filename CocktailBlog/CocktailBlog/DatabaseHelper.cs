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
    * denken manier favoriete cocktails.
    * 
    */

    public class DatabaseHelper
    {
        private string connenctionString = @"Data Source=mssqlstud.fhict.local;Database=dbi483908;User Id=dbi483908;Password=Jeff@School#data;";
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

        public bool UpdateCocktail(int CocktailId, string name, string desc/*, string img, string ingre*/)
        {
            query = "UPDATE Cocktails SET Name = @name, Description = @desc WHERE Id = (@CocktailId)";

            try
            {
                OpenDbConnenction();

                cmd = new SqlCommand(query, cnn);

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@desc", desc);
                cmd.Parameters.AddWithValue("@CocktailId", CocktailId);

                cmd.ExecuteNonQuery();

                CloseDbConnection();
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Inner Exception: " + ex.Message);
                Console.WriteLine();
                Console.WriteLine("Query Executed: " + query);
                Console.WriteLine();
                throw;
                return false;
            }
        }

        public void DeleteCocktail(int CocktailId) 
        {
            CocktailId = 1;
            query = "Delete FROM Cocktails WHERE Id = (@ID)";

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

        //Todo Return.
        public void GetCocktails(int userID)
        {
            userID = 1;
            query = "SELECT * FROM Cocktails WHERE UserId = (@ID)";

            try
            {
                OpenDbConnenction();

                cmd = new SqlCommand(query, cnn);

                cmd.Parameters.AddWithValue("@ID", userID);

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

        public Cocktail GetCocktail(int cocktailId)
        {
            Cocktail newCocktail;

            string cocktailName = "";
            string cocktailInfo = "";
            string cocktailImg = "";
            string cocktailIngrest = "";
            string cocktailUserName = "";
            int userId = 0;
            string[] cocktailIngre = {""};
            List<string> cocktailTools = new List<string>();

            query = "SELECT * FROM Cocktails WHERE Id = (@ID)";
            
            try
            {
                OpenDbConnenction();

                cmd = new SqlCommand(query, cnn);

                cmd.Parameters.AddWithValue("@ID", cocktailId);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cocktailName = reader["Name"].ToString();
                        cocktailInfo = reader["Description"].ToString();
                        cocktailImg = reader["Photo"].ToString();
                        cocktailIngrest = reader["Ingredients"].ToString();
                        cocktailIngre = cocktailIngrest.Split(';');
                        userId = Int32.Parse(reader["UserId"].ToString());
                    }
                }

                query = "SELECT * FROM CocktailTools WHERE CocktailId = (@ID)";

                cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ID", cocktailId);

                List<int> tools = new List<int>();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tools.Add(Int32.Parse(reader["ToolId"].ToString()));
                    }
                }

                for (int i = 0; i < tools.Count(); i++)
                {
                    query = "SELECT * FROM Tools WHERE Id = (@ID)";

                    cmd = new SqlCommand(query, cnn);
                    cmd.Parameters.AddWithValue("@ID", tools[i]);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cocktailTools.Add(reader["Name"].ToString());
                        }
                    }
                }

                query = "SELECT FirstName, LastName FROM Users WHERE Id = (@ID)";

                cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@ID", userId);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cocktailUserName = $"{reader["FirstName"].ToString()} {reader["LastName"].ToString()}";
                    }
                }

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

            return newCocktail = new Cocktail(cocktailUserName, cocktailName, cocktailInfo, cocktailImg, cocktailTools, cocktailIngre);
        }
    }
}
