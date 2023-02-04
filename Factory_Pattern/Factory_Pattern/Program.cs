using Factory_Pattern;

while (true)
{
    try
    {
        Console.Write("\nMit J/j weiter mit N/n abbruch! : ");
        string wahl = Console.ReadLine();

        if (wahl == "N" | wahl == "n")
        {
            Console.WriteLine("Arividerci");
            break;
        }
        else if (wahl == "J" | wahl == "j")
        {
            Console.WriteLine("Bitte wählen Sie eine Pizza! ");
            Console.WriteLine("\nPizza Margherita               (1)");
            Console.WriteLine("\nPizza Rustica                  (2)");
            Console.Write("\nEingabe                          :");
            int Gericht = Convert.ToInt32(Console.ReadLine());

            PizzaKüche meinePizzaKüche = new PizzaKüche();

            switch (Gericht)
            {
                case 1:
                    IPizza meinePizza1 = meinePizzaKüche.erzeugePizza("Margherita");
                    Console.WriteLine("\nMeine Pizza ist : {0}", meinePizza1.GetName());
                    break;
                case 2:
                    IPizza meinePizza2 = meinePizzaKüche.erzeugePizza("Rustica");
                    Console.WriteLine("\nMeine Pizza ist : {0}", meinePizza2.GetName());
                    break;
                default:
                    Console.WriteLine("Falsche Eingabe!");
                    break;
            }

        }
        else
        {
            Console.WriteLine("Falsche Eingabe du Jonny!");
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
    
}
