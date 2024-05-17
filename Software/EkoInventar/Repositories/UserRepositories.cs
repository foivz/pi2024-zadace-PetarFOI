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
    internal class UserRepositories
    {
        public static Korisnik GetKorisnik(string username)
        {
            string sql = $"SELECT * FROM Korisnik WHERE KKorIme = '{username}'";
            return FetchKorisnik(sql);
        }

        public static Korisnik GetKorisnik(int id)
        {
            string sql = $"SELECT * FROM Korisnik WHERE ID_korisnik = {id}";
            return FetchKorisnik(sql);
        }

        private static Korisnik FetchKorisnik(string sql)
        {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Korisnik korisnik = null;

            if (reader.HasRows == true)
            {
                reader.Read();
                korisnik = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();

            return korisnik;
        }

        public static List<Korisnik> GetKorisnik()
        {
            var korisnik = new List<Korisnik>(); 
            string sql = "SELECT * FROM Korisnik";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Korisnik korisnici = CreateObject(reader);
                korisnik.Add(korisnici);
            }

            reader.Close();
            DB.CloseConnection();

            return korisnik;
        }

        private static Korisnik CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["ID_korisnik"].ToString());
            string ime = reader["Ime"].ToString();
            string prezime = reader["Prezime"].ToString();
            string adminUser = reader["KKorIme"].ToString();
            string adminPass = reader["KLozinka"].ToString();

            var korisnik = new Korisnik
            {
                ID_korisnik = id,
                Ime = ime,
                Prezime = prezime,
                KKorIme = adminUser,
                KLozinka = adminPass
            };
            return korisnik;
        }
    }
}
