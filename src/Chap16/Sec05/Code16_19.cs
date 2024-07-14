using System.ComponentModel.DataAnnotations;

public class UserModel {
    [StringLength(16, ErrorMessage = "ユーザ名が長すぎます。")]
    public string Name { get; set; } = string.Empty;

    [Range(0, 130, ErrorMessage = "年齢の範囲を超えています。")]
    public int Age { get; set; }
}

