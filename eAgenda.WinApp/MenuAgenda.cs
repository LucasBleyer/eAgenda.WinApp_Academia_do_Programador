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

            DialogResult mostrarTela = tela.ShowDialog();

            if (mostrarTela == DialogResult.OK)
            {
                tela.DialogResult = mostrarTela;
            }
        }

        private void bt_menuContatos_Click(object sender, EventArgs e)
        {
            ListagemContatos tela = new ListagemContatos();

            DialogResult mostrarTela = tela.ShowDialog();

            if (mostrarTela == DialogResult.OK)
            {
                tela.DialogResult = mostrarTela;
            }
        }

        private void bt_menuCompromissos_Click(object sender, EventArgs e)
        {
            ListagemCompromissos tela = new ListagemCompromissos();

            DialogResult mostrarTela = tela.ShowDialog();

            if (mostrarTela == DialogResult.OK)
            {
                tela.DialogResult = mostrarTela;
            }
        }
    }
}
