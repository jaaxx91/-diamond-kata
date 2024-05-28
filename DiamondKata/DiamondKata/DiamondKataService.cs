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

            for (int i = 0; i <= indexOfMidpointLetter; i++)
            {
                stringBuilder.Append(new string(Space, indexOfMidpointLetter - i));

                if (i == 0)
                {
                    stringBuilder.Append(Alphabet[i]);
                }
                else
                {
                    stringBuilder.Append(Alphabet[i]);
                    stringBuilder.Append(new string(Space, indexOfMidpointLetter));
                    stringBuilder.Append(Alphabet[i]);
                }

                stringBuilder.Append(new string(Space, indexOfMidpointLetter - i));
                stringBuilder.AppendLine();
            }

            for (int i = indexOfMidpointLetter; i > 0; i--)
            {
                stringBuilder.Append(new string(Space, i));
                stringBuilder.Append(Alphabet[i-1]);
                stringBuilder.Append(new string(Space, i));

                if (i-1 != 0)
                {
                    stringBuilder.AppendLine();
                }
            }

            return stringBuilder.ToString();
        }
    }
}
