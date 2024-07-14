class GreetingMorning : GreetingBase {
    public override string GetMessage() => "おはよう";
}

class GreetingAfternoon : GreetingBase {
    public override string GetMessage() => "こんにちは";
}

class GreetingEvening : GreetingBase {
    public override string GetMessage() => "こんばんは";

}

