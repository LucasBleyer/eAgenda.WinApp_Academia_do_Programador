using GestaoCompromissos.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WinApp
{
    public partial class CadastroCompromissos : Form
    {
        public Compromisso compromisso;

        public CadastroCompromissos()
        {
            InitializeComponent();
        }

        public Compromisso Compromisso
        {
            get 
            { 
                return compromisso; 
            }
            set
            {
                compromisso = value;
                txtAssunto.Text = compromisso.Assunto;
                txtLocal.Text = compromisso.Local;
                txtData.Text = compromisso.Data.ToString();
                txtHoraInicial.Text = compromisso.HoraInicio;
                txtHoraTermino.Text = compromisso.HoraTermino;
            }
        }

        private void bt_gravar_Click(object sender, EventArgs e)
        {
            compromisso.Assunto = txtAssunto.Text;
            compromisso.Local = txtLocal.Text;
            txtData.Text = compromisso.Data.ToString();
            compromisso.HoraInicio = txtHoraInicial.Text;
            compromisso.HoraTermino = txtHoraTermino.Text;
        }
    }
}
