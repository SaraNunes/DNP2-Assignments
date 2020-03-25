using System;
using System.Collections.Generic;
using System.Linq;


namespace Assigment4_LINQ
{
        class Customer
        {
            public string Name;
            public string City;
            public Order[] Orders;
        }

        class Order
        {
            public int Quantity;
            public Product Product;
        }

        class Product
        {
            public string Name;
            public decimal Price;
        }

        class Program
        {
            static void Main(string[] args)
            {
                var Milk = new Product
                {
                    Name = "Milk",
                    Price = 7
                };
                var Beer = new Product
                {
                    Name = "Beer",
                    Price = 3
                };
                var Butter = new Product
                {
                    Name = "Butter",
                    Price = 2
                };
                var Cacao = new Product
                {
                    Name = "Cacao",
                    Price = 5
                };
                var Juice = new Product
                {
                    Name = "Juice",
                    Price = 2
                };

            // Question A
                Customer customer1 = new Customer
                {
                    Name = "Kim Foged",
                    City = "Beder",
                    Orders = new Order[] {new Order { Product = Milk , Quantity = 1 },
                    new Order {Product = Beer, Quantity = 2},
                    new Order {Product = Butter, Quantity = 1}
                }
                };

                var customer2 = new Customer
                {
                    Name = "Ib Havn",
                    City = "Horsens",
                    Orders = new Order[] {new Order { Product = Milk , Quantity = 1 },
                    new Order {Product = Beer, Quantity = 2},
                    new Order {Product = Butter, Quantity = 1},
                    new Order {Product = Cacao, Quantity=5}
                }
                };
                var customer3 = new Customer
                {
                    Name = "Rasmus Bjerner",
                    City = "Horsens",
                    Orders = new Order[] { new Order { Product = Juice, Quantity = 1 } }
                };


                var customers = new List<Customer>()
            {
                customer1,customer2,customer3
            };

                //Question B
                var query1 = customers.Select(x => (x.Name, x.City));

                foreach (var customer in query1)
                {
                    Console.WriteLine(customer);
                }

                //Question C
                var query2 = customers.Where(x => x.City == "Horsens").Select(x => x.Name);
                foreach (var customer in query2)
                    Console.WriteLine(customer);
                Console.ReadLine();

                //Question D
                var query3 = customers.Where(x => x.Name == "Ib Havn").Select(x => x.Orders.Length).SingleOrDefault();
                Console.WriteLine(query3);

                //Question E 
                // List<Customer> query4 = customers.FindAll(x => x.Orders.Where(x=>x.Product is Milk)).Select(x=>x.Name);
                var customersBuyingMilk = customers.Where(x => x.Orders.Any(z => z.Product == Milk));
                foreach (Customer customer in customersBuyingMilk)
                {
                    string s = customer.Name;
                    Console.WriteLine(s);
                }
                Console.ReadLine();

                //Question F

                //var query5 = customers.Select(x => (x.Name, x.Orders.Sum(x => x.Product.Price)));
                //foreach (var customer in query5)
                //    Console.WriteLine(customer);
                //Console.WriteLine("Customers and their order values2: ");

                var sum2 = from customer in customers
                           let sumTotal = customer.Orders.Sum(s => s.Product.Price)
                           select (customer.Name, sumTotal);

                foreach (var customer in sum2)
                {
                    Console.WriteLine(customer);
                }
                Console.ReadLine();

                //Question G
                //Write a LINQ query to select the total sum(All customers sum added).Print the results
                var totalSum = customers.Sum(x => x.Orders.Sum(o => o.Product.Price));
                Console.WriteLine(totalSum);
            }
        }
    }
