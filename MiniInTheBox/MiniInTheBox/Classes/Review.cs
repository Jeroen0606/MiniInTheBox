// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Review.cs" company="">
//   
// </copyright>
// <summary>
//   The review.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MiniInTheBox.Classes
{
    /// <summary>
    /// The review.
    /// </summary>
    public class Review
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Review"/> class.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <param name="tekst">
        /// The tekst.
        /// </param>
        /// <param name="beoordeling">
        /// The beoordeling.
        /// </param>
        public Review(int id, string tekst, int beoordeling)
        {
            this.Id = id;
            this.Tekst = tekst;
            this.Beoordeling = beoordeling;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the beoordeling.
        /// </summary>
        public int Beoordeling { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the tekst.
        /// </summary>
        public string Tekst { get; set; }

        #endregion
    }
}