// Якубовський Владислав, РІ-11, АП, ЛР 8.2
namespace AP_Lab_08_2
{
    public class Lab_08_2
    {
        public static string ChangeString(string stringToChange, out bool error)
        {
            bool isBracketOpened = false; error = false;

            string changedString = "";

            for (int ii = 0; ii < stringToChange.Length; ii++)
            {
                if (stringToChange[ii] == '(')
                {                    
                    if (isBracketOpened)
                    {
                        changedString = "ERROR!";

                        error = true;

                        break;
                    }

                    isBracketOpened = true;

                    continue;
                }

                else if (stringToChange[ii] == ')')
                {
                    if (isBracketOpened) isBracketOpened = false;

                    continue;
                }
                
                else if (!isBracketOpened) changedString += stringToChange[ii];
            }

            return changedString;
        }

        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            Console.Write("Введіть рядок: ");

            string stringToChange = Console.ReadLine()!;

            string changedString = ChangeString(stringToChange, out bool error);

            if (error) Console.WriteLine("Помилка! Всередині дужок не може бути інших дужок!");

            else Console.WriteLine($"Змінений вами рядок: {changedString}");
        }
    }
}