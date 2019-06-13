using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BetTracker.Models;
using System.Data.SqlClient;

namespace BetTracker.DAL
{
    public class DALStava
    {
        private IConfiguration configuration;

        public DALStava(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public int dodajStavo(int ID_uporabnik, string domaca_ekipa, string gostujoca_ekipa, string k, string izbera, string st, string sport, string status_stave)
        {
            double kvota = Math.Round(Convert.ToDouble(k), 2);
            double stava = Math.Round(Convert.ToDouble(st), 2);
            int ID_sport = Convert.ToInt32(sport);
            int status = Convert.ToInt32(status_stave);

            int ID_doma = 0;
            int ID_goste = 0;

            // connection na bazo
            string connStr = configuration.GetConnectionString("DefaultConnection");
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            // nastavitev query
            string q1 = "SELECT ID_ekipa from Ekipa where Ime = @ekipa";
            SqlCommand cmd = new SqlCommand(q1, conn);

            cmd.Parameters.AddWithValue("@ekipa", domaca_ekipa);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                ID_doma = Convert.ToInt16(reader[0]);
            }
            else
            {
                q1 = "INSERT into Ekipa values(@ekipa) select SCOPE_IDENTITY() as id;";
                cmd = new SqlCommand(q1, conn);

                cmd.Parameters.AddWithValue("@ekipa", domaca_ekipa);
                SqlDataReader readerhome = cmd.ExecuteReader();
                readerhome.Read();
                ID_doma = Convert.ToInt16(readerhome[0]);
            }

            string q2 = "SELECT ID_ekipa from Ekipa where Ime = @ekipa";
            SqlCommand cmd2 = new SqlCommand(q2, conn);

            cmd2.Parameters.AddWithValue("@ekipa", gostujoca_ekipa);

            SqlDataReader reader2 = cmd2.ExecuteReader();

            if (reader2.HasRows)
            {
                reader2.Read();
                ID_goste = Convert.ToInt16(reader2[0]);
            }
            else
            {
                q2 = "INSERT into Ekipa values(@ekipa) select SCOPE_IDENTITY() as id;";
                cmd2 = new SqlCommand(q2, conn);

                cmd2.Parameters.AddWithValue("@ekipa", gostujoca_ekipa);

                reader2 = cmd2.ExecuteReader();
                reader2.Read();
                ID_goste = Convert.ToInt16(reader2[0]);
            }
            string q3 = "INSERT into Stava values(@id_doma,@id_goste,@kvota,@kolicina,@izid,@izbera,@id_sport,@id_uporabnik)";

            SqlCommand cmd3 = new SqlCommand(q3, conn);

            cmd3.Parameters.AddWithValue("@id_doma", ID_doma);
            cmd3.Parameters.AddWithValue("@id_goste", ID_goste);
            cmd3.Parameters.AddWithValue("@kvota", kvota);
            cmd3.Parameters.AddWithValue("@kolicina", stava);
            cmd3.Parameters.AddWithValue("@izid", status);

            if (izbera == domaca_ekipa)
                cmd3.Parameters.AddWithValue("@izbera", ID_doma);
            else
                cmd3.Parameters.AddWithValue("@izbera", ID_goste);

            cmd3.Parameters.AddWithValue("@id_sport", ID_sport);
            cmd3.Parameters.AddWithValue("@id_uporabnik", ID_uporabnik);

            int updated = cmd3.ExecuteNonQuery();
            conn.Close();
            return updated;
        }

        public List<TransportStava> dobiVseStave(int ID_uporabnika)
        {
            List<TransportStava> seznam = new List<TransportStava>();

            // connection na bazo
            string connStr = configuration.GetConnectionString("DefaultConnection");
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            // nastavitev query
            string q = "SELECT e.Ime as Ime_doma, e1.Ime as Ime_goste, s.Kvota, s.Kolicina, s.Izid, sp.Naziv as Vrsta_sporta, (SELECT Ime from Ekipa where ID_ekipa = s.Izbera) as Izbral, s.ID_stava from Stava s inner join Ekipa e on e.ID_ekipa=s.ID_ekipa_doma inner join Ekipa e1 on s.ID_ekipa_goste=e1.ID_ekipa inner join Sport sp on s.ID_sport=sp.ID_sport where s.ID_uporabnik=@id;";
            SqlCommand cmd = new SqlCommand(q, conn);

            cmd.Parameters.AddWithValue("@id", ID_uporabnika);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    TransportStava tmp = new TransportStava();

                    tmp.Ime_doma = reader[0].ToString();
                    tmp.Ime_goste = reader[1].ToString();
                    tmp.Kvota = Math.Round(Convert.ToDouble(reader[2]), 2);
                    tmp.Kolicina = Math.Round(Convert.ToDouble(reader[3]), 2);
                    tmp.Izid = Convert.ToInt16(reader[4]);
                    tmp.Naziv = reader[5].ToString();
                    tmp.Izbral = reader[6].ToString();
                    tmp.ID_stava = Convert.ToInt16(reader[7]);
                    seznam.Add(tmp);
                }
            }

