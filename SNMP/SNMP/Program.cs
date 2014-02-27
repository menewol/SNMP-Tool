using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNMP
{
    class Program
    {
        static SnmpServices snmp;

        static void Main(string[] args)
        {
            Console.Title = "SNMP Tool";

            Console.WriteLine("For further information please enter help...\n");

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
            
            /* community string soll bei jedem befehl extra eingegeben werden */
            switch (command_arr[0])
            {
                case "get":
                {
                    snmp.Get(command_arr[1], "oid");
                    break;
                }

                case "getNext":
                {
                    snmp.GetNext(command_arr[1]);
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
                    snmp.ListenForTraps();
                    break;
                }

                case "help":
                {
                    /* wenn nachher noch parameter sind, dann checken ob ein befehl dahinter steht *
                     * dann nämlich befehl plus alle paramter genauer erklären */
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

                default:
                {
                   Console.WriteLine("Invalid command.\n"); 
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
