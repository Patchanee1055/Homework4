using System;

namespace HomeworkWeek9
{
    class Program
    {
        static bool IsValidSequence(string halfDNASequence)
        {
            foreach (char nucleotide in halfDNASequence)
            {
                if (!"ATCG".Contains(nucleotide))
                {
                    return false;
                }
            }
            return true;
        }
        static string ReplicateSequence(string halfDNASequence)
        {
            string result = "";
            foreach (char nucleotide in halfDNASequence)
            {
                result += "TAGC"["ATCG".IndexOf(nucleotide)];
            }
            return result;
        }
        static void Main(string[] args)
        {
            string DNA;
            bool IsValid;
            int x = 1;
            while (x == 1)
            {
                Console.Write("Input DNA:");
                DNA = Console.ReadLine();
                IsValid = IsValidSequence(DNA);
                if (IsValid == true)
                {
                    Console.WriteLine("Current half DNA sequence:{0}", DNA);
                    Console.WriteLine("Do you want to replicate it? (Y/N):");
                    Char Ans = Char.Parse(Console.ReadLine());
                    int y = 1;
                    while (y == 1)
                    {
                        if (Ans == 'Y')
                        {
                            string Ans2;
                            Ans2 = ReplicateSequence(DNA);
                            Console.WriteLine("Replicated half DNA sequence:{0}", Ans2);
                        }
                        y = 2;
                        if (Ans == 'N')
                        {
                            y = 2;
                        }
                        else
                        {
                            Console.WriteLine("Please input Y or N.");
                            Ans = Char.Parse(Console.ReadLine());
                        }
                    }
                }
                if (IsValid == false)
                {
                    Console.WriteLine("That half DNA sequence is invalid.");
                }
                Console.WriteLine("Do you want to process another sequence ? (Y/N)");
                Char Ans3 = Char.Parse(Console.ReadLine());
                int z = 1;
                while (z == 1)
                {
                    if (Ans3 == 'Y')
                    {
                        z = 2;
                    }
                    else if (Ans3 == 'N')
                    {
                        z = 2;
                        x = 2;
                    }
                    else
                    {
                        Console.WriteLine("Please input Y or N.");
                        Ans3 = char.Parse(Console.ReadLine());
                    }
                }
            }
            Console.ReadLine();
        }
    }
}