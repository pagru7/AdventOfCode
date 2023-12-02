namespace AoC._2023.Day01
{
    public class Trebuchet
    {
        public int Calibrate(string[] inputs)
        {
            int result = 0;
            foreach (var input in inputs)
            {
                result += Calibrate(input);
            }
            return result;
        }

        public int Calibrate(string input)
        {
            char? firstDigit = null;
            char? lastDigit = null;

            int firstFoundIndex = -1;

            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    firstDigit = input[i];
                    firstFoundIndex = i;
                    break;
                }
            }

            if (firstFoundIndex == -1)
            {
                return 0;
            }

            for (int i = input.Length - 1; i >= firstFoundIndex; i--)
            {
                if (char.IsDigit(input[i]))
                {
                    lastDigit = input[i];
                    break;
                }
            }

            return lastDigit == null
                    ? int.Parse($"{firstDigit}{firstDigit}")
                    : int.Parse($"{firstDigit}{lastDigit}");
        }
    }
}