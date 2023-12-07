// 2 temprature conversion
using System;
using System.Windows.Forms;
class FahrenheitToCelsius
{
    static void Main(string[] args)
    {
        Console.Write("Enter temp in Fahrenheit: ");
        string input = Console.ReadLine();
        // if (double.TryParse(input, out double Fahrenheit)){
        double Fahrenheit = (double)input; // remove
        double Celsius = (Fahrenheit - 32) * 5 / 9;

        MessageBox.Show($"Fahrenheit: {Fahrenheit}\n Celsius: {Celsius}", "Temp Conversion");
        Console.ReadLine();
        // }
        // else{
        //     MessageBox.Show("Invalid input", "Error");
        // }
    }
    static void Dialog()
    {
        DialogResult res = MessageBox.Show("Msg","Title", MessageBoxButtons.OKCancel,
MessageBoxIcon.Information);
        if (res == DialogResult.OK)
        {
            MessageBox.Show("Ok Button");
            //Some task...
        }
        if (res == DialogResult.Cancel)
        {

            MessageBox.Show("Cancel Button");
            //Some task...
        }
    }
}

