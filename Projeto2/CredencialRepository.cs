using System;
using Microsoft.EntityFrameworkCore;

namespace Projeto1
{
    public class CredencialRepository
    {
        public static void SaveOrUpdate(Credencial credencial)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (credencial.Id == 0)
                    {
                        dbContext.Credenciais.Add(credencial);
                    }
                    else
                    {
                        dbContext.Entry(credencial).State = EntityState.Modified;
                    }
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static Credencial? FindById(UInt64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Credenciais.Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<Credencial> FindAllWithUsuario()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Credenciais.Include("Usuario").ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
