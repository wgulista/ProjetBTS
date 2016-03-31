namespace AdminFleur
{
    partial class LaFleur
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaFleur));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabAccueil = new System.Windows.Forms.TabPage();
            this.lblAccueil3 = new System.Windows.Forms.Label();
            this.lblAccueilAdmin = new System.Windows.Forms.Label();
            this.lblAccueil2 = new System.Windows.Forms.Label();
            this.lblAccueil1 = new System.Windows.Forms.Label();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.tabProduits = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSupprimerProduit = new System.Windows.Forms.Button();
            this.btnAjouterProduit = new System.Windows.Forms.Button();
            this.btnChargerProduits = new System.Windows.Forms.Button();
            this.dgvProduits = new System.Windows.Forms.DataGridView();
            this.tabClients = new System.Windows.Forms.TabPage();
            this.btnChargerClients = new System.Windows.Forms.Button();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.tabCommande = new System.Windows.Forms.TabPage();
            this.dgvCommandeProduits = new System.Windows.Forms.DataGridView();
            this.lbCommandes = new System.Windows.Forms.ListBox();
            this.cmbClients = new System.Windows.Forms.ComboBox();
            this.lblNomClient = new System.Windows.Forms.Label();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblDroits = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.txbMdp = new System.Windows.Forms.TextBox();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.lblConnexion = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabAccueil.SuspendLayout();
            this.tabProduits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduits)).BeginInit();
            this.tabClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.tabCommande.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommandeProduits)).BeginInit();
            this.tabInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabAccueil);
            this.tabControl.Controls.Add(this.tabProduits);
            this.tabControl.Controls.Add(this.tabClients);
            this.tabControl.Controls.Add(this.tabCommande);
            this.tabControl.Controls.Add(this.tabInfo);
            this.tabControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(598, 344);
            this.tabControl.TabIndex = 0;
            this.tabControl.Visible = false;
            // 
            // tabAccueil
            // 
            this.tabAccueil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabAccueil.BackgroundImage")));
            this.tabAccueil.Controls.Add(this.lblAccueil3);
            this.tabAccueil.Controls.Add(this.lblAccueilAdmin);
            this.tabAccueil.Controls.Add(this.lblAccueil2);
            this.tabAccueil.Controls.Add(this.lblAccueil1);
            this.tabAccueil.Controls.Add(this.btnDeconnexion);
            this.tabAccueil.Location = new System.Drawing.Point(4, 27);
            this.tabAccueil.Name = "tabAccueil";
            this.tabAccueil.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccueil.Size = new System.Drawing.Size(590, 313);
            this.tabAccueil.TabIndex = 0;
            this.tabAccueil.Text = "Accueil";
            this.tabAccueil.UseVisualStyleBackColor = true;
            // 
            // lblAccueil3
            // 
            this.lblAccueil3.AutoSize = true;
            this.lblAccueil3.Location = new System.Drawing.Point(213, 179);
            this.lblAccueil3.Name = "lblAccueil3";
            this.lblAccueil3.Size = new System.Drawing.Size(165, 18);
            this.lblAccueil3.TabIndex = 13;
            this.lblAccueil3.Text = "Bonne Navigation !";
            // 
            // lblAccueilAdmin
            // 
            this.lblAccueilAdmin.AutoSize = true;
            this.lblAccueilAdmin.Location = new System.Drawing.Point(313, 70);
            this.lblAccueilAdmin.Name = "lblAccueilAdmin";
            this.lblAccueilAdmin.Size = new System.Drawing.Size(0, 18);
            this.lblAccueilAdmin.TabIndex = 12;
            // 
            // lblAccueil2
            // 
            this.lblAccueil2.AutoSize = true;
            this.lblAccueil2.Location = new System.Drawing.Point(8, 70);
            this.lblAccueil2.Name = "lblAccueil2";
            this.lblAccueil2.Size = new System.Drawing.Size(299, 18);
            this.lblAccueil2.TabIndex = 11;
            this.lblAccueil2.Text = "Vous êtes connectés en tant que : ";
            // 
            // lblAccueil1
            // 
            this.lblAccueil1.AutoSize = true;
            this.lblAccueil1.Location = new System.Drawing.Point(115, 24);
            this.lblAccueil1.Name = "lblAccueil1";
            this.lblAccueil1.Size = new System.Drawing.Size(361, 18);
            this.lblAccueil1.TabIndex = 10;
            this.lblAccueil1.Text = "Bienvenue dans la partie Admin de LaFleur";
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDeconnexion.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconnexion.Location = new System.Drawing.Point(3, 279);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(584, 31);
            this.btnDeconnexion.TabIndex = 9;
            this.btnDeconnexion.Text = "Deconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            this.btnDeconnexion.Visible = false;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // tabProduits
            // 
            this.tabProduits.BackColor = System.Drawing.Color.Transparent;
            this.tabProduits.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabProduits.BackgroundImage")));
            this.tabProduits.Controls.Add(this.btnRefresh);
            this.tabProduits.Controls.Add(this.btnSupprimerProduit);
            this.tabProduits.Controls.Add(this.btnAjouterProduit);
            this.tabProduits.Controls.Add(this.btnChargerProduits);
            this.tabProduits.Controls.Add(this.dgvProduits);
            this.tabProduits.Location = new System.Drawing.Point(4, 27);
            this.tabProduits.Name = "tabProduits";
            this.tabProduits.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduits.Size = new System.Drawing.Size(590, 313);
            this.tabProduits.TabIndex = 1;
            this.tabProduits.Text = "Produits";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(561, 42);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(23, 25);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "R";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSupprimerProduit
            // 
            this.btnSupprimerProduit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerProduit.Location = new System.Drawing.Point(3, 42);
            this.btnSupprimerProduit.Name = "btnSupprimerProduit";
            this.btnSupprimerProduit.Size = new System.Drawing.Size(23, 25);
            this.btnSupprimerProduit.TabIndex = 11;
            this.btnSupprimerProduit.Text = "X";
            this.btnSupprimerProduit.UseVisualStyleBackColor = true;
            this.btnSupprimerProduit.Click += new System.EventHandler(this.btnSupprimerProduit_Click);
            // 
            // btnAjouterProduit
            // 
            this.btnAjouterProduit.Location = new System.Drawing.Point(223, 267);
            this.btnAjouterProduit.Name = "btnAjouterProduit";
            this.btnAjouterProduit.Size = new System.Drawing.Size(145, 46);
            this.btnAjouterProduit.TabIndex = 10;
            this.btnAjouterProduit.Text = "Ajouter un Produit";
            this.btnAjouterProduit.UseVisualStyleBackColor = true;
            this.btnAjouterProduit.Click += new System.EventHandler(this.btnAjouterProduit_Click_1);
            // 
            // btnChargerProduits
            // 
            this.btnChargerProduits.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChargerProduits.Location = new System.Drawing.Point(255, 6);
            this.btnChargerProduits.Name = "btnChargerProduits";
            this.btnChargerProduits.Size = new System.Drawing.Size(80, 30);
            this.btnChargerProduits.TabIndex = 1;
            this.btnChargerProduits.Text = "Charger";
            this.btnChargerProduits.UseVisualStyleBackColor = true;
            this.btnChargerProduits.Click += new System.EventHandler(this.btnChargerProduits_Click);
            // 
            // dgvProduits
            // 
            this.dgvProduits.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(93)))), ((int)(((byte)(130)))));
            this.dgvProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduits.GridColor = System.Drawing.Color.Silver;
            this.dgvProduits.Location = new System.Drawing.Point(2, 67);
            this.dgvProduits.Name = "dgvProduits";
            this.dgvProduits.ReadOnly = true;
            this.dgvProduits.Size = new System.Drawing.Size(586, 198);
            this.dgvProduits.TabIndex = 0;
            // 
            // tabClients
            // 
            this.tabClients.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabClients.BackgroundImage")));
            this.tabClients.Controls.Add(this.btnChargerClients);
            this.tabClients.Controls.Add(this.dgvClients);
            this.tabClients.Location = new System.Drawing.Point(4, 27);
            this.tabClients.Name = "tabClients";
            this.tabClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabClients.Size = new System.Drawing.Size(590, 313);
            this.tabClients.TabIndex = 2;
            this.tabClients.Text = "Clients";
            this.tabClients.UseVisualStyleBackColor = true;
            // 
            // btnChargerClients
            // 
            this.btnChargerClients.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChargerClients.Location = new System.Drawing.Point(255, 7);
            this.btnChargerClients.Name = "btnChargerClients";
            this.btnChargerClients.Size = new System.Drawing.Size(80, 30);
            this.btnChargerClients.TabIndex = 2;
            this.btnChargerClients.Text = "Charger";
            this.btnChargerClients.UseVisualStyleBackColor = true;
            this.btnChargerClients.Click += new System.EventHandler(this.btnChargerClients_Click);
            // 
            // dgvClients
            // 
            this.dgvClients.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(93)))), ((int)(((byte)(130)))));
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Location = new System.Drawing.Point(2, 67);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.Size = new System.Drawing.Size(586, 198);
            this.dgvClients.TabIndex = 1;
            // 
            // tabCommande
            // 
            this.tabCommande.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabCommande.BackgroundImage")));
            this.tabCommande.Controls.Add(this.dgvCommandeProduits);
            this.tabCommande.Controls.Add(this.lbCommandes);
            this.tabCommande.Controls.Add(this.cmbClients);
            this.tabCommande.Controls.Add(this.lblNomClient);
            this.tabCommande.Location = new System.Drawing.Point(4, 27);
            this.tabCommande.Name = "tabCommande";
            this.tabCommande.Padding = new System.Windows.Forms.Padding(3);
            this.tabCommande.Size = new System.Drawing.Size(590, 313);
            this.tabCommande.TabIndex = 3;
            this.tabCommande.Text = "Commande";
            this.tabCommande.UseVisualStyleBackColor = true;
            // 
            // dgvCommandeProduits
            // 
            this.dgvCommandeProduits.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(93)))), ((int)(((byte)(130)))));
            this.dgvCommandeProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommandeProduits.Location = new System.Drawing.Point(11, 137);
            this.dgvCommandeProduits.Name = "dgvCommandeProduits";
            this.dgvCommandeProduits.Size = new System.Drawing.Size(569, 153);
            this.dgvCommandeProduits.TabIndex = 3;
            // 
            // lbCommandes
            // 
            this.lbCommandes.FormattingEnabled = true;
            this.lbCommandes.ItemHeight = 18;
            this.lbCommandes.Location = new System.Drawing.Point(178, 73);
            this.lbCommandes.Name = "lbCommandes";
            this.lbCommandes.Size = new System.Drawing.Size(234, 58);
            this.lbCommandes.TabIndex = 2;
            this.lbCommandes.SelectedIndexChanged += new System.EventHandler(this.lbCommandes_SelectedIndexChanged);
            // 
            // cmbClients
            // 
            this.cmbClients.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClients.FormattingEnabled = true;
            this.cmbClients.Location = new System.Drawing.Point(235, 35);
            this.cmbClients.Name = "cmbClients";
            this.cmbClients.Size = new System.Drawing.Size(121, 24);
            this.cmbClients.TabIndex = 1;
            this.cmbClients.SelectedIndexChanged += new System.EventHandler(this.cmbClients_SelectedIndexChanged);
            // 
            // lblNomClient
            // 
            this.lblNomClient.AutoSize = true;
            this.lblNomClient.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomClient.Location = new System.Drawing.Point(160, 14);
            this.lblNomClient.Name = "lblNomClient";
            this.lblNomClient.Size = new System.Drawing.Size(270, 16);
            this.lblNomClient.TabIndex = 0;
            this.lblNomClient.Text = "Les commandes en fonction du client : ";
            // 
            // tabInfo
            // 
            this.tabInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabInfo.BackgroundImage")));
            this.tabInfo.Controls.Add(this.lblCopyright);
            this.tabInfo.Controls.Add(this.lblDroits);
            this.tabInfo.Controls.Add(this.lblInfo);
            this.tabInfo.Controls.Add(this.pictureBox1);
            this.tabInfo.Location = new System.Drawing.Point(4, 27);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfo.Size = new System.Drawing.Size(590, 313);
            this.tabInfo.TabIndex = 4;
            this.tabInfo.Text = "A propos";
            this.tabInfo.UseVisualStyleBackColor = true;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(297, 214);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(276, 18);
            this.lblCopyright.TabIndex = 3;
            this.lblCopyright.Text = "® Copyright 2013 E. Zapotoczny";
            // 
            // lblDroits
            // 
            this.lblDroits.AutoSize = true;
            this.lblDroits.Location = new System.Drawing.Point(333, 91);
            this.lblDroits.Name = "lblDroits";
            this.lblDroits.Size = new System.Drawing.Size(218, 54);
            this.lblDroits.TabIndex = 2;
            this.lblDroits.Text = "Tout Droits Reservés. \r\n\r\nZepenetso Corporation ™";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(354, 35);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(153, 18);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "LA FLEUR 2013 ©";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(19, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 269);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(252, 193);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(120, 31);
            this.btnConnexion.TabIndex = 8;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // txbMdp
            // 
            this.txbMdp.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMdp.Location = new System.Drawing.Point(154, 164);
            this.txbMdp.Name = "txbMdp";
            this.txbMdp.PasswordChar = '*';
            this.txbMdp.Size = new System.Drawing.Size(288, 23);
            this.txbMdp.TabIndex = 7;
            this.txbMdp.Text = "*******";
            this.txbMdp.Click += new System.EventHandler(this.txbMdp_Click);
            // 
            // txbLogin
            // 
            this.txbLogin.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLogin.Location = new System.Drawing.Point(154, 118);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(288, 23);
            this.txbLogin.TabIndex = 6;
            this.txbLogin.Text = "Identifiant";
            this.txbLogin.Click += new System.EventHandler(this.txbLogin_Click);
            // 
            // lblConnexion
            // 
            this.lblConnexion.AutoSize = true;
            this.lblConnexion.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnexion.Location = new System.Drawing.Point(249, 82);
            this.lblConnexion.Name = "lblConnexion";
            this.lblConnexion.Size = new System.Drawing.Size(98, 16);
            this.lblConnexion.TabIndex = 5;
            this.lblConnexion.Text = "Se Connecter";
            // 
            // LaFleur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(596, 342);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lblConnexion);
            this.Controls.Add(this.txbLogin);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.txbMdp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LaFleur";
            this.Text = "LaFleur";
            this.Load += new System.EventHandler(this.LaFleur_Load);
            this.tabControl.ResumeLayout(false);
            this.tabAccueil.ResumeLayout(false);
            this.tabAccueil.PerformLayout();
            this.tabProduits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduits)).EndInit();
            this.tabClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.tabCommande.ResumeLayout(false);
            this.tabCommande.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommandeProduits)).EndInit();
            this.tabInfo.ResumeLayout(false);
            this.tabInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabAccueil;
        private System.Windows.Forms.TabPage tabProduits;
        private System.Windows.Forms.TabPage tabClients;
        private System.Windows.Forms.TabPage tabCommande;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.TextBox txbMdp;
        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.Label lblConnexion;
        private System.Windows.Forms.DataGridView dgvProduits;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Button btnChargerProduits;
        private System.Windows.Forms.Button btnChargerClients;
        private System.Windows.Forms.ComboBox cmbClients;
        private System.Windows.Forms.Label lblNomClient;
        private System.Windows.Forms.Label lblAccueil3;
        private System.Windows.Forms.Label lblAccueilAdmin;
        private System.Windows.Forms.Label lblAccueil2;
        private System.Windows.Forms.Label lblAccueil1;
        private System.Windows.Forms.DataGridView dgvCommandeProduits;
        private System.Windows.Forms.ListBox lbCommandes;
        private System.Windows.Forms.Button btnAjouterProduit;
        private System.Windows.Forms.Button btnSupprimerProduit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblDroits;
        private System.Windows.Forms.Label lblInfo;
    }
}

