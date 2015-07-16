// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TableAttribute.cs" company="pzcast">
//   (C) 2015 pzcast. All rights reserved.
// </copyright>
// <summary>
//   The table attribute.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EntityTemplate.Attributes
{
    using System;

    /// <summary>
    /// The table attribute.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class TableAttribute : Attribute
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TableAttribute"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        public TableAttribute(string name)
        {
            this.Name = name;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the name.
        /// </summary>
        public string Name { get; private set; }

        #endregion
    }
}