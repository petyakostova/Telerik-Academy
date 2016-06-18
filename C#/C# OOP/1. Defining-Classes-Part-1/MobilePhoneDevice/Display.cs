namespace MobilePhoneDevice
{
    using System;

    // 1. class that holds information about display characteristics: size and number of colors
    public class Display
    {
        // constants (instead of null values)

        private const int DefaultHeight = 180;
        private const int DefaultWidth = 120;
        private const long DefaultNumberOfColors = 16000000;

        // fields

        private int height;
        private int width;
        private long numberOfColors;

        // constructors

        public Display()
            : this(DefaultHeight, DefaultWidth, DefaultNumberOfColors) { }

        public Display(int height, int width, long numberOfColors)
        {
            this.Height = height;
            this.Width = width;
            this.NumberOfColors = numberOfColors;
        }
        
        // properties

        public int Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height must be > 0");
                }

                this.height = value;
            }
        }

        public int Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width must be > 0");
                }

                this.width = value;
            }
        }

        public long NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Number of colors must be > 0");
                }

                this.numberOfColors = value;
            }
        }
        
    }
}
