using System;
using System.Collections.Generic;
using System.IO;

namespace DesignPatterns.SOLID.SingleResposibility
{
    class Journal
    {
        private readonly List<string> entries;

        public Journal()
        {
            this.entries = new List<string>();
        }

        public void Add(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentNullException(nameof(text));

            this.entries.Add(text);
        }

        public void Remove(uint index)
        {
            this.entries.RemoveAt((int)index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, this.entries);
        }

        // Two methods below violate the Single Responsibility principle because the class has too many responsibilities.
        public void Save(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));

            File.WriteAllText(path, this.ToString());
        }

        public List<Journal> Read(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));

            // read and deserialize to objects
            throw new NotImplementedException();
        }
    }
}
