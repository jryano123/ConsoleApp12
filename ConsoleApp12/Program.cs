using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        
        using (StreamReader reader = new StreamReader("C:\\Users\\Administrator\\Desktop\\VB.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

        
        using (StreamWriter writer = File.AppendText("C:\\Users\\Administrator\\Desktop\\VB.txt"))
        {
            string message = "This is my streamwriter logging details " + DateTime.Now.ToString() + ".";
            writer.WriteLine(message);
        }

        Console.WriteLine("Logs written successfully.");
        Console.ReadKey();
    }
}