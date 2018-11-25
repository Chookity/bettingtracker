using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BetTracker.Models;
using System.Data.SqlClient;

namespace BetTracker.DAL
{
    public class DALEkipa
    {
        private IConfiguration configuration;

        public DALEkipa(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public List<Ekipa> seznamEkip() {
            List<Ekipa> seznam = new List<Ekipa>();

            // connection na bazo
            string connStr = configuration.GetConnectionString("DefaultConnection");
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            // nastavitev query
            string query = "SELECT ID_ekipa, Ime from Ekipa;";
            SqlCommand cmd = new SqlCommand(query, conn);

            // if prazen
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.HasRows)
            {
                reader.Read();
                Ekipa e = new Ekipa();
                e.ID_ekipa = Convert.ToInt16(reader[0]);
                e.Ime = reader[1].ToString();
                seznam.Add(e);
            }
        
            conn.Close();

            return seznam;
        }
    }
}
