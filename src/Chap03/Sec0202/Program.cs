var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };

// 奇数の数をカウントする
var count1 = Count(numbers, n => n % 2 == 1);
Console.WriteLine(count1);

// 5以上の数をカウントする
var count2 = Count(numbers, n => n >= 5);
Console.WriteLine(count2);

// 5以上10未満の数をカウントする
var count3 = Count(numbers, n => 5 <= n && n < 10);
Console.WriteLine(count3);

// 数字の'5'が含まれている数をカウントする
var count4 = Count(numbers, n => n.ToString().Contains('5'));
Console.WriteLine(count4);


static int Count(int[] numbers, Predicate<int> judge) {
    int count = 0;
    foreach (var n in numbers) {
        if (judge(n) == true)
            count++;
    }
    return count;
}