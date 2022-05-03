namespace eAgenda.WinApp.Compromisso
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
            this.listComrpomissos = new System.Windows.Forms.ListBox();
            this.bt_vizualizar = new System.Windows.Forms.Button();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.bt_editar = new System.Windows.Forms.Button();
            this.bt_inserir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_voltar
            // 
            this.bt_voltar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_voltar.Location = new System.Drawing.Point(273, 337);
            this.bt_voltar.Name = "bt_voltar";
            this.bt_voltar.Size = new System.Drawing.Size(75, 40);
            this.bt_voltar.TabIndex = 19;
            this.bt_voltar.Text = "Voltar";
            this.bt_voltar.UseVisualStyleBackColor = true;
            // 
            // listComrpomissos
            // 
            this.listComrpomissos.FormattingEnabled = true;
            this.listComrpomissos.ItemHeight = 15;
            this.listComrpomissos.Location = new System.Drawing.Point(12, 72);
            this.listComrpomissos.Name = "listComrpomissos";
            this.listComrpomissos.Size = new System.Drawing.Size(612, 259);
            this.listComrpomissos.TabIndex = 18;
            // 
            // bt_vizualizar
            // 
            this.bt_vizualizar.Location = new System.Drawing.Point(547, 12);
            this.bt_vizualizar.Name = "bt_vizualizar";
            this.bt_vizualizar.Size = new System.Drawing.Size(75, 40);
            this.bt_vizualizar.TabIndex = 17;
            this.bt_vizualizar.Text = "Vizualizar";
            this.bt_vizualizar.UseVisualStyleBackColor = true;
            // 
            // bt_excluir
            // 
            this.bt_excluir.Location = new System.Drawing.Point(202, 12);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(75, 40);
            this.bt_excluir.TabIndex = 16;
            this.bt_excluir.Text = "Excluir";
            this.bt_excluir.UseVisualStyleBackColor = true;
            // 
            // bt_editar
            // 
            this.bt_editar.Location = new System.Drawing.Point(106, 12);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(75, 40);
            this.bt_editar.TabIndex = 15;
            this.bt_editar.Text = "Editar";
            this.bt_editar.UseVisualStyleBackColor = true;
            // 
            // bt_inserir
            // 
            this.bt_inserir.Location = new System.Drawing.Point(12, 12);
            this.bt_inserir.Name = "bt_inserir";
            this.bt_inserir.Size = new System.Drawing.Size(75, 40);
            this.bt_inserir.TabIndex = 14;
            this.bt_inserir.Text = "Inserir";
            this.bt_inserir.UseVisualStyleBackColor = true;
            // 
            // ListagemCompromissos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 387);
            this.Controls.Add(this.bt_voltar);
            this.Controls.Add(this.listComrpomissos);
            this.Controls.Add(this.bt_vizualizar);
            this.Controls.Add(this.bt_excluir);
            this.Controls.Add(this.bt_editar);
            this.Controls.Add(this.bt_inserir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListagemCompromissos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Compromissos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_voltar;
        private System.Windows.Forms.ListBox listComrpomissos;
        private System.Windows.Forms.Button bt_vizualizar;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Button bt_inserir;
    }
}