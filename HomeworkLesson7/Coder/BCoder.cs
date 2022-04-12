namespace HomeworkLesson7
{
    public class BCoder : ICoder
    {
        private string _str;

        public BCoder(string str)
        {
            _str = str;
        }

        /// <summary>
        /// декодирует строку
        /// </summary>
        public void Decode()
        {
            var str = _str.ToCharArray();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 65 && str[i] <= 90)
                {
                    str[i] = (char)(65 + (90 - (int)str[i]));
                }
                else if (str[i] >= 97 && str[i] <= 122)
                {
                    str[i] = (char) (97 + (122 - (int) str[i]));
                }
            }

            _str = new string(str);
        }

        /// <summary>
        /// кодирует строку
        /// </summary>
        public void Encode()
        {
            var str = _str.ToCharArray();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 65 && str[i] <= 90)
                {
                    str[i] = (char)(90 - ((int)str[i] - 65));
                }
                else if (str[i] >= 97 && str[i] <= 122)
                {
                    str[i] = (char)(122 - ((int)str[i] - 97));
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
