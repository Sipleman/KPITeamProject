using System;
using System.ServiceModel;
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
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public int Authorizate(string username, string password)
        {
            DataTable queryResult = GetQuery(String.Format("select * from users where user_name='{0}'", username));
            if (queryResult == null || (queryResult.Rows.Count == 0))
                return -1;
            string passwordHash = GetMD5HashCode(password);
            foreach (DataRow row in queryResult.Rows)
            {
                if (passwordHash == (string)row["user_password"])
                    return (int)row["id_user"];
            }
            return -2;
        }

        public int Registration(string username, string password)
        {
            return 0;
        }

        private DataTable GetQuery(string query)
        {
            DataTable dt = null;
            try
            {
                _connection.Open();
                MySqlCommand comm = new MySqlCommand(query, _connection);
                MySqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    dt = new DataTable();
                    dt.Load(dr);
                }
                _connection.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
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
