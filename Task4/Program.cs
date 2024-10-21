using Newtonsoft.Json;
using Task4;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string filePath = Path.Combine(currentDirectory, "birthday.json");
            File.WriteAllText(filePath, "{" + Environment.NewLine +
                "  \"currentDate\": \"June 14 2022\"," + Environment.NewLine +
                "  \"birthday\": \"June 20 2022\"" + Environment.NewLine +
                "}");

            string readJSON = File.ReadAllText(filePath);
            BirthdayInfo birthdaydayInfo = JsonConvert.DeserializeObject<BirthdayInfo>(readJSON);
            DateTime currentDate = DateTime.Parse(birthdaydayInfo.CurrentDate);
            DateTime birthday = DateTime.Parse(birthdaydayInfo.Birthday);

            Console.WriteLine($"{(birthday - currentDate).TotalDays} days left till your birthday");


        }

    }   
}


