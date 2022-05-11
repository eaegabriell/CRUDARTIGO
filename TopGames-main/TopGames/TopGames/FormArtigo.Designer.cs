
using System;

namespace TopGames
{
    partial class FormArtigo
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
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.lblvalor = new System.Windows.Forms.Label();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnatualizar = new System.Windows.Forms.Button();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.txtempresa = new System.Windows.Forms.TextBox();
            this.txttamanho = new System.Windows.Forms.TextBox();
            this.txtcategoria = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblempresa = new System.Windows.Forms.Label();
            this.lbltamanho = new System.Windows.Forms.Label();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.dgvartigo = new System.Windows.Forms.DataGridView();
            this.btnlocalizar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvartigo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(12, 229);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(184, 20);
            this.txtvalor.TabIndex = 37;
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Location = new System.Drawing.Point(9, 213);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(31, 13);
            this.lblvalor.TabIndex = 36;
            this.lblvalor.Text = "Valor";
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(286, 385);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 35;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(286, 109);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 34;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnatualizar
            // 
            this.btnatualizar.Location = new System.Drawing.Point(286, 77);
            this.btnatualizar.Name = "btnatualizar";
            this.btnatualizar.Size = new System.Drawing.Size(75, 23);
            this.btnatualizar.TabIndex = 33;
            this.btnatualizar.Text = "Atualizar";
            this.btnatualizar.UseVisualStyleBackColor = true;
            this.btnatualizar.Click += new System.EventHandler(this.btnatualizar_Click);
            // 
            // btncadastrar
            // 
            this.btncadastrar.Location = new System.Drawing.Point(286, 48);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(75, 23);
            this.btncadastrar.TabIndex = 32;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_click);
            // 
            // txtempresa
            // 
            this.txtempresa.Location = new System.Drawing.Point(12, 190);
            this.txtempresa.Name = "txtempresa";
            this.txtempresa.Size = new System.Drawing.Size(184, 20);
            this.txtempresa.TabIndex = 31;
            // 
            // txttamanho
            // 
            this.txttamanho.Location = new System.Drawing.Point(12, 151);
            this.txttamanho.Name = "txttamanho";
            this.txttamanho.Size = new System.Drawing.Size(184, 20);
            this.txttamanho.TabIndex = 30;
            // 
            // txtcategoria
            // 
            this.txtcategoria.Location = new System.Drawing.Point(12, 112);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(184, 20);
            this.txtcategoria.TabIndex = 29;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(12, 70);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(184, 20);
            this.txtnome.TabIndex = 28;
            // 
            // lblempresa
            // 
            this.lblempresa.AutoSize = true;
            this.lblempresa.Location = new System.Drawing.Point(9, 174);
            this.lblempresa.Name = "lblempresa";
            this.lblempresa.Size = new System.Drawing.Size(48, 13);
            this.lblempresa.TabIndex = 27;
            this.lblempresa.Text = "Empresa";
            // 
            // lbltamanho
            // 
            this.lbltamanho.AutoSize = true;
            this.lbltamanho.Location = new System.Drawing.Point(9, 135);
            this.lbltamanho.Name = "lbltamanho";
            this.lbltamanho.Size = new System.Drawing.Size(52, 13);
            this.lbltamanho.TabIndex = 26;
            this.lbltamanho.Text = "Tamanho";
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Location = new System.Drawing.Point(9, 96);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(52, 13);
            this.lblcategoria.TabIndex = 25;
            this.lblcategoria.Text = "Categoria";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(9, 53);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(35, 13);
            this.lblnome.TabIndex = 24;
            this.lblnome.Text = "Nome";
            // 
            // dgvartigo
            // 
            this.dgvartigo.AllowUserToAddRows = false;
            this.dgvartigo.AllowUserToDeleteRows = false;
            this.dgvartigo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvartigo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvartigo.Location = new System.Drawing.Point(9, 268);
            this.dgvartigo.Name = "dgvartigo";
            this.dgvartigo.ReadOnly = true;
            this.dgvartigo.Size = new System.Drawing.Size(352, 101);
            this.dgvartigo.TabIndex = 23;
            this.dgvartigo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnlocalizar
            // 
            this.btnlocalizar.Location = new System.Drawing.Point(286, 19);
            this.btnlocalizar.Name = "btnlocalizar";
            this.btnlocalizar.Size = new System.Drawing.Size(75, 23);
            this.btnlocalizar.TabIndex = 22;
            this.btnlocalizar.Text = "Localizar";
            this.btnlocalizar.UseVisualStyleBackColor = true;
            this.btnlocalizar.Click += new System.EventHandler(this.btnlocalizar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 32);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(184, 20);
            this.txtId.TabIndex = 21;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(9, 16);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 20;
            this.lblId.Text = "Id";
            // 
            // FormArtigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 419);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.lblvalor);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnatualizar);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.txtempresa);
            this.Controls.Add(this.txttamanho);
            this.Controls.Add(this.txtcategoria);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblempresa);
            this.Controls.Add(this.lbltamanho);
            this.Controls.Add(this.lblcategoria);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.dgvartigo);
            this.Controls.Add(this.btnlocalizar);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Name = "FormArtigo";
            this.Text = "FormArtigo";
            this.Load += new System.EventHandler(this.FormArtigo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvartigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btncadastrar_click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnatualizar;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.TextBox txtempresa;
        private System.Windows.Forms.TextBox txttamanho;
        private System.Windows.Forms.TextBox txtcategoria;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblempresa;
        private System.Windows.Forms.Label lbltamanho;
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.DataGridView dgvartigo;
        private System.Windows.Forms.Button btnlocalizar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
    }
}