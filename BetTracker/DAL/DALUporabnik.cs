using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using BetTracker.Models;

namespace BetTracker.DAL
{
    public class DALUporabnik
    {
        private IConfiguration configuration;

        public DALUporabnik(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public int addUporabnik(string ime, string priimek, string email, string drzava, string geslo)
        {
            // connection na bazo
            string connStr = configuration.GetConnectionString("DefaultConnection");
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            // če že obstaja
            string query1 = "SELECT ID_uporabnik FROM Uporabnik WHERE Email = @email;";
            SqlCommand cmd1 = new SqlCommand(query1, conn);
            cmd1.Parameters.AddWithValue("@email", email);

            SqlDataReader reader1 = cmd1.ExecuteReader();

            if (reader1.HasRows)
            {
                return -1;
            }

            // nastavitev query
            string query = "INSERT INTO Uporabnik VALUES(@ime,@priimek,@email,@drzava,@geslo) select SCOPE_IDENTITY() as id;";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@ime", ime);
            cmd.Parameters.AddWithValue("@priimek", priimek);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@drzava", drzava);
            cmd.Parameters.AddWithValue("@geslo", geslo);
            SqlDataReader reader = cmd.ExecuteReader();
            int uID = 0;
            if (reader.HasRows)
            {
                reader.Read();
                uID = Convert.ToInt16(reader[0]);
            }

            return uID;
        }

        public int preveriLogin(string email, string geslo)
        {
            // connection na bazo
            string connStr = configuration.GetConnectionString("DefaultConnection");
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            // nastavitev query
            string query = "SELECT ID_uporabnik from Uporabnik where email = @email and geslo = @geslo;";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@geslo", geslo);

            // if prazen
            SqlDataReader reader = cmd.ExecuteReader();
            int uID = 0;
            if (reader.HasRows)
            {
                reader.Read();
                uID = Convert.ToInt16(reader[0]);
            }
            else
            {
                uID = 0;
            }

            conn.Close();

            return uID;
        }

        public Uporabnik dobiPodatke(int ID_uporabnika)
        {
            // connection na bazo
            string connStr = configuration.GetConnectionString("DefaultConnection");
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            // nastavitev query
            string query = "SELECT * from Uporabnik where ID_uporabnik = @id";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@id", ID_uporabnika);

            Uporabnik u = new Uporabnik();
            // if prazen
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                u.Ime = reader[1].ToString();
                u.Priimek = reader[2].ToString();
                u.Email = reader[3].ToString();
                u.Drzava = reader[4].ToString();
            }

            conn.Close();

            return u;
        }

        public int posodobiUporabnika(int ID_uporabnika, Uporabnik u)
        {
            // connection na bazo
            string connStr = configuration.GetConnectionString("DefaultConnection");
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            int updated;
            if (u.Geslo == null)
            {
                string query = "UPDATE Uporabnik set Ime=@ime,Priimek=@priimek,Drzava=@drzava where ID_uporabnik = @id";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", ID_uporabnika);
                cmd.Parameters.AddWithValue("@ime", u.Ime);
                cmd.Parameters.AddWithValue("@priimek", u.Priimek);
                cmd.Parameters.AddWithValue("@drzava", u.Drzava);
                updated = cmd.ExecuteNonQuery();
            }

            else
            {
                string query = "UPDATE Uporabnik set Ime=@ime,Priimek=@priimek,Drzava=@drzava,Geslo=@geslo where ID_uporabnik = @id";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", ID_uporabnika);
                cmd.Parameters.AddWithValue("@ime", u.Ime);
                cmd.Parameters.AddWithValue("@priimek", u.Priimek);
                cmd.Parameters.AddWithValue("@drzava", u.Drzava);
                cmd.Parameters.AddWithValue("@geslo", u.Geslo);
                updated = cmd.ExecuteNonQuery();
            }

            conn.Close();

            return updated;
        }
    }
}
