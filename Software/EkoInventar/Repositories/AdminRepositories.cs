using DBLayer;
using EkoInventar.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkoInventar.Repositories
{
    internal class AdminRepositories
    {
        public static Administrator GetAdmin(string username)
        {
            string sql = $"SELECT * FROM Administrator WHERE AKorIme = '{username}'";
            return FetchAdmin(sql);
        }

        public static Administrator GetAdmin(int id)
        {
            string sql = $"SELECT * FROM Administrator WHERE Id_Admin = {id}";
            return FetchAdmin(sql);
        }

        public static List<Administrator> GetAdmin()
        {
            var administrator = new List<Administrator>();

            string sql = "SELECT * FROM Administrator";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Administrator administratori = CreateObject(reader);
                administrator.Add(administratori);
            }

            reader.Close();
            DB.CloseConnection();

            return administrator;
        }


        private static Administrator FetchAdmin(string sql)
        {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Administrator administrator = null;

            if (reader.HasRows == true) { 
            reader.Read();
            administrator = CreateObject(reader);
            reader.Close();
            }
            DB.CloseConnection();

            return administrator;
        }
        private static Administrator CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id_Admin"].ToString());
            string ime = reader["Ime"].ToString();
            string prezime = reader["Prezime"].ToString();
            string adminUser = reader["AKorIme"].ToString();
            string adminPass = reader["ALozinka"].ToString();

            var administrator = new Administrator
            {
                ID_Admin = id,
                Ime = ime,
                Prezime=prezime,
                AKorIme = adminUser,
                ALozinka = adminPass
            };
            return administrator;
        }
    }
}
