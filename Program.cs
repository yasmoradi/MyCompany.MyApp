using Humanizer;

Console.Write("Enter a number: ".ToUpperCase());
if (int.TryParse(Console.ReadLine(), out int number))
{
    Console.WriteLine(number.ToWords());
    Console.WriteLine(DateTime.Today.AddDays(-number).Humanize());
}
else
{
    Console.WriteLine("Invalid number.");
}


public static class StringExtensions
{
    extension(string str)
    {
        public string ToUpperCase()
        {
            return str.ToUpper();
        }
    }
}
