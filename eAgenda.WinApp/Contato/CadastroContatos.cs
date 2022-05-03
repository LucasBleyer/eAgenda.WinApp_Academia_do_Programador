using GestaoContatos.Dominio;
using System;
using System.Windows.Forms;

namespace eAgenda.WinApp
{
    public partial class CadastroContatos : Form
    {
        private Contato contato;
        public CadastroContatos()
        {
            InitializeComponent();
        }
        public Contato Contato
        {
            get
            {
                return contato;
            }
            set
            {
                contato = value;
                txtNome.Text = contato.Nome;
                txtEmail.Text = contato.Email;
                txtTelefone.Text = contato.Telefone;
                txtEmpresa.Text = contato.Empresa;
                txtCargo.Text = contato.Cargo;
            }
        }

        private void bt_gravar_Click(object sender, EventArgs e)
        {
            contato.Nome = txtNome.Text;
            contato.Email = txtEmail.Text;
            contato.Telefone = txtTelefone.Text;
            contato.Empresa = txtEmpresa.Text;
            contato.Cargo = txtCargo.Text;
        }

        private void bt_gravarClick(object sender, EventArgs e)
        {

        }
    }
}
