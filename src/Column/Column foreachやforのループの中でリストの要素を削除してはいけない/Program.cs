// ダメな例　例外発生
{
    try {
        List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        foreach (int n in list) {
            if (n % 4 == 0)
                list.Remove(n);  //- foreachの中で、要素を削除
        }
        Console.WriteLine(list.Count);
        foreach (var n in list) {
            Console.Write($"{n} ");
        }
        Console.WriteLine();
    } catch (Exception e) {
        Console.WriteLine(e.Message);
        // 次へ進む
    }
}

// ダメな例　正しく削除できない
{
    List<int> list = new List<int> { 1, 2, 3, 4, 5, 5, 6, 7, 8, 9 };
    for (int i = 0; i < list.Count; i++) {
        if (list[i] == 5)
            list.Remove(list[i]);  //- for文の中で、要素を削除
    }
    Console.WriteLine(list.Count);
    foreach (var n in list) {
        Console.Write($"{n} ");
    }
    Console.WriteLine();
}

// 正しく削除できる
{
    var list = new List<int> { 1, 2, 3, 4, 5, 5, 6, 7, 8, 9 };
    list.RemoveAll(x => x == 5);
    foreach (var n in list) {
        Console.Write($"{n} ");
    }
    Console.WriteLine();

}

// 正しく削除できるが、複雑
{
    List<int> list = new List<int> { 1, 2, 3, 4, 5, 5, 6, 7, 8, 9 };
    for (int i = list.Count - 1; i >= 0; i--) {
        if (list[i] == 5)
            list.Remove(list[i]);
    }
    foreach (var n in list) {
        Console.Write($"{n} ");
    }
    Console.WriteLine();
}

// LINQ使っても良い。listを変更する必要がなければこれが良い。
{
    var list = new List<int> { 1, 2, 3, 4, 5, 5, 6, 7, 8, 9 };
    // 場合によってはToList()を呼び出す。
    var newList = list.Where(x => x != 5);
    foreach (var n in newList) {
        Console.Write($"{n} ");
    }
    Console.WriteLine();

}