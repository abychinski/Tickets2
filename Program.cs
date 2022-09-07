using System;
using System.IO;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;

internal class Program
{
    private static string wat;

    public static string JSwat { get; private set; }
    public static string DK { get; private set; }
    public static string JS { get; private set; }
    public static string BJ { get; private set; }

    private static void Main(string[] args)
    {
        string file = "ticket.csv";
        string choice;




        do
        {

            Console.WriteLine("1) Read data from file.");
            Console.WriteLine("2) Create file from data.");
            Console.WriteLine("Enter any other key to exit.");

            choice = Console.ReadLine();

            if (choice == "1")
            {

                if (File.Exists(file))
                {

                    StreamReader sr = new StreamReader(file);
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();

                        string[] arr = line.Split(',');

                        Console.WriteLine(arr[0]);
                        Console.WriteLine(arr[1]);
                        Console.WriteLine(arr[2]);
                        Console.WriteLine(arr[3]);
                        Console.WriteLine(arr[4]);
                        Console.WriteLine(arr[5]);
                        Console.WriteLine(arr[6]);


                    }

                }
                else
                {
                    Console.WriteLine("File does not exist");
                }
            }
            else if (choice == "2")
            {

                StreamWriter sw = new StreamWriter(file);
                sw.WriteLine("TicketID, Summary, Status, Priority, Submitter, Assigned, Watching");
                for (int i = 0; i < 8; i++)
                {

                    Console.WriteLine("Enter a ticket? (Y/N)?");

                    string resp = Console.ReadLine().ToUpper();

                    if (resp != "Y") { break; }

                    Console.WriteLine("What is the ticket ID?");

                    string id = Console.ReadLine();

                    Console.WriteLine("Enter the Ticket summary");

                    string sum = Console.ReadLine();
                    Console.WriteLine("Enter the ticket status");
                    string stat = Console.ReadLine();

                    Console.WriteLine("What is the priority?");
                    string pri = Console.ReadLine();

                    Console.WriteLine("Who submitted the ticket?");
                    string sub = Console.ReadLine();

                    Console.WriteLine("Who is assigned to the ticket?");
                    string ass = Console.ReadLine();



                    Console.WriteLine("Who is watching the ticket?");
                    Console.WriteLine("Is Drew Kjell is watching? Select DK");
                    Console.WriteLine("Is John Smith is watching? Select JS");
                    Console.WriteLine("Is Bill Jones is watching? BJ");

                    string DK = Console.ReadLine().ToUpper();
                    if (DK == "DK")
                    {

                        wat = "Drew Kjell";

                    }
                    else if (DK == "JS")
                    {
                        wat = "John Smith";

                    }
                    else if (DK == "BJ")
                    {
                        wat = "Bill Jones";
                    }

                    sw.WriteLine("{0},{1},{2},{3},{4},{5},{6}", id, sum, stat, pri, ass, sub, wat);

                }
                sw.Close();
            }
        } while (choice == "1" || choice == "2");
    }
}