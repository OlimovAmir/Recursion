namespace Recursion
{
    public class Recursion
    {
        public static object Child { get; private set; }

        static void Foo(int i)
        {
            Console.WriteLine(i);
            if (i >=4)
            {
                return;
            }
            ++i;
            Foo(i);
        }




        public class Item
        {
            public int Value { get; set; }
            public Item Child { get; set; }
        }

        public static Item InitIten()
        {
            return new Item()
            {
                Value = 25,

                Child = new Item()
                {
                    Value = 5,
                    Child = new Item()
                    {
                        Value = 2,
                    }
                }
            };
           
        }

        public static void Print(Item item)
        {
            if (item!=null)
            {
                Console.WriteLine(item.Value);
                Print(item.Child);
            }
            
        }

       
    }
}
