namespace eAgenda.WinApp.Contato
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
            this.bt_voltar.Location = new System.Drawing.Point(273, 350);
            this.bt_voltar.Name = "bt_voltar";
            this.bt_voltar.Size = new System.Drawing.Size(75, 40);
            this.bt_voltar.TabIndex = 13;
            this.bt_voltar.Text = "Voltar";
            this.bt_voltar.UseVisualStyleBackColor = true;
            // 
            // listContatos
            // 
            this.listContatos.FormattingEnabled = true;
            this.listContatos.ItemHeight = 15;
            this.listContatos.Location = new System.Drawing.Point(12, 85);
            this.listContatos.Name = "listContatos";
            this.listContatos.Size = new System.Drawing.Size(612, 259);
            this.listContatos.TabIndex = 12;
            // 
            // bt_vizualizarPorCargo
            // 
            this.bt_vizualizarPorCargo.Location = new System.Drawing.Point(489, 25);
            this.bt_vizualizarPorCargo.Name = "bt_vizualizarPorCargo";
            this.bt_vizualizarPorCargo.Size = new System.Drawing.Size(135, 40);
            this.bt_vizualizarPorCargo.TabIndex = 11;
            this.bt_vizualizarPorCargo.Text = "Vizualizar por Cargo";
            this.bt_vizualizarPorCargo.UseVisualStyleBackColor = true;
            // 
            // bt_excluir
            // 
            this.bt_excluir.Location = new System.Drawing.Point(204, 25);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(75, 40);
            this.bt_excluir.TabIndex = 9;
            this.bt_excluir.Text = "Excluir";
            this.bt_excluir.UseVisualStyleBackColor = true;
            // 
            // bt_editar
            // 
            this.bt_editar.Location = new System.Drawing.Point(106, 25);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(75, 40);
            this.bt_editar.TabIndex = 8;
            this.bt_editar.Text = "Editar";
            this.bt_editar.UseVisualStyleBackColor = true;
            // 
            // bt_inserir
            // 
            this.bt_inserir.Location = new System.Drawing.Point(12, 25);
            this.bt_inserir.Name = "bt_inserir";
            this.bt_inserir.Size = new System.Drawing.Size(75, 40);
            this.bt_inserir.TabIndex = 7;
            this.bt_inserir.Text = "Inserir";
            this.bt_inserir.UseVisualStyleBackColor = true;
            // 
            // ListagemContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 402);
            this.Controls.Add(this.bt_voltar);
            this.Controls.Add(this.listContatos);
            this.Controls.Add(this.bt_vizualizarPorCargo);
            this.Controls.Add(this.bt_excluir);
            this.Controls.Add(this.bt_editar);
            this.Controls.Add(this.bt_inserir);
            this.Name = "ListagemContatos";
            this.Text = "ListagemContatos";
            this.ResumeLayout(false);

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