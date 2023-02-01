namespace Question3
{
    internal class Program
    {
        static Pizza input_data()
        {
            Pizza pz = new Pizza();
            try
            {
                Console.Write("Enter added toppings: ");
                string toppings = Console.ReadLine();
                Console.Write("Enter diameter: ");
                string diameter_string = Console.ReadLine();
                float diameter = float.Parse(diameter_string);
                Console.Write("Enter number of slices: ");
                string slice_string = Console.ReadLine();
                int slices = int.Parse(slice_string);
                pz.Diameter = diameter;
                pz.Slices = slices;
                pz.Toppings = toppings;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error data entered! Please enter again!");
                return input_data();
            }
            return pz;
        }
        static void Main(string[] args)
        {
            Pizza pz = input_data();
            Console.WriteLine("Pizza detail:");
            Console.WriteLine(pz);
        }
    }
}