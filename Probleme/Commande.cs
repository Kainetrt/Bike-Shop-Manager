using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme
{
    public class Commande
    {
        private int numero;
        private List<Piece> listePiece;
        private List<Velo> listeVelo;
        private DateTime dateCommande;
        private string adresse;
        private DateTime dateLivraison;
        private string numeroPiece;
        private string numeroVelo;

        public Commande()
        {
            this.numero = -1;
        }

        public Commande(int numero, List<Piece> listePiece,List<Velo> listeVelo,DateTime dateCommande,string adresse, DateTime dateLivraison)
        {
            this.numero = numero;
            this.listePiece = listePiece;
            this.listeVelo = listeVelo;
            this.dateCommande = dateCommande;
            this.adresse = adresse;
            this.dateLivraison = dateLivraison;
        }

        public Commande(int numero, DateTime dateCommande, string adresse, DateTime dateLivraison)
        {
            this.numero = numero;
            this.dateCommande = dateCommande;
            this.adresse = adresse;
            this.dateLivraison = dateLivraison;
        }

        public Commande(int numero, string numeroPiece,string numeroVelo,DateTime dateCommande, string adresse, DateTime dateLivraison)
        {
            this.numero = numero;
            this.dateCommande = dateCommande;
            this.adresse = adresse;
            this.dateLivraison = dateLivraison;
            this.numeroPiece = numeroPiece;
            this.numeroVelo = numeroVelo;
        }

        public int Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }

        public List<Piece> ListePiece
        {
            get { return this.listePiece; }
            set { this.listePiece = value; }
        }

        public List<Velo> ListeVelo
        {
            get { return this.listeVelo; }
            set { this.listeVelo = value; }
        }

        public DateTime DateCommande
        {
            get { return this.dateCommande; }
            set { this.dateCommande = value; }
        }

        public string Adresse
        {
            get { return this.adresse; }
            set { this.adresse = value; }
        }

        public DateTime DateLivraison
        {
            get { return this.dateLivraison; }
            set { this.dateLivraison = value; }
        }

        public string NumeroPiece
        {
            get { return this.numeroPiece; }
            set { this.numeroPiece = value; }
        }

        public string NumeroVelo
        {
            get { return this.numeroVelo; }
            set { this.numeroVelo = value; }
        }
    }
}
