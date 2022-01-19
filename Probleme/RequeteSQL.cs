using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Probleme
{
    public class RequeteSQL
    {
        public string requete;
        public string reponse;

        public RequeteSQL()
        {
        }

        public string Requete
        {
            get { return this.requete; }
            set { this.requete = value; }
        }

        public string Reponse
        {
            get { return this.reponse; }
            set { this.reponse = value; }
        }

        public void SQLINSERT(string requete)
        {
            MySqlConnection maConnexion = null;
            try
            {
                string connexionString = "SERVER=localhost;PORT=3306;" +
                                         "DATABASE=probleme;" +
                                         "UID=root;PASSWORD=root";

                maConnexion = new MySqlConnection(connexionString);
                maConnexion.Open();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(" ErreurConnexion : " + e.ToString());
            }

            string insertTable = requete;
            MySqlCommand command2 = maConnexion.CreateCommand();
            command2.CommandText = insertTable;
            try
            {
                command2.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(" ErreurConnexion : " + e.ToString());
                Console.ReadLine();
            }

            command2.Dispose();
            maConnexion.Close();
        }

        public void SQLDELETE(string requete)
        {
            MySqlConnection maConnexion = null;
            try
            {
                string connexionString = "SERVER=localhost;PORT=3306;" +
                                         "DATABASE=probleme;" +
                                         "UID=root;PASSWORD=root";

                maConnexion = new MySqlConnection(connexionString);
                maConnexion.Open();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(" ErreurConnexion : " + e.ToString());
            }

            MySqlCommand command1 = maConnexion.CreateCommand();
            command1.CommandText = requete;

            MySqlDataReader reader = command1.ExecuteReader();

            string[] valueString = new string[reader.FieldCount];
            reader.Close();
            command1.Dispose();
            maConnexion.Close();
        }

        public string SQL(string requete)
        {
            MySqlConnection maConnexion = null;
            try
            {
                string connexionString = "SERVER=localhost;PORT=3306;" +
                                         "DATABASE=probleme;" +
                                         "UID=root;PASSWORD=root";

                maConnexion = new MySqlConnection(connexionString);
                maConnexion.Open();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(" ErreurConnexion : " + e.ToString());
                return Convert.ToString(e);
            }

            string resultat = "";
            MySqlCommand command1 = maConnexion.CreateCommand();
            command1.CommandText = requete;

            MySqlDataReader reader = command1.ExecuteReader();

            string[] valueString = new string[reader.FieldCount];
            while (reader.Read())
            {
                //string first_name = (string)reader["first_name"];
                //DateTime mylastupdate = (DateTime)reader["last_update"];
                //Console.WriteLine(first_name + " " + mylastupdate);

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    valueString[i] = reader.GetValue(i).ToString();
                    resultat = resultat + valueString[i] + "~";

                }
                resultat = resultat + "\n";
            }
            reader.Close();
            command1.Dispose();
            maConnexion.Close();
            if (resultat.Length > 0)
            {
                resultat = resultat.Remove(resultat.Length - 1);
            }
            return resultat;
        }

    }
}
