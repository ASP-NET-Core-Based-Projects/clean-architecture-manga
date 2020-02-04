// <copyright file="NameShouldNotBeEmptyException.cs" company="Ivan Paulovich">
// Copyright © Ivan Paulovich. All rights reserved.
// </copyright>

namespace Domain.Customers.ValueObjects
{
    /// <summary>
    /// Name Should Not Be Empty Exception.
    /// </summary>
    public sealed class NameShouldNotBeEmptyException : DomainException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NameShouldNotBeEmptyException"/> class.
        /// </summary>
        /// <param name="message">Message.</param>
        internal NameShouldNotBeEmptyException(string message)
            : base(message)
        {
        }
    }
}
