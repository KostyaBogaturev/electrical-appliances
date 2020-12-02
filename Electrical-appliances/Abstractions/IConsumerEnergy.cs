namespace Electrical_appliances.Abstractions
{
    /// <summary>
    /// Inteface ,which discribe thing which consume energy.
    /// </summary>
    public interface IConsumerEnergy
    {
        /// <summary>
        /// Gets for volume.
        /// </summary>
        public double Volume { get; }

        /// <summary>
        /// Gets for price.
        /// </summary>
        public int Price { get; }

        /// <summary>
        /// Gets or sets for Power Consumption.
        /// </summary>
        public int PowerConsumption { get; set; }
    }
}
