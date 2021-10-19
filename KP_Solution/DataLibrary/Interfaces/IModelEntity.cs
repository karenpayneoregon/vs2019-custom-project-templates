using System;
using System.Collections.Generic;
using System.Text;

namespace $safeprojectname$.Interfaces
{
    public interface IModelEntity<T>
    {
        /// <summary>
        /// Get Message by primary key
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetById(decimal id);
        /// <summary>
        /// Update Message
        /// </summary>
        /// <param name="pMessage"></param>
        /// <returns></returns>
        T Update(T pMessage);
        /// <summary>
        /// Add a new Message
        /// </summary>
        /// <param name="pMessage"></param>
        /// <returns></returns>
        T Add(T pMessage);
        /// <summary>
        /// Remove Message by primary key
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T Delete(int id);
        int Commit();
        List<T> GetAll();
    }
}
