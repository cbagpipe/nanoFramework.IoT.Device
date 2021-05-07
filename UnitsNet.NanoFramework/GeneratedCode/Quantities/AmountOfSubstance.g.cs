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
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using UnitsNet.Units;

namespace UnitsNet
{
    /// <inheritdoc />
    /// <summary>
    ///     Mole is the amount of substance containing Avagadro's Number (6.02 x 10 ^ 23) of real particles such as molecules,atoms, ions or radicals.
    /// </summary>
    public struct  AmountOfSubstance
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly AmountOfSubstanceUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public AmountOfSubstanceUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public AmountOfSubstance(double value, AmountOfSubstanceUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static AmountOfSubstanceUnit BaseUnit { get; } = AmountOfSubstanceUnit.Mole;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static AmountOfSubstance MaxValue { get; } = new AmountOfSubstance(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static AmountOfSubstance MinValue { get; } = new AmountOfSubstance(double.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static AmountOfSubstance Zero { get; } = new AmountOfSubstance(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Get AmountOfSubstance in Centimoles.
        /// </summary>
        public double Centimoles => As(AmountOfSubstanceUnit.Centimole);

        /// <summary>
        ///     Get AmountOfSubstance in CentipoundMoles.
        /// </summary>
        public double CentipoundMoles => As(AmountOfSubstanceUnit.CentipoundMole);

        /// <summary>
        ///     Get AmountOfSubstance in Decimoles.
        /// </summary>
        public double Decimoles => As(AmountOfSubstanceUnit.Decimole);

        /// <summary>
        ///     Get AmountOfSubstance in DecipoundMoles.
        /// </summary>
        public double DecipoundMoles => As(AmountOfSubstanceUnit.DecipoundMole);

        /// <summary>
        ///     Get AmountOfSubstance in Kilomoles.
        /// </summary>
        public double Kilomoles => As(AmountOfSubstanceUnit.Kilomole);

        /// <summary>
        ///     Get AmountOfSubstance in KilopoundMoles.
        /// </summary>
        public double KilopoundMoles => As(AmountOfSubstanceUnit.KilopoundMole);

        /// <summary>
        ///     Get AmountOfSubstance in Megamoles.
        /// </summary>
        public double Megamoles => As(AmountOfSubstanceUnit.Megamole);

        /// <summary>
        ///     Get AmountOfSubstance in Micromoles.
        /// </summary>
        public double Micromoles => As(AmountOfSubstanceUnit.Micromole);

        /// <summary>
        ///     Get AmountOfSubstance in MicropoundMoles.
        /// </summary>
        public double MicropoundMoles => As(AmountOfSubstanceUnit.MicropoundMole);

        /// <summary>
        ///     Get AmountOfSubstance in Millimoles.
        /// </summary>
        public double Millimoles => As(AmountOfSubstanceUnit.Millimole);

        /// <summary>
        ///     Get AmountOfSubstance in MillipoundMoles.
        /// </summary>
        public double MillipoundMoles => As(AmountOfSubstanceUnit.MillipoundMole);

        /// <summary>
        ///     Get AmountOfSubstance in Moles.
        /// </summary>
        public double Moles => As(AmountOfSubstanceUnit.Mole);

        /// <summary>
        ///     Get AmountOfSubstance in Nanomoles.
        /// </summary>
        public double Nanomoles => As(AmountOfSubstanceUnit.Nanomole);

        /// <summary>
        ///     Get AmountOfSubstance in NanopoundMoles.
        /// </summary>
        public double NanopoundMoles => As(AmountOfSubstanceUnit.NanopoundMole);

        /// <summary>
        ///     Get AmountOfSubstance in PoundMoles.
        /// </summary>
        public double PoundMoles => As(AmountOfSubstanceUnit.PoundMole);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get AmountOfSubstance from Centimoles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmountOfSubstance FromCentimoles(double centimoles) => new AmountOfSubstance(centimoles, AmountOfSubstanceUnit.Centimole);

        /// <summary>
        ///     Get AmountOfSubstance from CentipoundMoles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmountOfSubstance FromCentipoundMoles(double centipoundmoles) => new AmountOfSubstance(centipoundmoles, AmountOfSubstanceUnit.CentipoundMole);

        /// <summary>
        ///     Get AmountOfSubstance from Decimoles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmountOfSubstance FromDecimoles(double decimoles) => new AmountOfSubstance(decimoles, AmountOfSubstanceUnit.Decimole);

        /// <summary>
        ///     Get AmountOfSubstance from DecipoundMoles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmountOfSubstance FromDecipoundMoles(double decipoundmoles) => new AmountOfSubstance(decipoundmoles, AmountOfSubstanceUnit.DecipoundMole);

        /// <summary>
        ///     Get AmountOfSubstance from Kilomoles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmountOfSubstance FromKilomoles(double kilomoles) => new AmountOfSubstance(kilomoles, AmountOfSubstanceUnit.Kilomole);

        /// <summary>
        ///     Get AmountOfSubstance from KilopoundMoles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmountOfSubstance FromKilopoundMoles(double kilopoundmoles) => new AmountOfSubstance(kilopoundmoles, AmountOfSubstanceUnit.KilopoundMole);

        /// <summary>
        ///     Get AmountOfSubstance from Megamoles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmountOfSubstance FromMegamoles(double megamoles) => new AmountOfSubstance(megamoles, AmountOfSubstanceUnit.Megamole);

        /// <summary>
        ///     Get AmountOfSubstance from Micromoles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmountOfSubstance FromMicromoles(double micromoles) => new AmountOfSubstance(micromoles, AmountOfSubstanceUnit.Micromole);

        /// <summary>
        ///     Get AmountOfSubstance from MicropoundMoles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmountOfSubstance FromMicropoundMoles(double micropoundmoles) => new AmountOfSubstance(micropoundmoles, AmountOfSubstanceUnit.MicropoundMole);

        /// <summary>
        ///     Get AmountOfSubstance from Millimoles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmountOfSubstance FromMillimoles(double millimoles) => new AmountOfSubstance(millimoles, AmountOfSubstanceUnit.Millimole);

        /// <summary>
        ///     Get AmountOfSubstance from MillipoundMoles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmountOfSubstance FromMillipoundMoles(double millipoundmoles) => new AmountOfSubstance(millipoundmoles, AmountOfSubstanceUnit.MillipoundMole);

        /// <summary>
        ///     Get AmountOfSubstance from Moles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmountOfSubstance FromMoles(double moles) => new AmountOfSubstance(moles, AmountOfSubstanceUnit.Mole);

        /// <summary>
        ///     Get AmountOfSubstance from Nanomoles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmountOfSubstance FromNanomoles(double nanomoles) => new AmountOfSubstance(nanomoles, AmountOfSubstanceUnit.Nanomole);

        /// <summary>
        ///     Get AmountOfSubstance from NanopoundMoles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmountOfSubstance FromNanopoundMoles(double nanopoundmoles) => new AmountOfSubstance(nanopoundmoles, AmountOfSubstanceUnit.NanopoundMole);

        /// <summary>
        ///     Get AmountOfSubstance from PoundMoles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmountOfSubstance FromPoundMoles(double poundmoles) => new AmountOfSubstance(poundmoles, AmountOfSubstanceUnit.PoundMole);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="AmountOfSubstanceUnit" /> to <see cref="AmountOfSubstance" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>AmountOfSubstance unit value.</returns>
        public static AmountOfSubstance From(double value, AmountOfSubstanceUnit fromUnit)
        {
            return new AmountOfSubstance(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(AmountOfSubstanceUnit unit) => GetValueAs(unit);        

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public AmountOfSubstance ToUnit(AmountOfSubstanceUnit unit)
        {
                
            var convertedValue = GetValueAs(unit);
            return new AmountOfSubstance(convertedValue, unit);
        }


        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double GetValueInBaseUnit()
        {
            switch(Unit)
            {
                case AmountOfSubstanceUnit.Centimole: return (_value) * 1e-2d;
                case AmountOfSubstanceUnit.CentipoundMole: return (_value*453.59237) * 1e-2d;
                case AmountOfSubstanceUnit.Decimole: return (_value) * 1e-1d;
                case AmountOfSubstanceUnit.DecipoundMole: return (_value*453.59237) * 1e-1d;
                case AmountOfSubstanceUnit.Kilomole: return (_value) * 1e3d;
                case AmountOfSubstanceUnit.KilopoundMole: return (_value*453.59237) * 1e3d;
                case AmountOfSubstanceUnit.Megamole: return (_value) * 1e6d;
                case AmountOfSubstanceUnit.Micromole: return (_value) * 1e-6d;
                case AmountOfSubstanceUnit.MicropoundMole: return (_value*453.59237) * 1e-6d;
                case AmountOfSubstanceUnit.Millimole: return (_value) * 1e-3d;
                case AmountOfSubstanceUnit.MillipoundMole: return (_value*453.59237) * 1e-3d;
                case AmountOfSubstanceUnit.Mole: return _value;
                case AmountOfSubstanceUnit.Nanomole: return (_value) * 1e-9d;
                case AmountOfSubstanceUnit.NanopoundMole: return (_value*453.59237) * 1e-9d;
                case AmountOfSubstanceUnit.PoundMole: return _value*453.59237;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double GetValueAs(AmountOfSubstanceUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            switch(unit)
            {
                case AmountOfSubstanceUnit.Centimole: return (baseUnitValue) / 1e-2d;
                case AmountOfSubstanceUnit.CentipoundMole: return (baseUnitValue/453.59237) / 1e-2d;
                case AmountOfSubstanceUnit.Decimole: return (baseUnitValue) / 1e-1d;
                case AmountOfSubstanceUnit.DecipoundMole: return (baseUnitValue/453.59237) / 1e-1d;
                case AmountOfSubstanceUnit.Kilomole: return (baseUnitValue) / 1e3d;
                case AmountOfSubstanceUnit.KilopoundMole: return (baseUnitValue/453.59237) / 1e3d;
                case AmountOfSubstanceUnit.Megamole: return (baseUnitValue) / 1e6d;
                case AmountOfSubstanceUnit.Micromole: return (baseUnitValue) / 1e-6d;
                case AmountOfSubstanceUnit.MicropoundMole: return (baseUnitValue/453.59237) / 1e-6d;
                case AmountOfSubstanceUnit.Millimole: return (baseUnitValue) / 1e-3d;
                case AmountOfSubstanceUnit.MillipoundMole: return (baseUnitValue/453.59237) / 1e-3d;
                case AmountOfSubstanceUnit.Mole: return baseUnitValue;
                case AmountOfSubstanceUnit.Nanomole: return (baseUnitValue) / 1e-9d;
                case AmountOfSubstanceUnit.NanopoundMole: return (baseUnitValue/453.59237) / 1e-9d;
                case AmountOfSubstanceUnit.PoundMole: return baseUnitValue/453.59237;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

    }
}

