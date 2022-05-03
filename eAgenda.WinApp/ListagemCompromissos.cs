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
            CadastroCompromissos tela = new CadastroCompromissos();
            tela.Compromisso = new Compromisso();

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioCompromisso.Inserir(tela.Compromisso);
                CarregarCompromissos();
            }
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            Compromisso compromissoSelecionado = (Compromisso)listCompromissos.SelectedItem;//selecionar a tarefa na lista

            if (compromissoSelecionado == null)
            {
                MessageBox.Show("Selecione um compromisso primeiro",
                "Edição de Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                CadastroCompromissos tela = new CadastroCompromissos();
                tela.Compromisso = compromissoSelecionado;

                DialogResult resultado = tela.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    repositorioCompromisso.Editar(tela.Compromisso);
                    CarregarCompromissos();
                }
            }
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            Compromisso compromissoSelecionado = (Compromisso)listCompromissos.SelectedItem;//selecionar a tarefa na lista

            if (compromissoSelecionado == null)
            {
                MessageBox.Show("Selecione um compromisso primeiro",
                "Edição de Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                CadastroCompromissos tela = new CadastroCompromissos();
                tela.Compromisso = compromissoSelecionado;

                DialogResult resultado = tela.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    repositorioCompromisso.Excluir(tela.Compromisso);
                    CarregarCompromissos();
                }
            }
        }
    }
}
