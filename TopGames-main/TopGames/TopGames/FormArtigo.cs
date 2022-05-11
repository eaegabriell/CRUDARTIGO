﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TopGames.Classes;

namespace TopGames
{
    public partial class FormArtigo : Form
    {
        private object txtNome;

        public string nome { get; private set; }

        public FormArtigo()
        {
            InitializeComponent();
        }

        private void FormArtigo_Load(object sender, EventArgs e)
        {
            ClassArtigo cli = new ClassArtigo();
            List<ClassCliente> artigo = cli.listaartigo();
            dgvartigo.DataSource = artigo;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvartigo.Rows[e.RowIndex];
                    txtnome.Text = row.Cells[0].Value.ToString();
                    txtcategoria.Text = row.Cells[1].Value.ToString();
                    txttamanho.Text = row.Cells[2].Value.ToString();
                    txtempresa.Text = row.Cells[3].Value.ToString();
                    txtvalor.Text = row.Cells[4].Value.ToString();

                }

        }

        private void btnlocalizar_Click(object sender, EventArgs e)
        {
            ClassArtigo artigo = new ClassArtigo();
            artigo.Procurar(nome);
            //txtNome.Text = "";
            txttamanho.Text = artigo.tamanho;
            txttamanho.Text = artigo.tamanho;
            txtempresa.Text = artigo.empresa;
            txtvalor.Text = artigo.valor;

        }

        private async void btncadastrar_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                ClassArtigo artigo = new ClassArtigo();
                await artigo.Inserir(txtnome.Text, txtcategoria.Text, txttamanho.Text, txtempresa.Text, txtvalor.Text);
                MessageBox.Show("Artigo cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<ClassArtigo> cli = artigo.listaartigo();
                dgvartigo.DataSource = cli;
                txtnome.Text = "";
                txtcategoria.Text = "";
                txttamanho.Text = "";
                txtempresa.Text = "";
                txtvalor.Text = "";

                DBContext.FecharConexao();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

        }

        private void btnatualizar_Click(object sender, EventArgs e)
        {



        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
