namespace Electrical_appliances.Abstractions
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Electrical_appliances.Enums;

    /// <summary>
    /// Abstract class witch describe electro. devices.
    /// </summary>
    public abstract class Appliances : IConsumerEnergy
    {
        private readonly double volume;
        private readonly int price;
        private readonly Country productionPlace;
        private readonly Devices type;
        private readonly int powerConsumption;

        /// <summary>
        /// Initializes a new instance of the <see cref="Appliances"/> class.
        /// </summary>
        /// <param name="volume">Volume of appliances.</param>
        /// <param name="price">Price of appliances.</param>
        /// <param name="productionPlace">Place of prodaction of appliances.</param>
        /// <param name="powerConsumption">Consumption of power of appliances.</param>
        /// <param name="type">Type of appliances.</param>
        public Appliances(double volume, int price, Country productionPlace, int powerConsumption, Devices type)
        {
            this.volume = volume;
            this.price = price;
            this.productionPlace = productionPlace;
            this.powerConsumption = powerConsumption;
            this.type = type;
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
                return;
            }
        }

        /// <summary>
        /// Gets implement interface property place of production.
        /// </summary>
        public Country ProductionPlace => this.productionPlace;

        /// <summary>
        /// Gets type of device.
        /// </summary>
        public Devices Type => this.type;

        /// <summary>
        /// Gets or sets a value indicating whether is this appliances turn on.
        /// </summary>
        public abstract bool IsTurnOn { get; set; }

        /// <summary>
        /// This method return what make appliances which we use.
        /// </summary>
        protected abstract void Use();
    }
}