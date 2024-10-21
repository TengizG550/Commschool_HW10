using System.Xml;

namespace Task3
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Enter a word");
            string inputString = Console.ReadLine() ?? "";
            Console.WriteLine("Enter a number you want to divide string by");
            int n = Convert.ToInt32(Console.ReadLine());
            List<string> parts = DivideStringIntoEqualParts(inputString, n);

            string currentDirectory = Directory.GetCurrentDirectory();
            string filePath = Path.Combine(currentDirectory, "example.xml");

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            using (XmlWriter writer = XmlWriter.Create(filePath, settings)) {
                writer.WriteStartDocument();
                writer.WriteStartElement("root");
                for (int i = 0; i < parts.Count; i++)
                {
                    writer.WriteElementString(parts[i], $"string {i+1}");
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }


        private static List<string> DivideStringIntoEqualParts(string inputString, int partSize)
        { 
            List<string> parts = new List<string>();
   
            for (int i = 0; i < inputString.Length; i += partSize)
            {
                if(i + partSize <= inputString.Length)
                parts.Add(inputString.Substring(i, partSize).Replace(" ", "_"));
                else parts.Add(inputString.Substring(i).Replace(" ","_"));
            }
            return parts;
        }
    }
}


