using BetTracker.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BetTracker.DAL
{
    public class DALDrzava
    {
        private IConfiguration configuration;

        public DALDrzava(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public List<Drzava> vrniVseDrzave() {
            List<Drzava> seznam = new List<Drzava>();

            // connection na bazo
            string connStr = configuration.GetConnectionString("DefaultConnection");
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            // nastavitev query
            string query = "SELECT * from Drzava;";
            SqlCommand cmd = new SqlCommand(query, conn);

            // if prazen
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Drzava d = new Drzava();
                    d.ID_drzava = Convert.ToInt16(reader[0]);
                    d.Ime = reader[1].ToString();
                    seznam.Add(d);
                }
            }

            conn.Close();

            return seznam;
        }

    }
}
