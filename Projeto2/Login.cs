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
    public partial class Login : Form
    {
        private static Login _instance;
        private Usuario _usuario;

        private Login()
        {
            InitializeComponent();

        }

        public static Login GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new Login();
            }
            return _instance;
        }
        private void txtUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
                txtSenha.SelectAll();
            }
        }

        private void txtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Usuario usuarioAutenticado = new Usuario();
                foreach (Credencial credencial in CredencialRepository.FindAllWithUsuario())
                {
                    if (txtUsuario.Text == credencial.NomeUsuario
                        && credencial.Senha == Credencial.ComputeSHA256(txtSenha.Text, Credencial.SALT))
                    {
                        usuarioAutenticado = credencial.Usuario;
                        break;
                    }
                }
                if (usuarioAutenticado != null)
                {
                    
                    txtUsuario.Clear();
                    txtSenha.Clear();

                    Hide();

                    // new Sistema(_usuario).Show(); errado
                    Sistema.GetInstance(usuarioAutenticado).Show();
                }
                else
                {
                    lblInvalida.Show();
                    txtUsuario.Focus();
                    txtUsuario.SelectAll();
                    txtSenha.Clear();
                }
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            lblInvalida.Hide();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            lblInvalida.Hide();
        }
    }
}
