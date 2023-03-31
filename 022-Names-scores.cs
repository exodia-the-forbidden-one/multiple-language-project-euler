//P022 Names scores 
string file = "p022_names.txt";
string nametext = File.ReadAllText(file);
string[] names = nametext.Replace("\"", "").Split(",");
Array.Sort(names);

char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

int sumOfNameScores = 0;

for (int i = 0; i < names.Length; i++)
{
    int sum = 0;
    foreach (char c in names[i])
    {
        sum += getAlphabeticalPosition(c);
    }
    sumOfNameScores += (sum * (i + 1));
}

Console.WriteLine(sumOfNameScores); //871198282




int getAlphabeticalPosition(char letter)
{
    return Array.IndexOf(letters, letter) + 1;
}
