namespace NCloud.Application
{
    using System.Collections.Generic;
    using Furion.DatabaseAccessor;
    using Furion.DynamicApiController;
    using NCloud.Core.Entity;

    /// <summary>
    /// Defines the <see cref="PersonAppService" />.
    /// </summary>
    public class PersonAppService : IDynamicApiController
    {
        /// <summary>
        /// Defines the repository.
        /// </summary>
        private readonly IRepository<Person> repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonAppService"/> class.
        /// </summary>
        /// <param name="repository">The repository<see cref="IRepository{Person}"/>.</param>
        public PersonAppService(IRepository<Person> repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// The Insert.
        /// </summary>
        /// <param name="person">The person<see cref="Person"/>.</param>
        public void Insert(Person person)
        {
            repository.Insert(person);
        }

        /// <summary>
        /// The GetAll.
        /// </summary>
        /// <returns>The <see cref="List{Person}"/>.</returns>
        public List<Person> GetAll()
        {
            return repository.AsEnumerable();
        }
    }
}
