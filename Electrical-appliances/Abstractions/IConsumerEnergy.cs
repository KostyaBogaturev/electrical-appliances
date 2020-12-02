namespace Electrical_appliances.Abstractions
{
    /// <summary>
    /// Inteface ,which discribe thing which consume energy.
    /// </summary>
    public interface IConsumerEnergy
    {
        /// <summary>
        /// Gets for height.
        /// </summary>
        public double Height { get; }

        /// <summary>
        /// Gets for length.
        /// </summary>
        public double Length { get;  }

        /// <summary>
        /// Gets for width.
        /// </summary>
        public double Width { get; }

        /// <summary>
        /// Gets or sets for Power Consumption.
        /// </summary>
        public int PowerConsumption { get; set; }
    }
}
