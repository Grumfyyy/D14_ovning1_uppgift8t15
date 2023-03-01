namespace D14_ovning1_uppgift8t15
{
    internal class Program
    {
        class Land
        {
            public string namn, styrestyp, huvudstad;
            public int invånarantal;
        }

        static void Main(string[] args)
        {
            Land sverige = new Land() { namn = "Sverige", styrestyp = "Monarki", huvudstad = "Stockholm", invånarantal = 10512820 };
            Land tyskland = new Land() { namn = "Sverige", styrestyp = "Republik", huvudstad = "Berlin", invånarantal = 83783902 };
            Land sanMarino = new Land() { namn = "San Marino", styrestyp = "Republik", huvudstad = "San Marino", invånarantal = 33600 };
        }
    }
}