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
    public partial class CadastroUsuario : Form
    {
        private static CadastroUsuario _instance;
        private CadastroUsuario()
        {
            InitializeComponent();
        }

        public static CadastroUsuario GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new CadastroUsuario();
            }
            return _instance;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Credencial credencialAux = new Credencial();
            Usuario usuarioAux = new Usuario();

            if (txtRepetirSenha.Text != txtSenha.Text || txtSenha.Text.Length < 8)
            {
                lblAviso.Visible = true;
                txtRepetirSenha.Clear();
                txtRepetirSenha.Focus();
            }
            else
            {
                usuarioAux.Nome = txtNome.Text;
                usuarioAux.Telefone = mskTelefone.Text;
                usuarioAux.Email = txtEmail.Text;

                credencialAux.Senha = txtSenha.Text;
                credencialAux.NomeUsuario = txtUsuario.Text;

                usuarioAux.Credencial = credencialAux;
                credencialAux.Usuario = usuarioAux;

                usuarioAux.Credencial.Gerente = radGerente.Checked;
                usuarioAux.Credencial.Vendedor = radVendedor.Checked;
                usuarioAux.Credencial.Caixa = radCaixa.Checked;

                UsuarioRepository.SaveOrUpdate(usuarioAux);
                CredencialRepository.SaveOrUpdate(credencialAux);

                lblSucesso.Visible = true;

                txtNome.Clear();
                txtUsuario.Clear();
                mskTelefone.Clear();
                txtSenha.Clear();
                txtRepetirSenha.Clear();
                txtEmail.Clear();
            }
        }

        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtUsuario.Focus();
                txtUsuario.SelectAll();
            }
        }

        private void txtUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmail.Focus();
                txtEmail.SelectAll();
            }
        }
        private void txtEmail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mskTelefone.Focus();
                mskTelefone.SelectAll();
            }
        }

        private void mskTelefone_KeyUp(object sender, KeyEventArgs e)
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
                txtRepetirSenha.Focus();
                txtRepetirSenha.SelectAll();
            }
        }

        private void txtRepetirSenha_KeyUp(object sender, KeyEventArgs e)
        {
            Credencial credencialAux = new Credencial();
            Usuario usuarioAux = new Usuario();
            if (e.KeyCode == Keys.Enter)
            {
                if (txtRepetirSenha.Text != txtSenha.Text || txtSenha.Text.Length < 8)
                {
                    lblAviso.Visible = true;
                    txtRepetirSenha.Clear();
                    txtSenha.Clear();
                    txtSenha.Focus();
                }
                else
                {
                    usuarioAux.Nome = txtNome.Text;
                    usuarioAux.Telefone = mskTelefone.Text;
                    usuarioAux.Email = txtEmail.Text;

                    credencialAux.Senha = txtSenha.Text;
                    credencialAux.NomeUsuario = txtUsuario.Text;

                    usuarioAux.Credencial = credencialAux;
                    credencialAux.Usuario = usuarioAux;

                    usuarioAux.Credencial.Gerente = radGerente.Checked;
                    usuarioAux.Credencial.Vendedor = radVendedor.Checked;
                    usuarioAux.Credencial.Caixa = radCaixa.Checked;

                    UsuarioRepository.SaveOrUpdate(usuarioAux);
                    CredencialRepository.SaveOrUpdate(credencialAux);

                    lblSucesso.Visible = true;

                    txtNome.Clear();
                    txtUsuario.Clear();
                    mskTelefone.Clear();
                    txtSenha.Clear();
                    txtRepetirSenha.Clear();
                    txtEmail.Clear();
                }
            }
        }

    }
}
