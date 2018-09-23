﻿// *****************************************************************************
// BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
//  © Component Factory Pty Ltd, 2006-2018, All rights reserved.
// The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2017 - 2018. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-4.7)
//  Version 4.7.0.0  www.ComponentFactory.com
// *****************************************************************************

using System;
using System.ComponentModel;
using System.Globalization;

namespace ComponentFactory.Krypton.Toolkit
{
    /// <summary>
    /// Add DBNull/Null conversion for date time types.
    /// </summary>
    public class DateTimeNullableConverter : DateTimeConverter
    {
        #region Identity
        /// <summary>
        /// Initialize a new instance of the DateTimeNullableConverter class.
        /// </summary>
        public DateTimeNullableConverter()
        {
        }
        #endregion

        #region Protected Overrides
        /// <summary>
        /// Converts the given object to the type of this converter, using the specified context and culture information.
        /// </summary>
        /// <param name="context">An ITypeDescriptorContext that provides a format context.</param>
        /// <param name="culture">The CultureInfo to use as the current culture.</param>
        /// <param name="value">The Object to convert.</param>
        /// <returns>An Object that represents the converted value.</returns>
        public override object ConvertFrom(ITypeDescriptorContext context, 
                                           CultureInfo culture, 
                                           object value)
        {
            // We allow an empty string or a string with DBNull/null/Nothing to be converted to a DBNull value.
            if (value is string)
            {
                string stringValue = value.ToString().ToLower();
                if ((stringValue == "dbnull") || (stringValue == "null") || (stringValue == "nothing"))
                {
                    return DBNull.Value;
                }
            }

            return base.ConvertFrom(context, culture, value);
        }
        #endregion
    }
}
