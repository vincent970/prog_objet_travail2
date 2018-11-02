namespace jeu
{
    partial class Form1
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
            this.labelJ1 = new System.Windows.Forms.Label();
            this.labelPtsJ2 = new System.Windows.Forms.Label();
            this.labelJ2 = new System.Windows.Forms.Label();
            this.labelPtsJ1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTour = new System.Windows.Forms.Label();
            this.btnPoints = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelValeur = new System.Windows.Forms.Label();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.lstObjets = new System.Windows.Forms.ListBox();
            this.btnAfficherObjets = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelJ1
            // 
            this.labelJ1.AutoSize = true;
            this.labelJ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJ1.Location = new System.Drawing.Point(60, 40);
            this.labelJ1.Name = "labelJ1";
            this.labelJ1.Size = new System.Drawing.Size(52, 17);
            this.labelJ1.TabIndex = 0;
            this.labelJ1.Text = "label1";
            this.labelJ1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPtsJ2
            // 
            this.labelPtsJ2.AutoSize = true;
            this.labelPtsJ2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPtsJ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPtsJ2.Location = new System.Drawing.Point(448, 40);
            this.labelPtsJ2.Name = "labelPtsJ2";
            this.labelPtsJ2.Size = new System.Drawing.Size(19, 19);
            this.labelPtsJ2.TabIndex = 1;
            this.labelPtsJ2.Text = "0";
            // 
            // labelJ2
            // 
            this.labelJ2.AutoSize = true;
            this.labelJ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJ2.Location = new System.Drawing.Point(383, 40);
            this.labelJ2.Name = "labelJ2";
            this.labelJ2.Size = new System.Drawing.Size(52, 17);
            this.labelJ2.TabIndex = 2;
            this.labelJ2.Text = "label3";
            this.labelJ2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPtsJ1
            // 
            this.labelPtsJ1.AutoSize = true;
            this.labelPtsJ1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPtsJ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPtsJ1.Location = new System.Drawing.Point(127, 40);
            this.labelPtsJ1.Name = "labelPtsJ1";
            this.labelPtsJ1.Size = new System.Drawing.Size(19, 19);
            this.labelPtsJ1.TabIndex = 3;
            this.labelPtsJ1.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tour de:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTour
            // 
            this.labelTour.AutoSize = true;
            this.labelTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTour.Location = new System.Drawing.Point(291, 9);
            this.labelTour.Name = "labelTour";
            this.labelTour.Size = new System.Drawing.Size(35, 17);
            this.labelTour.TabIndex = 5;
            this.labelTour.Text = "nom";
            this.labelTour.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPoints
            // 
            this.btnPoints.Location = new System.Drawing.Point(216, 40);
            this.btnPoints.Name = "btnPoints";
            this.btnPoints.Size = new System.Drawing.Size(121, 23);
            this.btnPoints.TabIndex = 6;
            this.btnPoints.Text = "Obtenir un objet";
            this.btnPoints.UseVisualStyleBackColor = true;
            this.btnPoints.Click += new System.EventHandler(this.btnPoints_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Type objet:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valeur points:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(319, 90);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(35, 17);
            this.labelType.TabIndex = 9;
            this.labelType.Text = "type";
            this.labelType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelValeur
            // 
            this.labelValeur.AutoSize = true;
            this.labelValeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValeur.Location = new System.Drawing.Point(319, 122);
            this.labelValeur.Name = "labelValeur";
            this.labelValeur.Size = new System.Drawing.Size(47, 17);
            this.labelValeur.TabIndex = 10;
            this.labelValeur.Text = "valeur";
            this.labelValeur.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(216, 167);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(121, 23);
            this.btnSuivant.TabIndex = 11;
            this.btnSuivant.Text = "Joueur suivant";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // lstObjets
            // 
            this.lstObjets.FormattingEnabled = true;
            this.lstObjets.Location = new System.Drawing.Point(127, 225);
            this.lstObjets.Name = "lstObjets";
            this.lstObjets.Size = new System.Drawing.Size(308, 108);
            this.lstObjets.TabIndex = 12;
            // 
            // btnAfficherObjets
            // 
            this.btnAfficherObjets.Location = new System.Drawing.Point(206, 196);
            this.btnAfficherObjets.Name = "btnAfficherObjets";
            this.btnAfficherObjets.Size = new System.Drawing.Size(148, 23);
            this.btnAfficherObjets.TabIndex = 13;
            this.btnAfficherObjets.Text = "Afficher les objets obtenus";
            this.btnAfficherObjets.UseVisualStyleBackColor = true;
            this.btnAfficherObjets.Click += new System.EventHandler(this.btnAfficherObjets_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 341);
            this.Controls.Add(this.btnAfficherObjets);
            this.Controls.Add(this.lstObjets);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.labelValeur);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPoints);
            this.Controls.Add(this.labelTour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPtsJ1);
            this.Controls.Add(this.labelJ2);
            this.Controls.Add(this.labelPtsJ2);
            this.Controls.Add(this.labelJ1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelJ1;
        private System.Windows.Forms.Label labelPtsJ2;
        private System.Windows.Forms.Label labelJ2;
        private System.Windows.Forms.Label labelPtsJ1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTour;
        private System.Windows.Forms.Button btnPoints;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelValeur;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.ListBox lstObjets;
        private System.Windows.Forms.Button btnAfficherObjets;
    }
}

