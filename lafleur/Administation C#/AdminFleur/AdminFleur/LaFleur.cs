using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConnexionDll;
using MySql.Data.MySqlClient;

namespace AdminFleur
{
    public partial class LaFleur : Form
    {
        public LaFleur()
        {
            InitializeComponent();
        }

        #region Load
        private void LaFleur_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            sql.Initialize();
            MySqlCommand cmdAffich = sql.GetConnection().CreateCommand();
            MySqlDataReader Reader;
            sql.OpenConnection();
            cmdAffich.CommandText = "Select distinct nomPrenomClient from Commande";
            Reader = cmdAffich.ExecuteReader();
            while (Reader.Read())
            {
                cmbClients.Items.Add(Reader["nomPrenomClient"].ToString());
            }

        }
        #endregion

        #region Declarations
        ConnexionSql sql = new ConnexionSql();
        #endregion

        #region TextBox
        private void txbMdp_Click(object sender, EventArgs e)
        {
            if (txbMdp.Text == "*******")
            {
                txbMdp.ResetText();
            }
            if (txbLogin.Text == "")
            {
                txbLogin.Text = "Identifiant";
            }
        }

        private void txbLogin_Click(object sender, EventArgs e)
        {
            if (txbLogin.Text == "Identifiant")
            {
                txbLogin.ResetText();
            }
        }
        #endregion

        #region ComboBox et ListBox

