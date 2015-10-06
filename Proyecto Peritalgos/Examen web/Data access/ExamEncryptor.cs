using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen_web.Data_access
{
    public class ExamEncryptor
    {
        #region Protected Members
        protected const string vlcfuentes = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmn!opqrstuvwxyz*/&%$#@";
        protected const string vlcencript = "FDSAPOIUYTRMNBVCXZ!LKJHGEWQmnbvapoiuytrcxzlkjhgfdsewq9876543210$%&/@#*";
        #endregion

        #region Protected Methods
        protected string Encrypt(string text)
        {
            string vlclaencri = "";
            string clave = text.Trim();
            int i = 0, j = 0;
            char charFuente = new char(), charClave = new char(), charEncript = new char();

            for (j = 0; j < clave.Length; j++)
            {
                charClave = clave[j];

                for (i = 0; i < vlcfuentes.Length; i++)
                {
                    charFuente = vlcfuentes[i];
                    if (charFuente == charClave)
                    {
                        if (i < vlcencript.Length)
                        {
                            charEncript = vlcencript[i];
                        }
                        vlclaencri += charEncript.ToString();
                        break;
                    }
                }
            }
            return vlclaencri;
        }

        protected string Decrypt(string text)
        {
            string vlclaencri = "";
            string clave = text.Trim();
            int i = 0, j = 0;
            char charFuente = new char(), charClave = new char(), charEncript = new char();
            for (j = 0; j < clave.Length; j++)
            {
                charClave = clave[j];

                for (i = 0; i < vlcfuentes.Length; i++)
                {
                    charEncript = vlcencript[i];
                    if (charEncript == charClave)
                    {
                        if (i < vlcfuentes.Length)
                        {
                            charFuente = vlcfuentes[i];
                        }
                        vlclaencri += charFuente.ToString();
                        break;
                    }
                }
            }
            return vlclaencri;

        }
        #endregion

        #region Public Methods

        /// <summary>
        /// Encripta o desencripta un texto
        /// </summary>
        /// <param name="isEncript">'S' si se desea encriptar y un valor diferente si se desea desencriptar</param>
        /// <param name="text">texto a enxriptar</param>
        /// <returns>cadena de texto procesada</returns>
        public string EncryptDecryptText(char isEncript, string text)
        {
            return isEncript == 'S' ? this.Encrypt(text) : this.Decrypt(text);
        }
        #endregion
    }
}