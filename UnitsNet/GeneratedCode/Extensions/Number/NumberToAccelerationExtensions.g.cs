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
namespace UnitsNet.Extensions.NumberToAcceleration
{
    public static class NumberToAccelerationExtensions
    {
        #region CentimeterPerSecondSquared

        /// <inheritdoc cref="Acceleration.FromCentimeterPerSecondSquared(double)"/>
        public static Acceleration CentimeterPerSecondSquared(this int value) => Acceleration.FromCentimeterPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromCentimeterPerSecondSquared(double?)"/>
        public static Acceleration? CentimeterPerSecondSquared(this int? value) => Acceleration.FromCentimeterPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromCentimeterPerSecondSquared(double)"/>
        public static Acceleration CentimeterPerSecondSquared(this long value) => Acceleration.FromCentimeterPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromCentimeterPerSecondSquared(double?)"/>
        public static Acceleration? CentimeterPerSecondSquared(this long? value) => Acceleration.FromCentimeterPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromCentimeterPerSecondSquared(double)"/>
        public static Acceleration CentimeterPerSecondSquared(this double value) => Acceleration.FromCentimeterPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromCentimeterPerSecondSquared(double?)"/>
        public static Acceleration? CentimeterPerSecondSquared(this double? value) => Acceleration.FromCentimeterPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromCentimeterPerSecondSquared(double)"/>
        public static Acceleration CentimeterPerSecondSquared(this float value) => Acceleration.FromCentimeterPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromCentimeterPerSecondSquared(double?)"/>
        public static Acceleration? CentimeterPerSecondSquared(this float? value) => Acceleration.FromCentimeterPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromCentimeterPerSecondSquared(double)"/>
        public static Acceleration CentimeterPerSecondSquared(this decimal value) => Acceleration.FromCentimeterPerSecondSquared(Convert.ToDouble(value));

