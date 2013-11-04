using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace AbonnementsimuleringKlient
{
    public class EConomicCredentialsDAO : IEConomicCredentialsDAO
    {
        public string Brugernavn { get; set; }
        public string Kodeord { get; set; }
        public string Aftalenummer { get; set; }

        private IDTO DTO;

        public bool LoginVerificering()
        {
           return true; // ikke færdig
        }

        public string KrypterKodeord(string kodeord)
        {
            return Encrypt3DES(kodeord);
        }

        public string DekrypterKodeord(string kodeord)
        {
            return Decrypt3DES(kodeord);
        }

        //-------------------------------------------------------------------------------------
        // Alt neden for er lånt fra nettet

        private System.Text.Encoding _encoding;

        private string Key
        {
            get
            {
                return "xxxxxxxx";
            }
        }


        private System.Text.Encoding Encoding
        {
            get
            {
                if (_encoding == null)
                {
                    _encoding = System.Text.Encoding.UTF8;
                }
                return _encoding;
            }

            set
            {
                _encoding = value;
            }
        }
        
        private string Encrypt3DES(string strString)
        {
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();

            DES.Key = Encoding.GetBytes(this.Key);
            DES.Mode = CipherMode.ECB;
            DES.Padding = PaddingMode.Zeros;

            ICryptoTransform DESEncrypt = DES.CreateEncryptor();

            byte[] Buffer = _encoding.GetBytes(strString);

            return Convert.ToBase64String(DESEncrypt.TransformFinalBlock(Buffer, 0, Buffer.Length));
        }


        private string Decrypt3DES(string strString)
        {
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();

            DES.Key = Encoding.UTF8.GetBytes(this.Key);
            DES.Mode = CipherMode.ECB;
            DES.Padding = PaddingMode.Zeros;
            ICryptoTransform DESDecrypt = DES.CreateDecryptor();

            byte[] Buffer = Convert.FromBase64String(strString);
            return UTF8Encoding.UTF8.GetString(DESDecrypt.TransformFinalBlock(Buffer, 0, Buffer.Length));
        }
    }


}

