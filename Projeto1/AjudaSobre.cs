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
    public partial class AjudaSobre : Form
    {
        private static AjudaSobre _instance;
        private AjudaSobre()
        {
            InitializeComponent();
        }

        public static AjudaSobre GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new AjudaSobre();
            }
            return _instance;
        }
    }
}
