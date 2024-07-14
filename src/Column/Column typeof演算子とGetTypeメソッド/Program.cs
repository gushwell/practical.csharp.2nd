Type type = typeof(Product);
Console.WriteLine(type.ToString());

Person person = new Employee();
Type type2 = person.GetType();
Console.WriteLine(type2.ToString());


public class Product { }

public class Person { }

public class Employee : Person { }
