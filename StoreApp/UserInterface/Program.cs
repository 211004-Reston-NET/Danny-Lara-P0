﻿using System;
using BusinessLogic;
using DataAccessLogic;

namespace UserInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Flower Shop App!");
            bool loop = true;
            IMenu page = new MainMenu();

            while (loop)
            {
                page.Menu();
                MenuType currentPage = page.Choice();
                switch (currentPage)
                {
                    case MenuType.MainMenu:
                        page = new MainMenu();
                        break;
                    case MenuType.AddCustomer:
                        page = new AddCustomer(new CustomerBL(new StoreRepo()));
                        break;
                    case MenuType.Search:
                        page = new Search(new CustomerBL(new StoreRepo()));
                        break;
                    case MenuType.Inventory:
                        page = new Inventory(new StoreBL(new StoreRepo()));
                        break;
                    case MenuType.PlaceOrder:
                        page = new PlaceOrder(new StoreBL(new StoreRepo()));
                        break;
                    /*case MenuType.StoreOrderMenu:
                        page = new StoreOrderMenu(new StoreBL(new Repository()));
                        break;*/
                    case MenuType.OrderHistory:
                        page = new OrderHistory();
                        break;
                    case MenuType.Replenish:
                        page = new Replenish();
                        break;
                    case MenuType.Exit:
                        Console.WriteLine("Thank you, and have a nice day!");
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Forgot to add a menu!");
                        loop = false;
                        break;
                }
            }
            
        }
    }
}