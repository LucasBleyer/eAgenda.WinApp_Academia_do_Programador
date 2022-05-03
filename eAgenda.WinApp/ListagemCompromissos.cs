using GestaoCompromissos.Dominio;
using GestaoCompromissos.Infra;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eAgenda.WinApp
{
    public partial class ListagemCompromissos : Form
    {
        private readonly RepositorioCompromisso repositorioCompromisso;
        public ListagemCompromissos()
        {
            repositorioCompromisso = new RepositorioCompromisso();
            InitializeComponent();
            CarregarCompromissos();
        }
        private void CarregarCompromissos()
        {
            List<Compromisso> compromissos = repositorioCompromisso.SelecionarTodos();

            listCompromissos.Items.Clear();

            foreach (Compromisso c in compromissos)
            {
                listCompromissos.Items.Add(c);
            }
        }

        private void bt_inserir_Click(object sender, EventArgs e)
        {

        }

        private void bt_editar_Click(object sender, EventArgs e)
        {

        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {

        }
    }
}
