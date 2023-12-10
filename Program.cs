using Recursion;

class Program
{
    static void Main(string[] args)
    {
        // Вызываем статический метод Print из класса Recursion
        Recursion.Recursion.Item item = Recursion.Recursion.InitIten(); // Пример вызова метода InitIten для получения объекта Item
        Recursion.Recursion.Print(item);

        for(Recursion.Recursion.Item i = item; i != null; i=i.Child)
        {
            Console.WriteLine(i.Value);
        }
    }
}