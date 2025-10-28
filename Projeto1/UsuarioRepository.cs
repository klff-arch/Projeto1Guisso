using Microsoft.EntityFrameworkCore;
using System;

namespace Projeto1
{
    internal class UsuarioRepository
    {
        public static void SaveOrUpdate(Usuario usuario)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (usuario.Id == 0)
                    {
                        dbContext.Usuarios.Add(usuario);
                    }
                    else
                    {
                        dbContext.Entry(usuario).State = EntityState.Modified;
                    }
                }
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
