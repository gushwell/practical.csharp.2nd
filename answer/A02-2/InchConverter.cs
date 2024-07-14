// List 2-10
// List 2-12

namespace DistanceConverter;

public class InchConverter {
    private static readonly double ratio = 0.0254;

    // メートルからフィートを求める
    public static double FromMeter(double meter) {
        return meter / ratio;
    }

    // フィートからメートルを求める
    public static double ToMeter(double feet) {
        return feet * ratio;
    }
}

