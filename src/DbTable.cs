// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DbTable.cs" company="pzcast">
//   (C) 2015 pzcast. All rights reserved.
// </copyright>
// <summary>
//   The db table.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EntityTemplate
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Design.PluralizationServices;
    using System.Linq;

    /// <summary>
    /// The db table.
    /// </summary>
    public class DbTable : DbObject
    {
        #region Fields

        /// <summary>
        /// The column collection.
        /// </summary>
        protected readonly DbColumnCollection ColumnCollection = new DbColumnCollection();
        
        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the columns.
        /// </summary>
        public virtual DbColumnCollection Columns
        {
            get
            {
                return this.ColumnCollection;
            }

            set
            {
                if (value != this.ColumnCollection)
                {
                    this.ColumnCollection.Clear();
                    if (value != null)
                    {
                        this.ColumnCollection.AddRange(value);
                    }
                }
            }
        }

        /// <summary>
        /// Gets the className.
        /// </summary>
        public string ClassName
        {
            get
            {
                return Singularize(this.Name.Replace("_", string.Empty));
            }
        }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets the identity column.
        /// </summary>
        public virtual DbColumn IdentityColumn
        {
            get
            {
                return this.Columns.FirstOrDefault(column => column.IsIdentityColumn);
            }
        }

        /// <summary>
        /// Gets the primary keys.
        /// </summary>
        public virtual DbColumnCollection PrimaryKeys
        {
            get
            {
                var primaryKeys = new DbColumnCollection();

                primaryKeys.AddRange(this.Columns.Where(column => column.IsPrimaryKey));

                return primaryKeys;
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The singularize.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static string Singularize(string name)
        {
            return PluralizationService.CreateService(System.Globalization.CultureInfo.GetCultureInfo("en-us")).Singularize(name);
        }

        #endregion
    }

    /// <summary>
    /// The db table collection.
    /// </summary>
    public class DbTableCollection : List<DbTable>
    {
        #region Public Methods and Operators

        /// <summary>
        /// The contains name.
        /// </summary>
        /// <param name="tableName">
        /// The table name.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool ContainsName(string tableName)
        {
            return this.Any(table => string.Equals(table.Name, tableName, StringComparison.CurrentCultureIgnoreCase));
        }

        #endregion
    }
}