using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNMP
{
    class Program
    {
        static Snmp snmp;

        static void Main(string[] args)
        {
            Console.Title = "SNMP Tool";
            Console.Write("Geben Sie einem Community String ein: ");
            
            snmp = new Snmp(Console.ReadLine());
            Console.WriteLine("Community String ist jetzt: " + snmp.CommunityName + "\n");
            Console.WriteLine("Zum Ändern oder sonstige Hilfen geben Sie 'help' ein\n");

            /* listen for SNMP-commands */
            while (true)
            {
                Console.Write("SNMP> ");
                DoCommand(Console.ReadLine());                
            }
        }

        private static void DoCommand(string command)
        {
            string[] command_arr = command.Split(' ');

            switch (command)
            {
                case "get":
                {
                    break;
                }

                case "getNext":
                {
                    break;
                }

                case "getBulk":
                {
                    break;
                }

                case "set":
                {
                    break;
                }
                    
                case "listen":
                {                 
                    break;
                }

                case "help":
                {
                    ShowCommands();
                    break;
                }

                case "clear":
                {
                    Console.Clear();
                    break;
                }

                case "close":
                {
                    Environment.Exit(0);
                    break;
                }
            }
        }

        private static void ShowCommands()
        {
            Console.WriteLine("\nget                                Abfrage eines Datensatzes");
            Console.WriteLine("getNext                            Abfrage des nächsten Datensatzes");
            Console.WriteLine("getBulk                            Abfrage von mehreren Datensätzen");
            Console.WriteLine("set                                Bearbeiten eines Datensatzes");
            Console.WriteLine("listen                             Hören nach Trap-Nachrichten");
            Console.WriteLine("clear                              Löschen des Bildschirminhaltes");
            Console.WriteLine("close                              Beenden der Anwendung\n");
        }
    }
}
