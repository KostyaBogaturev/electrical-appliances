namespace Electrical_appliances.Models.Technics
{
    using System;
    using Electrical_appliances.Abstractions;
    using Electrical_appliances.Enums;

    /// <summary>
    /// Class Washing Machine.
    /// </summary>
    public class WashingMachine : Appliances
    {
        private bool isTurnOn;

        /// <summary>
        /// Initializes a new instance of the <see cref="WashingMachine"/> class.
        /// </summary>
        /// <param name="price">price.</param>
        /// <param name="productionPlace"> Place of production.</param>
        public WashingMachine(int price, Country productionPlace)
        : base(1.5, price, productionPlace, 220, Devices.WashingMachine)
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
            Console.WriteLine("I washed a clothes");
        }
    }
}
