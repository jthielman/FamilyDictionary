using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>
            {
                { "older sister", new Dictionary<string, string>() { { "name", "Emily" }, { "age", "37" } } },
                { "younger sister", new Dictionary<string, string>() { { "name", "Anne" }, { "age", "30" } } },
                { "youngest sister", new Dictionary<string, string>(){ { "name", "Sarah" }, { "age", "27" } } },
                { "mother", new Dictionary<string, string>(){ { "name", "Loretta" }, { "age", "69" } } },
                { "father", new Dictionary<string, string>(){ { "name", "Peter" }, { "age", "71" } } }
            };

            foreach(var familyMember in myFamily)
            {
                var famInfo = familyMember.Value;
                Console.WriteLine($"{famInfo["name"]} is my {familyMember.Key} and is {famInfo["age"]} years old.");
            }
        }
    }
}
