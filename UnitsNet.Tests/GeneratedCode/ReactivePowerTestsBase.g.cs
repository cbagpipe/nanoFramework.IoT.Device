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
    /// Test of ReactivePower.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ReactivePowerTestsBase
    {
        protected abstract double KilovoltamperesReactiveInOneVoltampereReactive { get; }
        protected abstract double MegavoltamperesReactiveInOneVoltampereReactive { get; }
        protected abstract double VoltamperesReactiveInOneVoltampereReactive { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double KilovoltamperesReactiveTolerance { get { return 1e-5; } }
        protected virtual double MegavoltamperesReactiveTolerance { get { return 1e-5; } }
        protected virtual double VoltamperesReactiveTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void VoltampereReactiveToReactivePowerUnits()
        {
            ReactivePower voltamperereactive = ReactivePower.FromVoltamperesReactive(1);
            AssertEx.EqualTolerance(KilovoltamperesReactiveInOneVoltampereReactive, voltamperereactive.KilovoltamperesReactive, KilovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(MegavoltamperesReactiveInOneVoltampereReactive, voltamperereactive.MegavoltamperesReactive, MegavoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(VoltamperesReactiveInOneVoltampereReactive, voltamperereactive.VoltamperesReactive, VoltamperesReactiveTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, ReactivePower.From(1, ReactivePowerUnit.KilovoltampereReactive).KilovoltamperesReactive, KilovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.From(1, ReactivePowerUnit.MegavoltampereReactive).MegavoltamperesReactive, MegavoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.From(1, ReactivePowerUnit.VoltampereReactive).VoltamperesReactive, VoltamperesReactiveTolerance);
        }

        [Fact]
        public void As()
        {
            var voltamperereactive = ReactivePower.FromVoltamperesReactive(1);
            AssertEx.EqualTolerance(KilovoltamperesReactiveInOneVoltampereReactive, voltamperereactive.As(ReactivePowerUnit.KilovoltampereReactive), KilovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(MegavoltamperesReactiveInOneVoltampereReactive, voltamperereactive.As(ReactivePowerUnit.MegavoltampereReactive), MegavoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(VoltamperesReactiveInOneVoltampereReactive, voltamperereactive.As(ReactivePowerUnit.VoltampereReactive), VoltamperesReactiveTolerance);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ReactivePower voltamperereactive = ReactivePower.FromVoltamperesReactive(1);
            AssertEx.EqualTolerance(1, ReactivePower.FromKilovoltamperesReactive(voltamperereactive.KilovoltamperesReactive).VoltamperesReactive, KilovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.FromMegavoltamperesReactive(voltamperereactive.MegavoltamperesReactive).VoltamperesReactive, MegavoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.FromVoltamperesReactive(voltamperereactive.VoltamperesReactive).VoltamperesReactive, VoltamperesReactiveTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ReactivePower v = ReactivePower.FromVoltamperesReactive(1);
            AssertEx.EqualTolerance(-1, -v.VoltamperesReactive, VoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(2, (ReactivePower.FromVoltamperesReactive(3)-v).VoltamperesReactive, VoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(2, (v + v).VoltamperesReactive, VoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(10, (v*10).VoltamperesReactive, VoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(10, (10*v).VoltamperesReactive, VoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(2, (ReactivePower.FromVoltamperesReactive(10)/5).VoltamperesReactive, VoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(2, ReactivePower.FromVoltamperesReactive(10)/ReactivePower.FromVoltamperesReactive(5), VoltamperesReactiveTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ReactivePower oneVoltampereReactive = ReactivePower.FromVoltamperesReactive(1);
            ReactivePower twoVoltamperesReactive = ReactivePower.FromVoltamperesReactive(2);

            Assert.True(oneVoltampereReactive < twoVoltamperesReactive);
            Assert.True(oneVoltampereReactive <= twoVoltamperesReactive);
            Assert.True(twoVoltamperesReactive > oneVoltampereReactive);
            Assert.True(twoVoltamperesReactive >= oneVoltampereReactive);

            Assert.False(oneVoltampereReactive > twoVoltamperesReactive);
            Assert.False(oneVoltampereReactive >= twoVoltamperesReactive);
            Assert.False(twoVoltamperesReactive < oneVoltampereReactive);
            Assert.False(twoVoltamperesReactive <= oneVoltampereReactive);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ReactivePower voltamperereactive = ReactivePower.FromVoltamperesReactive(1);
            Assert.Equal(0, voltamperereactive.CompareTo(voltamperereactive));
            Assert.True(voltamperereactive.CompareTo(ReactivePower.Zero) > 0);
            Assert.True(ReactivePower.Zero.CompareTo(voltamperereactive) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ReactivePower voltamperereactive = ReactivePower.FromVoltamperesReactive(1);
            Assert.Throws<ArgumentException>(() => voltamperereactive.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ReactivePower voltamperereactive = ReactivePower.FromVoltamperesReactive(1);
            Assert.Throws<ArgumentNullException>(() => voltamperereactive.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            ReactivePower a = ReactivePower.FromVoltamperesReactive(1);
            ReactivePower b = ReactivePower.FromVoltamperesReactive(2);

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
            ReactivePower v = ReactivePower.FromVoltamperesReactive(1);
            Assert.True(v.Equals(ReactivePower.FromVoltamperesReactive(1)));
            Assert.False(v.Equals(ReactivePower.Zero));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ReactivePower voltamperereactive = ReactivePower.FromVoltamperesReactive(1);
            Assert.False(voltamperereactive.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ReactivePower voltamperereactive = ReactivePower.FromVoltamperesReactive(1);
            Assert.False(voltamperereactive.Equals(null));
        }
    }
}
