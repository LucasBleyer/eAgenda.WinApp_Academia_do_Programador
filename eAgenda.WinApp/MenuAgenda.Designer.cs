namespace eAgenda.WinApp
{
    partial class MenuAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAgenda));
            this.PainelPrincipal = new System.Windows.Forms.Panel();
            this.bt_menuTarefas = new System.Windows.Forms.Button();
            this.bt_menuContatos = new System.Windows.Forms.Button();
            this.bt_menuCompromissos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PainelPrincipal
            // 
            this.PainelPrincipal.Location = new System.Drawing.Point(177, 21);
            this.PainelPrincipal.Name = "PainelPrincipal";
            this.PainelPrincipal.Size = new System.Drawing.Size(610, 380);
            this.PainelPrincipal.TabIndex = 0;
            // 
            // bt_menuTarefas
            // 
            this.bt_menuTarefas.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_menuTarefas.Location = new System.Drawing.Point(27, 81);
            this.bt_menuTarefas.Name = "bt_menuTarefas";
            this.bt_menuTarefas.Size = new System.Drawing.Size(133, 69);
            this.bt_menuTarefas.TabIndex = 1;
            this.bt_menuTarefas.Text = "Tarefas";
            this.bt_menuTarefas.UseVisualStyleBackColor = true;
            this.bt_menuTarefas.Click += new System.EventHandler(this.bt_menuTarefas_Click);
            // 
            // bt_menuContatos
            // 
            this.bt_menuContatos.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_menuContatos.Location = new System.Drawing.Point(27, 156);
            this.bt_menuContatos.Name = "bt_menuContatos";
            this.bt_menuContatos.Size = new System.Drawing.Size(133, 69);
            this.bt_menuContatos.TabIndex = 2;
            this.bt_menuContatos.Text = "Contatos";
            this.bt_menuContatos.UseVisualStyleBackColor = true;
            // 
            // bt_menuCompromissos
            // 
            this.bt_menuCompromissos.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_menuCompromissos.Location = new System.Drawing.Point(27, 231);
            this.bt_menuCompromissos.Name = "bt_menuCompromissos";
            this.bt_menuCompromissos.Size = new System.Drawing.Size(133, 69);
            this.bt_menuCompromissos.TabIndex = 3;
            this.bt_menuCompromissos.Text = "Compromissos";
            this.bt_menuCompromissos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(66, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "eAgenda";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 54);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MenuAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 423);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_menuCompromissos);
            this.Controls.Add(this.bt_menuContatos);
            this.Controls.Add(this.bt_menuTarefas);
            this.Controls.Add(this.PainelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eAgenda";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PainelPrincipal;
        private System.Windows.Forms.Button bt_menuTarefas;
        private System.Windows.Forms.Button bt_menuContatos;
        private System.Windows.Forms.Button bt_menuCompromissos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}