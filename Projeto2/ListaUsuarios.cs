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
    public partial class ListaUsuarios : Form
    {
        private static ListaUsuarios _instance;
        private ListaUsuarios()
        {
            InitializeComponent();
            foreach (Usuario usuario in UsuarioRepository.FindAllWithCredencial())
            {
                lstUsuarios.Items.Add($"|Id: {usuario.Id} | Nome: {usuario.Nome} | Telefone: {usuario.Telefone} | E-mail: {usuario.Email}");
            }
        }

        public static ListaUsuarios GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new ListaUsuarios();
            }
            return _instance;
        }

        
    }
}
