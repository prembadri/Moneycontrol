using Moneycontrol.Common.Models;
using Moneycontrol.DAL.Contracts;
using System.Data.SQLite;

namespace Moneycontrol.DAL.DataSource
{
    public class SQLiteOperator : ISQLiteOperator
    {
        private readonly string _connectionString = string.Empty;

        public SQLiteOperator(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<CategoryTypesModel> GetCategoryTypes()
        {
            List<CategoryTypesModel> categoryTypes = new List<CategoryTypesModel>();

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT Id,Type FROM CategoryTypes";
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        categoryTypes.Add(new CategoryTypesModel()
                        {
                            Id = int.Parse(reader["Id"].ToString()),
                            CategoryType = reader["Type"].ToString()
                        });
                    }
                }
            }

            return categoryTypes;
        }
    }
}
