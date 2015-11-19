using System;
using System.Security.Cryptography;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;

namespace Server
{
    class DataBase : IDataBase
    {
        private MySqlConnection _connection;

        public DataBase()
        {
            MySqlConnectionStringBuilder _connectionSB = new MySqlConnectionStringBuilder();
            _connectionSB.Server = "localhost";
            _connectionSB.UserID = "server";
            _connectionSB.Password = "1111";
            _connectionSB.Database = "KPITeamProject";

            _connection = new MySqlConnection(_connectionSB.ConnectionString);
            try
            {
                _connection.Open();
                if (!_connection.Ping())
                    Console.WriteLine("DataBase connection is failed");
                _connection.Close();
                Log.WriteMessage("Ping and open connection was succeed", "Start connection");
            }
            catch(Exception ex)
            {
                Log.WriteMessage(ex.Message, "Start connection");
            }
        }

        public int Authorizate(string username, string password)
        {
            DataTable queryResult;
            try
            {
                queryResult = GetQuery(String.Format("select * from users where user_name='{0}'", username));
                if (queryResult.Rows.Count == 0)
                    return -1;
                string passwordHash = GetMD5HashCode(password);
                foreach (DataRow row in queryResult.Rows)
                {
                    if (passwordHash == (string)row["user_password"])
                    {
                        Log.WriteMessage(username, "Authorizate");
                        return (int)row["id_user"];
                    }
                }
                return -2;
            }
            catch(Exception ex)
            {
                Log.WriteMessage(ex.Message, "Authorizate");
                return -400;
            }

        }

        public int Registration(string username, string password, string firstName, string secondName, string language = null)
        {
            DataTable queryResult = null;
            try
            {
                queryResult = GetQuery(String.Format("select * from users where user_name='{0}'", username));
                if (queryResult.Rows.Count > 0)
                    return -10;
            }
            catch (Exception ex)
            {
                Log.WriteMessage(ex.Message, "Registration");
                return -400;
            }

            string passwordHash = GetMD5HashCode(password);

            try
            {
                queryResult = GetQuery(String.Format(
                    "insert into users(user_name, user_password, user_first_name, user_second_name, user_language) values ('{0}', '{1}', '{2}', '{3}', '{4}')"
                    , username, passwordHash, firstName, secondName, language));

                queryResult = GetQuery(String.Format("select * from users where user_name='{0}'", username));

                if (queryResult.Rows.Count == 1)
                {
                    Log.WriteMessage("Succeed new registration user", "Registration");
                    return (int)queryResult.Rows[0]["id_user"];
                }
                else
                {
                    Log.WriteMessage("Can't find new user in database", "Registration");
                    return -20;
                }
            }
            catch(Exception ex)
            {
                Log.WriteMessage(ex.Message, "Registration");
                return -400;
            }
        }

        private DataTable GetQuery(string query)
        {
            DataTable dt = null;
            try
            {
                _connection.Open();
                MySqlCommand comm = new MySqlCommand(query, _connection);
                MySqlDataReader dr = comm.ExecuteReader();
                dt = new DataTable();
                if (dr.HasRows)
                {
                    dt.Load(dr);
                }
                _connection.Close();
            }
            catch(Exception ex)
            {
                Log.WriteMessage(ex.Message, "Query");
                return null;
            }
            if (dt == null)
                throw new Exception("Invalid sql command");
            return dt;
        }

        private string GetMD5HashCode(string input)
        {
            //Создание хэшируещего объекта
            MD5 md5 = MD5.Create();

            //Конвертирование хэш-значения входящей строки в массив бит
            byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            //Создание конструктора строки для преобразования хэш-суммы в строку
            StringBuilder sBuilder = new StringBuilder();

            //Воссоздание строки из массива бит в формате х2
            for (int i = 0; i < data.Length; i++)
                sBuilder.Append(data[i].ToString("x2"));

            return sBuilder.ToString();
        }
    }
}
