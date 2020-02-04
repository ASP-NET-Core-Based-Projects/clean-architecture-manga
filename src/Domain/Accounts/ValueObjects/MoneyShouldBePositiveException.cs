// <copyright file="MoneyShouldBePositiveException.cs" company="Ivan Paulovich">
// Copyright © Ivan Paulovich. All rights reserved.
// </copyright>

namespace Domain.Accounts.ValueObjects
{
    /// <summary>
    /// Money Should Be Positive Exception.
    /// </summary>
    public sealed class MoneyShouldBePositiveException : DomainException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MoneyShouldBePositiveException"/> class.
        /// </summary>
        /// <param name="message">Message.</param>
        internal MoneyShouldBePositiveException(string message)
            : base(message)
        {
        }
    }
}
