// See https://aka.ms/new-console-template for more information
// Create a new Student object:
using TutorialsPoint;

Student s = new Student();

// Setting code, name and the age of the student
s.Code = "001";
s.Name = "Zara";
s.Age = 9;
Console.WriteLine("Student Info: {0}", s);

//let us increase age
s.Age += 1;
Console.WriteLine("Student Info: {0}", s);
Console.ReadKey();
