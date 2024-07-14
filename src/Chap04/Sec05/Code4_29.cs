using System;
using System.Collections.Generic;

public static class Code4_29 {
    public static void Run() {
        var rank = CustomerRank.Silver;

        if (rank == CustomerRank.Silver) {
            Console.WriteLine("シルバーです");
        }
    }

    public enum CustomerRank : short {
        Bronze = 1,
        Silver = 2,
        Gold = 3,
        Platinum = 4
    }
}
