using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace WindowsFormsApp1
{
    class PassWordGen
    {
        readonly string passWord;
        readonly int myLength;

        const int myIterations = 1000; // поки не використовую (ця кількість ітерацій впливає на ключ, який буде сформовано з пароля)

        byte[] salt0 = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 }; // не менше 8 байт (цей масив впливає на ключ, який буде сформовано з пароля)
        byte[] _result;

        public PassWordGen(string usageText, string usageLen) //конструктор класа
        {
            passWord = usageText; // поле для читання може бути ініціалізувати або змінено в конструкторі після компіляції
            myLength = int.Parse(usageLen); //довжина ключа в байтах
        }

        public byte[] Result
        {
            get // те що повертає функція
            {
                this._result = calculations(this.passWord, this.myLength);
                return this._result;
            }
            set // те що приймає функція
            {

            }
        }

        private byte[] calculations(string passWord, int len)
        {
            Rfc2898DeriveBytes k0 = new Rfc2898DeriveBytes(passWord, salt0); // те саме, що і з myIterations = 1000
            //Rfc2898DeriveBytes k0 = new Rfc2898DeriveBytes("pass", salt0, myIterations);
            //byte[] salt = k0.Salt;
            byte[] key = k0.GetBytes(len);
            return key;
        }

    }

}
