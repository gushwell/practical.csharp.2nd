

public class Code15_3 {
    public static void Run() {
        List<GreetingBase> greetings = [
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