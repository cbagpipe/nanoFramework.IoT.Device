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
    /// Test of ForceChangeRate.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ForceChangeRateTestsBase
    {
        protected abstract double CentinewtonsPerSecondInOneNewtonPerSecond { get; }
        protected abstract double DecanewtonsPerMinuteInOneNewtonPerSecond { get; }
        protected abstract double DecanewtonsPerSecondInOneNewtonPerSecond { get; }
        protected abstract double DecinewtonsPerSecondInOneNewtonPerSecond { get; }
        protected abstract double KilonewtonsPerMinuteInOneNewtonPerSecond { get; }
        protected abstract double KilonewtonsPerSecondInOneNewtonPerSecond { get; }
        protected abstract double MicronewtonsPerSecondInOneNewtonPerSecond { get; }
        protected abstract double MillinewtonsPerSecondInOneNewtonPerSecond { get; }
        protected abstract double NanonewtonsPerSecondInOneNewtonPerSecond { get; }
        protected abstract double NewtonsPerMinuteInOneNewtonPerSecond { get; }
        protected abstract double NewtonsPerSecondInOneNewtonPerSecond { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CentinewtonsPerSecondTolerance { get { return 1e-5; } }
        protected virtual double DecanewtonsPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double DecanewtonsPerSecondTolerance { get { return 1e-5; } }
        protected virtual double DecinewtonsPerSecondTolerance { get { return 1e-5; } }
        protected virtual double KilonewtonsPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double KilonewtonsPerSecondTolerance { get { return 1e-5; } }
        protected virtual double MicronewtonsPerSecondTolerance { get { return 1e-5; } }
        protected virtual double MillinewtonsPerSecondTolerance { get { return 1e-5; } }
        protected virtual double NanonewtonsPerSecondTolerance { get { return 1e-5; } }
        protected virtual double NewtonsPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double NewtonsPerSecondTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void NewtonPerSecondToForceChangeRateUnits()
        {
            ForceChangeRate newtonpersecond = ForceChangeRate.FromNewtonsPerSecond(1);
            AssertEx.EqualTolerance(CentinewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.CentinewtonsPerSecond, CentinewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(DecanewtonsPerMinuteInOneNewtonPerSecond, newtonpersecond.DecanewtonsPerMinute, DecanewtonsPerMinuteTolerance);
            AssertEx.EqualTolerance(DecanewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.DecanewtonsPerSecond, DecanewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(DecinewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.DecinewtonsPerSecond, DecinewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(KilonewtonsPerMinuteInOneNewtonPerSecond, newtonpersecond.KilonewtonsPerMinute, KilonewtonsPerMinuteTolerance);
            AssertEx.EqualTolerance(KilonewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.KilonewtonsPerSecond, KilonewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(MicronewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.MicronewtonsPerSecond, MicronewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(MillinewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.MillinewtonsPerSecond, MillinewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(NanonewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.NanonewtonsPerSecond, NanonewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(NewtonsPerMinuteInOneNewtonPerSecond, newtonpersecond.NewtonsPerMinute, NewtonsPerMinuteTolerance);
            AssertEx.EqualTolerance(NewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.NewtonsPerSecond, NewtonsPerSecondTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, ForceChangeRate.From(1, ForceChangeRateUnit.CentinewtonPerSecond).CentinewtonsPerSecond, CentinewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.From(1, ForceChangeRateUnit.DecanewtonPerMinute).DecanewtonsPerMinute, DecanewtonsPerMinuteTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.From(1, ForceChangeRateUnit.DecanewtonPerSecond).DecanewtonsPerSecond, DecanewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.From(1, ForceChangeRateUnit.DecinewtonPerSecond).DecinewtonsPerSecond, DecinewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.From(1, ForceChangeRateUnit.KilonewtonPerMinute).KilonewtonsPerMinute, KilonewtonsPerMinuteTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.From(1, ForceChangeRateUnit.KilonewtonPerSecond).KilonewtonsPerSecond, KilonewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.From(1, ForceChangeRateUnit.MicronewtonPerSecond).MicronewtonsPerSecond, MicronewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.From(1, ForceChangeRateUnit.MillinewtonPerSecond).MillinewtonsPerSecond, MillinewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.From(1, ForceChangeRateUnit.NanonewtonPerSecond).NanonewtonsPerSecond, NanonewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.From(1, ForceChangeRateUnit.NewtonPerMinute).NewtonsPerMinute, NewtonsPerMinuteTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.From(1, ForceChangeRateUnit.NewtonPerSecond).NewtonsPerSecond, NewtonsPerSecondTolerance);
        }

        [Fact]
        public void As()
        {
            var newtonpersecond = ForceChangeRate.FromNewtonsPerSecond(1);
            AssertEx.EqualTolerance(CentinewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.As(ForceChangeRateUnit.CentinewtonPerSecond), CentinewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(DecanewtonsPerMinuteInOneNewtonPerSecond, newtonpersecond.As(ForceChangeRateUnit.DecanewtonPerMinute), DecanewtonsPerMinuteTolerance);
            AssertEx.EqualTolerance(DecanewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.As(ForceChangeRateUnit.DecanewtonPerSecond), DecanewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(DecinewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.As(ForceChangeRateUnit.DecinewtonPerSecond), DecinewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(KilonewtonsPerMinuteInOneNewtonPerSecond, newtonpersecond.As(ForceChangeRateUnit.KilonewtonPerMinute), KilonewtonsPerMinuteTolerance);
            AssertEx.EqualTolerance(KilonewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.As(ForceChangeRateUnit.KilonewtonPerSecond), KilonewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(MicronewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.As(ForceChangeRateUnit.MicronewtonPerSecond), MicronewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(MillinewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.As(ForceChangeRateUnit.MillinewtonPerSecond), MillinewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(NanonewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.As(ForceChangeRateUnit.NanonewtonPerSecond), NanonewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(NewtonsPerMinuteInOneNewtonPerSecond, newtonpersecond.As(ForceChangeRateUnit.NewtonPerMinute), NewtonsPerMinuteTolerance);
            AssertEx.EqualTolerance(NewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.As(ForceChangeRateUnit.NewtonPerSecond), NewtonsPerSecondTolerance);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ForceChangeRate newtonpersecond = ForceChangeRate.FromNewtonsPerSecond(1);
            AssertEx.EqualTolerance(1, ForceChangeRate.FromCentinewtonsPerSecond(newtonpersecond.CentinewtonsPerSecond).NewtonsPerSecond, CentinewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.FromDecanewtonsPerMinute(newtonpersecond.DecanewtonsPerMinute).NewtonsPerSecond, DecanewtonsPerMinuteTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.FromDecanewtonsPerSecond(newtonpersecond.DecanewtonsPerSecond).NewtonsPerSecond, DecanewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.FromDecinewtonsPerSecond(newtonpersecond.DecinewtonsPerSecond).NewtonsPerSecond, DecinewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.FromKilonewtonsPerMinute(newtonpersecond.KilonewtonsPerMinute).NewtonsPerSecond, KilonewtonsPerMinuteTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.FromKilonewtonsPerSecond(newtonpersecond.KilonewtonsPerSecond).NewtonsPerSecond, KilonewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.FromMicronewtonsPerSecond(newtonpersecond.MicronewtonsPerSecond).NewtonsPerSecond, MicronewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.FromMillinewtonsPerSecond(newtonpersecond.MillinewtonsPerSecond).NewtonsPerSecond, MillinewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.FromNanonewtonsPerSecond(newtonpersecond.NanonewtonsPerSecond).NewtonsPerSecond, NanonewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.FromNewtonsPerMinute(newtonpersecond.NewtonsPerMinute).NewtonsPerSecond, NewtonsPerMinuteTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.FromNewtonsPerSecond(newtonpersecond.NewtonsPerSecond).NewtonsPerSecond, NewtonsPerSecondTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ForceChangeRate v = ForceChangeRate.FromNewtonsPerSecond(1);
            AssertEx.EqualTolerance(-1, -v.NewtonsPerSecond, NewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(2, (ForceChangeRate.FromNewtonsPerSecond(3)-v).NewtonsPerSecond, NewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(2, (v + v).NewtonsPerSecond, NewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(10, (v*10).NewtonsPerSecond, NewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(10, (10*v).NewtonsPerSecond, NewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(2, (ForceChangeRate.FromNewtonsPerSecond(10)/5).NewtonsPerSecond, NewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(2, ForceChangeRate.FromNewtonsPerSecond(10)/ForceChangeRate.FromNewtonsPerSecond(5), NewtonsPerSecondTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ForceChangeRate oneNewtonPerSecond = ForceChangeRate.FromNewtonsPerSecond(1);
            ForceChangeRate twoNewtonsPerSecond = ForceChangeRate.FromNewtonsPerSecond(2);

            Assert.True(oneNewtonPerSecond < twoNewtonsPerSecond);
            Assert.True(oneNewtonPerSecond <= twoNewtonsPerSecond);
            Assert.True(twoNewtonsPerSecond > oneNewtonPerSecond);
            Assert.True(twoNewtonsPerSecond >= oneNewtonPerSecond);

            Assert.False(oneNewtonPerSecond > twoNewtonsPerSecond);
            Assert.False(oneNewtonPerSecond >= twoNewtonsPerSecond);
            Assert.False(twoNewtonsPerSecond < oneNewtonPerSecond);
            Assert.False(twoNewtonsPerSecond <= oneNewtonPerSecond);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ForceChangeRate newtonpersecond = ForceChangeRate.FromNewtonsPerSecond(1);
            Assert.Equal(0, newtonpersecond.CompareTo(newtonpersecond));
            Assert.True(newtonpersecond.CompareTo(ForceChangeRate.Zero) > 0);
            Assert.True(ForceChangeRate.Zero.CompareTo(newtonpersecond) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ForceChangeRate newtonpersecond = ForceChangeRate.FromNewtonsPerSecond(1);
            Assert.Throws<ArgumentException>(() => newtonpersecond.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ForceChangeRate newtonpersecond = ForceChangeRate.FromNewtonsPerSecond(1);
            Assert.Throws<ArgumentNullException>(() => newtonpersecond.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            ForceChangeRate a = ForceChangeRate.FromNewtonsPerSecond(1);
            ForceChangeRate b = ForceChangeRate.FromNewtonsPerSecond(2);

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
            ForceChangeRate v = ForceChangeRate.FromNewtonsPerSecond(1);
            Assert.True(v.Equals(ForceChangeRate.FromNewtonsPerSecond(1)));
            Assert.False(v.Equals(ForceChangeRate.Zero));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ForceChangeRate newtonpersecond = ForceChangeRate.FromNewtonsPerSecond(1);
            Assert.False(newtonpersecond.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ForceChangeRate newtonpersecond = ForceChangeRate.FromNewtonsPerSecond(1);
            Assert.False(newtonpersecond.Equals(null));
        }
    }
}
