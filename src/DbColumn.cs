// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DbColumn.cs" company="pzcast">
//   (C) 2015 pzcast. All rights reserved.
// </copyright>
// <summary>
//   The db column.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EntityTemplate
{
    using System.Collections.Generic;

    /// <summary>
    /// The db column.
    /// </summary>
    public class DbColumn : DbObject
    {
        #region Fields

        /// <summary>
        /// The column type.
        /// </summary>
        private string columnType;

        /// <summary>
        /// The default value.
        /// </summary>
        private object defaultValue;

        /// <summary>
        /// The description.
        /// </summary>
        private string description;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DbColumn"/> class.
        /// </summary>
        public DbColumn()
        {
            this.IsIdentityColumn = false;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets a value indicating whether allow empty.
        /// </summary>
        public bool AllowEmpty { get; set; }

        /// <summary>
        /// Gets or sets the column type.
        /// </summary>
        public string ColumnType
        {
            get
            {
                return this.columnType;
            }

            set
            {
                if (value == null)
                {
                    value = string.Empty;
                }

                this.columnType = value;
            }
        }

        /// <summary>
        /// Gets the property type.
        /// </summary>
        public string PropertyType
        {
            get
            {
                return GetPropertyType(this.ColumnType);
            }
        }

        /// <summary>
        /// Gets or sets the default value.
        /// </summary>
        public object DefaultValue
        {
            get
            {
                return this.defaultValue;
            }

            set
            {
                if (value == null)
                {
                    value = string.Empty;
                }

                this.defaultValue = value;
            }
        }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description
        {
            get
            {
                return this.description;
            }

            set
            {
                if (value == null)
                {
                    value = string.Empty;
                }

                this.description = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether is identity column.
        /// </summary>
        public bool IsIdentityColumn { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is primary key.
        /// </summary>
        public bool IsPrimaryKey { get; set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The get property type.
        /// </summary>
        /// <param name="columnType">
        /// The column Type.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static string GetPropertyType(string columnType)
        {
            string propertyType = "string";
            switch (columnType.ToLower())
            {
                case "bigint":
                    propertyType = "long";
                    break;
                case "smallint":
                    propertyType = "short";
                    break;
                case "int":
                    propertyType = "int";
                    break;
                case "uniqueidentifier":
                    propertyType = "Guid";
                    break;
                case "smalldatetime":
                case "datetime":
                case "datetime2":
                case "date":
                case "time":
                    propertyType = "DateTime";
                    break;
                case "float":
                    propertyType = "double";
                    break;
                case "real":
                    propertyType = "float";
                    break;
                case "numeric":
                case "smallmoney":
                case "decimal":
                case "money":
                    propertyType = "decimal";
                    break;
                case "tinyint":
                    propertyType = "byte";
                    break;
                case "bit":
                    propertyType = "bool";
                    break;
                case "image":
                case "binary":
                case "varbinary":
                case "timestamp":
                    propertyType = "byte[]";
                    break;
                case "geography":
                    propertyType = "Microsoft.SqlServer.Types.SqlGeography";
                    break;
                case "geometry":
                    propertyType = "Microsoft.SqlServer.Types.SqlGeometry";
                    break;
            }

            return propertyType;
        }
        
        #endregion
    }
    
    /// <summary>
    /// The db column collection.
    /// </summary>
    public class DbColumnCollection : List<DbColumn>
    {
    }
}