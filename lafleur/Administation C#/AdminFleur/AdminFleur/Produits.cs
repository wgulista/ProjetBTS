using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ConnexionDll;
using System.Net;
using System.IO;

namespace AdminFleur
{
    public partial class Produits : Form
    {
        public Produits()
        {
            InitializeComponent();
        }

        #region Declarations
        ConnexionSql sql = new ConnexionSql();
        #endregion

        #region Load
        private void Produits_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }
        #endregion

        #region Boutons
        private void btnPlus_Click(object sender, EventArgs e)
        {
            /*openImage.Filter = "Fichiers image(*.gif)|*.gif";
            if (openImage.ShowDialog() == DialogResult.OK)
            {
                string nomFichier = openImage.SafeFileName;
                rtbImage.Text += nomFichier;
            }*/
            ImageRtb();

        }

        private void btnMoins_Click(object sender, EventArgs e)
        {
            rtbImage.ResetText();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Ajouter();
        }
        #endregion

        #region Fonctions
        /// <summary>
        /// Méthode Ajouter permet d'ajouter un nouveau produit dans la base de donnée 
        /// </summary>
        private void Ajouter()
        {
            if ((txbPrix.Text != "") || (rtbDescription.Text != "") || (txbId.Text != "") || (cmbCategorie.SelectedIndex != -1) || (rtbImage.Text != ""))
            {
                string id = txbId.Text;
                string description = rtbDescription.Text;
                double prix = Convert.ToDouble(txbPrix.Text);
                string image = rtbImage.Text;
                string categorie = cmbCategorie.SelectedItem.ToString();

                Produit P1 = new Produit(id,description,prix,image,categorie);
                sql.Initialize();
                MySqlCommand cmdAffich = sql.GetConnection().CreateCommand();
                cmdAffich.CommandText = "INSERT INTO produit values('" + P1.getId() + "','" + P1.getDescription() +"','" + P1.getPrix() + "','" + P1.getImage() + "','" + P1.getIdCategorie() + "')";
                sql.OpenConnection();
                if (cmdAffich.ExecuteNonQuery() != -1)
                {
                    upload(rtbImage.Text, openImage.FileName);
                    MessageBox.Show("L'ajout réussi");
                    txbId.ResetText();
                    rtbDescription.ResetText();
                    txbPrix.ResetText();
                    rtbImage.ResetText();
                    cmbCategorie.ResetText();
                    cmbType.ResetText();
                    rtbImage.Enabled = false;
                }
                
            }
            else
            {
                MessageBox.Show("Ajout impossible. Veuillez remplir tout les champs");
            }
        }

        private void upload(string source, string target)
        {

            Uri server = new Uri("ftp://airday@ftp.alwaysdata.com/www/lafleur/design/" + source);
            FtpWebRequest myRequest = (FtpWebRequest)WebRequest.Create(server);
            myRequest.UseBinary = true;
            myRequest.Credentials = new NetworkCredential("airday", "Y4Sh9TTp6B5g15975328");
            byte[] fileData = File.ReadAllBytes(target);


            myRequest.KeepAlive = false;
            myRequest.Method = WebRequestMethods.Ftp.UploadFile;
            myRequest.Timeout = 5000;

            Stream reqStream = myRequest.GetRequestStream();
            reqStream.Write(fileData, 0, fileData.Length);
            reqStream.Close();


            FtpWebResponse response = (FtpWebResponse)myRequest.GetResponse();

        }

        private void ImageRtb()
        {
            openImage.Filter = "Fichiers image(*.jpg)|*.jpg";
            if (openImage.ShowDialog() == DialogResult.OK)
            {
                string nomFichier = openImage.SafeFileName;
                rtbImage.Text += nomFichier;
            }
        }

        private void comboCategorie()
        {
            rtbImage.ResetText();
            if (cmbCategorie.SelectedItem.ToString() == "com")
            {
                rtbImage.Text += "images/compo/";
                rtbImage.Enabled = true;
            }

            if (cmbCategorie.SelectedItem.ToString() == "fle")
            {
                rtbImage.Text += "images/fleurs/";
                rtbImage.Enabled = true;
            }

            if (cmbCategorie.SelectedItem.ToString() == "pla")
            {
                rtbImage.Text += "images/plantes/";
                rtbImage.Enabled = true;
            }
        }

        private void comboType()
        {
            txbId.ResetText();
            string type = cmbType.SelectedItem.ToString();
            sql.Initialize();
            MySqlCommand cmdAffich = sql.GetConnection().CreateCommand();
            MySqlDataReader Reader;
            sql.OpenConnection();
            cmdAffich.CommandText = "Select max(id) as id from produit where id like '" + type + "%' ";
            Reader = cmdAffich.ExecuteReader();
            Reader.Read();
            string id = Reader["id"].ToString();
            int test = Convert.ToInt32(id.Substring(1)) + 1;
            if (test < 10)
            {
                string final = "0" + test;
                txbId.Text = type + final;
            }
            else
            {
                txbId.Text = type + test;
            }
        }

        #endregion

        #region Combobox
        private void cmbCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboCategorie();
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboType();
        }  
        #endregion
    }
}