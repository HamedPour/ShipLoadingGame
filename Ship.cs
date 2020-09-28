using System;

namespace ShipLoadingGame
{
    internal class Ship
    {
        // Constent Vars
        private const int CYCLE_WEIGHT = 3;

        private const int CAR_WEIGHT = 5;
        private const int TRUCK_WEIGHT = 11;
        private const int TRAIN_WEIGHT = 17;

        private const int MAX_WEIGHT = 10;

        // Properties
        public int Capacity { get; set; }

        public int CycleCount { get; set; }
        public int CarCount { get; set; }
        public int TruckCount { get; set; }
        public int TrainCount { get; set; }

        private Random random = new Random();

        // Methods

        public Ship()
        {
            CycleCount = 0;
            CarCount = 0;
            TruckCount = 0;
            TrainCount = 0;

            // create a random load for the ship
            Capacity = random.Next(MAX_WEIGHT) * CYCLE_WEIGHT +
                        random.Next(MAX_WEIGHT) * CAR_WEIGHT +
                        random.Next(MAX_WEIGHT) * TRUCK_WEIGHT +
                        random.Next(MAX_WEIGHT) * TRAIN_WEIGHT;
        }

        public int getShipLoad()
        {
            // calculate the total weight of the cargo on the ship.
            return CycleCount * CYCLE_WEIGHT +
                   CarCount * CAR_WEIGHT +
                   TruckCount * TRUCK_WEIGHT +
                   TrainCount * TRAIN_WEIGHT;
        }

        public int overUnder()
        {
            // return a value of how loaded the ship is.
            return Capacity - getShipLoad();
        }

        public override string ToString()
        {
            return "Capacity: " + Capacity + ", Current Load: " + getShipLoad();
        }
    }
}