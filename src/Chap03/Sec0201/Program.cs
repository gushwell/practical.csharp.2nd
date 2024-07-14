// See https://aka.ms/new-console-template for more information
Step0();
Step1();
Step2();
Step3();
Step4();
Step5();


static void Step0() {
    var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };
    Predicate<int> judge =
        (int n) => {              //- ┓
            if (n % 2 == 0)       //- ┃
                return true;      //- ┣ これがラムダ式,judge変数に代入  
            else                  //- ┃
                return false;     //- ┃
        };                        //- ┛
    var count = Count(numbers, judge);
    Console.WriteLine(count);
}

static void Step1() {
    var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };
    var count = Count(numbers,
      (int n) => {
          if (n % 2 == 0)
              return true;
          else
              return false;
      }
    );
    Console.WriteLine(count);

}

static void Step2() {
    var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };
    var count = Count(numbers, (int n) => { return n % 2 == 0; });
    Console.WriteLine(count);

}

static void Step3() {
    var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };
    var count = Count(numbers, (int n) => n % 2 == 0);
    Console.WriteLine(count);

}

static void Step4() {
    var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };
    var count = Count(numbers, (n) => n % 2 == 0);
    Console.WriteLine(count);

}

static void Step5() {
    var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };
    var count = Count(numbers, n => n % 2 == 0);
    Console.WriteLine(count);
}


static int Count(int[] numbers, Predicate<int> judge) {
    int count = 0;
    foreach (var n in numbers) {
        if (judge(n) == true)
            count++;
    }
    return count;
}