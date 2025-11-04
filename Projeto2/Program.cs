using Mysqlx.Crud;
using System;
using System.Text;  
namespace Projeto1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(Login.GetInstance());
            Repository repository = new Repository();
        }
    }
}