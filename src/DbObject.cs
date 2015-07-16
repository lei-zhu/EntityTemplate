// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DbObject.cs" company="pzcast">
//   (C) 2015 pzcast. All rights reserved.
// </copyright>
// <summary>
//   The db object.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EntityTemplate
{
    /// <summary>
    /// The db object.
    /// </summary>
    public class DbObject
    {
        #region Fields

        /// <summary>
        /// The property hashtable.
        /// </summary>
        internal readonly ObjectHashtable PropertyHashtable = new ObjectHashtable();

        /// <summary>
        /// The name.
        /// </summary>
        private string name = string.Empty;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value.Trim();
            }
        }

        /// <summary>
        /// Gets or sets the properties.
        /// </summary>
        public ObjectHashtable Properties
        {
            get
            {
                return this.PropertyHashtable;
            }

            set
            {
                if (value != this.PropertyHashtable)
                {
                    this.PropertyHashtable.Clear();
                    if (value != null && value.Count > 0)
                    {
                        this.PropertyHashtable.AddRange(value);
                    }
                }
            }
        }

        /// <summary>
        /// Gets or sets the tag.
        /// </summary>
        public object Tag { get; set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The to string.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string ToString()
        {
            return this.Name;
        }

        #endregion
    }
}