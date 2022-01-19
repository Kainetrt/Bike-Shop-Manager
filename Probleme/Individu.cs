using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme
{
    public class Individu
    {
        private string nom;
        private string prenom;
        private string adresse;
        private string telephone;
        private string courriel;
        private int fidelio;

        public Individu()
        {
            this.nom = null;
        }

        public Individu(string nom,string prenom,string adresse,string telephone,string courriel,int fidelio)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.telephone = telephone;
            this.courriel = courriel;
            this.fidelio = fidelio;
        }

        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; }
        }

        public string Prenom
        {
            get { return this.prenom; }
            set { this.prenom = value; }
        }

        public string Adresse
        {
            get { return this.adresse; }
            set { this.adresse = value; }
        }

        public string Telephone
        {
            get { return this.telephone; }
            set { this.telephone = value; }
        }

        public string Courriel
        {
            get { return this.courriel; }
            set { this.courriel = value; }
        }

        public int Fidelio
        {
            get { return this.fidelio; }
            set { this.fidelio = value; }
        }
    }
}
