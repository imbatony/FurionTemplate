namespace NCloud.Core.Entity
{
    using Furion.DatabaseAccessor;

    /// <summary>
    /// Defines the <see cref="Person" />.
    /// </summary>
    public class Person : Entity
    {
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Age.
        /// </summary>
        public int Age { get; set; }
    }
}
