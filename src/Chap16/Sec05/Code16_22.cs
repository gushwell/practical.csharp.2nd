using System.Reflection;

namespace Gushwell.Utilities;

public static class EnumDisplayExtensions {
    private static EnumDisplayAttribute? GetFieldAttribute(Enum value) {
        // 例えば、valueがGender.Maleなら、Gender.MaleのFieldInfoを取り出す
        var name = value.ToString();
        var fi = value.GetType().GetField(name!);
        // そのフィールドに付加されたEnumDisplay属性を取り出し返す。
        // 取り出せない場合は、nullを返す。
        if (fi != null) {
            var attr = fi
                .GetCustomAttributes(typeof(EnumDisplayAttribute), false)
                .Cast<EnumDisplayAttribute>()
                .FirstOrDefault();
            return attr;
        } else {
            return null;
        }
    }

    public static string GetDisplayName(this Enum value) {
        var attribute = GetFieldAttribute(value);
        // その属性のNameプロパティを返す。属性が取り出せなければ、value.ToString()を返す。
        return attribute?.Name ?? value.ToString();
    }
}
