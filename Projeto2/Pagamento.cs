using System;

namespace Projeto1
{
    public class Pagamento
    {
        public UInt64 Id { get; set; }
        private DateTime? _vencimento;   
        public DateTime? Vencimento
        {
            get
            {
                return _vencimento;
            }
            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException("A data de vencimento não pode ser nula");
                }
                _vencimento = value;
            }
        }
        private DateTime _dataPagamento;
        public DateTime DataPagamento
        {
            get
            {
                return _dataPagamento;
            }
            set
            {
                if(value < DateTime.Now)
                {
                    throw new ArgumentException("A data de pagamento não pode ser anterior à data de hoje");
                }
            }
        }
        public Decimal MultaAtraso { get; set; }
        private Compra? _compra;
        public Compra? Compra
        {
            get
            {
                return _compra;
            }
            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException("A compra não pode ser nula");
                }
            }
        }
    }
}
