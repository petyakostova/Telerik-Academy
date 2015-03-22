namespace CatSystem
{
    public class GenericList<T> where T : Animal
    // public class GenericList<T>  // without restrictions for T
    //public class GenericList<T> where T : class // works if T is class => won't work when T is int
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
            //// won't work because element is T type, so behaves like object 
            //var sum = element + element; 
            //var sum = element < element; 

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
