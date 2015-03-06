using System;
using System.Linq;

namespace Number_Calculations
{
    class NumberSequence<T>
        where T : IComparable
    {
        private T[] numbers;
        private T min;
        private T max;
        private T sum;
        private T product;
        private T average;

        public NumberSequence(T[] numbers)
        {
            this.numbers = numbers;
            GetResults();
        }

        public T Min
        {
            get
            {
                return this.min;
            }
            private set
            {
                this.min = value;
            }
        }

        public T Max
        {
            get
            {
                return this.max;
            }
            private set
            {
                this.max = value;
            }
        }

        public T Sum
        {
            get
            {
                return this.sum;
            }
            private set
            {
                this.sum = value;
            }
        }

        public T Product
        {
            get
            {
                return this.product;
            }
            private set
            {
                this.product = value;
            }
        }

        public T Average
        {
            get
            {
                return this.average;
            }
            private set
            {
                this.average = value;
            }
        }

        private void GetResults()
        {
            this.Min = this.numbers.Min();
            this.Max = this.numbers.Max();
            dynamic product = 1;
            dynamic sum = 0;

            foreach (var number in numbers)
            {
                product *= number;
                sum += number;
            }

            this.Product = (T)product;
            this.Sum = (T)sum;
            this.Average = (T)(this.sum / (dynamic)this.numbers.Length);
        }

        public override string ToString()
        {
            return String.Format(@"
[{0}]
MIN:  {1, -10} SUM:   {3, -15}
MAX:  {2, -10} PROD:  {4, -15}
AVG:  {5}
            ", String.Join(", ", this.numbers), this.Min, this.Max, this.Sum, this.Product, this.Average);
        }
    }
}
