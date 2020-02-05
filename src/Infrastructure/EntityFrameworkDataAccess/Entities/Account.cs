// <copyright file="Account.cs" company="Ivan Paulovich">
// Copyright © Ivan Paulovich. All rights reserved.
// </copyright>

namespace Infrastructure.EntityFrameworkDataAccess
{
    using System;
    using System.Collections.Generic;
    using Domain.Accounts.Credits;
    using Domain.Accounts.Debits;
    using Domain.Accounts.ValueObjects;
    using Domain.Customers.ValueObjects;

    /// <summary>
    /// Account.
    /// </summary>
    public class Account : Domain.Accounts.Account
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Account"/> class.
        /// </summary>
        /// <param name="customerId">CustomerId.</param>
        public Account(CustomerId customerId)
        {
            Id = new AccountId(Guid.NewGuid());
            CustomerId = customerId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Account"/> class.
        /// </summary>
        protected Account()
        {
        }

        /// <summary>
        /// Gets or sets CustomerId.
        /// </summary>
        public CustomerId CustomerId { get; protected set; }

        /// <summary>
        /// Load Relationships.
        /// </summary>
        /// <param name="credits">Credits.</param>
        /// <param name="debits">Debits.</param>
        public void Load(IList<Credit> credits, IList<Debit> debits)
        {
            Credits = new CreditsCollection();
            Credits.Add(credits);

            Debits = new DebitsCollection();
            Debits.Add(debits);
        }
    }
}
