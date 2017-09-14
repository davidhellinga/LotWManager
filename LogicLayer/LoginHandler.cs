using System;
using System.Collections.Generic;
using DALayer;

namespace LogicLayer
{
    public class LoginHandler
    {
        /// <summary>
        /// Creates DataAccesor. Call _dataAcces to communicate with database
        /// </summary>
        private readonly IDataAccess _dataAccess = new DataAccessor().GetAccess();

        /// <summary>
        /// Checks wheather user and password exist and belong to eachother
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool checkUserAndPassword(string user, string password)
        {
            var numberOfMatches=_dataAccess.checkPasswordWithUsername(user, password);
            return Convert.ToBoolean(numberOfMatches);
        }
    }
}