// <copyright file="SSNShouldNotBeEmptyException.cs" company="Ivan Paulovich">
// Copyright © Ivan Paulovich. All rights reserved.
// </copyright>

namespace Domain.Customers.ValueObjects
{
    /// <summary>
    /// SSN Should Not Be Empty Exception.
    /// </summary>
    public sealed class SSNShouldNotBeEmptyException : DomainException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SSNShouldNotBeEmptyException"/> class.
        /// </summary>
        /// <param name="message">Message.</param>
        internal SSNShouldNotBeEmptyException(string message)
            : base(message)
        {
        }
    }
}