        private void cmbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboClients();
        }

        private void lbCommandes_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxCommandes();
        }

        #endregion

        #region Boutons
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            Connexion();
        }

        private void Connexion()
        {
            sql.Initialize();
            MySqlCommand cmdAffich = sql.GetConnection().CreateCommand();
            MySqlDataReader Reader;
            sql.OpenConnection();
            cmdAffich.CommandText = "Select nom, mdp from administrateur";
            Reader = cmdAffich.ExecuteReader();
            while (Reader.Read())
            {
                if ((txbLogin.Text == Reader["nom"].ToString()) && (txbMdp.Text == Reader["mdp"].ToString()))
                {
                    tabControl.Visible = true;
                    lblConnexion.Visible = false;
                    txbLogin.Visible = false;
                    txbMdp.Visible = false;
                    btnDeconnexion.Visible = true;
                    btnConnexion.Visible = false;
                    lblAccueilAdmin.Text = txbLogin.Text;
                    MessageBox.Show("Vous êtes connectés !");
                    txbLogin.Text = "Identifiant";
                    txbMdp.Text = "*******";
                }
                else
                {
                    MessageBox.Show("Identifiant ou Mot de Passe erronées");
                    txbLogin.Text = "Identifiant";
                    txbMdp.Text = "*******";
                }
            }
        }
        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            tabControl.Visible = false;
            lblConnexion.Visible = true;
            txbLogin.Visible = true;
            txbMdp.Visible = true;
            btnConnexion.Visible = true;
        }

        private void btnChargerProduits_Click(object sender, EventArgs e)
        {
            chargerProduits();
        }

        private void btnChargerClients_Click(object sender, EventArgs e)
        {
            chargerClients();
        }

        private void btnAjouterProduit_Click_1(object sender, EventArgs e)
        {
            Form produit = new Produits();
            produit.ShowDialog();
        }

        private void btnSupprimerProduit_Click(object sender, EventArgs e)
        {
            SupprimerProduit();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvProduits.Rows.Clear();
            chargerProduits();
        }

        #endregion

        #region Fonctions

        /// <summary>
        /// La méthode chargerProduits permet de charger les produits à partir de la base de donnée.
        /// Elle liste ensuite chaque produit dans un DataGridView.
        /// </summary>
        private void chargerProduits()
        {
                dgvProduits.Rows.Clear();
                sql.Initialize();
                MySqlCommand cmdAffich = sql.GetConnection().CreateCommand();
                MySqlDataReader Reader;
                sql.OpenConnection();
                cmdAffich.CommandText = "Select * from produit";
                Reader = cmdAffich.ExecuteReader();
                DataGridViewRow row = new DataGridViewRow();
                while (Reader.Read())
                {
                    dgvProduits.ColumnCount = 5;
                    dgvProduits.Columns[0].Name = "id";
                    dgvProduits.Columns[1].Name = "description";
                    dgvProduits.Columns[2].Name = "prix";
                    dgvProduits.Columns[3].Name = "image";
                    dgvProduits.Columns[4].Name = "idCat";

                    string[] rows = new string[] { Reader["id"].ToString(), Reader["description"].ToString(), Reader["prix"].ToString(), Reader["image"].ToString(), Reader["idCategorie"].ToString() };
                    dgvProduits.Rows.Add(rows);
                }
                btnChargerProduits.Enabled = false;
        }

        /// <summary>
        /// La méthode chargerClients permet de charger tout les clients enregistrés sur le site LA FLEUR à partir de la base de donnée.
        /// Elle liste ensuite chaque client dans un DataGridView
        /// </summary>
        private void chargerClients()
        {
            if (dgvClients.Rows.Count == 0)
            {
                sql.Initialize();
                MySqlCommand cmdAffich = sql.GetConnection().CreateCommand();
                MySqlDataReader Reader;
                sql.OpenConnection();
                cmdAffich.CommandText = "Select * from Client";
                Reader = cmdAffich.ExecuteReader();
                DataGridViewRow row = new DataGridViewRow();
                while (Reader.Read())
                {
                    dgvClients.ColumnCount = 7;
                    dgvClients.Columns[0].Name = "id";
                    dgvClients.Columns[1].Name = "nom";
                    dgvClients.Columns[2].Name = "prenom";
                    dgvClients.Columns[3].Name = "adresse";
                    dgvClients.Columns[4].Name = "phone";
                    dgvClients.Columns[5].Name = "mail";
                    dgvClients.Columns[6].Name = "Activé";

                    string[] rows = new string[] { Reader["id"].ToString(), Reader["nom"].ToString(), Reader["prenom"].ToString(), Reader["adresse"].ToString(), Reader["phone"].ToString(), Reader["email"].ToString(), Reader["active"].ToString() };
                    dgvClients.Rows.Add(rows);
                }
            }
        }
        /// <summary>
        /// La méthode comboClients permet de remplir la listBox avec les numeros de commande en fonction du Client choisi dans la ComboBox.
        /// </summary>
        private void comboClients()
        {
            string client = cmbClients.SelectedItem.ToString();
            if (client != "")
            {
                lbCommandes.Items.Clear();
                sql.Initialize();
                MySqlCommand cmdAffich = sql.GetConnection().CreateCommand();
                MySqlDataReader Reader;
                sql.OpenConnection();
                cmdAffich.CommandText = "Select id from commande where nomPrenomClient='" + client + "'";
                Reader = cmdAffich.ExecuteReader();
                while (Reader.Read())
                {
                    lbCommandes.Items.Add(Reader["id"].ToString());
                }
            }
        }
        /// <summary>
        /// La méthode listBoxCommandes permet de lister L'Id Produit, la quantité et le prix ttc des produits d'une commande choisie.
        /// </summary>
        private void listBoxCommandes()
        {
            dgvCommandeProduits.Rows.Clear();
            if (lbCommandes.SelectedIndex != -1)
            {
                string commande = lbCommandes.SelectedItem.ToString();

                sql.Initialize();
                MySqlCommand cmdAffich = sql.GetConnection().CreateCommand();
                MySqlDataReader Reader;
                sql.OpenConnection();
                cmdAffich.CommandText = "SELECT C.idProduit as id, C.quantite as quantite, P.prix as prix " +
                                        "FROM contenir C, produit P " +
                                        "WHERE C.idProduit = P.id and C.idCommande='" + commande + "'";
                Reader = cmdAffich.ExecuteReader();
                while (Reader.Read())
                {
                    dgvCommandeProduits.ColumnCount = 3;
                    dgvCommandeProduits.Columns[0].Name = "Id Produit";
                    dgvCommandeProduits.Columns[1].Name = "Quantité";
                    dgvCommandeProduits.Columns[2].Name = "Prix TTC";

                    string[] rows = new string[] { Reader["id"].ToString(), Reader["quantite"].ToString(), Reader["prix"].ToString() };
                    dgvCommandeProduits.Rows.Add(rows);
                }
            }
        }

        /// <summary>
        /// La méthode SupprimerProduit permet de supprimer un produit de la base de donnée en fonction du produit choisi par l'administrateur.
        /// </summary>
        private void SupprimerProduit()
        {
            string ligne = dgvProduits.CurrentCell.Value.ToString();
            sql.Initialize();
            MySqlCommand cmdSuppr = sql.GetConnection().CreateCommand();
            sql.OpenConnection();
            cmdSuppr.CommandText = "DELETE from produit where id = '" + ligne + "'";
            if (MessageBox.Show("Voulez vous vraiment supprimer?", "Important Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int res = cmdSuppr.ExecuteNonQuery();
                if (res != -1)
                {
                    MessageBox.Show("Suppression reussi");
                    dgvProduits.Rows.RemoveAt(dgvProduits.CurrentCell.RowIndex);
                }
            }
        }

        #endregion
    }
}
