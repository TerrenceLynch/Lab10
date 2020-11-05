using System;

class Employee {
  private string firstname;
  private string lastname;
  private string id;
  private int age;
  private string address;
  private string phonenumber;
  private string title;
  private double yearlysalary;
  private string employeestatus;

 public string FirstName {get; set;}
 public string LastName {get; set;}
 public int Age  
          {get{return age;} set{if (value >= 18) age = value; else  {age = 18;} } }
 public double YearlySalary
 {get{return yearlysalary;}
  set{if (value >= 1000) 
     yearlysalary = value;
      else
      {yearlysalary = 1000;}}}
 public string Id {get; set;}
 public string EmployeeStatus {get; set;}

  public Employee()
  {
   FirstName = "unknown";
   LastName = "unknown";
   Id = "0";
   Age = 0;
   YearlySalary = 0;
   employeestatus = "active";
  }

  public Employee(string myFirstName, string myLastName, string myId, int myAge, double myYearlySalary)
  {
    FirstName = myFirstName;
    LastName = myLastName;
    Id = myId;
    Age = myAge;
    YearlySalary = myYearlySalary;
    employeestatus = "active";
   }



  public void Intro()
  {
    Console.WriteLine("Firstname: " + FirstName);
    Console.WriteLine("Lastname: " + LastName);
    Console.WriteLine("Id: " + Id);
    Console.WriteLine("Age:" + Age);
    Console.WriteLine("Salary: " + YearlySalary);
  }

  public void IncreaseSalary(double Precent)
  {
    if (Precent >= 0 && Precent <= 100)
    {YearlySalary = (YearlySalary + (YearlySalary * (Precent / 100)));
    Console.WriteLine("The new salary is $" + YearlySalary + " it is a " + Precent + "% increase.");}
    else
    {Console.WriteLine("The Precent value is invalid, Salary has no change as a result.");}
  }

  public void RemoveEmployee()
  {
    if (employeestatus == "inactive")
    {
      Console.WriteLine("Employee is already inactive.");
    }
    else if (employeestatus == "active")
    {
      employeestatus = "inactive";
      Console.WriteLine("Employee has been removed.");
    }
  }

}