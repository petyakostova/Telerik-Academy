namespace MyCollections
{
    using System;
    using CatSystem;

    public class GenericList<T> where T : Animal
        //public class GenericList<T>  // without restrictions for T
        //public class GenericList<T> where T : new() // want every type in GenericList to have parameterless constructor 
        //public class GenericList<T> where T : class // works if T is class => won't work when T is int
    {
        private T[] elements; // this list works with array
        private int index; // on which index we filled the array

        // constructor
        public GenericList()
        {
            this.elements = new T[16];
            this.index = 0; // by creating the index is 0
        }

        // method
        public void Add(T element)
        {
            // won't work because element is T type, so behaves like object 
            //var sum = element + element; 
            //var sum = element < element; 

            this.elements[this.index] = element;
            this.index++; // for the next time when we add something

            //if (this.index == this.elements.Length)
            //{
            //    // resize... for Homework
            //    // copy the elements in new array with 32 elements...
            //}
        }

        // define indexer for the class
        public T this[int index]
        {
            get
            {
                return this.elements[index];
            }
            set
            {
                if (index < 0 || index >= this.elements.Length)
                {
                    throw new IndexOutOfRangeException();
                }

                this.elements[index] = value;
            }
        }

    }
}