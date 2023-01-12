
Console.Write("How many courses? ");
int courses = int.Parse(Console.ReadLine());
HashSet<int> studentsSet = new HashSet<int>();

for (int i = 0; i < courses; i++)
{
    char letter = (char)('A' + i);
    Console.Write($"How many students for course {letter}? ");
    int students = int.Parse(Console.ReadLine());
    for (int j = 0; j < students; j++)
    {
        studentsSet.Add(int.Parse(Console.ReadLine()));
    }
}

System.Console.WriteLine($"Total students: {studentsSet.Count}");