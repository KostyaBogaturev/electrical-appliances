namespace Electrical_appliances.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Electrical_appliances.Abstractions;
    using Electrical_appliances.Enums;
    using Electrical_appliances.Heper;

    /// <summary>
    /// Describe class home.
    /// </summary>
    public class Home : IConsumerEnergy
    {
        private readonly double volume;
        private readonly int price;
        private readonly Country productionPlace;

        private int powerConsumption;
        private CustomCollectioncs devices;

        /// <summary>
        /// Initializes a new instance of the <see cref="Home"/> class.
        /// </summary>
        /// <param name="volume">volume of house.</param>
        /// <param name="price">price of house.</param>
        /// <param name="productionPlace">place of production of house.</param>
        public Home(double volume, int price, Country productionPlace)
        {
            this.volume = volume;
            this.price = price;
            this.productionPlace = productionPlace;
            this.powerConsumption = 0;
            this.devices = new CustomCollectioncs(1);
        }

        /// <summary>
        /// Gets implement interface property volume.
        /// </summary>
        public double Volume => this.volume;

        /// <summary>
        /// Gets implement interface property price.
        /// </summary>
        public int Price => this.price;

        /// <summary>
        /// Gets or sets implement interface property volume.
        /// </summary>
        public int PowerConsumption
        {
            get
            {
                return this.powerConsumption;
            }

            set
            {
                this.powerConsumption = value;
            }
        }

        /// <summary>
        /// Gets implement interface property place of production.
        /// </summary>
        public Country ProductionPlace => this.productionPlace;

        /// <summary>
        /// Find device in array.
        /// </summary>
        /// <param name="country">Country.</param>
        /// <param name="device">type.</param>
        public void FindDevice(Country country, Devices device)
        {
            try
            {
                Console.WriteLine(this.devices.TryFind(country, device));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Adding new item to devices.
        /// </summary>
        /// <param name="temp">name of appliances.</param>
        public void Add(Appliances temp)
        {
            this.devices.Add(temp);
        }

        /// <summary>
        /// Count the consumed energy in house.
        /// </summary>
        /// <returns>int counter.</returns>
        public int ConsumedEnergy()
        {
            int counter = 0;

            foreach (Appliances item in this.devices)
            {
                if (item.IsTurnOn)
                {
                    counter += item.PowerConsumption;
                }
            }

            return counter;
        }

        /// <summary>
        /// Output array of devices at home.
        /// </summary>
        public void Output()
        {
            foreach (var item in this.devices)
            {
                Console.WriteLine(item);
            }
        }
    }
}
