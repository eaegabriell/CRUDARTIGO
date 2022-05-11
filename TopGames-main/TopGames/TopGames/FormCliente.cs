using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TopGames.Classes;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;

namespace TopGames
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            ClassCliente cli = new ClassCliente();
            List<ClassCliente> clientes = cli.listacliente();
            dgvCliente.DataSource = clientes;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtCpf.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
            this.dtpNascimento.Value = DateTime.Now.Date;
        }

        private async void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                ClassCliente cliente = new ClassCliente();
                await cliente.Inserir(txtNome.Text, txtCpf.Text, txtTelefone.Text, txtEmail.Text, txtCpf.Text, dtpNascimento.Value);
                MessageBox.Show("Cliente cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<ClassCliente> cli = cliente.listacliente();
                dgvCliente.DataSource = cli;
                txtNome.Text = "";
                txtCpf.Text = "";
                txtTelefone.Text = "";
                txtEmail.Text = "";
                this.dtpNascimento.Value = DateTime.Now.Date;
                DBContext.FecharConexao();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                string cpf = txtCpf.Text.Trim();
                ClassCliente cliente = new ClassCliente();
                cliente.Exclui(cpf);
                MessageBox.Show("Cliente excluído com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<ClassCliente> cli = cliente.listacliente();
                dgvCliente.DataSource = cli;
                txtCpf.Text = "";
                txtNome.Text = "";
                txtTelefone.Text = "";
                txtEmail.Text = "";
                this.dtpNascimento.Value = DateTime.Now.Date;
                DBContext.FecharConexao();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string Cpf = txtCpf.Text.Trim();
            ClassCliente cliente = new ClassCliente();
            cliente.Atualizar(txtNome.Text, Cpf, txtTelefone.Text, txtEmail.Text, Cpf, dtpNascimento.Value);
            MessageBox.Show("Cliente atualizado com sucesso!");
            List<ClassCliente> clientes = cliente.listacliente();
            dgvCliente.DataSource = clientes;
            txtCpf.Text = "";
            txtNome.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
            this.dtpNascimento.Value = DateTime.Now.Date;
        }

        private void FormCliente_Load_1(object sender, EventArgs e)
        {
            ClassCliente cliente = new ClassCliente();
            List<ClassCliente> clientes = cliente.listacliente();
            dgvCliente.DataSource = clientes;
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            string cpf = txtCpf.Text.Trim();
            ClassCliente cliente = new ClassCliente();
            cliente.Procurar(cpf);
            txtNome.Text = cliente.nome;
            //txtNome.Text = "";
            txtTelefone.Text = cliente.tamanho;
            txtEmail.Text = cliente.empresa;
            this.dtpNascimento.Value = cliente.data_nascimento;
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvCliente.Rows[e.RowIndex]; 
                txtCpf.Text = row.Cells[0].Value.ToString(); 
                txtNome.Text = row.Cells[1].Value.ToString();
                txtTelefone.Text = row.Cells[2].Value.ToString();
                txtEmail.Text = row.Cells[3].Value.ToString();
                dtpNascimento.Text = row.Cells[4].ToString();
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {

        }
    }
}