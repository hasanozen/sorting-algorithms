namespace SortingAlgorithms
{
    class Settings
    {
        public static Form1 Instance { get; private set; }

        private bool randomize;
        public bool Randomize { get { return randomize; } set { randomize = value; } }

        private int size;
        public int Size { get { return size; } set { size = value; } }

        private int lowerLimit;
        public int LowerLimit { get { return lowerLimit; } set { lowerLimit = value; } }

        private int upperLimit;
        public int UpperLimit { get { return upperLimit; } set { upperLimit = value; } }

        private int delay;
        public int Delay { get { return delay; } set { delay = value; } }

        private bool isColor;
        public bool IsColor { get { return isColor; } set { isColor = value; } }

        private int visualizeStyle;
        public int VisualizeStyle { get { return visualizeStyle; } set { visualizeStyle = value; } }

        //
        // Summary:
        //     Creates a new algorithm settings.
        //
        // Parameters:
        //   randomize:
        //     The random value for the array numbers. Valid values are true or
        //     false.
        //
        //   size:
        //     The array size to create the new array.
        //
        //   lower:
        //     Base for random numbers.
        //
        //   upper:
        //     Ceiling for random numbers.
        //
        //   delay:
        //     Delay for algorithm operation.
        //
        //   color:
        //     The bool value for colorization. Valid values are true or false.
        //
        // Returns:
        //     The algorithm settings that this method creates.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     randomize is not true or false.
        //     size is less then 0.
        public Settings(bool randomize, int size, int lower, int upper, int delay, bool color, int visual)
        {
            this.randomize = randomize;
            this.size = size;
            this.lowerLimit = lower;
            this.upperLimit = upper;
            this.delay = delay;
            this.isColor = color;
            this.visualizeStyle = visual;
        }
    }
}
