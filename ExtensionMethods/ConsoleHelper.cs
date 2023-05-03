namespace ExtensionMethods
{
    public static class ConsoleHelper
    {
        public static string RequestString(this string message)
        {
            string output = "";

            while (string.IsNullOrWhiteSpace(output))
            {
                Console.Write(message);
                output = Console.ReadLine();
            }

            return output;
        }



        public static int RequestInt(this string message, int minVal, int maxVal)
        {
            return message.RequestInt(true, minVal, maxVal);
        }

        public static int RequestInt(this string message)
        {
            return message.RequestInt(false);
        }

        private static int RequestInt(this string message, bool useMinMax, int minVal = 0, int maxVal = 0)
        {
            int output = 0;
            bool isValidInt = false;
            bool isInValidRange = true;

            while (isValidInt == false || isInValidRange == false)
            {
                Console.Write(message);
                isValidInt = int.TryParse(Console.ReadLine(), out output);

                if (useMinMax == true)
                {
                    isInValidRange = (output >= minVal && output <= maxVal);
                }
            }

            return output;
        }
    }
}