namespace DictionaryCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Dictionary<string, string> RaindeerNames = new Dictionary<string, string>();
            Dictionary<string, Int16> RaindeerNumber = new Dictionary<string, Int16>();
            Dictionary<string, float> SalaryCarrots = new Dictionary<string, float>(5);




            RaindeerNames.Add("Rudolf", "One");
            RaindeerNames.Add("Dancer", "Seven");
            RaindeerNames.Add("Blitzen", "Four");
            RaindeerNames.Add("Prancer", "Five");
            RaindeerNames.Add("Cupid", "Two");
                



            Console.WriteLine("Raindeer Names List:");
            Dictionary<string, string>.KeyCollection key = RaindeerNames.Keys;
            foreach (string d in key)
            {
                Console.WriteLine("Name: {0}", d);
            }
            Console.WriteLine();



            Console.WriteLine("Raindeer Positions:");
            Dictionary<string, string>.ValueCollection values = RaindeerNames.Values;
            foreach (string r in values)
            {
                Console.WriteLine("Number Position: {0}", r);
            }
            Console.WriteLine();

            Console.WriteLine("Raindeer Name Name/Positiion:");
            foreach (KeyValuePair<string, string> kvp in RaindeerNames)
            {
                Console.WriteLine($"Name: {kvp.Key}  Number Position: {kvp.Value}");
            }
            Console.WriteLine();




            RaindeerNames["Rudolf"] = "One";
            RaindeerNames["Prancer"] = "Five";
            RaindeerNames.Remove("Dancer");



            Console.WriteLine("Revised List of Raindeer Names/Positions:");
            foreach (KeyValuePair<string, string> kvp in RaindeerNames)
            {
                Console.WriteLine($"Name: {kvp.Key}  Position: {kvp.Value}");
            }
            Console.WriteLine();


            RaindeerNumber.Add("Sloppy Joe", 8);
            RaindeerNumber.Add("Shimmer", 9);
            RaindeerNumber.Add("Dexter", 10);
            RaindeerNumber.Add("Polly", 11);



            bool RainDept = true;
            while (RainDept)
            {
                Console.WriteLine("Enter the Raindeer Name you want on the team:");
                string RainName = Console.ReadLine();
                if (RaindeerNumber.ContainsKey(RainName))
                {
                    RaindeerNumber.Remove(RainName);
                }
                Console.WriteLine("Enter the Position number you wish to add them to:");
                Int16 RainNum = Int16.Parse(Console.ReadLine());
                RaindeerNumber.Add(RainName, RainNum);
                Console.WriteLine("Your Raindeer has been added");
                Console.WriteLine("Add another Raindeer? (y for yes, any key for no)");
                string answer = Console.ReadLine();
                if (answer == "y")
                    continue;
                else
                    RainDept = false;

            }


            Console.WriteLine($"There are {RaindeerNumber.Count} on the sleigh team :)");
            foreach (KeyValuePair<string, Int16> kvp in RaindeerNumber)
            {
                Console.WriteLine($"Department Name: {kvp.Key}   Number: {kvp.Value}");
            }
            Console.WriteLine();



            SalaryCarrots.Add("Rodulf", 60);
            SalaryCarrots.Add("Prancer", 61);
            SalaryCarrots.Add("Blitzen", 62);
            SalaryCarrots.Add("Shimmer", 65);



            Console.WriteLine("Salaries for different positions");
            foreach (KeyValuePair<string, float> kvp in SalaryCarrots)
            {
                Console.WriteLine($"Position: {kvp.Key}   Carrots: " + (kvp.Value));
            }
            Console.WriteLine();


        }

    }
}
