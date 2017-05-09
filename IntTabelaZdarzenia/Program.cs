using IntTabelaZdarzenia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    public delegate void PrintSizeDelegate(object oSender, EventArgs oEventArgs);

    class Program
    {
        public delegate void PrintSizeDelegate(int size);
        public event PrintSizeDelegate PrintSizeEvent;
        static void Main(string[] args)
        {
            int menuChoice = 0;
            int numberToAdd = 0;
            int positionToAdd = 0;
            int positionToDisplay = 0;
            Tabela tabela = new Tabela();
            Program program = new Program();
            

            while (true)
            {
                System.Console.WriteLine("\n***MENU***\n");
                System.Console.WriteLine("1 - Add integer number to table");
                System.Console.WriteLine("2 - Display table");
                System.Console.WriteLine("3 - Exit program");

                menuChoice = Convert.ToInt32(Console.ReadLine());

                while (!(menuChoice != 1 || menuChoice != 2))
                {
                    System.Console.WriteLine("NOOO YOU CAN ONLY TAP 1 OR 2!\n");
                    System.Console.WriteLine("\n***MENU***\n");
                    System.Console.WriteLine("1 - Add integer number to table");
                    System.Console.WriteLine("2 - Display table");
                    System.Console.WriteLine("3 - Exit program");
                    menuChoice = Convert.ToInt32(Console.ReadLine());
                }


                switch (menuChoice)
                {
                    

                    case 1:
                        System.Console.WriteLine("\nInteger: ");
                        numberToAdd = Convert.ToInt32(Console.ReadLine());

                        System.Console.WriteLine("On position: ");
                        positionToAdd = Convert.ToInt32(Console.ReadLine());

                        if (positionToAdd > tabela.Length)
                        {
                            tabela.Resize(positionToAdd);
                            tabela[positionToAdd - 1] = numberToAdd;
                        }
                        else
                            tabela[positionToAdd - 1] = numberToAdd;

                        break;

                    case 2:
                        try
                        {
                            System.Console.WriteLine("Row table to display: ");
                            positionToDisplay = Convert.ToInt32(Console.ReadLine());
                            System.Console.WriteLine("tabela[" + positionToDisplay + "]: " + tabela[positionToDisplay]);
                        }
                        catch (IndexOutOfRangeException)
                        {
                            System.Console.WriteLine("Sorry! Your index is out of boundary!");
                        }
                        break;

                    case 3:
                        Environment.Exit(0);
                        break;

                    default:
                        System.Console.WriteLine("You tap sth different");
                        break;
                }

            }
        }



        protected void PrintSize(int size)
        {
            if (PrintSizeEvent != null)
            {
                System.Console.WriteLine("Table size: " + size);
            }  
        }
    }
}