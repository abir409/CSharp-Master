using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace AdoNetExample
{
    public class DataUtility
    {
        private readonly string _connectionString;

        public DataUtility(string connectionString)
        {
            _connectionString = connectionString;
        }

        public int ExecuteCommand(string commandText, IList<SqlParameter> parameters)
        {
            using (SqlCommand cmd = GetCommand(commandText,parameters))
            {
                return cmd.ExecuteNonQuery();
            }
        }
        public object ExecuteScalar(string commandText, IList<SqlParameter> parameters)
        {
            using (SqlCommand cmd = GetCommand(commandText,parameters))
            {
                return cmd.ExecuteScalar();
            }
        }

        public List<Dictionary<string, object>> ExecuteQuery(string query, IList<SqlParameter> parameters)
        {
            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();

            using (SqlCommand cmd = GetCommand(query,parameters))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Dictionary<string, object> dict = new Dictionary<string, object>();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            dict.Add(reader.GetName(i), reader.GetValue(i));
                        }
                        result.Add(dict);
                    }
                }
            }
            return result;
        }

        

        private SqlCommand GetCommand(string commandText, IList<SqlParameter> parameters)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand cmd = connection.CreateCommand();

            cmd.Connection = connection;
            cmd.CommandText = commandText;

            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            cmd.Parameters.AddRange(parameters.ToArray());


            return cmd;
        }
    }
}
