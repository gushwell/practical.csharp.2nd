namespace DistanceConverter {

    public class FeetConverter {
        // メートルからフィートを求める
        public double FromMeter(double meter) {
            return meter / 0.3048;
        }

        // フィートからメートルを求める
        public double ToMeter(double feet) {
            return feet * 0.3048;
        }
    }
}
