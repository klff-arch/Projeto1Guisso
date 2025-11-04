using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Projeto1
{
    internal class CompraRepository
    {
        public static void SaveOrUpdate(Compra compra)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (compra.Id == 0)
                    {
                        dbContext.Compras.Add(compra);
                    }
                    else
                    {
                        dbContext.Entry(compra).State = EntityState.Modified;
                    }
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Compra> FindAll()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Compras.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Compra> FindById(UInt64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Compras.Where(c => c.Id == id).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Delete(Compra compra)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Compras.Remove(compra);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
