public static class Code6_35 {
    public static void Run() {
        Run1();
        Run2();
    }

    static void Run1() {
        int number = 12345;
        //int number = 0;
        var s1 = number.ToString();             //  "12345"
        var s2 = number.ToString("#");          //  "12345"
        var s3 = number.ToString("0000000");    //  "0012345"
        var s4 = number.ToString("#,0");        //  "12,345"

        decimal distance = 9876.123m;
        //decimal distance = 0m;
        var s5 = distance.ToString();           //  "9876.123"
        var s6 = distance.ToString("#");        //  "9876"
        var s7 = distance.ToString("#,0.0");    //  "9,876.1"
        var s8 = distance.ToString("#,0.0000"); //  "9,876.1230"

        Console.WriteLine(s1);
        Console.WriteLine(s2);
        Console.WriteLine(s3);
        Console.WriteLine(s4);
        Console.WriteLine(s5);
        Console.WriteLine(s6);
        Console.WriteLine(s7);
        Console.WriteLine(s8);
    }
    static void Run2() {
        int number = 0;
        //int number = 0;
        var s1 = number.ToString();             //  "0"
        var s2 = number.ToString("#");          //  ""
        var s3 = number.ToString("0000000");    //  "0000000"
        var s4 = number.ToString("#,0");        //  "0"

        decimal distance = 0.0m;
        //decimal distance = 0m;
        var s5 = distance.ToString();           //  "0.0"
        var s6 = distance.ToString("#");        //  ""
        var s7 = distance.ToString("#,0.0");    //  "0.0"
        var s8 = distance.ToString("#,0.0000"); //  "0.0000"

        Console.WriteLine(s1);
        Console.WriteLine(s2);
        Console.WriteLine(s3);
        Console.WriteLine(s4);
        Console.WriteLine(s5);
        Console.WriteLine(s6);
        Console.WriteLine(s7);
        Console.WriteLine(s8);
    }

}