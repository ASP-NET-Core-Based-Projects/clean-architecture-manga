namespace Domain.Accounts.Credits
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Domain.Accounts.ValueObjects;

    /// <summary>
    /// Credits <see href="https://github.com/ivanpaulovich/clean-architecture-manga/wiki/Design-Patterns#first-class-collections">First-Class Collection Design Pattern</see>.
    /// </summary>
    public sealed class CreditsCollection
    {
        private readonly IList<ICredit> _credits;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditsCollection"/> class.
        /// </summary>
        public CreditsCollection()
        {
            this._credits = new List<ICredit>();
        }

        /// <summary>
        /// Adds a list of credits.
        /// </summary>
        /// <typeparam name="T">Some ICredit implementation.</typeparam>
        /// <param name="credits">The list of credits.</param>
        public void Add<T>(IEnumerable<T> credits)
            where T : ICredit
        {
            foreach (var credit in credits)
            {
                this.Add(credit);
            }
        }

        /// <summary>
        /// Adds a Credit.
        /// </summary>
        /// <param name="credit">ICredit implementation.</param>
        public void Add(ICredit credit) => this._credits.Add(credit);

        /// <summary>
        /// List Transactions.
        /// </summary>
        /// <returns>ReadOnly Transactions.</returns>
        public IReadOnlyCollection<ICredit> GetTransactions()
        {
            var transactions = new ReadOnlyCollection<ICredit>(this._credits);
            return transactions;
        }

        /// <summary>
        /// Gets Total amount.
        /// </summary>
        /// <returns>Positive amount.</returns>
        public PositiveMoney GetTotal()
        {
            PositiveMoney total = new PositiveMoney(0);

            foreach (ICredit credit in this._credits)
            {
                total = credit.Sum(total);
            }

            return total;
        }
    }
}
