// Code 3-6
var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };
int count = Count(numbers, delegate (int n) { return n % 2 == 0; });
Console.WriteLine(count);

static int Count(int[] numbers, Predicate<int> judge) {
    var count = 0;
    foreach (var n in numbers) {
        if (judge(n) == true) {
            count++;
        }
    }
    return count;
}

