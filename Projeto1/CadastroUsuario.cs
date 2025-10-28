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
                usuarioAux.Apelido = txtUsuario.Text;
                usuarioAux.Telefone = mskTelefone.Text;
                credencialAux.Senha = txtSenha.Text;
                usuarioAux.Credencial = credencialAux;
                credencialAux.Usuario = usuarioAux;
                usuarioAux.Credencial.Gerente = chkGerente.Checked;
                UsuarioRepository.SaveOrUpdate(usuarioAux);
                CredencialRepository.SaveOrUpdate(credencialAux);
            }
        }
    }
}
