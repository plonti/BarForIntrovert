using System;
using System.Collections.Generic;

namespace BarForIntrovert {
    public class Program {
        static void Main(string[] args) {
            //FillStepByStep(barSize: 6, neliChoice: 5);

            int[] optimalChoises = FindOptimalChoices(barSize: 26);
            Helper.PrintOptimalChoises(optimalChoises);
        }

        public static int[] FindOptimalChoices(int barSize) {
            int maxTakenSeats;
            if (barSize % 2 == 0) {
                maxTakenSeats = barSize / 2;
            } else {
                maxTakenSeats = barSize / 2 + 1;
            }

            List<int> optimalChoises = new List<int>();
            for (int i = 0; i < barSize; i++) {
                bool[] seats = new bool[barSize];
                seats[i] = true;
                int occupiedSeats = FindTakenSeats(seats);
                if (occupiedSeats == maxTakenSeats) {
                    optimalChoises.Add(i);
                }
            }
            return optimalChoises.ToArray();
        }

        static int FindTakenSeats(bool[] seats) {
            int seatsTaken = 1;
            while (true) {
                (int spareIndex, int spareLength) = IntrovertActions.FindLongestSpareSeats(seats);
                int spareSeat = IntrovertActions.FindFreeSeatIndex(
                    numberOfSeats: seats.Length,
                    spareIndex: spareIndex,
                    spareLength: spareLength);
                if (spareSeat == -1) {
                    break;
                } else {
                    seats[spareSeat] = true;
                    seatsTaken++;
                }
            }
            return seatsTaken;
        }

        static void FillStepByStep(int barSize, int neliChoice) {
            bool[] seats = new bool[barSize];
            seats[neliChoice - 1] = true;

            Console.WriteLine($"Нели выбрала место: {neliChoice}");
            Helper.PrintSeats(seats);

            int seatsTaken = 1;
            while (true) {
                (int spareIndex, int spareLength) = IntrovertActions.FindLongestSpareSeats(seats);
                Console.WriteLine();
                Console.WriteLine($"Свободное место: {spareIndex + 1}, " +
                                  $"количество мест: {spareLength}");

                int spareSeat = IntrovertActions.FindFreeSeatIndex(
                    numberOfSeats: seats.Length,
                    spareIndex: spareIndex,
                    spareLength: spareLength);
                if (spareSeat == -1) {
                    Console.WriteLine("Все места заняты!");
                    break;
                } else {
                    seats[spareSeat] = true;
                    seatsTaken++;
                    Console.WriteLine($"Занимаем место: {spareSeat + 1}.");
                }
                Helper.PrintSeats(seats);
                //Console.ReadKey();
            }

            Console.WriteLine();
            Console.WriteLine($"Всего занято мест: {seatsTaken}");
            Console.ReadKey();
        }
    }
}
