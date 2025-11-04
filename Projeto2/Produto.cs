using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1
{
    public class Produto
    {
        public UInt64 Id { get; set; }

        public Produto()
        {
            _estoqueMinimo = 10;
            Ativo = true;
        }
        private String _nome;
        public String Nome {
            get
            {
                return _nome;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("O nome do produto não pode ser nulo");
                }
                _nome = value;
            }
        }

        private Decimal? _preco;
        public Decimal? Preco 
        {
            get
            {
                return _preco;
            }
            set
            {
                if (_preco is null)
                {
                    throw new ArgumentNullException("O preço não pode ser nulo");
                }
                if (_preco < 0)
                {
                    throw new ArgumentException("O preço não pode ser menor do que 0");
                }
                _preco = value;
            }
        }

        private UInt32? _estoque;
        public UInt32? Estoque 
        {
            get
            {
                return _estoque;
            }
            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException("O estoque não pode ser nulo");
                }
                _estoque = value;
            }
        }

        private UInt32? _estoqueMinimo;
        public UInt32? EstoqueMinimo
        {
            get
            {
                return _estoqueMinimo;
            }
            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException("O estoque minímo não pode ser nulo");
                }
            }
        } 

        public Boolean Ativo { get; set; }
    }
}
