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

            Credencial credencial = new Credencial()
            {
                Id = 1001,
                NomeUsuario = "ana.zaira",
                Senha = "123456785",
                Gerente = true
            };
            _usuario = new Usuario()
            {
                Id = 1,
                Nome = "Ana Zaira da Silva",
                Credencial = credencial
            };
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
                txtUsuario.Focus();

                if (txtUsuario.Text == _usuario.Credencial.NomeUsuario
                    && txtSenha.Text == _usuario.Credencial.Senha)
                {
                    txtUsuario.Clear();
                    txtSenha.Clear();

                    
                    Hide();

                    // new Sistema(_usuario).Show(); errado
                    Sistema.GetInstance(_usuario).Show();
                }
                else
                {
                    lblInvalida.Show();
                    txtUsuario.SelectAll();
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
