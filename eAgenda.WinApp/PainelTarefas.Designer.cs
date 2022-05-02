namespace eAgenda.WinApp
{
    partial class PainelTarefas
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listTarefas = new System.Windows.Forms.ListBox();
            this.bt_atualizar = new System.Windows.Forms.Button();
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.bt_editar = new System.Windows.Forms.Button();
            this.bt_inserir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listTarefas
            // 
            this.listTarefas.FormattingEnabled = true;
            this.listTarefas.ItemHeight = 15;
            this.listTarefas.Location = new System.Drawing.Point(15, 76);
            this.listTarefas.Name = "listTarefas";
            this.listTarefas.Size = new System.Drawing.Size(578, 289);
            this.listTarefas.TabIndex = 11;
            // 
            // bt_atualizar
            // 
            this.bt_atualizar.Location = new System.Drawing.Point(458, 17);
            this.bt_atualizar.Name = "bt_atualizar";
            this.bt_atualizar.Size = new System.Drawing.Size(135, 41);
            this.bt_atualizar.TabIndex = 10;
            this.bt_atualizar.Text = "Atualizar Itens Tarefa";
            this.bt_atualizar.UseVisualStyleBackColor = true;
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.Location = new System.Drawing.Point(300, 17);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(152, 41);
            this.bt_cadastrar.TabIndex = 9;
            this.bt_cadastrar.Text = "Cadastrar Items Tarefa";
            this.bt_cadastrar.UseVisualStyleBackColor = true;
            // 
            // bt_excluir
            // 
            this.bt_excluir.Location = new System.Drawing.Point(205, 17);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(89, 41);
            this.bt_excluir.TabIndex = 8;
            this.bt_excluir.Text = "Excluir Tarefa";
            this.bt_excluir.UseVisualStyleBackColor = true;
            // 
            // bt_editar
            // 
            this.bt_editar.Location = new System.Drawing.Point(108, 17);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(91, 41);
            this.bt_editar.TabIndex = 7;
            this.bt_editar.Text = "Editar Tarefa";
            this.bt_editar.UseVisualStyleBackColor = true;
            // 
            // bt_inserir
            // 
            this.bt_inserir.Location = new System.Drawing.Point(15, 17);
            this.bt_inserir.Name = "bt_inserir";
            this.bt_inserir.Size = new System.Drawing.Size(87, 41);
            this.bt_inserir.TabIndex = 6;
            this.bt_inserir.Text = "Inserir Tarefa";
            this.bt_inserir.UseVisualStyleBackColor = true;
            // 
            // PainelTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listTarefas);
            this.Controls.Add(this.bt_atualizar);
            this.Controls.Add(this.bt_cadastrar);
            this.Controls.Add(this.bt_excluir);
            this.Controls.Add(this.bt_editar);
            this.Controls.Add(this.bt_inserir);
            this.Name = "PainelTarefas";
            this.Size = new System.Drawing.Size(610, 380);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listTarefas;
        private System.Windows.Forms.Button bt_atualizar;
        private System.Windows.Forms.Button bt_cadastrar;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Button bt_inserir;
    }
}
