using System;

class MainClass {
  public static void Main (string[] args) {
    
    Employee Default = new Employee();
    Default.Intro();

    Employee one = new Employee("Robert", "Downey", "12321", 12, 100);
    one.Intro();

    Employee two = new Employee("John", "Smith", "S0089", 38, 50000);
    two.IncreaseSalary(-2);
    two.RemoveEmployee();

    Employee three = new Employee("Maria", "Lambert", "26", 26, 80000);
    three.IncreaseSalary(7);
    three.RemoveEmployee();
    three.RemoveEmployee();

    Console.WriteLine ("Hello World");
  }
}