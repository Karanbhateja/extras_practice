using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        try{
            
            Console.WriteLine ("Enter the First Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
        
            Console.WriteLine ("Enter the Second Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            int result = num1/num2;
            Console.WriteLine ("Result is: " + result);
        }
        catch(FormatException e){
            Console.WriteLine ("Enter NUMBERS Only !!!");
        }
        catch(DivideByZeroException e){
            Console.WriteLine ("You cannot divide by Zero !!");
        }
        catch(Exception e){
            Console.WriteLine ("Something went Wrong !!");
        }
        finally{
            Console.WriteLine ("Thankyou the program is now ended !!");
        }
    }
}
