﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopGames.Classes
{
    class ClassArtigo
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string categoria { get; set; }
        public string tamanho { get; set; }
        public string empresa { get; set; }
        public string valor { get; set; }
        public List<ClassCliente> listaartigo()
        {
            List<ClassCliente> li = new List<ClassCliente>();
            SqlConnection con = DBContext.ObterConexao();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM cliente";
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ClassCliente c = new ClassCliente();
                c.Id = (int)dr["Id"];
                c.nome = dr["nome"].ToString();
                c.categoria = dr["categoria"].ToString();
                c.tamanho = dr["tamanho"].ToString();
                c.empresa = dr["empresa"].ToString();
                c.valor = dr["valor"].ToString();
                li.Add(c);
            }
            return li;
        }

        public async Task<bool> Inserir(string nome, string categoria, string tamanho, string empresa, string valor)
        {
            SqlConnection con = DBContext.ObterConexao();
            SqlCommand cmd = con.CreateCommand();
            var busca = await BuscarPornome(nome);
            if (busca)
            {
                cmd.CommandText = "INSERT INTO artigo(nome,categoria,tamanho,empresa,valor) VALUES ('" + nome + "','" + categoria + "','" + tamanho + "','" + empresa + "','" + valor + "')";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DBContext.FecharConexao();
                return true;
            }
            else
            {
                DBContext.FecharConexao();
                return false;
            }

        }

        public void Procurar(string nome)
        {
            SqlConnection con = DBContext.ObterConexao();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM artigo WHERE nome='" + nome + "'";
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nome = dr["nome"].ToString();
                categoria = dr["categoria"].ToString();
                tamanho = dr["tamanho"].ToString();
                empresa = dr["empresa"].ToString();
                valor = dr["valor"].ToString();


            }
        }

        public async Task<bool> BuscarPornome(string nome)
        {
            SqlConnection con = DBContext.ObterConexao();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM artigo WHERE nome='" + nome + "'";
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Já existe um artigo cadastrado com esse nome", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Exclui(string nome)
        {
            SqlConnection con = DBContext.ObterConexao();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "DELETE FROM artigo WHERE nome='" + nome + "'";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            DBContext.FecharConexao();
        }

        public void Atualizar(string nome, string categoria, string tamanho, string empresa, string valor)
        {
            SqlConnection con = DBContext.ObterConexao();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "UPDATE artigo SET nome='" + nome + "',categoria='" + categoria + "',tamanho='" + tamanho + "',empresa='" + empresa + "',valor='" + valor + "' WHERE nome = '" + FormLogin.usuarioconectado + "'";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            DBContext.FecharConexao();
        }
    }
}
