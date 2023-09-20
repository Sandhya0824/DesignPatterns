using static System.Collections.Specialized.BitVector32;

namespace GarmentFactoryMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IGarment garment = GarmentFactory.ChooseGarment(Section.Men, Type.TeeShirt);
            Console.WriteLine(garment);

            IGarment garment1 = GarmentFactory.ChooseGarment(Section.Women, Type.Dress);
            if (garment1 == null)
            {
                Console.WriteLine("No such type available");
            }
            Console.WriteLine(garment1);
        }
    }
}