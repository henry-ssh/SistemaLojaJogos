﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LojaRoupas.obj
{
    public partial class BackupTela : Form
    {
        public BackupTela()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Backup2.Backup(), "Informação",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdArquivo = new OpenFileDialog();
            ofdArquivo.Filter = "ARQUIVO DE BACKUP|*.bak";
            ofdArquivo.ShowDialog();
            MessageBox.Show(Backup2.restore(ofdArquivo.FileName), "Informação",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BackupTela_Load(object sender, EventArgs e)
        {

        }
    }
}
