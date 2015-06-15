// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CategorieProduct.cs" company="">
//   
// </copyright>
// <summary>
//   The categorie product.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MiniInTheBox.Classes
{
    /// <summary>
    /// The categorie product.
    /// </summary>
    public class CategorieProduct
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CategorieProduct"/> class.
        /// </summary>
        /// <param name="categorie">
        /// The categorie.
        /// </param>
        public CategorieProduct(string categorie)
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