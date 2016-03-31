using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdminFleur
{
    class Produit
    {
        private string id;
        private string description;
        private double prix;
        private string image;
        private string idCategorie;

        public Produit()
        {

        }

        public Produit(string unId, string uneDescription, double unPrix, string uneImage, string unIdCategorie)
        {
            id = unId;
            description = uneDescription;
            prix = unPrix;
            image = uneImage;
            idCategorie = unIdCategorie;
        }

        public string getId()
        {
            return (id);
        }

        public string getDescription()
        {
            return (description);
        }

        public double getPrix()
        {
            return (prix);
        }

        public string getImage()
        {
            return (image);
        }

        public string getIdCategorie()
        {
            return (idCategorie);
        }
    }
}
