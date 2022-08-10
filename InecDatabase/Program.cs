namespace InecDatabase
{

        internal class Program
        {
            static void Main(string[] args)
            {
                void CheckVoterDatabase()
                {

                        SortedDictionary<string, int> myDictionary = new SortedDictionary<string, int>();

                var votersName = new List<string>
                {
                    "mahfooz abubakar", "will smith", "michael lubarton","mahfooz abubakar",
                     "abayomi oyaifo","kolawole smith", "bola hungbe", "mahfooz abubakar", "abayomi oyaifo", "abayomi oyaifo"

                };


             
                   HashSet<string> sortedName = votersName.ToHashSet(); // Prevent duplicate entry by using hashsets

                foreach (string name in sortedName)
                        {
                            int number = votersName.Count(x => x == name);
                            myDictionary.Add(name, number);
                        }


                try // Prevent system crash with exception message 
                {
                    foreach (var item in myDictionary)
                    {
                        if (item.Value == 1)
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine($"Registration {item.Key} was entered {item.Value} times");
                        }
                    }

                    Console.WriteLine("Enter Candidate Information");
                    string? newRegistration = Console.ReadLine();
                        newRegistration.ToLower(); //Convert new entries to lowercase for correctness
                    if (myDictionary.ContainsKey(newRegistration)) // Check if registration alerady exists
                    {
                        Console.WriteLine("Warning! Multiple Entry.");
                    }
                    else
                    {
                        votersName.Add(newRegistration);
                        Console.WriteLine("Registration Successful");

                    }

                }
                catch (Exception errorMessage)
                {

                    Console.WriteLine(errorMessage.Message);
                }





                }
                CheckVoterDatabase();
            }

        }
}
