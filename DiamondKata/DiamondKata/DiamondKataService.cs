using System.Text;

namespace DiamondKata
{
    public class DiamondKataService
    {
        private static char[] Alphabet = Enumerable.Range('A', 'Z' - 'A' + 1).Select(i => (Char)i).ToArray();

        private static char Space = '_';

        public string GetDiamondPrint(char letter)
        {
            var indexOfMidpointLetter = Array.IndexOf(Alphabet, letter);

            if (indexOfMidpointLetter == 0)
            {
                return letter.ToString();
            }

            var stringBuilder = new StringBuilder();

            for (int currentLetterIndex = 0; currentLetterIndex <= indexOfMidpointLetter; currentLetterIndex++)
            {
                stringBuilder.Append(new string(Space, indexOfMidpointLetter - currentLetterIndex));

                if (currentLetterIndex == 0)
                {
                    stringBuilder.Append(Alphabet[currentLetterIndex]);
                }
                else
                {
                    var previousLetterIndex = currentLetterIndex - 1;
                    stringBuilder.Append(Alphabet[currentLetterIndex]);
                    stringBuilder.Append(new string(Space, currentLetterIndex + previousLetterIndex));
                    stringBuilder.Append(Alphabet[currentLetterIndex]);
                }

                stringBuilder.Append(new string(Space, indexOfMidpointLetter - currentLetterIndex));
                stringBuilder.AppendLine();
            }

            // passed midpoint, going to build bottom of the diamond

            for (int currentLetterIndex = indexOfMidpointLetter - 1; currentLetterIndex >= 0; currentLetterIndex--)
            {
                if (currentLetterIndex == 0)
                {
                    stringBuilder.Append(new string(Space, indexOfMidpointLetter));
                    stringBuilder.Append(Alphabet[0]);
                    stringBuilder.Append(new string(Space, indexOfMidpointLetter));
                }
                else
                {
                    stringBuilder.Append(new string(Space, currentLetterIndex));
                    stringBuilder.Append(Alphabet[currentLetterIndex]);
                    stringBuilder.Append(new string(Space, currentLetterIndex));
                    stringBuilder.Append(Alphabet[currentLetterIndex]);
                    stringBuilder.Append(new string(Space, currentLetterIndex));
                }

                if (currentLetterIndex != 0)
                {
                    stringBuilder.AppendLine();
                }
            }

            return stringBuilder.ToString();
        }
    }
}
