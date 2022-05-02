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
    public partial class MenuAgenda : Form
    {
        private readonly PainelTarefas painelTarefas;
        public MenuAgenda()
        {
            InitializeComponent();
            painelTarefas = new PainelTarefas();
        }

        private void bt_menuTarefas_Click(object sender, EventArgs e)
        {
            PainelPrincipal.Controls.Clear();
            PainelPrincipal.Controls.Add(painelTarefas);
        }
    }
}
