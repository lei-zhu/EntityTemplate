// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GenericDictionary.cs" company="pzcast">
//   (C) 2015 pzcast. All rights reserved.
// </copyright>
// <summary>
//   The generic dictionary.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EntityTemplate
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    /// <summary>
    /// The generic dictionary.
    /// </summary>
    /// <typeparam name="T">
    /// The generic type.
    /// </typeparam>
    public class GenericDictionary<T> : Dictionary<string, T>
        where T : class
    {
        #region Static Fields

        /// <summary>
        /// The default value.
        /// </summary>
        private static readonly T DefaultValue = default(T);

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericDictionary{T}"/> class.
        /// </summary>
        public GenericDictionary()
            : base(StringComparer.CurrentCultureIgnoreCase)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericDictionary{T}"/> class.
        /// </summary>
        /// <param name="serializationInfo">
        /// The serialization info.
        /// </param>
        /// <param name="streamingContext">
        /// The streaming context.
        /// </param>
        public GenericDictionary(SerializationInfo serializationInfo, StreamingContext streamingContext)
            : base(serializationInfo, streamingContext)
        {
        }

        #endregion

        #region Public Indexers

        /// <summary>
        /// The this.
        /// </summary>
        /// <param name="key">
        /// The key.
        /// </param>
        /// <returns>
        /// The <see cref="T"/>.
        /// </returns>
        public new T this[string key]
        {
            get
            {
                T result;
                if (this.TryGetValue(key, out result))
                {
                    return result;
                }

                return DefaultValue;
            }

            set
            {
                if (this.ContainsKey(key))
                {
                    this[key] = value;
                }
                else
                {
                    this.Add(key, value);
                }
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The add range.
        /// </summary>
        /// <param name="values">
        /// The values.
        /// </param>
        public virtual void AddRange(GenericDictionary<T> values)
        {
            if (values == null || values.Count <= 0)
            {
                return;
            }

            foreach (string item in values.Keys)
            {
                this[item] = values[item];
            }
        }

        #endregion
    }
}