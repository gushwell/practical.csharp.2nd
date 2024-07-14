class GreetingMorning : IGreeting {
    public string GetMessage() => "おはよう";
}

class GreetingAfternoon : IGreeting {
    public string GetMessage() => "こんにちは";
}

class GreetingEvening : IGreeting {
    public string GetMessage() => "こんばんは";
}