using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme
{
    public class Fidelio
    {
        private int numero;
        private string nom;
        private double prix;
        private int duree;
        private double rabais;

        public Fidelio()
        {

        }

        public Fidelio(int numero,string nom,double prix,int duree,double rabais)
        {
            this.numero = numero;
            this.nom = nom;
            this.prix = prix;
            this.duree = duree;
            this.rabais = rabais;
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

        public double Prix
        {
            get { return this.prix; }
            set { this.prix = value; }
        }

        public int Duree
        {
            get { return this.duree; }
            set { this.duree = value; }
        }

        public double Rabais
        {
            get { return this.rabais; }
            set { this.rabais = value; }
        }
    }
}
