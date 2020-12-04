namespace Electrical_appliances.Models.Technics
{
    using System;
    using Electrical_appliances.Abstractions;
    using Electrical_appliances.Enums;

    /// <summary>
    /// Class Fridge.
    /// </summary>
    public class Fridge : Appliances
    {
        private bool isTurnOn;

        /// <summary>
        /// Initializes a new instance of the <see cref="Fridge"/> class.
        /// </summary>
        /// <param name="price">price.</param>
        /// <param name="productionPlace"> Place of production.</param>
        public Fridge(int price, Country productionPlace)
        : base(2.3, price, productionPlace, 420, Devices.Fridge)
        {
            this.isTurnOn = false;
        }

        /// <summary>
        /// Gets or sets a value indicating whether is device turn on.
        /// </summary>
        public override bool IsTurnOn { get => this.isTurnOn; set => this.isTurnOn = value; }

        /// <summary>
        /// Use kettle.
        /// </summary>
        public override void Use()
        {
            Console.WriteLine("I cool the products");
        }
    }
}
