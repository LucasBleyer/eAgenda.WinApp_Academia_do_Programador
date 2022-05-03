using System;
using System.Windows.Forms;
using GestaoTarefas.WinApp;

namespace eAgenda.WinApp
{
    public partial class MenuAgenda : Form
    {
        public MenuAgenda()
        {        
            InitializeComponent();
        }

        private void bt_menuTarefas_Click(object sender, EventArgs e)
        {
            ListagemTarefas tela = new ListagemTarefas();

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                tela.DialogResult = resultado;
            }
        }

        private void bt_menuContatos_Click(object sender, EventArgs e)
        {
            ListagemContatos tela = new ListagemContatos();

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                tela.DialogResult = resultado;
            }
        }
    }
}
