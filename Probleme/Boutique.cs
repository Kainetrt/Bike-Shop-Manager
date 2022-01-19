using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme
{
    public class Boutique
    {
        private string nom;
        private string adresse;
        private string telephone;
        private string courriel;
        private string nomContact;
        private double remise;

        public Boutique()
        {
            this.nom = null;
        }

        public Boutique(string nom, string adresse, string telephone, string courriel, string nomContact, double remise)
        {
            this.nom = nom;
            this.adresse = adresse;
            this.telephone = telephone;
            this.courriel = courriel;
            this.nomContact = nomContact;
            this.remise = remise;
        }

        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; }
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

        public string NomContact
        {
            get { return this.nomContact; }
            set { this.nomContact = value; }
        }

        public double Remise
        {
            get { return this.remise; }
            set { this.remise = value; }
        }
    }
}
