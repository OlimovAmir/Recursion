namespace Recursion
{
    class Recursion
    {
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
       



        class Item
        {
            public int Value { get; set; }
            public Item Child { get; set; }
        }

        static Item InitIten()
        {
            return new Item()
            {
                Value = 5,
                Child = new Item()
                {
                    Value = 2,
                }
            };
        }

        static void Print(Item item)
        {
            if (item!=null)
            {
                Console.WriteLine(item.Value);
                Print(item.Child);
            }
            
        }

       
    }
}
