// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrimaryKeyAttribute.cs" company="pzcast">
//   (C) 2015 pzcast. All rights reserved.
// </copyright>
// <summary>
//   The primary key attribute.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EntityTemplate.Attributes
{
    using System;

    /// <summary>
    /// The primary key attribute.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class PrimaryKeyAttribute : Attribute
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PrimaryKeyAttribute"/> class.
        /// </summary>
        /// <param name="autoIncrement">
        /// The auto increment.
        /// </param>
        public PrimaryKeyAttribute(bool autoIncrement)
        {
            this.AutoIncrement = autoIncrement;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets a value indicating whether auto increment.
        /// </summary>
        public bool AutoIncrement { get; private set; }

        #endregion
    }
}