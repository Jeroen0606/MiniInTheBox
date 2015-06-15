// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Account.cs" company="">
//   
// </copyright>
// <summary>
//   The account.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MiniInTheBox.Classes
{
    /// <summary>
    /// The account.
    /// </summary>
    public class Account
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Account"/> class.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <param name="voornaam">
        /// The voornaam.
        /// </param>
        /// <param name="achternaam">
        /// The achternaam.
        /// </param>
        /// <param name="emailadres">
        /// The emailadres.
        /// </param>
        /// <param name="wachtwoord">
        /// The wachtwoord.
        /// </param>
        public Account(int id, string voornaam, string achternaam, string emailadres, string wachtwoord)
        {
            this.Id = id;
            this.Voornaam = voornaam;
            this.Achternaam = achternaam;
            this.Emailadres = emailadres;
            this.Wachtwoord = wachtwoord;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Account"/> class.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <param name="titel">
        /// The titel.
        /// </param>
        /// <param name="voornaam">
        /// The voornaam.
        /// </param>
        /// <param name="achternaam">
        /// The achternaam.
        /// </param>
        /// <param name="beschrijving">
        /// The beschrijving.
        /// </param>
        /// <param name="bedrijf">
        /// The bedrijf.
        /// </param>
        /// <param name="emailadres">
        /// The emailadres.
        /// </param>
        /// <param name="wachtwoord">
        /// The wachtwoord.
        /// </param>
        /// <param name="factuuradres">
        /// The factuuradres.
        /// </param>
        /// <param name="factuuradresVervolgd">
        /// The factuuradres vervolgd.
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
        public Account(
            int id, 
            string titel, 
            string voornaam, 
            string achternaam, 
            string beschrijving, 
            string bedrijf, 
            string emailadres, 
            string wachtwoord, 
            string factuuradres, 
            string factuuradresVervolgd, 
            string stad, 
            string bestemmingsland, 
            string provincie, 
            string postcode, 
            string telefoonnummer)
        {
            this.Id = id;
            this.Titel = titel;
            this.Voornaam = voornaam;
            this.Achternaam = achternaam;
            this.Beschrijving = beschrijving;
            this.Bedrijf = bedrijf;
            this.Emailadres = emailadres;
            this.Wachtwoord = wachtwoord;
            this.Factuuradres = factuuradres;
            this.FactuuradresVervolgd = factuuradresVervolgd;
            this.Stad = stad;
            this.Bestemmingsland = bestemmingsland;
            this.Provincie = provincie;
            this.Postcode = postcode;
            this.Telefoonnummer = telefoonnummer;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the achternaam.
        /// </summary>
        public string Achternaam { get; set; }

        /// <summary>
        /// Gets or sets the bedrijf.
        /// </summary>
        public string Bedrijf { get; set; }

        /// <summary>
        /// Gets or sets the beschrijving.
        /// </summary>
        public string Beschrijving { get; set; }

        /// <summary>
        /// Gets or sets the bestemmingsland.
        /// </summary>
        public string Bestemmingsland { get; set; }

        /// <summary>
        /// Gets or sets the emailadres.
        /// </summary>
        public string Emailadres { get; set; }

        /// <summary>
        /// Gets or sets the factuuradres.
        /// </summary>
        public string Factuuradres { get; set; }

        /// <summary>
        /// Gets or sets the factuuradres vervolgd.
        /// </summary>
        public string FactuuradresVervolgd { get; set; }

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
        /// Gets or sets the titel.
        /// </summary>
        public string Titel { get; set; }

        /// <summary>
        /// Gets or sets the voornaam.
        /// </summary>
        public string Voornaam { get; set; }

        /// <summary>
        /// Gets or sets the wachtwoord.
        /// </summary>
        public string Wachtwoord { get; set; }

        #endregion
    }
}