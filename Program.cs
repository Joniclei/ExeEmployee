using System;
using Funcionarios.Entities;

namespace Funcionarios;

class Program
{
  static void Main(string[] args)
  {
    List<Employee> funcionario = new List<Employee>();

    Console.Write("Enter the number of employees:");
    int qt = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <= qt; i++)
    {
      Console.WriteLine($"Employee {i} data:");
      Console.Write("Outsourced (y/n):");
      string a = Console.ReadLine();

      Console.Write("Name:");
      string name = Console.ReadLine();
      Console.Write("Hours");
      int hours = Convert.ToInt32(Console.ReadLine());
      Console.Write("Value por Hour");
      double valuePerHour = Double.Parse(Console.ReadLine());
      if(a == "y"){
        Console.Write("Additional charge");
        double additionalcharge = Double.Parse(Console.ReadLine());
        funcionario.Add(new Outsourcedemployee(name,hours,valuePerHour,additionalcharge));
      }
      else{
        funcionario.Add(new Employee(name,hours,valuePerHour));
      }
    }
    Console.WriteLine("");
    Console.WriteLine("Employees");
    foreach(var x in funcionario)
    {
      Console.WriteLine($"{x.Name},  {x.Payment().ToString("f2")}");
    }


  }
}
