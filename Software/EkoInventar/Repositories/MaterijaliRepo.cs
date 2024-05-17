using DBLayer;
using EkoInventar.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EkoInventar.Models
{
    public class MaterijaliRepo
    {
        public static Materijal GetMaterijal(int id)
        {
            Materijal materijal = null;

            string sql = $"SELECT * FROM MaterijaliEkoInventar WHERE ID_mat = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                materijal = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return materijal;
        }

        public static List<Materijal> GetMaterijali()
        {
            var materijali = new List<Materijal>(); 

            string sql = "SELECT * FROM MaterijaliEkoInventar";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Materijal materijal = CreateObject(reader);
                materijali.Add(materijal);
            }

            reader.Close();
            DB.CloseConnection();

            return materijali;
        }

        internal static Materijal GetMaterijalByID(int newMaterialID)
        {
            throw new NotImplementedException();
        }

        private static Materijal CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["ID_mat"].ToString());
            string name = reader["strNaziv"].ToString();
            int Kolicina = int.Parse(reader["intKolicina"].ToString());
            float Cijena = float.Parse(reader["intCijena"].ToString());
            float Kriticno = float.Parse(reader["intKriticno"].ToString());
            int MaxKolicina = int.Parse(reader["intMaxKolicina"].ToString());


            var materijal = new Materijal 
            {
                ID_mat = id,
                Naziv = name,
                Kolicina = Kolicina,
                Cijena = Cijena,
                KriticniPostotak = Kriticno,
                maxKolicina = MaxKolicina
            };

            return materijal;
        }
    }
}