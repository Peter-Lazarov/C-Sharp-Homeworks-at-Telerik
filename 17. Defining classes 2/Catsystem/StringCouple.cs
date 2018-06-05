using System.Collections.Generic;

namespace Catsystem
{
    public class StringCouple
    {
        private List<string> keys;
        private List<string> values;

        public StringCouple()
        {
            this.keys = new List<string>();
            this.values = new List<string>();
        }

        public string this[string index]
        {
            get
            {
                var indexInKeys = this.keys.IndexOf(index);
                return this.values[indexInKeys];
            }
            set
            {
                var indexInKeys = this.keys.IndexOf(index);
                this.values[indexInKeys] = value;
            }
        }

        public void Add(string key, string value)
        {
            this.keys.Add(key);
            this.values.Add(value);
        }
    }
}
