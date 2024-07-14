public static class Code4_6 {
    public static void Good() {
        var person = new Person {
            Name = "新井遥菜",
            Birthday = new DateTime(1995, 11, 23),
            PhoneNumber = "012-3456-7890",
        };
        Console.WriteLine($"{person.Name} {person.Birthday} {person.PhoneNumber}");
    }

    public static void Bad() {
        Person person = new Person();
        person.Name = "新井遥菜";
        person.Birthday = new DateTime(1995, 11, 23);
        person.PhoneNumber = "012-3456-7890";

        Console.WriteLine($"{person.Name} {person.Birthday} {person.PhoneNumber}");
    }

    class Person {
        public string Name { get; set; } = string.Empty;
        public DateTime Birthday { get; set; }

        public string PhoneNumber { get; set; } = string.Empty;
    }
}