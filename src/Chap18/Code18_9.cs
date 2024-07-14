
public class Code18_9 {
    public bool IsValid(MyModel model) {
        var result = false;
        if (model is not null) {
            if (!string.IsNullOrEmpty(model.Name)) {
                if (!string.IsNullOrEmpty(model.PhoneNo)) {
                    if (model.Birthday is not null)
                        result = true;
                }
            }
        }
        return result;
    }
}