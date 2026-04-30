using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStoreLib
{
    using System.Text.Json;

    using System.Text.Json;

    namespace PizzaStoreLib
    {
        public class PizzaStore
        {
            public List<Pizza> Pizzas { get; set; } = new List<Pizza>();

            private string filePath = @"C:\Users\DATA\pizzas.json.txt";
            public void LoadFromFile()
            {
                try
                {
                    StreamReader sr = new StreamReader(filePath);

                    string jsonStr = sr.ReadLine();
                    sr.Close();

                    List<Pizza> pizzas = JsonSerializer.Deserialize<List<Pizza>>(jsonStr);

                    if (pizzas != null)
                    {
                        Pizzas = pizzas;
                    }
                    else
                    {
                        Pizzas = new List<Pizza>();
                    }
                }
                catch (Exception)
                {
                  Pizzas = new List<Pizza>();
                }
            }

            public void SaveToFile()
            {
                try
                {
                    string jsonStr = JsonSerializer.Serialize(Pizzas);

                    StreamWriter sw = new StreamWriter(filePath);

                    sw.WriteLine(jsonStr);
                    sw.Close();
                }
                catch (Exception)
                {
                    Console.WriteLine("Kan ikke gemme fil");
                }
            }

            // Add pizza (bruges i program)
            public void AddPizza(Pizza pizza)
            {
                Pizzas.Add(pizza);
            }

            //Print pizzas
            public void PrintPizzas()
            {
                foreach (var pizza in Pizzas)
                {
                    Console.WriteLine(pizza);
                }
            }
        }
    }
}