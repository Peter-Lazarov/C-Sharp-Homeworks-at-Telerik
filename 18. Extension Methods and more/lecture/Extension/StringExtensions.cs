namespace lecture
{
    using System;
    public static class StringExtensions
    {
        public static int CountWords(this string input)
        {
            var words = input.Split(' ');
            return words.Length;
        }
    }
}
