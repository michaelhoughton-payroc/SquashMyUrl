﻿using System.Linq;
using System.Text;

namespace SquashMyUrlApp.Utilities
{
    public class UrlEncoder
    {
        private readonly string _inputString;
        static long COUNTER = 100000000000;
        string safeUrlElements = "0123456789abcdefghIjklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public UrlEncoder(string inputString = null)
        {
            if(inputString != null)
            {
                _inputString = inputString;
            }
        }

        public string EncodeUrl(string input = null)
        {
            if(input != null)
            return Base10ToBase62(COUNTER);
            else
            {
                return string.Empty;
            }
        }

        private string Base10ToBase62(long counter)
        {
            StringBuilder stringBuilder = new StringBuilder();
            while(counter != 0)
            {
                long remainder = counter % 62;
                int element = (int)remainder;
                stringBuilder.Append(safeUrlElements.ElementAt(element));
                counter /= 62;
            }

            return stringBuilder.ToString();
        }
    }
}
