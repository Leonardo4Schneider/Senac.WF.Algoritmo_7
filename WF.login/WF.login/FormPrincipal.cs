﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF.login
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja encerrar o programa?", "Titulo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormProdutos().Show();
        }
    }
}
