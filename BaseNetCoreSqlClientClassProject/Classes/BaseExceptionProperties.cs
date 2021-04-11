﻿using System;
using System.Data.SqlClient;

namespace BaseNetCoreSqlClientClassProject.Classes
{
    public class BaseExceptionProperties
    {
        protected static bool mHasException;
        /// <summary>
        /// Indicate the last operation thrown an exception or not
        /// </summary>
        /// <returns></returns>
        public static bool HasException => mHasException;

        protected static Exception mLastException;
        /// <summary>
        /// Provides access to the last exception thrown
        /// </summary>
        /// <returns></returns>
        public static Exception LastException => mLastException;
        public bool HasSqlException => mLastException is SqlException;
        /// <summary>
        /// If you don't need the entire exception as in LastException this 
        /// provides just the text of the exception
        /// </summary>
        /// <returns></returns>
        public static string LastExceptionMessage => mLastException.Message;
        /// <summary>
        /// Indicate for return of a function if there was an exception thrown or not.
        /// </summary>
        /// <returns></returns>
        public static bool IsSuccessFul => !mHasException;
    }
}