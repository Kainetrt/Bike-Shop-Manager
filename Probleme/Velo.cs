using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme
{
    public class Velo
    {
        private int numero;
        private string nom;
        private string grandeur;
        private double prix;
        private DateTime dateDebut;
        private DateTime dateFin;
        private Piece[] listePiece;
        private string gamme;
        private int quantite;

        public Velo()
        {
            this.numero = -1;
        }

        public Velo(int numero)
        {
            this.numero = numero;
        }

        public Velo(int numero,string nom,int quantite)
        {
            this.numero = numero;
            this.nom = nom;
            this.quantite = quantite;
        }

        public Velo(int numero, string nom, string grandeur, double prix,string gamme)
        {
            this.numero = numero;
            this.nom = nom;
            this.grandeur = grandeur;
            this.prix = prix;
            this.gamme = gamme;
        }

        public Velo(int numero, string nom, string grandeur, double prix, string gamme,int quantite)
        {
            this.numero = numero;
            this.nom = nom;
            this.grandeur = grandeur;
            this.prix = prix;
            this.gamme = gamme;
            this.quantite = quantite;
        }

        public Velo(int numero, string nom, string grandeur, double prix, DateTime dateDebut,DateTime dateFin,Piece[] listePiece)
        {
            this.numero = numero;
            this.nom = nom;
            this.grandeur = grandeur;
            this.prix = prix;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.listePiece = listePiece;
        }

        public int Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }

        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; }
        }

        public string Grandeur
        {
            get { return this.grandeur; }
            set { this.grandeur = value; }
        }

        public double Prix
        {
            get { return this.prix; }
            set { this.prix = value; }
        }

        public DateTime DateDebut
        {
            get { return this.dateDebut; }
            set { this.dateDebut = value; }
        }

        public DateTime DateFin
        {
            get { return this.dateFin; }
            set { this.dateFin = value; }
        }

        public Piece[] ListePiece
        {
            get { return this.listePiece; }
            set { this.listePiece = value; }
        }

        public string Gamme
        {
            get { return this.gamme; }
            set { this.gamme = value; }
        }

        public int Quantite
        {
            get { return this.quantite; }
            set { this.quantite = value; }
        }
    }
}
