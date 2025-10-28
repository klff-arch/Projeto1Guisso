using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1
{
    public partial class Sistema : Form
    {
        private static Sistema _instance;

        private Sistema(Usuario usuario)
        {
            InitializeComponent();

            mnuCadastroUsuario.Enabled = usuario.Credencial.Gerente;
        }

        public static Sistema GetInstance(Usuario usuario)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new Sistema(usuario);
            }
            return _instance;
        }

        private void mnuSobre_Click(object sender, EventArgs e)
        {
            AjudaSobre ajudaSobre = AjudaSobre.GetInstance();
            ajudaSobre.MdiParent = this;
            ajudaSobre.WindowState = FormWindowState.Normal;
            ajudaSobre.BringToFront();
            ajudaSobre.Show();
        }

        private void Sistema_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login.GetInstance().Show();
        }

        private void mnuArquivoSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuCadastroUsuario_Click(object sender, EventArgs e)
        {
            CadastroUsuario cadastroUsuario = CadastroUsuario.GetInstance();
            cadastroUsuario.MdiParent = this;
            cadastroUsuario.WindowState = FormWindowState.Normal;
            cadastroUsuario.BringToFront();
            cadastroUsuario.Show();
        }

        private void mnuRelatorioUsuarios_Click(object sender, EventArgs e)
        {
            ListaUsuarios listaUsuarios = ListaUsuarios.GetInstance();
            listaUsuarios.MdiParent = this;
            listaUsuarios.WindowState = FormWindowState.Normal;
            listaUsuarios.BringToFront();
            listaUsuarios.Show();
        }
    }
}
