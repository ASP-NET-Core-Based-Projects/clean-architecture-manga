namespace Domain.Security.ValueObjects
{
    /// <summary>
    /// ExternalUserId <see href="https://github.com/ivanpaulovich/clean-architecture-manga/wiki/Domain-Driven-Design-Patterns#entity">Entity Design Pattern</see>.
    /// </summary>
    public readonly struct ExternalUserId
    {
        private readonly string _text;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalUserId"/> struct.
        /// </summary>
        /// <param name="text">External User Id.</param>
        public ExternalUserId(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ExternalUserIdShouldNotBeEmptyException($"The '{nameof(text)}' field is required.");
            }

            this._text = text;
        }

        /// <summary>
        /// Converts into string.
        /// </summary>
        /// <returns>String.</returns>
        public override string ToString()
        {
            return this._text;
        }
    }
}
