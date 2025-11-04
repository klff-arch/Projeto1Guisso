using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto1
{
    public class Compra
    {
        public Compra()
        {
            _itens = new List<Item>();
        }
        public UInt64 Id {  get; set; }

        [Required]
        private UInt64? _numero;
        public UInt64? Numero
        {
            get
            {
                return _numero;
            }
            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException("O número da compra não pode ser nulo");
                }
                _numero = value;
            }
        }

        [Required]
        private DateTime? _inicio;
        public DateTime? Inicio
        {
            get
            {
                return _inicio;
            }
            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException("A data de início da compra não pode ser nula");
                }
                if (value > this._efetivacao)
                {
                    throw new ArgumentException("A data de início não pode ser posterior a data de efetivação");
                }
                _inicio = value;
            }
        }

        [Required]
        private DateTime? _efetivacao;
        public DateTime? Efetivacao
        {
            get
            {
                return _efetivacao;
            }
            set
            {
                if (value < this._inicio)
                {
                    throw new ArgumentNullException("A data de efetivação não pode ser anterior a data de início");
                }
                _efetivacao = value;
            }
        }

        [Required]
        private Decimal? _comissao;
        public Decimal? Comissao
        {
            get
            {
                return _comissao;
            }
            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException("A comissão não pode ser nula");
                }
                if (value < 0)
                {
                    throw new ArgumentException("A comissão não pode ser menor do que 0");
                }
                _comissao = value;
            }
        }
        private List<Item> _itens;
        public Decimal CalcularTotal()
        {
            return 1.5m;
        }

        public Decimal CalcularComissao()
        {
            _comissao 
        }

        [Required]
        private Estado _estado;
        public Estado Estado
        {
            get
            {
                return _estado;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("");
                }
                _estado = value;
            }
        }
    }
}
