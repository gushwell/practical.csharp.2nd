using System;

namespace SampleApp {  //- using SampleApp; は不要

    public class MyApp {
        public void Run() {
            // Productクラスは、SampleApp名前空間で定義されているので、
            // using SampleApp; 
            // は不要
            Product karinto = new Product(123, "かりんとう", 180);
            int taxIncluded = karinto.GetPriceIncludingTax();
            Console.WriteLine(taxIncluded);
        }
    }
}
