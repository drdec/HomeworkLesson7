using System;

namespace HomeworkLesson7
{
    public class ACoder : ICoder
    {
        private string _str;

        public ACoder(string str)
        {
            _str = str;
        }

        /// <summary>
        /// кодирует строку
        /// </summary>
        public void Encode()
        {
            var str = _str.ToCharArray();

            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {
                    case 'Z':
                        str[i] = 'A';
                        break;

                    case 'z':
                        str[i] = 'a';
                        break;

                    case 'я':
                        str[i] = 'а';
                        break;

                    case 'Я':
                        str[i] = 'А';
                        break;

                    default:
                        str[i] = ++str[i];
                        break;
                }
            }

            _str = new string(str);
        }

        /// <summary>
        /// декодирует строку
        /// </summary>
        public void Decode()
        {
            var str = _str.ToCharArray();

            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {
                    case 'A':
                        str[i] = 'Z';
                        break;

                    case 'a':
                        str[i] = 'z';
                        break;
                        
                    default:
                        str[i] = --str[i];
                        break;
                }
            }

            _str = new string(str);
        }

        public override string ToString()
        {
            return _str;
        }
    }
}
