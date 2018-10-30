﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jeu
{
    public partial class Form1 : Form
    {
        Controleur jeu = new Controleur();

        public Form1()
        {
            InitializeComponent();
            afficherJoueurs();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSuivant.Enabled = false;
        }

        private void btnPoints_Click(object sender, EventArgs e)
        {
            jouerUnTour();
        }

        void InverserBoutons()
        {
            btnSuivant.Enabled = !btnSuivant.Enabled;
            btnPoints.Enabled = !btnPoints.Enabled;
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            InverserBoutons();
            jeu.prochainJoueur();
            labelTour.Text = jeu.JoueurCourant.Nom;
        }

        private void attribuerPointsAuJoueurCourant()
        {

        }

        private void jouerUnTour()
        {
            InverserBoutons();
            jeu.genererUnObjet();
            jeu.ajouterPointsAuJoueurCourant();
            afficherInformationsObjet();
            afficherPointsJoueurs();
            
        }

        private void afficherPointsJoueurs()
        {
            labelPtsJ1.Text = jeu.lesJoueurs[0].PointsCumulatifs.ToString();
            labelPtsJ2.Text = jeu.lesJoueurs[1].PointsCumulatifs.ToString();

        }

        private void afficherInformationsObjet()
        {
            labelValeur.Text = jeu.objetCourant.Points.ToString();            
            labelType.Text = jeu.nomTypeObjet[1];
            
        }

        private void afficherJoueurs()
        {
            labelJ1.Text = jeu.ObtenirJoueur(1).Nom;
            labelJ2.Text = jeu.ObtenirJoueur(2).Nom;
            labelTour.Text = jeu.JoueurCourant.Nom;
        }

    }
}