        /// <inheritdoc cref="Acceleration.FromCentimeterPerSecondSquared(double?)"/>
        public static Acceleration? CentimeterPerSecondSquared(this decimal? value) => Acceleration.FromCentimeterPerSecondSquared(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DecimeterPerSecondSquared

        /// <inheritdoc cref="Acceleration.FromDecimeterPerSecondSquared(double)"/>
        public static Acceleration DecimeterPerSecondSquared(this int value) => Acceleration.FromDecimeterPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromDecimeterPerSecondSquared(double?)"/>
        public static Acceleration? DecimeterPerSecondSquared(this int? value) => Acceleration.FromDecimeterPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromDecimeterPerSecondSquared(double)"/>
        public static Acceleration DecimeterPerSecondSquared(this long value) => Acceleration.FromDecimeterPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromDecimeterPerSecondSquared(double?)"/>
        public static Acceleration? DecimeterPerSecondSquared(this long? value) => Acceleration.FromDecimeterPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromDecimeterPerSecondSquared(double)"/>
        public static Acceleration DecimeterPerSecondSquared(this double value) => Acceleration.FromDecimeterPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromDecimeterPerSecondSquared(double?)"/>
        public static Acceleration? DecimeterPerSecondSquared(this double? value) => Acceleration.FromDecimeterPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromDecimeterPerSecondSquared(double)"/>
        public static Acceleration DecimeterPerSecondSquared(this float value) => Acceleration.FromDecimeterPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromDecimeterPerSecondSquared(double?)"/>
        public static Acceleration? DecimeterPerSecondSquared(this float? value) => Acceleration.FromDecimeterPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromDecimeterPerSecondSquared(double)"/>
        public static Acceleration DecimeterPerSecondSquared(this decimal value) => Acceleration.FromDecimeterPerSecondSquared(Convert.ToDouble(value));

        /// <inheritdoc cref="Acceleration.FromDecimeterPerSecondSquared(double?)"/>
        public static Acceleration? DecimeterPerSecondSquared(this decimal? value) => Acceleration.FromDecimeterPerSecondSquared(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilometerPerSecondSquared

        /// <inheritdoc cref="Acceleration.FromKilometerPerSecondSquared(double)"/>
        public static Acceleration KilometerPerSecondSquared(this int value) => Acceleration.FromKilometerPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromKilometerPerSecondSquared(double?)"/>
        public static Acceleration? KilometerPerSecondSquared(this int? value) => Acceleration.FromKilometerPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromKilometerPerSecondSquared(double)"/>
        public static Acceleration KilometerPerSecondSquared(this long value) => Acceleration.FromKilometerPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromKilometerPerSecondSquared(double?)"/>
        public static Acceleration? KilometerPerSecondSquared(this long? value) => Acceleration.FromKilometerPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromKilometerPerSecondSquared(double)"/>
        public static Acceleration KilometerPerSecondSquared(this double value) => Acceleration.FromKilometerPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromKilometerPerSecondSquared(double?)"/>
        public static Acceleration? KilometerPerSecondSquared(this double? value) => Acceleration.FromKilometerPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromKilometerPerSecondSquared(double)"/>
        public static Acceleration KilometerPerSecondSquared(this float value) => Acceleration.FromKilometerPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromKilometerPerSecondSquared(double?)"/>
        public static Acceleration? KilometerPerSecondSquared(this float? value) => Acceleration.FromKilometerPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromKilometerPerSecondSquared(double)"/>
        public static Acceleration KilometerPerSecondSquared(this decimal value) => Acceleration.FromKilometerPerSecondSquared(Convert.ToDouble(value));

        /// <inheritdoc cref="Acceleration.FromKilometerPerSecondSquared(double?)"/>
        public static Acceleration? KilometerPerSecondSquared(this decimal? value) => Acceleration.FromKilometerPerSecondSquared(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MeterPerSecondSquared

        /// <inheritdoc cref="Acceleration.FromMeterPerSecondSquared(double)"/>
        public static Acceleration MeterPerSecondSquared(this int value) => Acceleration.FromMeterPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromMeterPerSecondSquared(double?)"/>
        public static Acceleration? MeterPerSecondSquared(this int? value) => Acceleration.FromMeterPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromMeterPerSecondSquared(double)"/>
        public static Acceleration MeterPerSecondSquared(this long value) => Acceleration.FromMeterPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromMeterPerSecondSquared(double?)"/>
        public static Acceleration? MeterPerSecondSquared(this long? value) => Acceleration.FromMeterPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromMeterPerSecondSquared(double)"/>
        public static Acceleration MeterPerSecondSquared(this double value) => Acceleration.FromMeterPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromMeterPerSecondSquared(double?)"/>
        public static Acceleration? MeterPerSecondSquared(this double? value) => Acceleration.FromMeterPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromMeterPerSecondSquared(double)"/>
        public static Acceleration MeterPerSecondSquared(this float value) => Acceleration.FromMeterPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromMeterPerSecondSquared(double?)"/>
        public static Acceleration? MeterPerSecondSquared(this float? value) => Acceleration.FromMeterPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromMeterPerSecondSquared(double)"/>
        public static Acceleration MeterPerSecondSquared(this decimal value) => Acceleration.FromMeterPerSecondSquared(Convert.ToDouble(value));

        /// <inheritdoc cref="Acceleration.FromMeterPerSecondSquared(double?)"/>
        public static Acceleration? MeterPerSecondSquared(this decimal? value) => Acceleration.FromMeterPerSecondSquared(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MicrometerPerSecondSquared

        /// <inheritdoc cref="Acceleration.FromMicrometerPerSecondSquared(double)"/>
        public static Acceleration MicrometerPerSecondSquared(this int value) => Acceleration.FromMicrometerPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromMicrometerPerSecondSquared(double?)"/>
        public static Acceleration? MicrometerPerSecondSquared(this int? value) => Acceleration.FromMicrometerPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromMicrometerPerSecondSquared(double)"/>
        public static Acceleration MicrometerPerSecondSquared(this long value) => Acceleration.FromMicrometerPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromMicrometerPerSecondSquared(double?)"/>
        public static Acceleration? MicrometerPerSecondSquared(this long? value) => Acceleration.FromMicrometerPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromMicrometerPerSecondSquared(double)"/>
        public static Acceleration MicrometerPerSecondSquared(this double value) => Acceleration.FromMicrometerPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromMicrometerPerSecondSquared(double?)"/>
        public static Acceleration? MicrometerPerSecondSquared(this double? value) => Acceleration.FromMicrometerPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromMicrometerPerSecondSquared(double)"/>
        public static Acceleration MicrometerPerSecondSquared(this float value) => Acceleration.FromMicrometerPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromMicrometerPerSecondSquared(double?)"/>
        public static Acceleration? MicrometerPerSecondSquared(this float? value) => Acceleration.FromMicrometerPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromMicrometerPerSecondSquared(double)"/>
        public static Acceleration MicrometerPerSecondSquared(this decimal value) => Acceleration.FromMicrometerPerSecondSquared(Convert.ToDouble(value));

        /// <inheritdoc cref="Acceleration.FromMicrometerPerSecondSquared(double?)"/>
        public static Acceleration? MicrometerPerSecondSquared(this decimal? value) => Acceleration.FromMicrometerPerSecondSquared(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MillimeterPerSecondSquared

        /// <inheritdoc cref="Acceleration.FromMillimeterPerSecondSquared(double)"/>
        public static Acceleration MillimeterPerSecondSquared(this int value) => Acceleration.FromMillimeterPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromMillimeterPerSecondSquared(double?)"/>
        public static Acceleration? MillimeterPerSecondSquared(this int? value) => Acceleration.FromMillimeterPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromMillimeterPerSecondSquared(double)"/>
        public static Acceleration MillimeterPerSecondSquared(this long value) => Acceleration.FromMillimeterPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromMillimeterPerSecondSquared(double?)"/>
        public static Acceleration? MillimeterPerSecondSquared(this long? value) => Acceleration.FromMillimeterPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromMillimeterPerSecondSquared(double)"/>
        public static Acceleration MillimeterPerSecondSquared(this double value) => Acceleration.FromMillimeterPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromMillimeterPerSecondSquared(double?)"/>
        public static Acceleration? MillimeterPerSecondSquared(this double? value) => Acceleration.FromMillimeterPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromMillimeterPerSecondSquared(double)"/>
        public static Acceleration MillimeterPerSecondSquared(this float value) => Acceleration.FromMillimeterPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromMillimeterPerSecondSquared(double?)"/>
        public static Acceleration? MillimeterPerSecondSquared(this float? value) => Acceleration.FromMillimeterPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromMillimeterPerSecondSquared(double)"/>
        public static Acceleration MillimeterPerSecondSquared(this decimal value) => Acceleration.FromMillimeterPerSecondSquared(Convert.ToDouble(value));

        /// <inheritdoc cref="Acceleration.FromMillimeterPerSecondSquared(double?)"/>
        public static Acceleration? MillimeterPerSecondSquared(this decimal? value) => Acceleration.FromMillimeterPerSecondSquared(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region NanometerPerSecondSquared

        /// <inheritdoc cref="Acceleration.FromNanometerPerSecondSquared(double)"/>
        public static Acceleration NanometerPerSecondSquared(this int value) => Acceleration.FromNanometerPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromNanometerPerSecondSquared(double?)"/>
        public static Acceleration? NanometerPerSecondSquared(this int? value) => Acceleration.FromNanometerPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromNanometerPerSecondSquared(double)"/>
        public static Acceleration NanometerPerSecondSquared(this long value) => Acceleration.FromNanometerPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromNanometerPerSecondSquared(double?)"/>
        public static Acceleration? NanometerPerSecondSquared(this long? value) => Acceleration.FromNanometerPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromNanometerPerSecondSquared(double)"/>
        public static Acceleration NanometerPerSecondSquared(this double value) => Acceleration.FromNanometerPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromNanometerPerSecondSquared(double?)"/>
        public static Acceleration? NanometerPerSecondSquared(this double? value) => Acceleration.FromNanometerPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromNanometerPerSecondSquared(double)"/>
        public static Acceleration NanometerPerSecondSquared(this float value) => Acceleration.FromNanometerPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromNanometerPerSecondSquared(double?)"/>
        public static Acceleration? NanometerPerSecondSquared(this float? value) => Acceleration.FromNanometerPerSecondSquared(value);

        /// <inheritdoc cref="Acceleration.FromNanometerPerSecondSquared(double)"/>
        public static Acceleration NanometerPerSecondSquared(this decimal value) => Acceleration.FromNanometerPerSecondSquared(Convert.ToDouble(value));

        /// <inheritdoc cref="Acceleration.FromNanometerPerSecondSquared(double?)"/>
        public static Acceleration? NanometerPerSecondSquared(this decimal? value) => Acceleration.FromNanometerPerSecondSquared(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
