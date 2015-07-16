// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IgnoreAttribute.cs" company="pzcast">
//   (C) 2015 pzcast. All rights reserved.
// </copyright>
// <summary>
//   The ignore attribute.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EntityTemplate.Attributes
{
    using System;

    /// <summary>
    /// The ignore attribute.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class IgnoreAttribute : Attribute
    {
    }
}