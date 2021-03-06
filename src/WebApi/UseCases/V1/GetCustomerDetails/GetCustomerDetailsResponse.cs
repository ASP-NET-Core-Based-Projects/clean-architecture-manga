namespace WebApi.UseCases.V1.GetCustomerDetails
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Domain.Customers.ValueObjects;
    using ViewModels;

    /// <summary>
    ///     The Customer Details.
    /// </summary>
    public sealed class GetCustomerDetailsResponse
    {
        public GetCustomerDetailsResponse(
            CustomerId customerId,
            SSN ssn,
            Name name,
            List<AccountDetailsModel> accounts)
        {
            this.CustomerId = customerId.ToGuid();
            this.SSN = ssn.ToString();
            this.Name = name.ToString();
            this.Accounts = accounts;
        }

        /// <summary>
        ///     Gets customer ID.
        /// </summary>
        [Required]
        public Guid CustomerId { get; }

        /// <summary>
        ///     Gets SSN.
        /// </summary>
        [Required]
        public string SSN { get; }

        /// <summary>
        ///     Gets name.
        /// </summary>
        [Required]
        public string Name { get; }

        /// <summary>
        ///     Gets accounts.
        /// </summary>
        [Required]
        public IList<AccountDetailsModel> Accounts { get; }
    }
}
