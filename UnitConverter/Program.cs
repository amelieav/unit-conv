<<<<<<< Updated upstream
﻿using System;
=======
﻿// Program.cs
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
>>>>>>> Stashed changes

public class HelloWorld
{
    public static void Main(string[] args)
    {
<<<<<<< Updated upstream

        int windowWidth = Console.WindowWidth;
        string[] lines = new string[] 
        {
            " █    ██  ███▄    █  ██▓▄▄▄█████▓ ▄████▄   ▒█████   ███▄    █ ██▒   █▓",
            " ██  ▓██▒ ██ ▀█   █ ▓██▒▓  ██▒ ▓▒▒██▀ ▀█  ▒██▒  ██▒ ██ ▀█   █▓██░   █▒",
            "▓██  ▒██░▓██  ▀█ ██▒▒██▒▒ ▓██░ ▒░▒▓█    ▄ ▒██░  ██▒▓██  ▀█ ██▒▓██  █▒░",
            "▓▓█  ░██░▓██▒  ▐▌██▒░██░░ ▓██▓ ░ ▒▓▓▄ ▄██▒▒██   ██░▓██▒  ▐▌██▒ ▒██ █░░",
            "▒▒█████▓ ▒██░   ▓██░░██░  ▒██▒ ░ ▒ ▓███▀ ░░ ████▓▒░▒██░   ▓██░  ▒▀█░  ",
            "░▒▓▒ ▒ ▒ ░ ▒░   ▒ ▒ ░▓    ▒ ░░   ░ ░▒ ▒  ░░ ▒░▒░▒░ ░ ▒░   ▒ ▒   ░ ▐░  ",
            "░░▒░ ░ ░ ░ ░░   ░ ▒░ ▒ ░    ░      ░  ▒     ░ ▒ ▒░ ░ ░░   ░ ▒░  ░ ░░  ",
            " ░░░ ░ ░    ░   ░ ░  ▒ ░  ░      ░        ░ ░ ░ ▒     ░   ░ ░     ░░  ",
            "   ░              ░  ░           ░ ░          ░ ░           ░      ░  ",
            "                                 ░                                ░   "
        };

        Console.ForegroundColor = ConsoleColor.Red;      
        foreach (string line in lines)
        {
            int leftPadding = (windowWidth / 2) - (line.Length / 2);
            string padding = new string(' ', leftPadding);
            Console.WriteLine(padding + line);
        }

                         
        
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine ("Welcome to the Unit Converter!");

        Console.WriteLine("What would you like to convert?");
        Console.WriteLine("1. Inches to Centimeters");
        Console.WriteLine("2. Centimeters to Inches");
        string choice = Console.ReadLine();

        // Declare variable to store the result
        double result = 0.0;

        switch (choice)
        {
            case "1":
                Console.WriteLine("Enter the length in inches:");
                string inchesStr = Console.ReadLine();
                if (inchesStr != null && double.TryParse(inchesStr, out double inches))
                {
                    result = inches * 2.54;
                    Console.WriteLine($"The length in centimeters is: {result} cm");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
                break;

            case "2":
                Console.WriteLine("Enter the length in centimeters:");
                string cmStr = Console.ReadLine();
                if (cmStr != null && double.TryParse(cmStr, out double cm))
                {
                    result = cm / 2.54;
                    Console.WriteLine($"The length in inches is: {result} inches");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }





        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine ("Press any key to exit...");
        Console.ReadKey();
    }


    
}
=======
        string input = Console.ReadLine(); // Read JSON input from Electron
        JObject jObject = JObject.Parse(input);
        string action = jObject.Value<string>("action");
        
        JObject response = new JObject();

        if (action == "InchesToCM")
        {
            double inches = jObject.Value<double>("value");
            double cm = inches * 2.54;
            response["result"] = cm;
        }
        else if (action == "CMToInches")
        {
            double cm = jObject.Value<double>("value");
            double inches = cm / 2.54;
            response["result"] = inches;
        }

        string output = JsonConvert.SerializeObject(response);
        Console.WriteLine(output); // Send JSON output to Electron
    }
}
>>>>>>> Stashed changes
