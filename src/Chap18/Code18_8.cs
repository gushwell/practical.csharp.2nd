
public class Code18_8 {
    public bool IsValid(MyModel model) {
        if (model is null)
            return false;
        if (string.IsNullOrEmpty(model.Name))
            return false;
        if (string.IsNullOrEmpty(model.PhoneNo))
            return false;
        if (model.Birthday is null)
            return false;
        return true;
    }
}

public class MyModel {
    public string Name { get; set; } = string.Empty;
    public string PhoneNo { get; set; } = string.Empty;
    public DateTime? Birthday { get; set; }

}