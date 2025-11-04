using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1
{
    public class Item
    {
        public UInt64 Id { get; set; }
        private UInt32 _quantidade;
        public UInt32 Quantidade 
        {
            get
            {
                return _quantidade;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A quantidade não pode ser menor que 0");
                }    
                _quantidade = value;
            }
        }
        private Decimal _precoUnitario;
        public Decimal PrecoUnitario 
        {
            get 
            {
                return _precoUnitario;
            } 
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("O preço unitário não pode ser menor do que 0");
                }
                _precoUnitario = value;
            }
        }
        private Decimal _desconto;
        public Decimal Desconto 
        {
            get
            {
                return _desconto;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("O desconto não pode ser menor do que 0");
                }
            }
        }

        public Decimal CalcularTotal(Decimal total)
        {
            total = Quantidade * PrecoUnitario;
            total = total - Desconto;
            return total;
        }
    }
}
