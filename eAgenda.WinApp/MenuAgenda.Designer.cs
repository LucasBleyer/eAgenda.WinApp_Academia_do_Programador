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
            this.bt_menuTarefas = new System.Windows.Forms.Button();
            this.bt_menuContatos = new System.Windows.Forms.Button();
            this.bt_menuCompromissos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_menuTarefas
            // 
            this.bt_menuTarefas.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_menuTarefas.Location = new System.Drawing.Point(176, 83);
            this.bt_menuTarefas.Name = "bt_menuTarefas";
            this.bt_menuTarefas.Size = new System.Drawing.Size(349, 101);
            this.bt_menuTarefas.TabIndex = 1;
            this.bt_menuTarefas.Text = "Gestão de Tarefas";
            this.bt_menuTarefas.UseVisualStyleBackColor = true;
            this.bt_menuTarefas.Click += new System.EventHandler(this.bt_menuTarefas_Click);
            // 
            // bt_menuContatos
            // 
            this.bt_menuContatos.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_menuContatos.Location = new System.Drawing.Point(176, 206);
            this.bt_menuContatos.Name = "bt_menuContatos";
            this.bt_menuContatos.Size = new System.Drawing.Size(349, 100);
            this.bt_menuContatos.TabIndex = 2;
            this.bt_menuContatos.Text = "Gestão de Contatos";
            this.bt_menuContatos.UseVisualStyleBackColor = true;
            this.bt_menuContatos.Click += new System.EventHandler(this.bt_menuContatos_Click);
            // 
            // bt_menuCompromissos
            // 
            this.bt_menuCompromissos.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_menuCompromissos.Location = new System.Drawing.Point(176, 324);
            this.bt_menuCompromissos.Name = "bt_menuCompromissos";
            this.bt_menuCompromissos.Size = new System.Drawing.Size(349, 100);
            this.bt_menuCompromissos.TabIndex = 3;
            this.bt_menuCompromissos.Text = "Gestão de Compromissos";
            this.bt_menuCompromissos.UseVisualStyleBackColor = true;
            this.bt_menuCompromissos.Click += new System.EventHandler(this.bt_menuCompromissos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(262, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "eAgenda";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(74, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(74, 219);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(84, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(74, 334);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(84, 79);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // MenuAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 465);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_menuCompromissos);
            this.Controls.Add(this.bt_menuContatos);
            this.Controls.Add(this.bt_menuTarefas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eAgenda";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_menuTarefas;
        private System.Windows.Forms.Button bt_menuContatos;
        private System.Windows.Forms.Button bt_menuCompromissos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}