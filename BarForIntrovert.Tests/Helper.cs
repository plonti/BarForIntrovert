using System;

namespace BarForIntrovert.Tests {
    static class Helper {
        public const int IterationThreshold = 1000 * 1000 * 1000;

        public static void FillTheBar(bool[] seats) {
            int guard = 0;
            while (true) {
                (int spareIndex, int spareLength) = IntrovertActions.FindLongestSpareSeats(seats);
                int spareSeat = IntrovertActions.FindFreeSeatIndex(
                    numberOfSeats: seats.Length,
                    spareIndex: spareIndex,
                    spareLength: spareLength);
                if (spareSeat != -1) {
                    seats[spareSeat] = true;
                } else {
                    break;
                }

                guard++;
                if (guard > IterationThreshold) {
                    var msg = $"Превышено максимальное количество итераций (IterationThreshold)!";
                    throw new TimeoutException(msg);
                }
            }
        }
    }
}