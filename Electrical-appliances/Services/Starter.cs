namespace Electrical_appliances.Services
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Electrical_appliances.Abstractions;
    using Electrical_appliances.Enums;
    using Electrical_appliances.Models;
    using Electrical_appliances.Models.Technics;

    /// <summary>
    /// Starter class.
    /// </summary>
    public class Starter
    {
        /// <summary>
        /// Run method.
        /// </summary>
        public static void Run()
        {
            Home home = new Home(40, 100000, Country.USA);
            AirConditioning conditioner = new AirConditioning(1000, Country.France);
            Appliances temp = conditioner;
            home.Add(temp);
            Kettle kettle = new Kettle(20, Country.Japan);
            temp = kettle;
            home.Add(temp);
            Oven oven = new Oven(200, Country.France);
            temp = oven;
            home.Add(temp);
            home.Output();
            home.FindDevice(Country.France, Devices.AirConditioning);

            kettle.IsTurnOn = true;
            Console.WriteLine(home.ConsumedEnergy());
        }
    }
}
