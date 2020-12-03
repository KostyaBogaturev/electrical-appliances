namespace Electrical_appliances.Models.Technics
{
    using System;
    using Electrical_appliances.Abstractions;
    using Electrical_appliances.Enums;

    /// <summary>
    /// Class Kettle.
    /// </summary>
    public class Kettle : Appliances
    {
        private bool isTurnOn;

        /// <summary>
        /// Initializes a new instance of the <see cref="Kettle"/> class.
        /// </summary>
        /// <param name="price">price.</param>
        /// <param name="productionPlace"> Place of production.</param>
        public Kettle(int price, Country productionPlace)
        : base(0.0072, price, productionPlace, 12, Devices.Kettle)
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
            Console.WriteLine("I boiled water");
        }
    }
}
