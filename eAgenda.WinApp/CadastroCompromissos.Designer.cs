namespace eAgenda.WinApp
{
    partial class CadastroCompromissos
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtHoraTermino = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHoraInicial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_gravar = new System.Windows.Forms.Button();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(128, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 21);
            this.label6.TabIndex = 34;
            this.label6.Text = "Cadastro Compromissos";
            // 
            // txtHoraTermino
            // 
            this.txtHoraTermino.Location = new System.Drawing.Point(91, 229);
            this.txtHoraTermino.Name = "txtHoraTermino";
            this.txtHoraTermino.Size = new System.Drawing.Size(323, 23);
            this.txtHoraTermino.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 32;
            this.label5.Text = "Hora Término:";
            // 
            // txtHoraInicial
            // 
            this.txtHoraInicial.Location = new System.Drawing.Point(91, 185);
            this.txtHoraInicial.Name = "txtHoraInicial";
            this.txtHoraInicial.Size = new System.Drawing.Size(323, 23);
            this.txtHoraInicial.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 30;
            this.label4.Text = "Hora Inicial:";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(91, 138);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(323, 23);
            this.txtData.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Data:";
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(91, 94);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(323, 23);
            this.txtLocal.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Local:";
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_cancelar.Location = new System.Drawing.Point(339, 284);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(75, 40);
            this.bt_cancelar.TabIndex = 25;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            // 
            // bt_gravar
            // 
            this.bt_gravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_gravar.Location = new System.Drawing.Point(258, 284);
            this.bt_gravar.Name = "bt_gravar";
            this.bt_gravar.Size = new System.Drawing.Size(75, 40);
            this.bt_gravar.TabIndex = 24;
            this.bt_gravar.Text = "Gravar";
            this.bt_gravar.UseVisualStyleBackColor = true;
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(91, 52);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(323, 23);
            this.txtAssunto.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Assunto:";
            // 
            // CadastroCompromissos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 334);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHoraTermino);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHoraInicial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_gravar);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroCompromissos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Compromissos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHoraTermino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHoraInicial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_gravar;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.Label label2;
    }
}