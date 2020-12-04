namespace Electrical_appliances.Heper
{
    using System;
    using System.Collections;
    using Electrical_appliances.Abstractions;
    using Electrical_appliances.Enums;
    using Electrical_appliances.Helper;

    /// <summary>
    /// In this class i wanna creatre my custom collection.
    /// </summary>
    public class CustomCollectioncs : IEnumerable
    {
        private Appliances[] array;
        private int fullness;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomCollectioncs"/> class.
        /// </summary>
        /// <param name="size">size of custom collection.</param>
        public CustomCollectioncs(int size)
        {
            this.array = new Appliances[size];
            this.fullness = 0;
        }

        /// <summary>
        /// This method add new item to collection.
        /// </summary>
        /// <param name="item">new item.</param>
        public void Add(Appliances item)
        {
            int size = this.array.Length;

            if (size <= this.fullness)
            {
                this.fullness = size;
                Array.Resize(ref this.array, size + 1);
            }

            this.array[this.fullness] = item;
            this.fullness++;
        }

        /// <summary>
        /// Implemented interface.
        /// </summary>
        /// <returns>I dont know.</returns>
        public IEnumerator GetEnumerator()
        {
            return this.array.GetEnumerator();
        }

        /// <summary>
        /// Try find first element.
        /// </summary>
        /// <param name="country">country.</param>
        /// <param name="device">device.</param>
        /// <returns>item.</returns>
        public Appliances TryFind(Country country, Devices device)
        {
            Appliances temp = this.array.Find(country, device);
            return temp == null ? throw new Exception("This object doesn't exist") : temp;
        }
    }
}