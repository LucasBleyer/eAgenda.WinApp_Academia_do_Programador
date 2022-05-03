namespace eAgenda.WinApp
{
    partial class ListagemCompromissos
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
            this.listCompromissos = new System.Windows.Forms.ListBox();
            this.bt_vizualizarPorCargo = new System.Windows.Forms.Button();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.bt_editar = new System.Windows.Forms.Button();
            this.bt_inserir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_voltar
            // 
            this.bt_voltar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_voltar.Location = new System.Drawing.Point(270, 337);
            this.bt_voltar.Name = "bt_voltar";
            this.bt_voltar.Size = new System.Drawing.Size(75, 40);
            this.bt_voltar.TabIndex = 19;
            this.bt_voltar.Text = "Voltar";
            this.bt_voltar.UseVisualStyleBackColor = true;
            // 
            // listCompromissos
            // 
            this.listCompromissos.FormattingEnabled = true;
            this.listCompromissos.ItemHeight = 15;
            this.listCompromissos.Location = new System.Drawing.Point(9, 72);
            this.listCompromissos.Name = "listCompromissos";
            this.listCompromissos.Size = new System.Drawing.Size(612, 259);
            this.listCompromissos.TabIndex = 18;
            // 
            // bt_vizualizarPorCargo
            // 
            this.bt_vizualizarPorCargo.Location = new System.Drawing.Point(546, 12);
            this.bt_vizualizarPorCargo.Name = "bt_vizualizarPorCargo";
            this.bt_vizualizarPorCargo.Size = new System.Drawing.Size(75, 40);
            this.bt_vizualizarPorCargo.TabIndex = 17;
            this.bt_vizualizarPorCargo.Text = "Vizualizar";
            this.bt_vizualizarPorCargo.UseVisualStyleBackColor = true;
            // 
            // bt_excluir
            // 
            this.bt_excluir.Location = new System.Drawing.Point(201, 12);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(75, 40);
            this.bt_excluir.TabIndex = 16;
            this.bt_excluir.Text = "Excluir";
            this.bt_excluir.UseVisualStyleBackColor = true;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // bt_editar
            // 
            this.bt_editar.Location = new System.Drawing.Point(103, 12);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(75, 40);
            this.bt_editar.TabIndex = 15;
            this.bt_editar.Text = "Editar";
            this.bt_editar.UseVisualStyleBackColor = true;
            this.bt_editar.Click += new System.EventHandler(this.bt_editar_Click);
            // 
            // bt_inserir
            // 
            this.bt_inserir.Location = new System.Drawing.Point(9, 12);
            this.bt_inserir.Name = "bt_inserir";
            this.bt_inserir.Size = new System.Drawing.Size(75, 40);
            this.bt_inserir.TabIndex = 14;
            this.bt_inserir.Text = "Inserir";
            this.bt_inserir.UseVisualStyleBackColor = true;
            this.bt_inserir.Click += new System.EventHandler(this.bt_inserir_Click);
            // 
            // ListagemCompromissos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 382);
            this.Controls.Add(this.bt_voltar);
            this.Controls.Add(this.listCompromissos);
            this.Controls.Add(this.bt_vizualizarPorCargo);
            this.Controls.Add(this.bt_excluir);
            this.Controls.Add(this.bt_editar);
            this.Controls.Add(this.bt_inserir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListagemCompromissos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestão de Compromissos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_voltar;
        private System.Windows.Forms.ListBox listCompromissos;
        private System.Windows.Forms.Button bt_vizualizarPorCargo;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Button bt_inserir;
    }
}