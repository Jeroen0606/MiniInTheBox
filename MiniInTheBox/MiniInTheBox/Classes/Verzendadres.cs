// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Verzendadres.cs" company="">
//   
// </copyright>
// <summary>
//   The verzendadres.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MiniInTheBox.Classes
{
    /// <summary>
    /// The verzendadres.
    /// </summary>
    public class Verzendadres
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Verzendadres"/> class.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <param name="verzendadres">
        /// The verzendadres.
        /// </param>
        /// <param name="verzendadresVervolg">
        /// The verzendadres vervolg.
        /// </param>
        /// <param name="stad">
        /// The stad.
        /// </param>
        /// <param name="bestemmingsland">
        /// The bestemmingsland.
        /// </param>
        /// <param name="provincie">
        /// The provincie.
        /// </param>
        /// <param name="postcode">
        /// The postcode.
        /// </param>
        /// <param name="telefoonnummer">
        /// The telefoonnummer.
        /// </param>
        public Verzendadres(
            int id, 
            string verzendadres, 
            string verzendadresVervolg, 
            string stad, 
            string bestemmingsland, 
            string provincie, 
            string postcode, 
            string telefoonnummer)
        {
            this.Id = id;
            this.Verzendadres1 = verzendadres;
            this.VerzendadresVervolg = verzendadresVervolg;
            this.Stad = stad;
            this.Bestemmingsland = bestemmingsland;
            this.Provincie = provincie;
            this.Postcode = postcode;
            this.Telefoonnummer = telefoonnummer;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the bestemmingsland.
        /// </summary>
        public string Bestemmingsland { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the postcode.
        /// </summary>
        public string Postcode { get; set; }

        /// <summary>
        /// Gets or sets the provincie.
        /// </summary>
        public string Provincie { get; set; }

        /// <summary>
        /// Gets or sets the stad.
        /// </summary>
        public string Stad { get; set; }

        /// <summary>
        /// Gets or sets the telefoonnummer.
        /// </summary>
        public string Telefoonnummer { get; set; }

        /// <summary>
        /// Gets or sets the verzendadres 1.
        /// </summary>
        public string Verzendadres1 { get; set; }

        /// <summary>
        /// Gets or sets the verzendadres vervolg.
        /// </summary>
        public string VerzendadresVervolg { get; set; }

        #endregion
    }
}