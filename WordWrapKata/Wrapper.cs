namespace WordWrapKata
{
    public class Wrapper
    {
        public static string Wrap(string inputText, int columnNumber)
        {
            string result = "";
            string currentText = inputText;
            var breakPosition = columnNumber;
            if (string.IsNullOrEmpty(currentText))
                return currentText;

            if (inputText.Length <= columnNumber)
                return inputText.Trim();

            var indexOf = inputText.IndexOf(" ");

            if (indexOf != -1 && indexOf <= columnNumber)
            {
                breakPosition = indexOf;
            }
            else if (indexOf <= -1)
            {
                breakPosition = columnNumber;
            }

            result += currentText.Trim().Substring(0, breakPosition) + "\n" + Wrap(currentText.Trim().Substring(breakPosition), columnNumber);
            result = result.Trim();
            return result;
        }

    }
}
