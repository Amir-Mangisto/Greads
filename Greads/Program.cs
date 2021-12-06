using Greads;

List<Proffesor> proffesors = new List<Proffesor>();
List<string> studentList = new List<string>();

void ProfessorInfo(List<string> stuList)
{
    Console.WriteLine("ENTER YOUR NAME");
    string proffesorInputName = Console.ReadLine();

    Console.WriteLine($"Hello {proffesorInputName} what do u want to do? \n1. Add Student\n2. Get 1st student info");

    int proffesorPick = int.Parse(Console.ReadLine());
    switch (proffesorPick)
    {
        case 1:
            try
            {
                AddStudent(stuList, proffesorInputName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            break;

        case 2:

            break;
    }
}
ProfessorInfo(studentList);


void AddStudent(List<string> studentList, string proffesorName)
{
    Console.WriteLine("how many student you need");
    int proffesorInputCount = int.Parse(Console.ReadLine());

    for (int i = 0; i < proffesorInputCount; i++)
    {
        Proffesor stu1 = new Proffesor();
        stu1.proffesorName = proffesorName;

        Console.WriteLine("enter student name");
        stu1.studentName = Console.ReadLine();

        Console.WriteLine("enter student id");
        stu1.studentId = int.Parse(Console.ReadLine());

        Console.WriteLine("enter his grads");
        stu1.studentGrade = new int[3];

        for (int j = 0; j < 3; j++)
        {
            Console.WriteLine("enter student grades");
            stu1.studentGrade[j] = int.Parse(Console.ReadLine());
        }
        proffesors.Add(stu1);
        GetReshoma(studentList, stu1);
        SaveToFile();
    }
}

void SaveToFile()
{
    int id = 0;

    foreach (Proffesor proffesor in proffesors)
    {
        FileStream proffesorList = new FileStream(@$"C:\Test\{proffesor.proffesorName}.txt", FileMode.Append);
        using (StreamWriter dd = new StreamWriter(proffesorList))
        {
            dd.Write($"id:{id} ,");
            dd.Write($"stuName:{proffesor.studentName} ,");
            dd.Write($"stuid:{proffesor.studentId} ,");
            for (int i = 0; i < proffesor.studentGrade.Length; i++)
            {
                dd.Write(proffesor.studentGrade[i] + ",");
            }
            Console.WriteLine("");
        }
        id++;
    }
}

void GetReshoma(List<string> list, Proffesor obj)
{
    list.Add($"stuName{obj.studentName} , stuId {obj.studentId} , stuGrades{obj.studentGrade[0]},{obj.studentGrade[1]} ,{obj.studentGrade[2]}");
}


//void Getast1Studeninfo(List<string> studentLis, string studentName)

//}
