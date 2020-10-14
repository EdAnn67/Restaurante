using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Restaurant Ticket0 = new Restaurant();
            int Option, Opt;
            string[] menu = new string[5];
            menu[0] = "Horchata Mexicana";
            menu[1] = "Sopes de res";
            menu[2] = "Tacos al pastor";
            menu[3] = "Burritos";
            menu[4] = "Tacos con chile";

            double[] price = new double[5];
            price[0] = 2.50;
            price[1] = 3.25;
            price[2] = 2.20;
            price[3] = 1.90;
            price[4] = 4.00;

            string[] waiters = new string[5];
            waiters[0] = "Juan";
            waiters[1] = "Alberto";
            waiters[2] = "Edward";
            waiters[3] = "Fernando";
            waiters[4] = "Ulises";

            double total = 0;
            int quantity;
            int ticket, table, i, x = 0, w;
            Random Z = new Random();
            ticket = Z.Next(50000);
            System.Threading.Thread.Sleep(20);
            w = Z.Next(5);
            System.Threading.Thread.Sleep(20);
            table = Z.Next(50);

            do
            {
                Console.Clear();
                Console.WriteLine("--------------- Menú ---------------");
                Console.WriteLine("1 - Ordenar");
                Console.WriteLine("2 - Solicitar Factura");
                Console.WriteLine("3 - Salir");
                do
                {
                    Console.Write("Opcion: ");
                    Option = int.Parse(Console.ReadLine());

                } while (Option < 1 || Option > 3);
                Console.Clear();
                if (Option == 1)
                {
                    do
                    {
                        Console.Write("Ingrese el número de personas en la mesa: ");
                        x = int.Parse(Console.ReadLine());
                    } while (x < 1);
                    Ticket0.People = x;
                    i = x = 0;
                    do
                    {
                        i = 0;
                        foreach (var y in menu)
                        {
                            Console.WriteLine(y + ":    $" + price[i]);
                            i++;
                        }
                        Console.WriteLine("6: Salir");
                        do
                        {
                            Console.Write("Opcion: ");
                            Opt = int.Parse(Console.ReadLine());
                        } while (Opt < 1 || Opt > 6);

                        if (Opt != 6)
                        {
                            do
                            {
                                Console.Write("Ingrese la cantidad a pedir: ");
                                quantity = int.Parse(Console.ReadLine());
                            } while (quantity < 1);
                            Ticket0.Ticket = ticket;
                            Ticket0.Table = table;
                            Ticket0.Quantity[x] = quantity;
                            Ticket0.Waiter = waiters[w];
                            Ticket0.Food[x] = menu[Opt - 1];
                            Ticket0.Price[x] = price[Opt - 1];
                            total += (price[Opt - 1] * quantity);
                        }
                        x++;
                    } while (Opt != 6 && x < 5);
                    Ticket0.Total = total * 1.1;
                }
                else if (Option == 2)
                {
                    Console.WriteLine("Laca Laca Multiplaza");
                    Console.WriteLine("Cuenta: " + Ticket0.Ticket + "     Mesa: " + Ticket0.Table);
                    Console.WriteLine("Mesero: " + Ticket0.Waiter + "     Personas: " + Ticket0.People);
                    for (int j = 0; j < x; j++)
                    {

                        Console.WriteLine(Ticket0.Quantity[j] + " x " + Ticket0.Price[j] + " =  $" + (Ticket0.Quantity[j] * Ticket0.Price[j]));
                        Console.WriteLine(Ticket0.Food[j]);
                    }
                    Console.WriteLine("Subtotal:       $" + (Ticket0.Total / 1.1));
                    Console.WriteLine("Propina:        $" + ((Ticket0.Total / 1.1) * 0.1));
                    Console.WriteLine("Total:          $" + Ticket0.Total);

                    Console.Write("\n\nIngrese el total a pagar: ");
                    total = double.Parse(Console.ReadLine());
                    double tt = Ticket0.Total - total;
                    while (tt > 0)
                    {
                        Console.Write("Pago insuficiente, ingrese el complemento: ");
                        total = double.Parse(Console.ReadLine());
                        tt -= total;
                    }
                    Console.WriteLine("Gracias por su consumo. Vuelto = " + (0 - tt));
                    Option = 3;
                }
                if (Option == 3)
                {
                    Console.WriteLine("Volviendo al menu principal");
                }
            } while (Option != 3);
        }
    }
}
