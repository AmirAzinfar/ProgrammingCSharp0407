using Microsoft.Data.SqlClient;
using ProgrammingInCshrpBaseBackend.Interfaces;
using ProgrammingInCshrpBaseBackend.Models;


namespace ProgrammingInCshrpBaseBackend.Services;

    public class UserService : IBaseService<User>
    {
        private const string Connectionstring = "Server=.;Database=ProgrammingCSharp0407Db;Integrated Security=True;TrustServerCertificate=True;";
        public void Add(User user)
        {
            //users.Add(user); 

            // 1:connect to Database (Db)

            using (SqlConnection connection = new SqlConnection(Connectionstring))
             { 
                connection.Open();
                // now, I write a Query with command INSERT (same "INSERT" as Query in Database)
                string Query = $"INSERT INTO [dbo].[Table_User]" +
                    "VALUES (@FirstName,@LastName,@NationalCode,@PhoneNumber,@Birthday,@CreatedAt)";

                SqlCommand command = new SqlCommand(Query, connection);

            // create Parameters to command data in Table of Db
                //command.Parameters.AddWithValue("@Id", "8");
                command.Parameters.AddWithValue("@FirstName", user.FirstName);
                command.Parameters.AddWithValue("@LastName", user.LastName);
                command.Parameters.AddWithValue("@NationalCode", user.NationalCode);
                command.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);
                command.Parameters.AddWithValue("@Birthday", user.Birthday);
                command.Parameters.AddWithValue("@CreatedAt", user.CreatedAt);

                //Excute INSERT Query
            
             int rowsaffected = command.ExecuteNonQuery();
            }
        }
        public List<User> GetAll()
        {
            //return users;
            List<User> users = new List<User>();

            //--------------------------------------------------------------------
            //ADO.NET (Active Data Objects .NET)
            //Daten aus verschiedenen Datenquellen wie SQL-Datenbanken,
            //XML-Dateien oder Webservices zu lesen, zu schreiben und zu verwalten.
            //--------------------------------------------------------------------

            // How we get Data from Tables of Database:

            // 1:connect to Database (Db)
            //const string Connectionstring = "Server=.;Database=ProgrammingCSharp0407Db;Integrated Security=True;TrustServerCertificate=True;";

            // 2: SqlServer command or Query --> select Table (User) from Db
            // here,I need SqlClient Pacage to Install, therefor I search "Microsoft.Data.SqlClient"
            // in Nuget of Project and install it.Attention:Installation musst be done in all projects.
            using (SqlConnection connection = new SqlConnection(Connectionstring))
            {
                connection.Open();
                // now, I write a Query with command SELECT (same "SELECT" as Query in Database)
                string Query = $"SELECT * FROM [dbo].[Table_User]";

                SqlCommand command = new SqlCommand(Query,connection);

                // create a SqlDatareader to read (bring/fetch) data from Table in Db
                SqlDataReader reader = command.ExecuteReader();

             // 3:Results (from Table in Db) --> Map to Instance (Objects)     
                while (reader.Read()) 
                {
                    User user = new User()
                    {
                        Id = (int)reader["Id"],
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        NationalCode = reader["NationalCode"].ToString(),
                        PhoneNumber = reader["PhoneNumber"].ToString(),
                        Birthday = (DateTime)reader["Birthday"],
                        CreatedAt = (DateTime)reader["CreatedAt"],

                    };
                    users.Add(user);
                }    
            }
            // 4-Return List<User>    
            return users;
        }

        public void Delete(int id)
        {
            //const string Connectionstring = "Server=.;Database=ProgrammingCSharp0407Db;Integrated Security=True;TrustServerCertificate=True;";
            using (SqlConnection connection = new SqlConnection(Connectionstring))
            {
                connection.Open();
                // now, I write a Query with command DELETE (same "DELETE" as Query in Database)
                //Without WHERE, all rows in the table will be deleted! The table remains empty.
                string Query = $"DELETE FROM [dbo].[Table_User] WHERE Id = @Id;";

                SqlCommand command = new SqlCommand(Query, connection);

                // create Parameters to command data in Table of Db
                //command.Parameters.AddWithValue("@Id", "8");
                command.Parameters.AddWithValue("@Id", id);

                //Excute INSERT Query

                int rowsaffected = command.ExecuteNonQuery();
            }
        }

        public void Update(User item)
        {
           // const string Connectionstring = "Server=.;Database=ProgrammingCSharp0407Db;Integrated Security=True;TrustServerCertificate=True;";
            using (SqlConnection connection = new SqlConnection(Connectionstring))
            {
                connection.Open();
                // now, I write a Query with command UPDATE (same "UPDATE" as Query in Database)
                //Without WHERE, all rows in the table will be changed!
                string Query = $"UPDATE [dbo].[Table_User] SET FirstName = @FirstName,LastName = @LastName,PhoneNumber = @PhoneNumber, NationalCode = @NationalCode, Birthday = @Birthday WHERE Id = @Id";

                SqlCommand command = new SqlCommand(Query, connection);

                // create Parameters to command data in Table of Db
                //command.Parameters.AddWithValue("@Id", "8");
                command.Parameters.AddWithValue("@FirstName", item.FirstName);
                command.Parameters.AddWithValue("@LastName", item.LastName);
                command.Parameters.AddWithValue("@NationalCode", item.NationalCode);
                command.Parameters.AddWithValue("@PhoneNumber", item.PhoneNumber);
                command.Parameters.AddWithValue("@Birthday", item.Birthday);
                command.Parameters.AddWithValue("@Id", item.Id);

                //Excute INSERT Query

                int rowsaffected = command.ExecuteNonQuery();
            }
        }
    }