using Humanizer;
using System.Globalization;

namespace Num2WordApp.Core
{
    public class WriteNumber
    {
        /// <summary>
        /// Write a number as word based on language code for output.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="languageCode"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static string WriteNumberAsWord(int number, int languageCode)
        {
            if (languageCode < 1 || languageCode > 2)
            {
                throw new ArgumentOutOfRangeException(nameof(languageCode));
            }
            try
            {
                return number.ToWords(GetLanguage(languageCode));
            }
            catch (Exception)
            {
                Console.WriteLine($"Something went wrong while converting number to word.");
                throw;
            }
        }

        private static CultureInfo GetLanguage(int languageCode) => languageCode switch
        {
            1 => new CultureInfo("en"),
            2 => new CultureInfo("pt-BR"),
            _ => throw new ArgumentException(message: "Invalid languageCode", paramName: nameof(languageCode))
        };

    }
}
