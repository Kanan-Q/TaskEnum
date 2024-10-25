namespace Task_Enum;
using static System.Console;

internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            bool next = true;
            string n = "";
            double number = 0;
            bool result = false;
            bool boolPrice = false;
            bool boolType = false;
            Types? type = null;
            do
            {
                Console.WriteLine("Mehsul adi daxil et:");
                string name = Console.ReadLine();

                int nums;
                if (int.TryParse(name, out nums))
                {
                    Console.WriteLine("Eded yox string daxi et!");
                }
                else
                {
                    n = name;
                    result = true;
                }
            } while (!result);

            do
            {
                Console.WriteLine("Mehsulun qiymetini daxil et");
                string priceInput = Console.ReadLine();
                if (double.TryParse(priceInput, out number))
                {
                    boolPrice = true;
                }
                else
                {
                    WriteLine("String yox eded daxil et");
                }
            } while (!boolPrice);

            do
            {
                WriteLine("Novu daxil et");
                WriteLine("\n 1.Baker\n 2.Drink\n 3.Meat\n 4.Diary");
                int input = int.Parse(ReadLine());
                switch (input)
                {
                    case 1:
                        type = Types.Meat;
                        WriteLine("Meat novune aiddir");
                        break;
                    case 2:
                        type = Types.Diary;
                        WriteLine("Diary novune aiddir");
                        break;
                    case 3:
                        type = Types.Baker;
                        WriteLine("Baker novune aiddir");
                        break;
                    case 4:
                        type = Types.Drink;
                        WriteLine("Drink novune aiddir");
                        break;
                    default:
                        WriteLine("Duzgun deyer daxil et");
                        break;
                }
            } while (boolType);
            Product product1 = new Product(n, number, type.Value);
            Store store = new Store();
            do
            {

                WriteLine("\n1.AddProduct\n2.GetProduct\n3.FilterProductByName\n4.RemoveId");
                int input = int.Parse(ReadLine());
                switch (input)
                {
                    case 1:
                        store.AddProduct(product1);
                        break;
                    case 2:
                        WriteLine("Axtardigin id daxil et");
                        if (int.TryParse(ReadLine(), out int num))
                        {
                            store.GetProduct(num);
                        }
                        else
                        {
                            WriteLine("String yox eded daxil et");
                        }
                        break;
                    case 3:
                        WriteLine("Axtarilan mehsulun adini daxil et");
                        string name = ReadLine();
                        store.FilterProductByName(name);
                        break;
                    case 4:
                        WriteLine("Butun melumatlar");
                        product1.ShowInfo();
                        break;
                    case 5:
                        WriteLine("Silmek istediyiniz mehsulun Id ni daxil et");
                        if (int.TryParse(ReadLine(), out int pro))
                        {
                            store.RemoveId(pro);
                        }
                        else
                        {
                            WriteLine("String yox eded daxil et");
                        }
                        break;
                    default:
                        WriteLine("1-5 araliginda qiymet daxil et");
                        break;
                }
            } while (next);

        }
        catch (Exception ex)
        {
            WriteLine(ex.Message);
        }
    }

}