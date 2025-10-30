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
                    dbContext.SaveChanges();
                }
            }
            catch(Exception)
            {
                throw;
            }
        }

        public static List<Usuario> FindAllWithCredencial()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Usuarios.Include("Credencial").ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Usuario? FindById(UInt64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Usuarios.Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
