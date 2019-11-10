using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Roshambo
{
    class Function
    {

        public static int RandomNumber()
        {
            Random random = new Random();
            return random.Next(1, 4);
        }

        public static void pause(int x)
        {
            x = x * 1000 / 4;
            Thread.Sleep(x);
        }

        /*static void textFiles()
        {
            // save the file path as a string variable
            string filePath = @"D:\code\c-sharp\Roshambo\Roshambo\data.txt";

            // create person object array
            List<Person> people = new List<Person>();
            // create text file line array
            List<string> lines = File.ReadAllLines(filePath).ToList();
            // split each word at the , and save it into an array
            foreach (string line in lines)
            {
                string[] entries = line.Split(',');

                // Create person object and populate the data
                Person newPerson = new Person();

                newPerson.FirstName = entries[0];
                newPerson.MiddleName = entries[1];
                newPerson.LastName = entries[2];
                newPerson.Age = entries[3];
                newPerson.MoreInfo = entries[4];
                // Add person object to people array
                people.Add(newPerson);
            }
            // List all the objects in people array to console
            foreach (var person in people)
            {
                Console.WriteLine($" {person.FirstName} {person.MiddleName} {person.LastName}: {person.Age}");
                Console.WriteLine("\t^" + person.MoreInfo);
            }
            // Add a new person object to people array
            people.Add(new Person { FirstName = "Fish", MiddleName = "in", LastName = "tank", Age = "2", MoreInfo = "So purdy" });
            // Create new array for storing people data in a csv exportable format
            List<string> output = new List<string>();
            foreach (var person in people)
            {
                // This is the comma seperated format
                output.Add($"{person.FirstName},{person.MiddleName},{person.LastName},{person.Age},{person.MoreInfo}");
            }
            Console.WriteLine("Writing to file...");
            // Overwrite text file with new data
            File.WriteAllLines(filePath, output);

            Console.WriteLine("Complete");*/


        /*
        File.ReadAllLines(filePath);
        List<string> lines = File.ReadAllLines(filePath).ToList(); // Read from text file

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

        lines.Add("Boss Tacular Prime, 7, Boss ahhaaa");

        File.WriteAllLines(filePath, lines); // Write to a text file
    }*/



    }


}
