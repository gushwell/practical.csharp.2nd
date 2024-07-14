// Code 2-9
namespace DistanceConverter {

    public static class FeetConverter {
        public static double FromMeter(double meter) {
            return meter / 0.3048;
        }

        public static double ToMeter(double feet) {
            return feet * 0.3048;
        }
    }
}
