namespace _22okt_classTask_extensions.Extentions
{
    static class Extensions
    {
        public static bool IsOdd(this int number)
        {
            if (number % 2 == 0) return false;
            return true;
        }
        public static bool IsEven(this int number)
        {
            if (number % 2 == 0) return true;
            return false;
        }

        //for ile   
        public static bool HasDigit(this string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i])) return true;
                return false;
            }
            return false;

        }
        //foraech ile
        public static bool HasDigit2(this string text)
        {
            foreach (char c in text)
            {
                if (char.IsDigit(c)) return true;
            }
            return false;

        }

        public static bool CheckPassword(this string text)
        {
            if (text.Length < 8) return false;

            bool hasDigit = false;
            bool hasUpper = false;
            var hasLower = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i])) hasDigit = true;
                if (char.IsUpper(text[i])) hasUpper = true;
                if (char.IsLower(text[i])) hasLower = true;

                if (hasDigit && hasUpper && hasLower) return true;
            }

            return false;

        }
        public static string Capitalize(this string word) {
            return char.ToUpper(word[0]) + word.Substring(1).ToLower();
            
        
        }



    }
}
   
