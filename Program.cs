namespace D14_ovning1_uppgift8t15
{
    internal class Program
    {
        class Land
        {
            public string namn, styrestyp, huvudstad;
            public int invånarantal;

            //Uppgift 10
            public void Print()
            {
                Console.WriteLine($"Land : {namn}");
                Console.WriteLine($"Huvudstad : {huvudstad}");
                Console.WriteLine($"Styrestyp : {styrestyp}");
                Console.WriteLine($"Invånarantal : {invånarantal}");
            }
        }

        static void Main(string[] args)
        {
            //Uppgift 9
            Land sverige = new Land() { namn = "Sverige", styrestyp = "Monarki", huvudstad = "Stockholm", invånarantal = 10512820 };
            Land tyskland = new Land() { namn = "Tyskland", styrestyp = "Republik", huvudstad = "Berlin", invånarantal = 83783902 };
            Land sanMarino = new Land() { namn = "San Marino", styrestyp = "Republik", huvudstad = "San Marino", invånarantal = 33600 };

            //Uppgift 10
            //sverige.Print();
            //tyskland.Print();
            //sanMarino.Print();

            //Uppgift 11
            Land[] länder = new Land[] { 
                sverige, tyskland, sanMarino,
                new Land() { namn = "Danmark", styrestyp = "Monarki", huvudstad = "Köpenhamn", invånarantal = 5928364 },
                new Land() { namn = "Italien", styrestyp = "Republik", huvudstad = "Rom", invånarantal = 58853482 },
                new Land() { namn = "Tjeckien", styrestyp = "Republik", huvudstad = "Prag", invånarantal = 10551219 },
                new Land() { namn = "Rumänien", styrestyp = "Republik", huvudstad = "Bukarest", invånarantal = 19760314 }
            };

            //Uppgift 12
            /*foreach(Land land in länder)
            {
                land.Print();
            }*/

            //Uppgift 13
            for (int i = 0; i < länder.Length; i++)
            {
                if (länder[i].styrestyp == "Republik")
                {
                    länder[i].Print();
                }
            }
        }
    }
}