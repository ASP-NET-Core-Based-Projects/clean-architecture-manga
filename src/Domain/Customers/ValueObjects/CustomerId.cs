namespace Domain.Customers.ValueObjects
{
    using System;

    /// <summary>
    /// CustomerId <see href="https://github.com/ivanpaulovich/clean-architecture-manga/wiki/Domain-Driven-Design-Patterns#entity">Entity Design Pattern</see>.
    /// </summary>
    public readonly struct CustomerId
    {
        private readonly Guid _customerId;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerId"/> struct.
        /// </summary>
        /// <param name="customerId">Customer Guid.</param>
        public CustomerId(Guid customerId)
        {
            if (customerId == Guid.Empty)
            {
                throw new EmptyCustomerIdException($"{nameof(customerId)} cannot be empty.");
            }

            this._customerId = customerId;
        }

        /// <summary>
        /// Converts into String.
        /// </summary>
        /// <returns>String.</returns>
        public override string ToString()
        {
            return this._customerId.ToString();
        }

        /// <summary>
        /// Converts into Guid.
        /// </summary>
        /// <returns>Guid.</returns>
        public Guid ToGuid() => this._customerId;
    }
}
