﻿using System;
using System.Windows.Forms;
using static APSwissVisite.SQL;

namespace APSwissVisite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FetchFamilles();
            FetchMedicaments();
            FetchDecisions();
        }

        private void button1_Click(object sender, EventArgs e) => new FormSaisieDecisionEtape().Show();
    }
}
