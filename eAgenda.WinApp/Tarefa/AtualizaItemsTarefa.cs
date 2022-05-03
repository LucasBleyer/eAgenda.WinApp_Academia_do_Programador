using System;
using GestaoTarefas.Dominio;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GestaoTarefas.WinApp
{
    public partial class AtualizaItemsTarefa : Form
    {
        private readonly Tarefa tarefa;
        public AtualizaItemsTarefa(Tarefa tarefa)//informar o parametro tarefa selecionada
        {
            InitializeComponent();
            this.tarefa = tarefa;
            lb_tituloTarefa.Text = tarefa.Titulo;

            CarregarItemsTarefa(tarefa);
        }
        private void CarregarItemsTarefa(Tarefa tarefa)
        {
            int i = 0;
            foreach (var item in tarefa.Items)
            {
                listItemsTarefa.Items.Add(item);

                if (item.Concluido)
                    listItemsTarefa.SetItemChecked(i, true);

                i++;
            }
        }

        public List<ItemTarefa> ItemsConcluidos
        {
            get
            {
                return listItemsTarefa.CheckedItems.Cast<ItemTarefa>().ToList();
            }
        }
    }
}
