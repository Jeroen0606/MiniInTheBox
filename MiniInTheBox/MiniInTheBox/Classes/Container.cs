// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Container.cs" company="">
//   
// </copyright>
// <summary>
//   The container.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MiniInTheBox.Classes
{
    /// <summary>
    /// The container.
    /// </summary>
    public class Container
    {
        private Databasemanager database;
        public Container()
        {
            database = new Databasemanager();
            database.SetConnectionString("dbi272062", "DJs0sfGBdG", "192.168.15.50:1521", "fhictora");
        }

        public Account LogIn(string username, string password)
        {
            return database.Login(username, password);
        }
    }
}