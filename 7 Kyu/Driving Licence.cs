using System;
using System.Globalization;
namespace CodeWars
{
    class Kata
    {
        public string driver (params string[] data)
        {
            string lastName;
            if (data[2].Length > 4) lastName = data[2].Substring(0, 5);
            else
            {
                lastName = data[2];
                const string nine = "9";
                do
                {
                    lastName += nine;
                } while (lastName.Length < 5);
            }
            string decade = data[3].Substring(data[3].Length - 2, 1);
            string month = data[3].Substring(3, 3);
            month = DateTime.ParseExact(month, "MMM", CultureInfo.CurrentCulture).Month.ToString();
            if (month.Length == 1) month = $"0{month}";
            if (data[4].Equals("F"))
            {
                if (month[0].Equals('0')) { month = $"5{month[1]}"; }
                else { month = $"6{month[1]}"; }
            }
            string mi = data[1].Length == 0 ? "9" : data[1].Substring(0, 1);
            return $"{lastName}{decade}{month}{data[3].Substring(0,2)}{data[3].Substring(data[3].Length-1, 1)}{data[0].Substring(0,1)}{mi}9AA".ToUpper();
        }
    }
}