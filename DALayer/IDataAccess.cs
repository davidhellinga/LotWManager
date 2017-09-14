using System;
using System.Collections.Generic;

namespace DALayer
{
    public interface IDataAccess
    {
        /// <summary>
        ///Checks "password" with stored one belonging to "user" in database.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        int checkPasswordWithUsername(string user, string password);
        
        /// <summary>
        /// Checks if user exists in db;
        /// </summary>
        /// <param name="user"></param>
        void checkUserExists(string user);
    }
}