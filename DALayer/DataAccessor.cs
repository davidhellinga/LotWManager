using System.IO;

namespace DALayer
{
    public class DataAccessor
    {
        /// <summary>
        /// return new DbHandler()
        /// </summary>
        public IDataAccess GetAccess()
        {
            return new DBHandler();
        }
    }
}