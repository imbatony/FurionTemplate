namespace NCloud.Core.Entity
{
    /// <summary>
    /// Defines the <see cref="Person" />.
    /// </summary>
    public class Person : Fur.DatabaseAccessor.Entity
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
