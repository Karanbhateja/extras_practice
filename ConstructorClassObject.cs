
using System;

public class employee{
    string name;
    int id;
    int salary;
    
// -------------------- Default Constructor ------------------------
  
    public employee(){
        Console.WriteLine("Default Constructor Invoked");
    }

// -----------------------------------------------------------------
    
// ------------------ Parameterised Constructor --------------------

    public employee(string name, int id, int salary){
        this.name=name;
        this.id=id;
        this.salary=salary;
    }

// -----------------------------------------------------------------
    
// -------------------- Copy Constructor ---------------------------

    public employee(employee e){
        this.name = e.name;
        this.id = e.id;
        this.salary = e.salary;
    }
    
    public void display(){
        Console.WriteLine("Id: " + id + " Name: " + name + " Salary: " + salary);
    }

// -----------------------------------------------------------------
  
// -------------------------Destructor------------------------------

    ~employee(){
        Console.WriteLine("Destructor Invoked");
    }
}

// -----------------------------------------------------------------

public class HelloWorld
{
    public static void Main(string[] args)
    {
        employee e1 = new employee("Rahul", 01 , 300000);
        e1.display();
    }
}
