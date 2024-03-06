class TextCalss {

    static void Main(String[] args) {

        Action szamkiiro = null;
        for (int i = 0; i < 10; i++) {
            int f = i;
            szamkiiro += delegate () {
                //Console.WriteLine(i);
                Console.WriteLine(f);
            };
        }
        szamkiiro();
    }


}