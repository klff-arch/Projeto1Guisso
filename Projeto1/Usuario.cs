using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto1
{
    public class Usuario
    {
        public UInt64 Id { get; set; }

        [Required]
        [MaxLength(60)]
        private String? _nome;
        public String? Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("O nome não pode ser nulo ou vazio");
                }
                if (value.Length > 60)
                {
                    throw new ArgumentException("O nome não pode ter mais de 60 caracteres");
                }
                value = _nome;
            }
        }

        [Required]
        [MaxLength(13)]
        private String? _telefone;
        public String? Telefone
        {
            get
            {
                return _telefone;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("O telefone não pode ser nulo ou vazio");
                }
                if (value.Length > 13 || value.Length < 13)
                {
                    throw new ArgumentException("O telefone deve ter 13 caracteres");
                }
                _telefone = value;
            }
        }

        [Required]
        [MaxLength(100)]
        private String? _email;
        public String? Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O email não pode ser nulo ou vazio");
                }
                if(value.Length > 100)
                {
                    throw new ArgumentException("O email não pode ter mais de 100 caracteres");
                }
                _email = value;
            }
        }

        [Required]
        [MaxLength(30)]
        private String? _apelido;
        public String? Apelido
        {
            get
            {
                return _apelido;
            }
            set
            {
                if(value is null )
                {
                    throw new ArgumentNullException("O apelido não pode ser nulo");
                }
                if(value.Length > 30)
                {
                    throw new ArgumentException("O apelido não pode ter mais de 30 caracteres");
                }
                _apelido = value;
            }
        }

        [Required]
        private Credencial? _credencial;
        public Credencial? Credencial
        {
            get
            {
                return _credencial;
            }
            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException("A credencial não pode ser nula");
                }
                _credencial = value;
            }
        }

        [Required]
        public UInt64 CredencialId { get; set; }
    }
}
