namespace BarForIntrovert {
    public static class IntrovertActions {
        public static (int spareIndex, int spareLength) FindLongestSpareSeats(bool[] seats) {
            int maxSpareLength = 0;
            int spareIndex = -1;
            int spareLength = 0;
            for (int i = 0; i < seats.Length; i++) {
                if (spareIndex == -1 && seats[i] == false) {
                    spareIndex = i;
                }

                if (seats[i]) {
                    maxSpareLength = 0;
                } else {
                    maxSpareLength++;
                }

                if (maxSpareLength > spareLength) {
                    spareLength = maxSpareLength;
                    spareIndex = i - maxSpareLength + 1;
                }

                if (maxSpareLength == spareLength && i == seats.Length - 1) {
                    spareIndex = i - maxSpareLength + 1;
                }
            }

            return (spareIndex, spareLength);
        }

        public static int FindFreeSeatIndex(int numberOfSeats, int spareIndex, int spareLength) {
            if (spareIndex == 0) {
                if (spareLength == 1) {
                    return -1;
                }
                return 0;
            }

            if (spareIndex + spareLength == numberOfSeats) {
                if (spareIndex == numberOfSeats - 1) {
                    return -1;
                }
                return numberOfSeats - 1;
            }

            if (spareLength <= 2) {
                return -1;
            }

            int half = spareLength / 2;
            if (spareLength % 2 == 0) {
                half = half - 1;
            }
            int index = spareIndex + half;
            return index;
        }
    }
}