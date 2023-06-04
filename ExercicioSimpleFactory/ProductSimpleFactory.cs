using SimpleFactoryExercise.Products;

namespace SimpleFactoryExercise
{
    internal class ProductSimpleFactory
    {
        public static Product? CreateProduct(string productName)
        {
            try
            {
                switch (productName)
                {
                    case "fridge":
                        Fridge fridge = new Fridge();
                        fridge.Name = Console.ReadLine();
                        fridge.Price = decimal.Parse(Console.ReadLine());
                        fridge.Capacity = int.Parse(Console.ReadLine());
                        return fridge;
                    case "television":
                        Television television = new Television();
                        television.Name = Console.ReadLine();
                        television.Price = decimal.Parse(Console.ReadLine());
                        television.Size = int.Parse(Console.ReadLine());
                        return television;
                    case "washingMachina":
                        WashingMachine washingMachine = new WashingMachine();
                        washingMachine.Name = Console.ReadLine();
                        washingMachine.Price = decimal.Parse(Console.ReadLine());
                        washingMachine.Load = int.Parse(Console.ReadLine());
                        return washingMachine;
                    default:
                        return null;
                }

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
