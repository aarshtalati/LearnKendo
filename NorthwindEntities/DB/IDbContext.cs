using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindEntities.DB
{
    public interface IDbContext
    {
        IDbSet<T> EntitySet<T>() where T : class;
        bool EntitySetExists<T>(T entity) where T : class;
        bool Exists<T>(params object[] keys) where T : class;
        DbEntityEntry<T> Entry<T>(T entity) where T : class;
        IQueryable<T> EntitySet<T>(string include) where T : class;
        DbContext Context { get; }

        int SaveChanges();

        /// <summary>
        /// Update specific properties on entity
        /// </summary>
        /// <typeparam name="T">Entity Type</typeparam>
        /// <param name="entityObject">Entity Object which must not yet be attached to context.</param>
        /// <param name="properties">Array of property names the flag as modified</param>
        void Update<T>(T entityObject, params string[] properties) where T : EntityBase;

        /// <summary>
        /// Update all properties on entity except specific properties
        /// </summary>
        /// <typeparam name="T">Entity Type</typeparam>
        /// <param name="entityObject">Entity Object which must not yet be attached to context.</param>
        /// <param name="properties">Array of property names the flag as not modified</param>
        void UpdateExcept<T>(T entityObject, params string[] properties) where T : EntityBase;

    }
}