            conn.Close();


            return seznam;
        }

        public double trenutnoStanje(int ID_uporabnika)
        { 
            double stanje = 0;

            // connection na bazo
            string connStr = configuration.GetConnectionString("DefaultConnection");
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            // nastavitev query
            string q = "(SELECT sum(Kolicina) from Stava where ID_uporabnik = @id and Izid = 2);";
            SqlCommand cmd = new SqlCommand(q, conn);

            cmd.Parameters.AddWithValue("@id", ID_uporabnika);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                if (reader[0] != System.DBNull.Value)
                {
                    stanje = stanje - Math.Round(Convert.ToDouble(reader[0]), 2);
                }
            }

            reader.Close();

            string q1 = "(SELECT sum(Kvota* Kolicina - Kolicina) from Stava where ID_uporabnik = @id1 and Izid = 1);";
            SqlCommand cmd1 = new SqlCommand(q1, conn);

            cmd1.Parameters.AddWithValue("@id1", ID_uporabnika);

            SqlDataReader reader1 = cmd1.ExecuteReader();

            if (reader1.HasRows)
            {
                reader1.Read();
                if (reader1[0] != System.DBNull.Value)
                {
                    stanje = stanje + Math.Round(Convert.ToDouble(reader1[0]), 2);
                }
            }

            conn.Close();
            return stanje;
        }

        public double maxDobljena(int ID_uporabnika)
        {
            double stanje = 0;

            // connection na bazo
            string connStr = configuration.GetConnectionString("DefaultConnection");
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            // nastavitev query
            string q = "SELECT MAX(Kvota* Kolicina) from Stava where ID_uporabnik = @id and Izid=1";
            SqlCommand cmd = new SqlCommand(q, conn);

            cmd.Parameters.AddWithValue("@id", ID_uporabnika);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                if (reader[0] != System.DBNull.Value)
                {
                    stanje = Math.Round(Convert.ToDouble(reader[0]), 2);
                }
            }

            conn.Close();
            return stanje;
        }

        public double maxIzguba(int ID_uporabnika)
        {
            double stanje = 0;

            // connection na bazo
            string connStr = configuration.GetConnectionString("DefaultConnection");
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            // nastavitev query
            string q = "SELECT MAX(Kolicina) from Stava where ID_uporabnik = @id and Izid=2";
            SqlCommand cmd = new SqlCommand(q, conn);

            cmd.Parameters.AddWithValue("@id", ID_uporabnika);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                if (reader[0] != System.DBNull.Value)
                {
                    stanje = Math.Round(Convert.ToDouble(reader[0]), 2);
                }         
            }

            conn.Close();
            return stanje;
        }

        public string winpercantage(int ID_uporabnika)
        {
            double dobljenih = 0;
            double vseh = 0;

            // connection na bazo
            string connStr = configuration.GetConnectionString("DefaultConnection");
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            // nastavitev query
            string q = "SELECT COUNT(*) from Stava where ID_uporabnik = @id and Izid=1";
            SqlCommand cmd = new SqlCommand(q, conn);

            cmd.Parameters.AddWithValue("@id", ID_uporabnika);

            SqlDataReader reader = cmd.ExecuteReader();
            var vrni = new System.Text.StringBuilder();
            if (reader.HasRows)
            {
                reader.Read();

                if (reader[0] != System.DBNull.Value)
                {
                    dobljenih = Convert.ToDouble(reader[0]);
                    vrni.Append(dobljenih.ToString() + "/");
                }
            }

            q = "SELECT COUNT(*) from Stava where ID_uporabnik = @id";
            SqlCommand cmd1 = new SqlCommand(q, conn);
            cmd1.Parameters.AddWithValue("@id", ID_uporabnika);
            reader = cmd1.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                if (reader[0] != System.DBNull.Value)
                {
                    vseh = Convert.ToDouble(reader[0]);
                    vrni.Append(vseh.ToString() + " ");
                }
            }
            double preracunano = 0;
            if (vseh != 0) {
                preracunano = dobljenih / vseh;
                preracunano = Math.Round(preracunano, 4) * 100;
            }

            vrni.Append(" " + preracunano + "%");

            conn.Close();
            return vrni.ToString();
        }
    }
}
