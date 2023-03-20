using System;

namespace BarForIntrovert {
    static class Helper {
        public static void PrintSeats(ReadOnlySpan<bool> seats) {
            for (int i = 0; i < seats.Length; i++) {
                Console.Write((i + 1).ToString() + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < seats.Length; i++) {
                if (seats[i]) {
                    Console.Write("X ");
                } else {
                    Console.Write("0 ");
                }

                string iAsString = (i + 1).ToString();
                int iStrLength = iAsString.Length;
                for (int j = 1; j < iStrLength; j++) {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();

            Console.Write("Без пробелов: ");
            for (int i = 0; i < seats.Length; i++) {
                if (seats[i]) {
                    Console.Write("X");
                } else {
                    Console.Write("0");
                }
            }

            Console.WriteLine();
        }

        public static void PrintOptimalChoises(ReadOnlySpan<int> choices) {
            for (int i = 0; i < choices.Length; i++) {
                if (i != choices.Length - 1) {
                    Console.Write((choices[i] + 1).ToString() + ",");
                } else {
                    Console.WriteLine((choices[i] + 1).ToString());
                }
            }
        }
    }
}