using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme
{
    public class Fournisseur
    {
        private int siret;
        private string nomEntreprise;
        private string contact;
        private string adresse;
        private int note;

        public Fournisseur()
        {
            this.siret = -1;
        }

        public Fournisseur(int siret, string nomEntreprise, string contact, string adresse, int note)
        {
            this.siret = siret;
            this.nomEntreprise = nomEntreprise;
            this.adresse = adresse;
            this.contact = contact;
            this.note = note;
        }

        public int Siret
        {
            get { return this.siret; }
            set { this.siret = value; }
        }

        public string NomEntreprise
        {
            get { return this.nomEntreprise; }
            set { this.nomEntreprise = value; }
        }

        public string Contact
        {
            get { return this.contact; }
            set { this.contact = value; }
        }

        public string Adresse
        {
            get { return this.adresse; }
            set { this.adresse = value; }
        }

        public int Note
        {
            get { return this.note; }
            set { this.note = value; }
        }
    }
}
