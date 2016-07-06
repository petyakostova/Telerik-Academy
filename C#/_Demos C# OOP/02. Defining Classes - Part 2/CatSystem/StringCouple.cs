namespace CatSystem
{
    using System;
    using System.Collections.Generic;

    public class StringCouple
    {
        private List<string> keys;
        private List<string> values;

        public StringCouple()
        {
            this.keys = new List<string>();
            this.values = new List<string>();
        }

        // we want indexer to work this way
        public string this[string index]
        {
            get
            {
                var indexInKeys = this.keys.IndexOf(index);
                if (indexInKeys < 0)
                {
                    throw new ArgumentException("Index was not found");
                }
                return this.values[indexInKeys];
            }
            set
            {
                var indexInKeys = this.keys.IndexOf(index);
                this.values[indexInKeys] = value;
            }
        }

        // allows to this collection to add couples of strings and the first string corresponds to the second string 
        public void Add(string key, string value)
        {
            this.keys.Add(key);
            this.values.Add(value);
        }

    }
}