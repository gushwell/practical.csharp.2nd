

public class Code15_7 {
    public static void Run() {
        List<IGreeting> greetings = [
            new GreetingMorning(),
            new GreetingAfternoon(),
            new GreetingEvening(),
        ];
        foreach (var obj in greetings) {
            string msg = obj.GetMessage();
            Console.WriteLine(msg);
        }
    }
}