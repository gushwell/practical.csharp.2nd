using System;
using System.Collections.Generic;

public static class Code4_28 {

    public enum CustomerRank {
        Bronze,
        Silver,
        Gold,
        Platinum
    }


    public static void Good() {
        var rank = CustomerRank.Silver;
        Console.WriteLine(rank);
    }

    public static void Bad1() {
        var customerRank = "Bronze";
        if (customerRank == "Bronz") {  // スペルミス
                                        // ブロンズの時の処理
        }

    }

    const int Bronze = 1;
    const int Silver = 2;
    const int Gold = 3;
    const int Platinum = 4;

    public static void Bad2() {
        var unitPricePerMonth = 100_000;
        var platinumValue = 80_000;
        int customerRank = Bronze;
        if (unitPricePerMonth > platinumValue) {
            customerRank = 5;           //- 上記の定数以外を代入できてしまう
        }
    }

}
