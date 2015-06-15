// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Winkelwagen.cs" company="">
//   
// </copyright>
// <summary>
//   The winkelwagen.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MiniInTheBox.Classes
{
    /// <summary>
    /// The winkelwagen.
    /// </summary>
    public class Winkelwagen
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Winkelwagen"/> class.
        /// </summary>
        /// <param name="accountId">
        /// The account id.
        /// </param>
        public Winkelwagen(int accountId)
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