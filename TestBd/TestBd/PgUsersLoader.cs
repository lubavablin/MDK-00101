using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestBd
{
    public class PgUsersLoader
    {
        private BindingList<User> result_ = new BindingList<User>();
        private const string connectSetting = "Host=192.168.1.48;Username=postgres;Password=PG@dmin$;Database=test01";
        public BindingList<User> Load()
        {
            try
            {
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "SELECT login,password,name, last_name, age FROM users";
                var cmd = new NpgsqlCommand(sql, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    User user = new User
                    {
                        Login = reader.GetString(0),
                        Password = reader.GetString(1),
                        Name = reader.GetString(2),
                        Last_name = reader.GetString(3),
                        Age = reader.GetInt32(4)
                    };

                    result_.Add(user);
                }
                con.Close();

                return result_;
            } catch(NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public bool DeleteUser(string login)
        {
            try
            {
                bool result = false;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = @"DELETE FROM quarty Where login = @login";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@login", login);
                int changedRows = cmd.ExecuteNonQuery();

                if (changedRows < 0)
                {
                    return false;
                }
                return true;
            } catch(NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        /*public bool AddUser(User user)
        {
            try
            {
                bool addResult = false;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "INSERT INTO users(login,password,name,last_name, age)VALUES(@login, @password, @name, @last_name, @age)";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@login", user.Login);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@last_name", user.Last_name);
                cmd.Parameters.AddWithValue("@age", user.Age);
                int execute*/
            }
        }
    }
}