namespace AdminFleur
{
    partial class Produits
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInfoProduits = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txbId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrix = new System.Windows.Forms.Label();
            this.txbPrix = new System.Windows.Forms.TextBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.rtbImage = new System.Windows.Forms.RichTextBox();
            this.lblIdCategorie = new System.Windows.Forms.Label();
            this.cmbCategorie = new System.Windows.Forms.ComboBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMoins = new System.Windows.Forms.Button();
            this.openImage = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblInfoProduits
            // 
            this.lblInfoProduits.AutoSize = true;
            this.lblInfoProduits.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoProduits.Location = new System.Drawing.Point(127, 18);
            this.lblInfoProduits.Name = "lblInfoProduits";
            this.lblInfoProduits.Size = new System.Drawing.Size(205, 16);
            this.lblInfoProduits.TabIndex = 0;
            this.lblInfoProduits.Text = "Ajouter un nouveau produit : ";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "c",
            "f",
            "p"});
            this.cmbType.Location = new System.Drawing.Point(23, 69);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(57, 21);
            this.cmbType.TabIndex = 1;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(31, 53);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(37, 13);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type :";
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(109, 70);
            this.txbId.Name = "txbId";
            this.txbId.ReadOnly = true;
            this.txbId.Size = new System.Drawing.Size(53, 20);
            this.txbId.TabIndex = 3;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(116, 54);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(25, 13);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "Id : ";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(23, 123);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(248, 79);
            this.rtbDescription.TabIndex = 5;
            this.rtbDescription.Text = "";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(31, 107);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(69, 13);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description : ";
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(31, 216);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(30, 13);
            this.lblPrix.TabIndex = 7;
            this.lblPrix.Text = "Prix :";
            // 
            // txbPrix
            // 
            this.txbPrix.Location = new System.Drawing.Point(23, 232);
            this.txbPrix.Name = "txbPrix";
            this.txbPrix.Size = new System.Drawing.Size(100, 20);
            this.txbPrix.TabIndex = 8;
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(240, 216);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(42, 13);
            this.lblImage.TabIndex = 9;
            this.lblImage.Text = "Image :";
            // 
            // rtbImage
            // 
            this.rtbImage.Location = new System.Drawing.Point(221, 232);
            this.rtbImage.Name = "rtbImage";
            this.rtbImage.ReadOnly = true;
            this.rtbImage.Size = new System.Drawing.Size(207, 63);
            this.rtbImage.TabIndex = 10;
            this.rtbImage.Text = "";
            // 
            // lblIdCategorie
            // 
            this.lblIdCategorie.AutoSize = true;
            this.lblIdCategorie.Location = new System.Drawing.Point(31, 264);
            this.lblIdCategorie.Name = "lblIdCategorie";
            this.lblIdCategorie.Size = new System.Drawing.Size(61, 13);
            this.lblIdCategorie.TabIndex = 11;
            this.lblIdCategorie.Text = "Categorie : ";
            // 
            // cmbCategorie
            // 
            this.cmbCategorie.FormattingEnabled = true;
            this.cmbCategorie.Items.AddRange(new object[] {
            "com",
            "fle",
            "pla"});
            this.cmbCategorie.Location = new System.Drawing.Point(23, 286);
            this.cmbCategorie.Name = "cmbCategorie";
            this.cmbCategorie.Size = new System.Drawing.Size(69, 21);
            this.cmbCategorie.TabIndex = 12;
            this.cmbCategorie.SelectedIndexChanged += new System.EventHandler(this.cmbCategorie_SelectedIndexChanged);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(187, 306);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(105, 48);
            this.btnAjouter.TabIndex = 13;
            this.btnAjouter.Text = "Ajouter dans la base";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(429, 237);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(26, 21);
            this.btnPlus.TabIndex = 14;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMoins
            // 
            this.btnMoins.Location = new System.Drawing.Point(429, 264);
            this.btnMoins.Name = "btnMoins";
            this.btnMoins.Size = new System.Drawing.Size(26, 21);
            this.btnMoins.TabIndex = 15;
            this.btnMoins.Text = "-";
            this.btnMoins.UseVisualStyleBackColor = true;
            this.btnMoins.Click += new System.EventHandler(this.btnMoins_Click);
            // 
            // openImage
            // 
            this.openImage.FileName = "openImage";
            // 
            // Produits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 366);
            this.Controls.Add(this.btnMoins);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.cmbCategorie);
            this.Controls.Add(this.lblIdCategorie);
            this.Controls.Add(this.rtbImage);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.txbPrix);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblInfoProduits);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Produits";
            this.Text = "Produits";
            this.Load += new System.EventHandler(this.Produits_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfoProduits;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.TextBox txbPrix;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.RichTextBox rtbImage;
        private System.Windows.Forms.Label lblIdCategorie;
        private System.Windows.Forms.ComboBox cmbCategorie;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMoins;
        private System.Windows.Forms.OpenFileDialog openImage;
    }
}