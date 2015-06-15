// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Bestelling.cs" company="">
//   
// </copyright>
// <summary>
//   The bestelling.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MiniInTheBox.Classes
{
    using System;

    /// <summary>
    /// The bestelling.
    /// </summary>
    public class Bestelling
    {
        #region Fields

        /// <summary>
        /// The datum.
        /// </summary>
        private DateTime datum;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Bestelling"/> class.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <param name="datum">
        /// The datum.
        /// </param>
        /// <param name="bedrag">
        /// The bedrag.
        /// </param>
        /// <param name="status">
        /// The status.
        /// </param>
        /// <param name="verzondenNaar">
        /// The verzonden naar.
        /// </param>
        /// <param name="verzendmethode">
        /// The verzendmethode.
        /// </param>
        /// <param name="betaalmethode">
        /// The betaalmethode.
        /// </param>
        /// <param name="gefactureerdAan">
        /// The gefactureerd aan.
        /// </param>
        public Bestelling(
            int id, 
            DateTime datum, 
            decimal bedrag, 
            string status, 
            string verzondenNaar, 
            string verzendmethode, 
            string betaalmethode, 
            string gefactureerdAan)
        {
            this.Id = id;
            this.datum = datum;
            this.Bedrag = bedrag;
            this.Status = status;
            this.VerzondenNaar = verzondenNaar;
            this.Verzendmethode = verzendmethode;
            this.Betaalmethode = betaalmethode;
            this.GefactureerdAan = gefactureerdAan;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the bedrag.
        /// </summary>
        public decimal Bedrag { get; set; }

        /// <summary>
        /// Gets or sets the betaalmethode.
        /// </summary>
        public string Betaalmethode { get; set; }

        /// <summary>
        /// Gets or sets the datum.
        /// </summary>
        public DateTime Datum
        {
            get
            {
                return this.datum;
            }

            set
            {
                this.datum = value;
            }
        }

        /// <summary>
        /// Gets or sets the gefactureerd aan.
        /// </summary>
        public string GefactureerdAan { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the verzendmethode.
        /// </summary>
        public string Verzendmethode { get; set; }

        /// <summary>
        /// Gets or sets the verzonden naar.
        /// </summary>
        public string VerzondenNaar { get; set; }

        #endregion
    }
}