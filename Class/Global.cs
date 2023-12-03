using ProjetoMars.WSCorreios;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace ProjetoMars.Class
{
    internal class Global
    {
        public static string caminhoImagens = caminhoImagens + @"Imagens";

       
       public class Encrypt
        {
            public static string HashString(string input)
            {
                StringBuilder sb = new StringBuilder();
                foreach (byte b in GetHash(input))
                    sb.Append(b.ToString("x3"));
                return sb.ToString();

            }

            public static byte[] GetHash(string input)
            {
                using (HashAlgorithm algorithm = SHA256.Create())
                    return algorithm.ComputeHash(Encoding.UTF8.GetBytes(input));
            }
        }

    }
}
