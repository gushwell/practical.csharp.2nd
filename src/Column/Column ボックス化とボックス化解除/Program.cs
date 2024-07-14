// ボックス化
{
    object obj = 123;
}

// ボックス化
{
    int val = 456;
    object obj = val;
}

// キャストでボックス化解除
{
    int val = 456;
    object obj = val;
    int val2 = (int)obj;
}

// ボックス化解除　間違い
{
    try {
        int val = 456;
        object obj = val;
        double val2 = (double)obj; // エラー発生。objの本当の型は int型である。
    } catch (Exception ex) {
        Console.WriteLine(ex.Message);
    }
}


// ボックス化
{
    DateTime dt = DateTime.Today;
    string s = string.Format("{0}", dt);
}