// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Vraag.cs" company="">
//   
// </copyright>
// <summary>
//   The vraag.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MiniInTheBox.Classes
{
    /// <summary>
    /// The vraag.
    /// </summary>
    public class Vraag
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Vraag"/> class.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <param name="vraag">
        /// The vraag.
        /// </param>
        /// <param name="antwoord">
        /// The antwoord.
        /// </param>
        public Vraag(int id, string vraag, string antwoord)
        {
            this.Id = id;
            this.Vraag1 = vraag;
            this.Antwoord = antwoord;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vraag"/> class.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <param name="vraag">
        /// The vraag.
        /// </param>
        /// <param name="antwoord">
        /// The antwoord.
        /// </param>
        /// <param name="nuttig">
        /// The nuttig.
        /// </param>
        /// <param name="nietNuttig">
        /// The niet nuttig.
        /// </param>
        public Vraag(int id, string vraag, string antwoord, int nuttig, int nietNuttig)
        {
            this.Id = id;
            this.Vraag1 = vraag;
            this.Antwoord = antwoord;
            this.Nuttig = nuttig;
            this.NietNuttig = nietNuttig;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the antwoord.
        /// </summary>
        public string Antwoord { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the niet nuttig.
        /// </summary>
        public int NietNuttig { get; set; }

        /// <summary>
        /// Gets or sets the nuttig.
        /// </summary>
        public int Nuttig { get; set; }

        /// <summary>
        /// Gets or sets the vraag 1.
        /// </summary>
        public string Vraag1 { get; set; }

        #endregion
    }
}