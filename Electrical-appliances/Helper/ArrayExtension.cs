namespace Electrical_appliances.Helper
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Electrical_appliances.Abstractions;
    using Electrical_appliances.Enums;

    /// <summary>
    /// asd.
    /// </summary>
    public static class ArrayExtension
    {
        /// <summary>
        /// Find first finded element.
        /// </summary>
        /// <param name="arr">Array.</param>
        /// <param name="country">Production country.</param>
        /// <param name="device">Type of device.</param>
        /// <returns>First finded device.</returns>
        public static Appliances Find(this Appliances[] arr, Country country, Devices device)
        {
            Appliances temp = null;
            foreach (var item in arr)
            {
                if (item.ProductionPlace == country && item.Type == device)
                {
                    temp = item;
                }
            }

            return temp;
        }
    }
}
