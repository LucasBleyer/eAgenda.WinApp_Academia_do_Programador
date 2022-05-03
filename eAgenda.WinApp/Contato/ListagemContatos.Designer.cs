using System;

namespace eAgenda.WinApp
{
    partial class ListagemContatos
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
            this.bt_voltar = new System.Windows.Forms.Button();
            this.listContatos = new System.Windows.Forms.ListBox();
            this.bt_vizualizarPorCargo = new System.Windows.Forms.Button();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.bt_editar = new System.Windows.Forms.Button();
            this.bt_inserir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_voltar
            // 
            this.bt_voltar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_voltar.Location = new System.Drawing.Point(312, 467);
            this.bt_voltar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_voltar.Name = "bt_voltar";
            this.bt_voltar.Size = new System.Drawing.Size(86, 53);
            this.bt_voltar.TabIndex = 13;
            this.bt_voltar.Text = "Voltar";
            this.bt_voltar.UseVisualStyleBackColor = true;
            // 
            // listContatos
            // 
            this.listContatos.FormattingEnabled = true;
            this.listContatos.ItemHeight = 20;
            this.listContatos.Location = new System.Drawing.Point(14, 113);
            this.listContatos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listContatos.Name = "listContatos";
            this.listContatos.Size = new System.Drawing.Size(699, 344);
            this.listContatos.TabIndex = 12;
            // 
            // bt_vizualizarPorCargo
            // 
            this.bt_vizualizarPorCargo.Location = new System.Drawing.Point(559, 33);
            this.bt_vizualizarPorCargo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_vizualizarPorCargo.Name = "bt_vizualizarPorCargo";
            this.bt_vizualizarPorCargo.Size = new System.Drawing.Size(154, 53);
            this.bt_vizualizarPorCargo.TabIndex = 11;
            this.bt_vizualizarPorCargo.Text = "Vizualizar por Cargo";
            this.bt_vizualizarPorCargo.UseVisualStyleBackColor = true;
            this.bt_vizualizarPorCargo.Click += new System.EventHandler(this.bt_vizualizarPorCargo_Click);
            // 
            // bt_excluir
            // 
            this.bt_excluir.Location = new System.Drawing.Point(233, 33);
            this.bt_excluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(86, 53);
            this.bt_excluir.TabIndex = 9;
            this.bt_excluir.Text = "Excluir";
            this.bt_excluir.UseVisualStyleBackColor = true;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // bt_editar
            // 
            this.bt_editar.Location = new System.Drawing.Point(121, 33);
            this.bt_editar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(86, 53);
            this.bt_editar.TabIndex = 8;
            this.bt_editar.Text = "Editar";
            this.bt_editar.UseVisualStyleBackColor = true;
            this.bt_editar.Click += new System.EventHandler(this.bt_editar_Click);
            // 
            // bt_inserir
            // 
            this.bt_inserir.Location = new System.Drawing.Point(14, 33);
            this.bt_inserir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_inserir.Name = "bt_inserir";
            this.bt_inserir.Size = new System.Drawing.Size(86, 53);
            this.bt_inserir.TabIndex = 7;
            this.bt_inserir.Text = "Inserir";
            this.bt_inserir.UseVisualStyleBackColor = true;
            this.bt_inserir.Click += new System.EventHandler(this.bt_inserir_Click);
            // 
            // ListagemContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 536);
            this.Controls.Add(this.bt_voltar);
            this.Controls.Add(this.listContatos);
            this.Controls.Add(this.bt_vizualizarPorCargo);
            this.Controls.Add(this.bt_excluir);
            this.Controls.Add(this.bt_editar);
            this.Controls.Add(this.bt_inserir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListagemContatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListagemContatos";
            this.ResumeLayout(false);

        }

        private void bt_vizualizarPorCargo_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button bt_voltar;
        private System.Windows.Forms.ListBox listContatos;
        private System.Windows.Forms.Button bt_vizualizarPorCargo;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Button bt_inserir;
    }
}