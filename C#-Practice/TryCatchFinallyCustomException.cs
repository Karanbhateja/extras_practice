using System;

public class invalidAgeException:Exception{
    public invalidAgeException(string message):base(message){}
}

public class HelloWorld
{
    
    public static void validateage(int age){
        if(age<18){
            throw new invalidAgeException("Sorry!! You are Underage");
        }
    }
    
    public static void Main(string[] args)
    {
        // -------------------- Try Block -----------------------------
        try{
            Console.WriteLine ("Enter the First Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
        
            Console.WriteLine ("Enter the Second Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            int result = num1/num2;
            Console.WriteLine ("Result is: " + result);
            
            validateage(12);
        }

        // ------------------ Catch Blocks ----------------------------
        
        catch(FormatException e){
            Console.WriteLine ("Enter NUMBERS Only !!!");
        }
        catch(DivideByZeroException e){
            Console.WriteLine ("You cannot divide by Zero !!");
        }
        catch(invalidAgeException e){
            Console.WriteLine(e);
        }
        catch(Exception e){
            Console.WriteLine ("Something went Wrong !!");
        }

    // -------------------------- Finally Block -----------------------
        
        finally{
            Console.WriteLine ("Thankyou the program is now ended !!");
        }
    }
}