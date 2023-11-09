using System.Xml.Linq;
using Task_6.DTo;


Console.Write("Task  number 2\n");
Console.Write("Enter choose according to the number of tasks  :");

int secim_et = int.Parse(Console.ReadLine());
switch (secim_et)
{

    case 1:
        int[] arr1 = new int[5];
        int[] arr2 = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Enter the {i + 1} th row ");
            
            arr1[i] = int.Parse(Console.ReadLine());
           

        }
        for(int j= 0; j < 5; j++)
        {
            Console.WriteLine($"Enter the {j + 1} th row ");
            Console.Write("arr2:");
            arr2[j] = int.Parse(Console.ReadLine());
        }
        IsArrayContains(arr1, arr2);
        static void IsArrayContains(int[] arr1, int[] arr2)
        {
            foreach (int a in arr1)
            {
                foreach (int b in arr2)
                {
                    if (a == b)
                    {

                        Console.WriteLine($"{a} the number of items together ");


                        break;

                    }
                   
                }
            }
        }
        break;
    case 2:
        List<User> users = new List<User>
        {
            new User
            {
            Id= Guid.NewGuid(),
            Name = "Johns",
            SurName = "Dose",
            UserName = "johndoe34",
            Password = "secret56"
            },
            new User
            {
             Id= Guid.NewGuid(),
             Name = "Johni",
            SurName = "Dsoe",
            UserName = "johndoe23",
            Password = "secret3"
            },
            new User
            {
            Id = Guid.NewGuid(),
            Name = "John",
            SurName = "Doe",
            UserName = "johndoe34",
            Password = "secret2"
            },
            new User
            {
            Id = Guid.NewGuid(),
            Name = "John",
            SurName = "Doe",
            UserName = "johndoe2367",
            Password = "secret1"
            }
        };
        List<Student> students = new List<Student>()
{

     new Student
            {
            Id = Guid.NewGuid(),
            Name = "John",
            SurName = "Doe",
            UserName = "johndoe237",
            Password = "secret1",
            Grade="7y"
            },
      new Student
            {
            Id = Guid.NewGuid(),
            Name = "John",
            SurName = "Doe",
            UserName = "johndoe34",
            Password = "secret2",
            Grade="7d"
            },
       new Student
            {
            Id = Guid.NewGuid(),
            Name = "John",
            SurName = "Doe",
            UserName = "johndoe267",
            Password = "secret1",
            Grade="12a"
            },
};


        Console.WriteLine("Enter your username and password:");
        Console.Write("UserName: ");
        string inputUserName = Console.ReadLine();
        Console.Write("Password: ");
        string inputPassword = Console.ReadLine();

        User foundUser = users.Find(user => user.UserName == inputUserName && user.Password == inputPassword);
        Student foundStudent = students.Find(student => student.UserName == inputUserName && student.Password == inputPassword);

        if (foundUser != null && foundStudent != null)
        {
            Console.Write("Loading...");
            await Task.Delay(1000);
            Console.WriteLine($"\nStudent's information:\n" +
                              $"Student ID: {foundStudent.Id}\n" +
                              $"Student Name: {foundStudent.Name}\n" +
                              $"Student Surname: {foundStudent.SurName}\n" +
                              $"Student Grade: {foundStudent.Grade}");
        }
        else
        {
            Console.WriteLine("User or student not found with the provided credentials.");
        }

        break;
    default:
        Console.Write("Enter eded according to the task number!");
        break;


}




