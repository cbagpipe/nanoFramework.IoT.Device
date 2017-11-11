﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyUnit.extra.cs files to add code to generated quantities.
//     Add Extensions\MyUnitExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyUnit.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;

// Windows Runtime Component does not support extension methods and method overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
namespace UnitsNet.Extensions.NumberToTemperature
{
    public static class NumberToTemperatureExtensions
    {
        #region DegreeCelsius

        /// <inheritdoc cref="Temperature.FromDegreesCelsius(double)"/>
        public static Temperature DegreesCelsius(this int value) => Temperature.FromDegreesCelsius(value);

        /// <inheritdoc cref="Temperature.FromDegreesCelsius(double?)"/>
        public static Temperature? DegreesCelsius(this int? value) => Temperature.FromDegreesCelsius(value);

        /// <inheritdoc cref="Temperature.FromDegreesCelsius(double)"/>
        public static Temperature DegreesCelsius(this long value) => Temperature.FromDegreesCelsius(value);

        /// <inheritdoc cref="Temperature.FromDegreesCelsius(double?)"/>
        public static Temperature? DegreesCelsius(this long? value) => Temperature.FromDegreesCelsius(value);

        /// <inheritdoc cref="Temperature.FromDegreesCelsius(double)"/>
        public static Temperature DegreesCelsius(this double value) => Temperature.FromDegreesCelsius(value);

        /// <inheritdoc cref="Temperature.FromDegreesCelsius(double?)"/>
        public static Temperature? DegreesCelsius(this double? value) => Temperature.FromDegreesCelsius(value);

        /// <inheritdoc cref="Temperature.FromDegreesCelsius(double)"/>
        public static Temperature DegreesCelsius(this float value) => Temperature.FromDegreesCelsius(value);

        /// <inheritdoc cref="Temperature.FromDegreesCelsius(double?)"/>
        public static Temperature? DegreesCelsius(this float? value) => Temperature.FromDegreesCelsius(value);

        /// <inheritdoc cref="Temperature.FromDegreesCelsius(double)"/>
        public static Temperature DegreesCelsius(this decimal value) => Temperature.FromDegreesCelsius(Convert.ToDouble(value));

