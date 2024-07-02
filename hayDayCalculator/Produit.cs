using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hayDayCalculator
{
    [Serializable]
    public class Produit
    {
        private string nom;
        private int prix;
        private int cout;
        private int tempsSecondes;
        private int qte;

        public string Nom { get => nom; set => nom = value; }
        public int Prix { get => prix; set => prix = value; }
        public int Cout { get => cout; set => cout = value; }
        public int TempsSecondes { get => tempsSecondes; set => tempsSecondes = value; }
        public int Qte { get => qte; set => qte = value; }

        public Produit(string nom, int prix, int cout, int tempsSecondes, int qte)
        {
            Nom = nom;
            Prix = prix;
            Cout = cout;
            TempsSecondes = tempsSecondes;
            Qte = qte;
        }

        public Produit() : this("Produit", 1, 1, 1, 1)
        {
            
        }

        public int CalculerProfit(int nbProduit)
        {
            return (Prix * nbProduit - Cout * nbProduit) * 3600 / TempsSecondes;
        }
    }
}
