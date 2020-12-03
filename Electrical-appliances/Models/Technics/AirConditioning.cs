﻿namespace Electrical_appliances.Models.Technics
{
    using System;
    using Electrical_appliances.Abstractions;
    using Electrical_appliances.Enums;

    /// <summary>
    /// Class AirConditioning.
    /// </summary>
    public class AirConditioning : Appliances
    {
        private bool isTurnOn;

        /// <summary>
        /// Initializes a new instance of the <see cref="AirConditioning"/> class.
        /// </summary>
        /// <param name="price">price.</param>
        /// <param name="productionPlace"> Place of production.</param>
        public AirConditioning(int price, Country productionPlace)
        : base(0.8, price, productionPlace, 90, Devices.AirConditioning)
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
            Console.WriteLine("I corrected the temperature");
        }
    }
}
