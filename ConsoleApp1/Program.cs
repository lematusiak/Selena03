using System.Data;

var employee1 = new Employee("Ola", "Ol", 33);
var employee2 = new Employee("Ina", "In", 41);
var employee3 = new Employee("Eza", "Ez", 52);

var employees = new List<Employee> { employee1, employee2, employee3 };

employee1.AddGrade(1);
employee1.AddGrade(7);

employee2.AddGrade(0);
employee2.AddGrade(3);

employee3.AddGrade(5);
employee3.AddGrade(8);

var employeeWithMaxScore = GetEmployeeWithMaxScore(employees);

Console.WriteLine($"Najlepsza: {employeeWithMaxScore.Name} {employeeWithMaxScore.Surname} {employeeWithMaxScore.Result} punktów");
Console.ReadKey();

static Employee GetEmployeeWithMaxScore(List<Employee> employees)
{
    var maxResult = 0;
    Employee employeeWithMaxScore = null;

    foreach (var employee in employees)
    {
        maxResult = Math.Max(employee.Result, maxResult);
        if (maxResult == employee.Result)
        {
            employeeWithMaxScore = employee;
        }
    }
    return employeeWithMaxScore;
}



public class Employee
{
    private List<int> grades = new();

    public Employee(string name, string surname, int age)
    {
        Name = name;
        Surname = surname;
        Age = age;
    }

    public string Name { get; private set; }
    public string Surname { get; private set; }

    public int Age { get; private set; }
    public int Result
    {
        get
        {
            return grades.Sum();
        }
    }
    public void AddGrade(int grade)
    {
        grades.Add(grade);
    }


}