        /// <inheritdoc cref="Temperature.FromDegreesCelsius(double?)"/>
        public static Temperature? DegreesCelsius(this decimal? value) => Temperature.FromDegreesCelsius(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DegreeDelisle

        /// <inheritdoc cref="Temperature.FromDegreesDelisle(double)"/>
        public static Temperature DegreesDelisle(this int value) => Temperature.FromDegreesDelisle(value);

        /// <inheritdoc cref="Temperature.FromDegreesDelisle(double?)"/>
        public static Temperature? DegreesDelisle(this int? value) => Temperature.FromDegreesDelisle(value);

        /// <inheritdoc cref="Temperature.FromDegreesDelisle(double)"/>
        public static Temperature DegreesDelisle(this long value) => Temperature.FromDegreesDelisle(value);

        /// <inheritdoc cref="Temperature.FromDegreesDelisle(double?)"/>
        public static Temperature? DegreesDelisle(this long? value) => Temperature.FromDegreesDelisle(value);

        /// <inheritdoc cref="Temperature.FromDegreesDelisle(double)"/>
        public static Temperature DegreesDelisle(this double value) => Temperature.FromDegreesDelisle(value);

        /// <inheritdoc cref="Temperature.FromDegreesDelisle(double?)"/>
        public static Temperature? DegreesDelisle(this double? value) => Temperature.FromDegreesDelisle(value);

        /// <inheritdoc cref="Temperature.FromDegreesDelisle(double)"/>
        public static Temperature DegreesDelisle(this float value) => Temperature.FromDegreesDelisle(value);

        /// <inheritdoc cref="Temperature.FromDegreesDelisle(double?)"/>
        public static Temperature? DegreesDelisle(this float? value) => Temperature.FromDegreesDelisle(value);

        /// <inheritdoc cref="Temperature.FromDegreesDelisle(double)"/>
        public static Temperature DegreesDelisle(this decimal value) => Temperature.FromDegreesDelisle(Convert.ToDouble(value));

        /// <inheritdoc cref="Temperature.FromDegreesDelisle(double?)"/>
        public static Temperature? DegreesDelisle(this decimal? value) => Temperature.FromDegreesDelisle(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DegreeFahrenheit

        /// <inheritdoc cref="Temperature.FromDegreesFahrenheit(double)"/>
        public static Temperature DegreesFahrenheit(this int value) => Temperature.FromDegreesFahrenheit(value);

        /// <inheritdoc cref="Temperature.FromDegreesFahrenheit(double?)"/>
        public static Temperature? DegreesFahrenheit(this int? value) => Temperature.FromDegreesFahrenheit(value);

        /// <inheritdoc cref="Temperature.FromDegreesFahrenheit(double)"/>
        public static Temperature DegreesFahrenheit(this long value) => Temperature.FromDegreesFahrenheit(value);

        /// <inheritdoc cref="Temperature.FromDegreesFahrenheit(double?)"/>
        public static Temperature? DegreesFahrenheit(this long? value) => Temperature.FromDegreesFahrenheit(value);

        /// <inheritdoc cref="Temperature.FromDegreesFahrenheit(double)"/>
        public static Temperature DegreesFahrenheit(this double value) => Temperature.FromDegreesFahrenheit(value);

        /// <inheritdoc cref="Temperature.FromDegreesFahrenheit(double?)"/>
        public static Temperature? DegreesFahrenheit(this double? value) => Temperature.FromDegreesFahrenheit(value);

        /// <inheritdoc cref="Temperature.FromDegreesFahrenheit(double)"/>
        public static Temperature DegreesFahrenheit(this float value) => Temperature.FromDegreesFahrenheit(value);

        /// <inheritdoc cref="Temperature.FromDegreesFahrenheit(double?)"/>
        public static Temperature? DegreesFahrenheit(this float? value) => Temperature.FromDegreesFahrenheit(value);

        /// <inheritdoc cref="Temperature.FromDegreesFahrenheit(double)"/>
        public static Temperature DegreesFahrenheit(this decimal value) => Temperature.FromDegreesFahrenheit(Convert.ToDouble(value));

        /// <inheritdoc cref="Temperature.FromDegreesFahrenheit(double?)"/>
        public static Temperature? DegreesFahrenheit(this decimal? value) => Temperature.FromDegreesFahrenheit(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DegreeNewton

        /// <inheritdoc cref="Temperature.FromDegreesNewton(double)"/>
        public static Temperature DegreesNewton(this int value) => Temperature.FromDegreesNewton(value);

        /// <inheritdoc cref="Temperature.FromDegreesNewton(double?)"/>
        public static Temperature? DegreesNewton(this int? value) => Temperature.FromDegreesNewton(value);

        /// <inheritdoc cref="Temperature.FromDegreesNewton(double)"/>
        public static Temperature DegreesNewton(this long value) => Temperature.FromDegreesNewton(value);

        /// <inheritdoc cref="Temperature.FromDegreesNewton(double?)"/>
        public static Temperature? DegreesNewton(this long? value) => Temperature.FromDegreesNewton(value);

        /// <inheritdoc cref="Temperature.FromDegreesNewton(double)"/>
        public static Temperature DegreesNewton(this double value) => Temperature.FromDegreesNewton(value);

        /// <inheritdoc cref="Temperature.FromDegreesNewton(double?)"/>
        public static Temperature? DegreesNewton(this double? value) => Temperature.FromDegreesNewton(value);

        /// <inheritdoc cref="Temperature.FromDegreesNewton(double)"/>
        public static Temperature DegreesNewton(this float value) => Temperature.FromDegreesNewton(value);

        /// <inheritdoc cref="Temperature.FromDegreesNewton(double?)"/>
        public static Temperature? DegreesNewton(this float? value) => Temperature.FromDegreesNewton(value);

        /// <inheritdoc cref="Temperature.FromDegreesNewton(double)"/>
        public static Temperature DegreesNewton(this decimal value) => Temperature.FromDegreesNewton(Convert.ToDouble(value));

        /// <inheritdoc cref="Temperature.FromDegreesNewton(double?)"/>
        public static Temperature? DegreesNewton(this decimal? value) => Temperature.FromDegreesNewton(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DegreeRankine

        /// <inheritdoc cref="Temperature.FromDegreesRankine(double)"/>
        public static Temperature DegreesRankine(this int value) => Temperature.FromDegreesRankine(value);

        /// <inheritdoc cref="Temperature.FromDegreesRankine(double?)"/>
        public static Temperature? DegreesRankine(this int? value) => Temperature.FromDegreesRankine(value);

        /// <inheritdoc cref="Temperature.FromDegreesRankine(double)"/>
        public static Temperature DegreesRankine(this long value) => Temperature.FromDegreesRankine(value);

        /// <inheritdoc cref="Temperature.FromDegreesRankine(double?)"/>
        public static Temperature? DegreesRankine(this long? value) => Temperature.FromDegreesRankine(value);

        /// <inheritdoc cref="Temperature.FromDegreesRankine(double)"/>
        public static Temperature DegreesRankine(this double value) => Temperature.FromDegreesRankine(value);

        /// <inheritdoc cref="Temperature.FromDegreesRankine(double?)"/>
        public static Temperature? DegreesRankine(this double? value) => Temperature.FromDegreesRankine(value);

        /// <inheritdoc cref="Temperature.FromDegreesRankine(double)"/>
        public static Temperature DegreesRankine(this float value) => Temperature.FromDegreesRankine(value);

        /// <inheritdoc cref="Temperature.FromDegreesRankine(double?)"/>
        public static Temperature? DegreesRankine(this float? value) => Temperature.FromDegreesRankine(value);

        /// <inheritdoc cref="Temperature.FromDegreesRankine(double)"/>
        public static Temperature DegreesRankine(this decimal value) => Temperature.FromDegreesRankine(Convert.ToDouble(value));

        /// <inheritdoc cref="Temperature.FromDegreesRankine(double?)"/>
        public static Temperature? DegreesRankine(this decimal? value) => Temperature.FromDegreesRankine(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DegreeReaumur

        /// <inheritdoc cref="Temperature.FromDegreesReaumur(double)"/>
        public static Temperature DegreesReaumur(this int value) => Temperature.FromDegreesReaumur(value);

        /// <inheritdoc cref="Temperature.FromDegreesReaumur(double?)"/>
        public static Temperature? DegreesReaumur(this int? value) => Temperature.FromDegreesReaumur(value);

        /// <inheritdoc cref="Temperature.FromDegreesReaumur(double)"/>
        public static Temperature DegreesReaumur(this long value) => Temperature.FromDegreesReaumur(value);

        /// <inheritdoc cref="Temperature.FromDegreesReaumur(double?)"/>
        public static Temperature? DegreesReaumur(this long? value) => Temperature.FromDegreesReaumur(value);

        /// <inheritdoc cref="Temperature.FromDegreesReaumur(double)"/>
        public static Temperature DegreesReaumur(this double value) => Temperature.FromDegreesReaumur(value);

        /// <inheritdoc cref="Temperature.FromDegreesReaumur(double?)"/>
        public static Temperature? DegreesReaumur(this double? value) => Temperature.FromDegreesReaumur(value);

        /// <inheritdoc cref="Temperature.FromDegreesReaumur(double)"/>
        public static Temperature DegreesReaumur(this float value) => Temperature.FromDegreesReaumur(value);

        /// <inheritdoc cref="Temperature.FromDegreesReaumur(double?)"/>
        public static Temperature? DegreesReaumur(this float? value) => Temperature.FromDegreesReaumur(value);

        /// <inheritdoc cref="Temperature.FromDegreesReaumur(double)"/>
        public static Temperature DegreesReaumur(this decimal value) => Temperature.FromDegreesReaumur(Convert.ToDouble(value));

        /// <inheritdoc cref="Temperature.FromDegreesReaumur(double?)"/>
        public static Temperature? DegreesReaumur(this decimal? value) => Temperature.FromDegreesReaumur(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DegreeRoemer

        /// <inheritdoc cref="Temperature.FromDegreesRoemer(double)"/>
        public static Temperature DegreesRoemer(this int value) => Temperature.FromDegreesRoemer(value);

        /// <inheritdoc cref="Temperature.FromDegreesRoemer(double?)"/>
        public static Temperature? DegreesRoemer(this int? value) => Temperature.FromDegreesRoemer(value);

        /// <inheritdoc cref="Temperature.FromDegreesRoemer(double)"/>
        public static Temperature DegreesRoemer(this long value) => Temperature.FromDegreesRoemer(value);

        /// <inheritdoc cref="Temperature.FromDegreesRoemer(double?)"/>
        public static Temperature? DegreesRoemer(this long? value) => Temperature.FromDegreesRoemer(value);

        /// <inheritdoc cref="Temperature.FromDegreesRoemer(double)"/>
        public static Temperature DegreesRoemer(this double value) => Temperature.FromDegreesRoemer(value);

        /// <inheritdoc cref="Temperature.FromDegreesRoemer(double?)"/>
        public static Temperature? DegreesRoemer(this double? value) => Temperature.FromDegreesRoemer(value);

        /// <inheritdoc cref="Temperature.FromDegreesRoemer(double)"/>
        public static Temperature DegreesRoemer(this float value) => Temperature.FromDegreesRoemer(value);

        /// <inheritdoc cref="Temperature.FromDegreesRoemer(double?)"/>
        public static Temperature? DegreesRoemer(this float? value) => Temperature.FromDegreesRoemer(value);

        /// <inheritdoc cref="Temperature.FromDegreesRoemer(double)"/>
        public static Temperature DegreesRoemer(this decimal value) => Temperature.FromDegreesRoemer(Convert.ToDouble(value));

        /// <inheritdoc cref="Temperature.FromDegreesRoemer(double?)"/>
        public static Temperature? DegreesRoemer(this decimal? value) => Temperature.FromDegreesRoemer(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Kelvin

        /// <inheritdoc cref="Temperature.FromKelvins(double)"/>
        public static Temperature Kelvins(this int value) => Temperature.FromKelvins(value);

        /// <inheritdoc cref="Temperature.FromKelvins(double?)"/>
        public static Temperature? Kelvins(this int? value) => Temperature.FromKelvins(value);

        /// <inheritdoc cref="Temperature.FromKelvins(double)"/>
        public static Temperature Kelvins(this long value) => Temperature.FromKelvins(value);

        /// <inheritdoc cref="Temperature.FromKelvins(double?)"/>
        public static Temperature? Kelvins(this long? value) => Temperature.FromKelvins(value);

        /// <inheritdoc cref="Temperature.FromKelvins(double)"/>
        public static Temperature Kelvins(this double value) => Temperature.FromKelvins(value);

        /// <inheritdoc cref="Temperature.FromKelvins(double?)"/>
        public static Temperature? Kelvins(this double? value) => Temperature.FromKelvins(value);

        /// <inheritdoc cref="Temperature.FromKelvins(double)"/>
        public static Temperature Kelvins(this float value) => Temperature.FromKelvins(value);

        /// <inheritdoc cref="Temperature.FromKelvins(double?)"/>
        public static Temperature? Kelvins(this float? value) => Temperature.FromKelvins(value);

        /// <inheritdoc cref="Temperature.FromKelvins(double)"/>
        public static Temperature Kelvins(this decimal value) => Temperature.FromKelvins(Convert.ToDouble(value));

        /// <inheritdoc cref="Temperature.FromKelvins(double?)"/>
        public static Temperature? Kelvins(this decimal? value) => Temperature.FromKelvins(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
