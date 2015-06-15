// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CategorieVraag.cs" company="">
//   
// </copyright>
// <summary>
//   The categorie vraag.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MiniInTheBox.Classes
{
    /// <summary>
    /// The categorie vraag.
    /// </summary>
    public class CategorieVraag
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CategorieVraag"/> class.
        /// </summary>
        /// <param name="categorie">
        /// The categorie.
        /// </param>
        public CategorieVraag(string categorie)
        {
            this.Categorie = categorie;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the categorie.
        /// </summary>
        public string Categorie { get; set; }

        #endregion
    }
}