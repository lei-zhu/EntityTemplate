// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NotNullAttribute.cs" company="pzcast">
//   (C) 2015 pzcast. All rights reserved.
// </copyright>
// <summary>
//   The not null attribute.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EntityTemplate.Attributes
{
    using System;

    /// <summary>
    /// The not null attribute.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class NotNullAttribute : Attribute
    {
    }
}