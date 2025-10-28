using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;
using System.Text;


namespace Projeto1
{
    public class Credencial
    {
        public UInt64 Id { get; set; }
        public const String SALT = "1FnM6_";
        [Required]
        [MaxLength(20)]
        private String? _nomeUsuario;
        public String? NomeUsuario
        {
            get
            {
                return _nomeUsuario;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value) )
                {
                    throw new ArgumentNullException("O nome do usuário não pode ser nulo");
                }
                if (value.Length > 20)
                {
                    throw new ArgumentException("O nome do usuário não pode ter mais de 20 caracteres");
                }
                _nomeUsuario = value;
            }
        }
        [Required]
        [MinLength(8)]
        private String? _senha;
        public String? Senha
        {
            get
            {
                return _senha;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("A senha não pode ser nula");
                }
                if (value.Length < 8)
                {
                    throw new ArgumentException("A senha não pode ter menos de 8 caracteres");
                }
                _senha = ComputeSHA256(value, SALT);
            }
        }
        [Required]
        public Boolean Gerente { get; set; } = false;

        [Required]
        private Usuario? _usuario;
        public Usuario? Usuario
        {
            get
            {
                return _usuario;
            }
            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException("O usuário não pode ser nulo");
                }
            }
        }
        #region Hashing
        public static String ComputeSHA256(String input)
        {
            return ComputeSHA256(input, null);
        }

        public static String ComputeSHA256(String input, String salt)
        {
            String hash = String.Empty;

            // 
            // https://learn.microsoft.com/en-us/dotnet/standard/security/cryptographic-services
            // https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.sha256?view=netframework-4.8
            // https://www.techiedelight.com/generate-sha-256-hash-of-string-csharp/
            // 

            // Initialize a SHA256 hash object
            using (SHA256 sha256 = SHA256.Create())
            {
                // Compute the hash of the given string
                byte[] hashValue = sha256.ComputeHash(
                    Encoding.UTF8.GetBytes(salt + input));

                // Convert the byte array to string format
                foreach (byte b in hashValue)
                {
                    hash += $"{b:X2}";
                }
            }

            return hash;
        }
        #endregion
    }
}
