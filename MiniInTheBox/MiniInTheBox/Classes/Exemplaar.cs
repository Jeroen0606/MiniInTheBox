// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Exemplaar.cs" company="">
//   
// </copyright>
// <summary>
//   The exemplaar.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MiniInTheBox.Classes
{
    /// <summary>
    /// The exemplaar.
    /// </summary>
    public class Exemplaar
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Exemplaar"/> class.
        /// </summary>
        /// <param name="accountId">
        /// The account id.
        /// </param>
        public Exemplaar(int accountId)
        {
            this.AccountId = accountId;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the account id.
        /// </summary>
        public int AccountId { get; set; }

        #endregion
    }
}