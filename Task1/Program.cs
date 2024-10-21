string currentDirectory = Directory.GetCurrentDirectory();
string filePath = Path.Combine(currentDirectory, "output.txt");

Console.WriteLine("Enter a number of how many lines you are going to enter");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    File.AppendAllText(filePath, input + Environment.NewLine);
}

string lastLine = File.ReadLines(filePath).Last();
Console.WriteLine(lastLine);


