using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
//using Chap08;

Console.WriteLine("---");
Code9_25.Run();
Code9_26.Run();
Code9_27.Run();
Code9_28.Run();
Code9_29.Run();
Console.ReadLine();

// 以下は速度比較のためのコード
Stopwatch sw = new();
sw.Start();
for (var i = 0; i < 10000; i++)
    Code9_28.Run();
sw.Stop();

var elapsedMilliseconds1 = sw.ElapsedMilliseconds;

sw.Reset();
sw.Start();
for (var i = 0; i < 10000; i++)
    Code9_29.Run();
sw.Stop();

Console.WriteLine(elapsedMilliseconds1);

Console.WriteLine(sw.ElapsedMilliseconds);

