// Params Keyword

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        
        double total = checkout(1.244,5.234,7.219,3.421);
        Console.WriteLine(total);
        
        static double checkout(params double[] prices){
            double total = 0;
            
            // foreach(double price in prices){
            //     total += price;
            // }
            
            for(int i = 0; i<prices.Length; i++){
                total += prices[i];
            }
            return total;
        }
        
    }
}
