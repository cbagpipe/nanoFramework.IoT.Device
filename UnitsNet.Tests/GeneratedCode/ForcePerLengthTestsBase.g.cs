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
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of ForcePerLength.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ForcePerLengthTestsBase
    {
        protected abstract double CentinewtonsPerMeterInOneNewtonPerMeter { get; }
        protected abstract double DecinewtonsPerMeterInOneNewtonPerMeter { get; }
        protected abstract double KilogramsForcePerMeterInOneNewtonPerMeter { get; }
        protected abstract double KilonewtonsPerMeterInOneNewtonPerMeter { get; }
        protected abstract double MicronewtonsPerMeterInOneNewtonPerMeter { get; }
        protected abstract double MillinewtonsPerMeterInOneNewtonPerMeter { get; }
        protected abstract double NanonewtonsPerMeterInOneNewtonPerMeter { get; }
        protected abstract double NewtonsPerMeterInOneNewtonPerMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CentinewtonsPerMeterTolerance { get { return 1e-5; } }
        protected virtual double DecinewtonsPerMeterTolerance { get { return 1e-5; } }
        protected virtual double KilogramsForcePerMeterTolerance { get { return 1e-5; } }
        protected virtual double KilonewtonsPerMeterTolerance { get { return 1e-5; } }
        protected virtual double MicronewtonsPerMeterTolerance { get { return 1e-5; } }
        protected virtual double MillinewtonsPerMeterTolerance { get { return 1e-5; } }
        protected virtual double NanonewtonsPerMeterTolerance { get { return 1e-5; } }
        protected virtual double NewtonsPerMeterTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void NewtonPerMeterToForcePerLengthUnits()
        {
            ForcePerLength newtonpermeter = ForcePerLength.FromNewtonsPerMeter(1);
            AssertEx.EqualTolerance(CentinewtonsPerMeterInOneNewtonPerMeter, newtonpermeter.CentinewtonsPerMeter, CentinewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(DecinewtonsPerMeterInOneNewtonPerMeter, newtonpermeter.DecinewtonsPerMeter, DecinewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(KilogramsForcePerMeterInOneNewtonPerMeter, newtonpermeter.KilogramsForcePerMeter, KilogramsForcePerMeterTolerance);
            AssertEx.EqualTolerance(KilonewtonsPerMeterInOneNewtonPerMeter, newtonpermeter.KilonewtonsPerMeter, KilonewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(MicronewtonsPerMeterInOneNewtonPerMeter, newtonpermeter.MicronewtonsPerMeter, MicronewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(MillinewtonsPerMeterInOneNewtonPerMeter, newtonpermeter.MillinewtonsPerMeter, MillinewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(NanonewtonsPerMeterInOneNewtonPerMeter, newtonpermeter.NanonewtonsPerMeter, NanonewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(NewtonsPerMeterInOneNewtonPerMeter, newtonpermeter.NewtonsPerMeter, NewtonsPerMeterTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, ForcePerLength.From(1, ForcePerLengthUnit.CentinewtonPerMeter).CentinewtonsPerMeter, CentinewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(1, ForcePerLength.From(1, ForcePerLengthUnit.DecinewtonPerMeter).DecinewtonsPerMeter, DecinewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(1, ForcePerLength.From(1, ForcePerLengthUnit.KilogramForcePerMeter).KilogramsForcePerMeter, KilogramsForcePerMeterTolerance);
            AssertEx.EqualTolerance(1, ForcePerLength.From(1, ForcePerLengthUnit.KilonewtonPerMeter).KilonewtonsPerMeter, KilonewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(1, ForcePerLength.From(1, ForcePerLengthUnit.MicronewtonPerMeter).MicronewtonsPerMeter, MicronewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(1, ForcePerLength.From(1, ForcePerLengthUnit.MillinewtonPerMeter).MillinewtonsPerMeter, MillinewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(1, ForcePerLength.From(1, ForcePerLengthUnit.NanonewtonPerMeter).NanonewtonsPerMeter, NanonewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(1, ForcePerLength.From(1, ForcePerLengthUnit.NewtonPerMeter).NewtonsPerMeter, NewtonsPerMeterTolerance);
        }

        [Fact]
        public void As()
        {
            var newtonpermeter = ForcePerLength.FromNewtonsPerMeter(1);
            AssertEx.EqualTolerance(CentinewtonsPerMeterInOneNewtonPerMeter, newtonpermeter.As(ForcePerLengthUnit.CentinewtonPerMeter), CentinewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(DecinewtonsPerMeterInOneNewtonPerMeter, newtonpermeter.As(ForcePerLengthUnit.DecinewtonPerMeter), DecinewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(KilogramsForcePerMeterInOneNewtonPerMeter, newtonpermeter.As(ForcePerLengthUnit.KilogramForcePerMeter), KilogramsForcePerMeterTolerance);
            AssertEx.EqualTolerance(KilonewtonsPerMeterInOneNewtonPerMeter, newtonpermeter.As(ForcePerLengthUnit.KilonewtonPerMeter), KilonewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(MicronewtonsPerMeterInOneNewtonPerMeter, newtonpermeter.As(ForcePerLengthUnit.MicronewtonPerMeter), MicronewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(MillinewtonsPerMeterInOneNewtonPerMeter, newtonpermeter.As(ForcePerLengthUnit.MillinewtonPerMeter), MillinewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(NanonewtonsPerMeterInOneNewtonPerMeter, newtonpermeter.As(ForcePerLengthUnit.NanonewtonPerMeter), NanonewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(NewtonsPerMeterInOneNewtonPerMeter, newtonpermeter.As(ForcePerLengthUnit.NewtonPerMeter), NewtonsPerMeterTolerance);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ForcePerLength newtonpermeter = ForcePerLength.FromNewtonsPerMeter(1);
            AssertEx.EqualTolerance(1, ForcePerLength.FromCentinewtonsPerMeter(newtonpermeter.CentinewtonsPerMeter).NewtonsPerMeter, CentinewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(1, ForcePerLength.FromDecinewtonsPerMeter(newtonpermeter.DecinewtonsPerMeter).NewtonsPerMeter, DecinewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(1, ForcePerLength.FromKilogramsForcePerMeter(newtonpermeter.KilogramsForcePerMeter).NewtonsPerMeter, KilogramsForcePerMeterTolerance);
            AssertEx.EqualTolerance(1, ForcePerLength.FromKilonewtonsPerMeter(newtonpermeter.KilonewtonsPerMeter).NewtonsPerMeter, KilonewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(1, ForcePerLength.FromMicronewtonsPerMeter(newtonpermeter.MicronewtonsPerMeter).NewtonsPerMeter, MicronewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(1, ForcePerLength.FromMillinewtonsPerMeter(newtonpermeter.MillinewtonsPerMeter).NewtonsPerMeter, MillinewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(1, ForcePerLength.FromNanonewtonsPerMeter(newtonpermeter.NanonewtonsPerMeter).NewtonsPerMeter, NanonewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(1, ForcePerLength.FromNewtonsPerMeter(newtonpermeter.NewtonsPerMeter).NewtonsPerMeter, NewtonsPerMeterTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ForcePerLength v = ForcePerLength.FromNewtonsPerMeter(1);
            AssertEx.EqualTolerance(-1, -v.NewtonsPerMeter, NewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(2, (ForcePerLength.FromNewtonsPerMeter(3)-v).NewtonsPerMeter, NewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(2, (v + v).NewtonsPerMeter, NewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(10, (v*10).NewtonsPerMeter, NewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(10, (10*v).NewtonsPerMeter, NewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(2, (ForcePerLength.FromNewtonsPerMeter(10)/5).NewtonsPerMeter, NewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(2, ForcePerLength.FromNewtonsPerMeter(10)/ForcePerLength.FromNewtonsPerMeter(5), NewtonsPerMeterTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ForcePerLength oneNewtonPerMeter = ForcePerLength.FromNewtonsPerMeter(1);
            ForcePerLength twoNewtonsPerMeter = ForcePerLength.FromNewtonsPerMeter(2);

            Assert.True(oneNewtonPerMeter < twoNewtonsPerMeter);
            Assert.True(oneNewtonPerMeter <= twoNewtonsPerMeter);
            Assert.True(twoNewtonsPerMeter > oneNewtonPerMeter);
            Assert.True(twoNewtonsPerMeter >= oneNewtonPerMeter);

            Assert.False(oneNewtonPerMeter > twoNewtonsPerMeter);
            Assert.False(oneNewtonPerMeter >= twoNewtonsPerMeter);
            Assert.False(twoNewtonsPerMeter < oneNewtonPerMeter);
            Assert.False(twoNewtonsPerMeter <= oneNewtonPerMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ForcePerLength newtonpermeter = ForcePerLength.FromNewtonsPerMeter(1);
            Assert.Equal(0, newtonpermeter.CompareTo(newtonpermeter));
            Assert.True(newtonpermeter.CompareTo(ForcePerLength.Zero) > 0);
            Assert.True(ForcePerLength.Zero.CompareTo(newtonpermeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ForcePerLength newtonpermeter = ForcePerLength.FromNewtonsPerMeter(1);
            Assert.Throws<ArgumentException>(() => newtonpermeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ForcePerLength newtonpermeter = ForcePerLength.FromNewtonsPerMeter(1);
            Assert.Throws<ArgumentNullException>(() => newtonpermeter.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            ForcePerLength a = ForcePerLength.FromNewtonsPerMeter(1);
            ForcePerLength b = ForcePerLength.FromNewtonsPerMeter(2);

// ReSharper disable EqualExpressionComparison
            Assert.True(a == a);
            Assert.True(a != b);

            Assert.False(a == b);
            Assert.False(a != a);
// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            ForcePerLength v = ForcePerLength.FromNewtonsPerMeter(1);
            Assert.True(v.Equals(ForcePerLength.FromNewtonsPerMeter(1)));
            Assert.False(v.Equals(ForcePerLength.Zero));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ForcePerLength newtonpermeter = ForcePerLength.FromNewtonsPerMeter(1);
            Assert.False(newtonpermeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ForcePerLength newtonpermeter = ForcePerLength.FromNewtonsPerMeter(1);
            Assert.False(newtonpermeter.Equals(null));
        }
    }
}
