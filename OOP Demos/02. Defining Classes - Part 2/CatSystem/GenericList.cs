namespace CatSystem
{
    public class GenericList<T>
    {
        private T[] elements;
        private int index;

        // constructor
        public GenericList()
        {
            this.elements = new T[16];
            this.index = 0;
        }

        public void Add(T element)
        {
            this.elements[this.index] = element;
            this.index++;

            //if (this.index == this.elements.Length)
            //{
            //    // resize... for Homework
            //    // copy the elements in new array with 32 elements...
            //}
        }
    }
}
