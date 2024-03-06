using System.ComponentModel;

class TextCalss {

    static void Main(String[] args) {
        List<int> lista = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
        int[] tomb = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
       

        int elsoParos = lista.Find(i => i % 2 == 0);
        Console.WriteLine("elso paros neve: " + elsoParos);

        List<int> osszesPAros = lista.FindAll(i => i % 2 == 0);
        foreach (var item in osszesPAros) { 
            Console.WriteLine(item);
        }

        bool vanParos = lista.Exists(x => x % 2 == 0);
        if (vanParos) {
            Console.WriteLine("Van parosan elem");
        } else {
            Console.WriteLine("Nincs parosan elem");
        }


        Array.Sort(tomb,
            (i1, i2) => {
                bool i1Paros = i1 % 2 == 0;
                bool i2Paros = i2 % 2 == 0;
                if (i1Paros && !i2Paros)
                    return 0;
                else if (!i1Paros && i2Paros)
                    return 1;
                else return 0;
            });

        foreach (var item in tomb) {
            Console.WriteLine(item);
        }

    }
    /*
        Action szamkiiro = null;
        for (int i = 0; i < 10; i++) {
            int f = i;
            szamkiiro += delegate () {
                //Console.WriteLine(i);
                Console.WriteLine(f);
            };
        }
        szamkiiro();
        */

}