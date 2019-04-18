using System;

namespace MonteCarlo
{
    public struct Coords
    {
        private readonly double y;

        public double X
        {
            get;
            set; 
        }

        public double Y
        {
            get => X;
            set => X = value;
        }

        // Sets a random value to coords
        public Coords(double x, double y)
        {
            X = x;
            this.y = y;
        }

        public Coords(Random random)
        {
            X = random.NextDouble();
            y = random.NextDouble();
        }

        // Calculates the hypotenuse 
        public double Hypotenuse()
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(y, 2));
        }
    }
}