using System;

namespace WordWrapKata
{
    public class Wrapper
    {
        public static string Wrap(string inputText, int columnNumber)
        {
            var result = string.Empty;
            var currentText = inputText;
            var breakPosition = columnNumber;
            if (string.IsNullOrEmpty(currentText))
                return currentText;

            if (inputText.Length <= columnNumber)
                return inputText.Trim();

            const string emptySpace = " ";
            var indexOf = inputText.IndexOf(emptySpace,StringComparison.CurrentCulture);

            if (indexOf != -1 && indexOf <= columnNumber)
            {
                breakPosition = indexOf;
            }
            else if (indexOf <= -1)
            {
                breakPosition = columnNumber;
            }

            const string backSlash = "\n";
            result += currentText.Trim().Substring(0, breakPosition) + backSlash + Wrap(currentText.Trim().Substring(breakPosition), columnNumber);
            return result.Trim();
        }
    }
}
