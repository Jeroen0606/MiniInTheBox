// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Product.cs" company="">
//   
// </copyright>
// <summary>
//   The product.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MiniInTheBox.Classes
{
    /// <summary>
    /// The product.
    /// </summary>
    public class Product
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <param name="naam">
        /// The naam.
        /// </param>
        /// <param name="verzending">
        /// The verzending.
        /// </param>
        /// <param name="prijs">
        /// The prijs.
        /// </param>
        /// <param name="aantal">
        /// The aantal.
        /// </param>
        /// <param name="kleur">
        /// The kleur.
        /// </param>
        /// <param name="verwerkingstijd">
        /// The verwerkingstijd.
        /// </param>
        /// <param name="verzendenNaar">
        /// The verzenden naar.
        /// </param>
        /// <param name="verzendtijd">
        /// The verzendtijd.
        /// </param>
        /// <param name="eigenschappen">
        /// The eigenschappen.
        /// </param>
        /// <param name="specificaties">
        /// The specificaties.
        /// </param>
        /// <param name="leverancier">
        /// The leverancier.
        /// </param>
        public Product(
            int id, 
            string naam, 
            string verzending, 
            decimal prijs, 
            int aantal, 
            string kleur, 
            string verwerkingstijd, 
            string verzendenNaar, 
            string verzendtijd, 
            string eigenschappen, 
            string specificaties, 
            string leverancier)
        {
            this.Id = id;
            this.Naam = naam;
            this.Verzending = verzending;
            this.Prijs = prijs;
            this.Aantal = aantal;
            this.Kleur = kleur;
            this.Verwerkingstijd = verwerkingstijd;
            this.VerzendenNaar = verzendenNaar;
            this.Verzendtijd = verzendtijd;
            this.Eigenschappen = eigenschappen;
            this.Specificaties = specificaties;
            this.Leverancier = leverancier;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the aantal.
        /// </summary>
        public int Aantal { get; set; }

        /// <summary>
        /// Gets or sets the eigenschappen.
        /// </summary>
        public string Eigenschappen { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the kleur.
        /// </summary>
        public string Kleur { get; set; }

        /// <summary>
        /// Gets or sets the leverancier.
        /// </summary>
        public string Leverancier { get; set; }

        /// <summary>
        /// Gets or sets the naam.
        /// </summary>
        public string Naam { get; set; }

        /// <summary>
        /// Gets or sets the prijs.
        /// </summary>
        public decimal Prijs { get; set; }

        /// <summary>
        /// Gets or sets the specificaties.
        /// </summary>
        public string Specificaties { get; set; }

        /// <summary>
        /// Gets or sets the verwerkingstijd.
        /// </summary>
        public string Verwerkingstijd { get; set; }

        /// <summary>
        /// Gets or sets the verzenden naar.
        /// </summary>
        public string VerzendenNaar { get; set; }

        /// <summary>
        /// Gets or sets the verzending.
        /// </summary>
        public string Verzending { get; set; }

        /// <summary>
        /// Gets or sets the verzendtijd.
        /// </summary>
        public string Verzendtijd { get; set; }

        #endregion
    }
}