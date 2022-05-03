using GestaoContatos.Infra;
using GestaoContatos.Dominio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eAgenda.WinApp
{
    public partial class ListagemContatos : Form
    {
        private readonly RepositorioContato repositorioContato;

        public ListagemContatos()
        {
            repositorioContato = new RepositorioContato();//pro repositiorio Tarefa não ficar null
            InitializeComponent();
            CarregarContatos();
        }

        private void CarregarContatos()
        {
            List<Contato> contatos = repositorioContato.SelecionarTodos();

            listContatos.Items.Clear();

            foreach (Contato c in contatos)
            {
                listContatos.Items.Add(c);
            }
        }

        private void bt_inserir_Click(object sender, EventArgs e)
        {
            CadastroContatos tela = new CadastroContatos();
            tela.Contato = new Contato();

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioContato.Inserir(tela.Contato);
                CarregarContatos();
            }
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            Contato contatoSelecionado = (Contato)listContatos.SelectedItem;//selecionar a tarefa na lista

            if (contatoSelecionado == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro",
                "Edição de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                CadastroContatos tela = new CadastroContatos();
                tela.Contato = contatoSelecionado;

                DialogResult resultado = tela.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    repositorioContato.Editar(tela.Contato);
                    CarregarContatos();
                }
            }
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            Contato contatoSelecionado = (Contato)listContatos.SelectedItem;//selecionar a tarefa na lista

            if (contatoSelecionado == null)
            {
                MessageBox.Show("Não existe nenhum contato selecionado!",
                "Exclusão de Conclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Deseja realmente excluir este Contato?",
                "Exclusão de Contatos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.OK)
                {
                    repositorioContato.Excluir(contatoSelecionado);
                    CarregarContatos();
                }
            }
        }
    }
}
