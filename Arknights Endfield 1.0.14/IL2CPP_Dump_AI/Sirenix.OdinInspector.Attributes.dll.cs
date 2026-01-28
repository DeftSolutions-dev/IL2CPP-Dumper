// ========================================================
// Dumped by @desirepro
// Assembly: Sirenix.OdinInspector.Attributes.dll
// Classes:  12
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: Sirenix.OdinInspector.DontApplyToListElementsAttribute
TYPE:  class
TOKEN: 0x2000002
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Sirenix.OdinInspector.RequiredListLengthAttribute
TYPE:  class
TOKEN: 0x2000003
EXTENDS: Attribute
FIELDS:
  private           System.Int32                    minLength  // 0x10
  private           System.Int32                    maxLength  // 0x14
  private           System.Boolean                  minLengthIsSet  // 0x18
  private           System.Boolean                  maxLengthIsSet  // 0x19
  public            System.String                   MinLengthGetter  // 0x20
METHODS:
  System.Void set_MinLength(System.Int32 value)
  System.Void set_MaxLength(System.Int32 value)
  System.Void .ctor(System.Int32 minLength, System.Int32 maxLength)
  System.Void .ctor(System.String minLengthGetter, System.Int32 maxLength)
END_CLASS

CLASS: Sirenix.OdinInspector.ShowInInspectorAttribute
TYPE:  class
TOKEN: 0x2000004
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Sirenix.OdinInspector.UnitAttribute
TYPE:  class
TOKEN: 0x2000005
EXTENDS: Attribute
FIELDS:
  public            Sirenix.OdinInspector.Units     Base  // 0x10
  public            Sirenix.OdinInspector.Units     Display  // 0x14
METHODS:
  System.Void .ctor(Sirenix.OdinInspector.Units unit)
  System.Void .ctor(Sirenix.OdinInspector.Units base, Sirenix.OdinInspector.Units display)
END_CLASS

CLASS: Sirenix.OdinInspector.Units
TYPE:  struct
TOKEN: 0x2000006
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Sirenix.OdinInspector.Units     Unset  // 0x0
  public    static  Sirenix.OdinInspector.Units     Nanometer  // 0x0
  public    static  Sirenix.OdinInspector.Units     Micrometer  // 0x0
  public    static  Sirenix.OdinInspector.Units     Millimeter  // 0x0
  public    static  Sirenix.OdinInspector.Units     Centimeter  // 0x0
  public    static  Sirenix.OdinInspector.Units     Meter  // 0x0
  public    static  Sirenix.OdinInspector.Units     Kilometer  // 0x0
  public    static  Sirenix.OdinInspector.Units     Inch  // 0x0
  public    static  Sirenix.OdinInspector.Units     Feet  // 0x0
  public    static  Sirenix.OdinInspector.Units     Mile  // 0x0
  public    static  Sirenix.OdinInspector.Units     Yard  // 0x0
  public    static  Sirenix.OdinInspector.Units     NauticalMile  // 0x0
  public    static  Sirenix.OdinInspector.Units     LightYear  // 0x0
  public    static  Sirenix.OdinInspector.Units     Parsec  // 0x0
  public    static  Sirenix.OdinInspector.Units     AstronomicalUnit  // 0x0
  public    static  Sirenix.OdinInspector.Units     CubicMeter  // 0x0
  public    static  Sirenix.OdinInspector.Units     CubicKilometer  // 0x0
  public    static  Sirenix.OdinInspector.Units     CubicCentimeter  // 0x0
  public    static  Sirenix.OdinInspector.Units     CubicMillimeter  // 0x0
  public    static  Sirenix.OdinInspector.Units     Liter  // 0x0
  public    static  Sirenix.OdinInspector.Units     Milliliter  // 0x0
  public    static  Sirenix.OdinInspector.Units     Centiliter  // 0x0
  public    static  Sirenix.OdinInspector.Units     Deciliter  // 0x0
  public    static  Sirenix.OdinInspector.Units     Hectoliter  // 0x0
  public    static  Sirenix.OdinInspector.Units     CubicInch  // 0x0
  public    static  Sirenix.OdinInspector.Units     CubicFeet  // 0x0
  public    static  Sirenix.OdinInspector.Units     CubicYard  // 0x0
  public    static  Sirenix.OdinInspector.Units     AcreFeet  // 0x0
  public    static  Sirenix.OdinInspector.Units     BarrelOil  // 0x0
  public    static  Sirenix.OdinInspector.Units     TeaspoonUS  // 0x0
  public    static  Sirenix.OdinInspector.Units     TablespoonUS  // 0x0
  public    static  Sirenix.OdinInspector.Units     CupUS  // 0x0
  public    static  Sirenix.OdinInspector.Units     GillUS  // 0x0
  public    static  Sirenix.OdinInspector.Units     PintUS  // 0x0
  public    static  Sirenix.OdinInspector.Units     QuartUS  // 0x0
  public    static  Sirenix.OdinInspector.Units     GallonUS  // 0x0
  public    static  Sirenix.OdinInspector.Units     BarrelUS  // 0x0
  public    static  Sirenix.OdinInspector.Units     FluidOunceUS  // 0x0
  public    static  Sirenix.OdinInspector.Units     BarrelUK  // 0x0
  public    static  Sirenix.OdinInspector.Units     FluidOunceUK  // 0x0
  public    static  Sirenix.OdinInspector.Units     TeaspoonUK  // 0x0
  public    static  Sirenix.OdinInspector.Units     TablespoonUK  // 0x0
  public    static  Sirenix.OdinInspector.Units     CupUK  // 0x0
  public    static  Sirenix.OdinInspector.Units     GillUK  // 0x0
  public    static  Sirenix.OdinInspector.Units     PintUK  // 0x0
  public    static  Sirenix.OdinInspector.Units     QuartUK  // 0x0
  public    static  Sirenix.OdinInspector.Units     GallonUK  // 0x0
  public    static  Sirenix.OdinInspector.Units     SquareMeter  // 0x0
  public    static  Sirenix.OdinInspector.Units     SquareKilometer  // 0x0
  public    static  Sirenix.OdinInspector.Units     SquareCentimeter  // 0x0
  public    static  Sirenix.OdinInspector.Units     SquareMillimeter  // 0x0
  public    static  Sirenix.OdinInspector.Units     SquareMicrometer  // 0x0
  public    static  Sirenix.OdinInspector.Units     SquareInch  // 0x0
  public    static  Sirenix.OdinInspector.Units     SquareFeet  // 0x0
  public    static  Sirenix.OdinInspector.Units     SquareYard  // 0x0
  public    static  Sirenix.OdinInspector.Units     SquareMile  // 0x0
  public    static  Sirenix.OdinInspector.Units     Hectare  // 0x0
  public    static  Sirenix.OdinInspector.Units     Acre  // 0x0
  public    static  Sirenix.OdinInspector.Units     Are  // 0x0
  public    static  Sirenix.OdinInspector.Units     Joule  // 0x0
  public    static  Sirenix.OdinInspector.Units     Kilojoule  // 0x0
  public    static  Sirenix.OdinInspector.Units     WattHour  // 0x0
  public    static  Sirenix.OdinInspector.Units     KilowattHour  // 0x0
  public    static  Sirenix.OdinInspector.Units     HorsepowerHour  // 0x0
  public    static  Sirenix.OdinInspector.Units     Newton  // 0x0
  public    static  Sirenix.OdinInspector.Units     Kilonewton  // 0x0
  public    static  Sirenix.OdinInspector.Units     Meganewton  // 0x0
  public    static  Sirenix.OdinInspector.Units     Giganewton  // 0x0
  public    static  Sirenix.OdinInspector.Units     Teranewton  // 0x0
  public    static  Sirenix.OdinInspector.Units     Centinewton  // 0x0
  public    static  Sirenix.OdinInspector.Units     Millinewton  // 0x0
  public    static  Sirenix.OdinInspector.Units     JouleMeter  // 0x0
  public    static  Sirenix.OdinInspector.Units     JouleCentimeter  // 0x0
  public    static  Sirenix.OdinInspector.Units     GramForce  // 0x0
  public    static  Sirenix.OdinInspector.Units     KilogramForce  // 0x0
  public    static  Sirenix.OdinInspector.Units     TonForce  // 0x0
  public    static  Sirenix.OdinInspector.Units     PoundForce  // 0x0
  public    static  Sirenix.OdinInspector.Units     KilopoundForce  // 0x0
  public    static  Sirenix.OdinInspector.Units     OunceForce  // 0x0
  public    static  Sirenix.OdinInspector.Units     MetersPerSecond  // 0x0
  public    static  Sirenix.OdinInspector.Units     MetersPerMinute  // 0x0
  public    static  Sirenix.OdinInspector.Units     MetersPerHour  // 0x0
  public    static  Sirenix.OdinInspector.Units     KilometersPerSecond  // 0x0
  public    static  Sirenix.OdinInspector.Units     KilometersPerMinute  // 0x0
  public    static  Sirenix.OdinInspector.Units     KilometersPerHour  // 0x0
  public    static  Sirenix.OdinInspector.Units     CentimetersPerSecond  // 0x0
  public    static  Sirenix.OdinInspector.Units     CentimetersPerMinute  // 0x0
  public    static  Sirenix.OdinInspector.Units     CentimetersPerHour  // 0x0
  public    static  Sirenix.OdinInspector.Units     MillimetersPerSecond  // 0x0
  public    static  Sirenix.OdinInspector.Units     MillimetersPerMinute  // 0x0
  public    static  Sirenix.OdinInspector.Units     MillimetersPerHour  // 0x0
  public    static  Sirenix.OdinInspector.Units     FeetPerSecond  // 0x0
  public    static  Sirenix.OdinInspector.Units     FeetPerMinute  // 0x0
  public    static  Sirenix.OdinInspector.Units     FeetPerHour  // 0x0
  public    static  Sirenix.OdinInspector.Units     YardsPerSecond  // 0x0
  public    static  Sirenix.OdinInspector.Units     YardsPerMinute  // 0x0
  public    static  Sirenix.OdinInspector.Units     YardsPerHour  // 0x0
  public    static  Sirenix.OdinInspector.Units     MilesPerSecond  // 0x0
  public    static  Sirenix.OdinInspector.Units     MilesPerMinute  // 0x0
  public    static  Sirenix.OdinInspector.Units     MilesPerHour  // 0x0
  public    static  Sirenix.OdinInspector.Units     Knot  // 0x0
  public    static  Sirenix.OdinInspector.Units     KnotUK  // 0x0
  public    static  Sirenix.OdinInspector.Units     SpeedOfLight  // 0x0
  public    static  Sirenix.OdinInspector.Units     Bit  // 0x0
  public    static  Sirenix.OdinInspector.Units     Kilobit  // 0x0
  public    static  Sirenix.OdinInspector.Units     Megabit  // 0x0
  public    static  Sirenix.OdinInspector.Units     Gigabit  // 0x0
  public    static  Sirenix.OdinInspector.Units     Terabit  // 0x0
  public    static  Sirenix.OdinInspector.Units     Petabit  // 0x0
  public    static  Sirenix.OdinInspector.Units     Byte  // 0x0
  public    static  Sirenix.OdinInspector.Units     Kilobyte  // 0x0
  public    static  Sirenix.OdinInspector.Units     Kibibyte  // 0x0
  public    static  Sirenix.OdinInspector.Units     Megabyte  // 0x0
  public    static  Sirenix.OdinInspector.Units     Mebibyte  // 0x0
  public    static  Sirenix.OdinInspector.Units     Gigabyte  // 0x0
  public    static  Sirenix.OdinInspector.Units     Gibibyte  // 0x0
  public    static  Sirenix.OdinInspector.Units     Terabyte  // 0x0
  public    static  Sirenix.OdinInspector.Units     Tebibyte  // 0x0
  public    static  Sirenix.OdinInspector.Units     Petabyte  // 0x0
  public    static  Sirenix.OdinInspector.Units     Pebibyte  // 0x0
  public    static  Sirenix.OdinInspector.Units     Kilogram  // 0x0
  public    static  Sirenix.OdinInspector.Units     Hectogram  // 0x0
  public    static  Sirenix.OdinInspector.Units     Dekagram  // 0x0
  public    static  Sirenix.OdinInspector.Units     Gram  // 0x0
  public    static  Sirenix.OdinInspector.Units     Decigram  // 0x0
  public    static  Sirenix.OdinInspector.Units     Centigram  // 0x0
  public    static  Sirenix.OdinInspector.Units     Milligram  // 0x0
  public    static  Sirenix.OdinInspector.Units     MetricTon  // 0x0
  public    static  Sirenix.OdinInspector.Units     Pounds  // 0x0
  public    static  Sirenix.OdinInspector.Units     ShortTon  // 0x0
  public    static  Sirenix.OdinInspector.Units     LongTon  // 0x0
  public    static  Sirenix.OdinInspector.Units     Ounce  // 0x0
  public    static  Sirenix.OdinInspector.Units     StoneUS  // 0x0
  public    static  Sirenix.OdinInspector.Units     StoneUK  // 0x0
  public    static  Sirenix.OdinInspector.Units     QuarterUS  // 0x0
  public    static  Sirenix.OdinInspector.Units     QuarterUK  // 0x0
  public    static  Sirenix.OdinInspector.Units     Slug  // 0x0
  public    static  Sirenix.OdinInspector.Units     Grain  // 0x0
  public    static  Sirenix.OdinInspector.Units     Celsius  // 0x0
  public    static  Sirenix.OdinInspector.Units     Fahrenheit  // 0x0
  public    static  Sirenix.OdinInspector.Units     Kelvin  // 0x0
  public    static  Sirenix.OdinInspector.Units     Pascal  // 0x0
  public    static  Sirenix.OdinInspector.Units     Decipascal  // 0x0
  public    static  Sirenix.OdinInspector.Units     Centipascal  // 0x0
  public    static  Sirenix.OdinInspector.Units     Millipascal  // 0x0
  public    static  Sirenix.OdinInspector.Units     Micropascal  // 0x0
  public    static  Sirenix.OdinInspector.Units     Kilopascal  // 0x0
  public    static  Sirenix.OdinInspector.Units     Megapascal  // 0x0
  public    static  Sirenix.OdinInspector.Units     Gigapascal  // 0x0
  public    static  Sirenix.OdinInspector.Units     Bar  // 0x0
  public    static  Sirenix.OdinInspector.Units     Millibar  // 0x0
  public    static  Sirenix.OdinInspector.Units     Microbar  // 0x0
  public    static  Sirenix.OdinInspector.Units     PSI  // 0x0
  public    static  Sirenix.OdinInspector.Units     KSI  // 0x0
  public    static  Sirenix.OdinInspector.Units     StandardAtmosphere  // 0x0
  public    static  Sirenix.OdinInspector.Units     Watt  // 0x0
  public    static  Sirenix.OdinInspector.Units     Kilowatt  // 0x0
  public    static  Sirenix.OdinInspector.Units     Megawatt  // 0x0
  public    static  Sirenix.OdinInspector.Units     Gigawatt  // 0x0
  public    static  Sirenix.OdinInspector.Units     Terawatt  // 0x0
  public    static  Sirenix.OdinInspector.Units     Horsepower  // 0x0
  public    static  Sirenix.OdinInspector.Units     JouleSecond  // 0x0
  public    static  Sirenix.OdinInspector.Units     JouleMinute  // 0x0
  public    static  Sirenix.OdinInspector.Units     JouleHour  // 0x0
  public    static  Sirenix.OdinInspector.Units     KilojouleSecond  // 0x0
  public    static  Sirenix.OdinInspector.Units     KilojouleMinute  // 0x0
  public    static  Sirenix.OdinInspector.Units     KilojouleHour  // 0x0
  public    static  Sirenix.OdinInspector.Units     Second  // 0x0
  public    static  Sirenix.OdinInspector.Units     Millisecond  // 0x0
  public    static  Sirenix.OdinInspector.Units     Microsecond  // 0x0
  public    static  Sirenix.OdinInspector.Units     Nanosecond  // 0x0
  public    static  Sirenix.OdinInspector.Units     Minute  // 0x0
  public    static  Sirenix.OdinInspector.Units     Hour  // 0x0
  public    static  Sirenix.OdinInspector.Units     Day  // 0x0
  public    static  Sirenix.OdinInspector.Units     Week  // 0x0
  public    static  Sirenix.OdinInspector.Units     Radian  // 0x0
  public    static  Sirenix.OdinInspector.Units     Degree  // 0x0
  public    static  Sirenix.OdinInspector.Units     Turn  // 0x0
  public    static  Sirenix.OdinInspector.Units     Grad  // 0x0
  public    static  Sirenix.OdinInspector.Units     SecondsOfAngle  // 0x0
  public    static  Sirenix.OdinInspector.Units     MinutesOfAngle  // 0x0
  public    static  Sirenix.OdinInspector.Units     Mil  // 0x0
  public    static  Sirenix.OdinInspector.Units     MetersPerSecondSquared  // 0x0
  public    static  Sirenix.OdinInspector.Units     DecimetersPerSecondSquared  // 0x0
  public    static  Sirenix.OdinInspector.Units     CentimetersPerSecondSquared  // 0x0
  public    static  Sirenix.OdinInspector.Units     MillimetersPerSecondSquared  // 0x0
  public    static  Sirenix.OdinInspector.Units     MicrometersPerSecondSquared  // 0x0
  public    static  Sirenix.OdinInspector.Units     DekametersPerSecondSquared  // 0x0
  public    static  Sirenix.OdinInspector.Units     HectometersPerSecondSquared  // 0x0
  public    static  Sirenix.OdinInspector.Units     KilometersPerSecondSquared  // 0x0
  public    static  Sirenix.OdinInspector.Units     MilePerSecondSquared  // 0x0
  public    static  Sirenix.OdinInspector.Units     YardPerSecondSquared  // 0x0
  public    static  Sirenix.OdinInspector.Units     FeetPerSecondSquared  // 0x0
  public    static  Sirenix.OdinInspector.Units     InchPerSecondSquared  // 0x0
  public    static  Sirenix.OdinInspector.Units     GForce  // 0x0
  public    static  Sirenix.OdinInspector.Units     NewtonMeter  // 0x0
  public    static  Sirenix.OdinInspector.Units     NewtonCentimeter  // 0x0
  public    static  Sirenix.OdinInspector.Units     NewtonMillimeter  // 0x0
  public    static  Sirenix.OdinInspector.Units     KilonewtonMeter  // 0x0
  public    static  Sirenix.OdinInspector.Units     KilogramForceMeter  // 0x0
  public    static  Sirenix.OdinInspector.Units     KilogramForceCentimeter  // 0x0
  public    static  Sirenix.OdinInspector.Units     KilogramForceMillimeter  // 0x0
  public    static  Sirenix.OdinInspector.Units     GramForceMeter  // 0x0
  public    static  Sirenix.OdinInspector.Units     GramForceCentimeter  // 0x0
  public    static  Sirenix.OdinInspector.Units     GramForceMillimeter  // 0x0
  public    static  Sirenix.OdinInspector.Units     PoundFeet  // 0x0
  public    static  Sirenix.OdinInspector.Units     PoundInch  // 0x0
  public    static  Sirenix.OdinInspector.Units     OuncecFeet  // 0x0
  public    static  Sirenix.OdinInspector.Units     OuncecInch  // 0x0
  public    static  Sirenix.OdinInspector.Units     RadiansPerSecond  // 0x0
  public    static  Sirenix.OdinInspector.Units     RadiansPerMinute  // 0x0
  public    static  Sirenix.OdinInspector.Units     RadiansPerHour  // 0x0
  public    static  Sirenix.OdinInspector.Units     RadiansPerDay  // 0x0
  public    static  Sirenix.OdinInspector.Units     DegreesPerSecond  // 0x0
  public    static  Sirenix.OdinInspector.Units     DegreesPerMinute  // 0x0
  public    static  Sirenix.OdinInspector.Units     DegreesPerHour  // 0x0
  public    static  Sirenix.OdinInspector.Units     DegreesPerDay  // 0x0
  public    static  Sirenix.OdinInspector.Units     RevolutionsPerSecond  // 0x0
  public    static  Sirenix.OdinInspector.Units     RevolutionsPerMinute  // 0x0
  public    static  Sirenix.OdinInspector.Units     RevolutionsPerHour  // 0x0
  public    static  Sirenix.OdinInspector.Units     RevolutionsPerDay  // 0x0
  public    static  Sirenix.OdinInspector.Units     Hertz  // 0x0
  public    static  Sirenix.OdinInspector.Units     Kilohertz  // 0x0
  public    static  Sirenix.OdinInspector.Units     Megahertz  // 0x0
  public    static  Sirenix.OdinInspector.Units     Gigahertz  // 0x0
  public    static  Sirenix.OdinInspector.Units     PercentMultiplier  // 0x0
  public    static  Sirenix.OdinInspector.Units     Percent  // 0x0
  public    static  Sirenix.OdinInspector.Units     Permille  // 0x0
  public    static  Sirenix.OdinInspector.Units     Permyriad  // 0x0
METHODS:
END_CLASS

CLASS: Sirenix.OdinInspector.ValueDropdownList`1
TYPE:  class
TOKEN: 0x2000007
EXTENDS: List`1
FIELDS:
METHODS:
  System.Void Add(System.String text, T value)
  System.Void Add(T value)
  System.Void .ctor()
END_CLASS

CLASS: Sirenix.OdinInspector.ValueDropdownItem`1
TYPE:  struct
TOKEN: 0x2000008
FIELDS:
  public            System.String                   Text  // 0x0
  public            T                               Value  // 0x0
METHODS:
  System.Void .ctor(System.String text, T value)
  System.String ToString()
END_CLASS

CLASS: Sirenix.OdinInspector.IconAlignment
TYPE:  struct
TOKEN: 0x2000009
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Sirenix.OdinInspector.IconAlignmentLeftOfText  // 0x0
  public    static  Sirenix.OdinInspector.IconAlignmentRightOfText  // 0x0
  public    static  Sirenix.OdinInspector.IconAlignmentLeftEdge  // 0x0
  public    static  Sirenix.OdinInspector.IconAlignmentRightEdge  // 0x0
METHODS:
END_CLASS

CLASS: Sirenix.OdinInspector.IncludeMyAttributesAttribute
TYPE:  class
TOKEN: 0x200000A
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Sirenix.OdinInspector.ISearchFilterable
TYPE:  interface
TOKEN: 0x200000B
FIELDS:
METHODS:
END_CLASS

CLASS: Sirenix.OdinInspector.SdfIconType
TYPE:  struct
TOKEN: 0x200000C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Sirenix.OdinInspector.SdfIconTypeNone  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeAlarmFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeAlarm  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeAlignBottom  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeAlignCenter  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeAlignEnd  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeAlignMiddle  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeAlignStart  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeAlignTop  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeAlt  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeAppIndicator  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeApp  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArchiveFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArchive  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrow90degDown  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrow90degLeft  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrow90degRight  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrow90degUp  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowBarDown  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowBarLeft  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowBarRight  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowBarUp  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowClockwise  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowCounterclockwise  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowDownCircleFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowDownCircle  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowDownLeftCircleFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowDownLeftCircle  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowDownLeftSquareFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowDownLeftSquare  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowDownLeft  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowDownRightCircleFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowDownRightCircle  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowDownRightSquareFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowDownRightSquare  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowDownRight  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowDownShort  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowDownSquareFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowDownSquare  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowDownUp  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowDown  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowLeftCircleFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowLeftCircle  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowLeftRight  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowLeftShort  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowLeftSquareFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowLeftSquare  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowLeft  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowRepeat  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowReturnLeft  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowReturnRight  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowRightCircleFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowRightCircle  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowRightShort  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowRightSquareFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowRightSquare  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowRight  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowUpCircleFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowUpCircle  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowUpLeftCircleFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowUpLeftCircle  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowUpLeftSquareFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowUpLeftSquare  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowUpLeft  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowUpRightCircleFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowUpRightCircle  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowUpRightSquareFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowUpRightSquare  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowUpRight  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowUpShort  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowUpSquareFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowUpSquare  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowUp  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowsAngleContract  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowsAngleExpand  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowsCollapse  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowsExpand  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowsFullscreen  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeArrowsMove  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeAspectRatioFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeAspectRatio  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeAsterisk  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeAt  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeAwardFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeAward  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBack  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBackspaceFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBackspaceReverseFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBackspaceReverse  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBackspace  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBadge3dFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBadge3d  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBadge4kFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBadge4k  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBadge8kFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBadge8k  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBadgeAdFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBadgeAd  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBadgeArFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBadgeAr  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBadgeCcFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBadgeCc  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBadgeHdFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBadgeHd  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBadgeTmFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBadgeTm  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBadgeVoFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBadgeVo  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBadgeVrFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBadgeVr  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBadgeWcFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBadgeWc  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBagCheckFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBagCheck  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBagDashFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBagDash  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBagFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBagPlusFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBagPlus  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBagXFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBagX  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBag  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBarChartFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBarChartLineFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBarChartLine  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBarChartSteps  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBarChart  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBasketFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBasket  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBasket2Fill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBasket2  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBasket3Fill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBasket3  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBatteryCharging  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBatteryFull  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBatteryHalf  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBattery  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBellFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBell  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBezier  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBezier2  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBicycle  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBinocularsFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBinoculars  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBlockquoteLeft  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBlockquoteRight  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBookFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBookHalf  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBook  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBookmarkCheckFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBookmarkCheck  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBookmarkDashFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBookmarkDash  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBookmarkFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBookmarkHeartFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBookmarkHeart  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBookmarkPlusFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBookmarkPlus  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBookmarkStarFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBookmarkStar  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBookmarkXFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBookmarkX  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBookmark  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBookmarksFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBookmarks  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBookshelf  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBootstrapFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBootstrapReboot  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBootstrap  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBorderAll  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBorderBottom  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBorderCenter  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBorderInner  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBorderLeft  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBorderMiddle  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBorderOuter  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBorderRight  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBorderStyle  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBorderTop  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBorderWidth  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBorder  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBoundingBoxCircles  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBoundingBox  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBoxArrowDownLeft  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBoxArrowDownRight  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBoxArrowDown  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBoxArrowInDownLeft  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBoxArrowInDownRight  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBoxArrowInDown  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBoxArrowInLeft  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBoxArrowInRight  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBoxArrowInUpLeft  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBoxArrowInUpRight  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBoxArrowInUp  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBoxArrowLeft  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBoxArrowRight  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBoxArrowUpLeft  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBoxArrowUpRight  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBoxArrowUp  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBoxSeam  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBox  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBraces  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBricks  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBriefcaseFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBriefcase  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBrightnessAltHighFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBrightnessAltHigh  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBrightnessAltLowFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBrightnessAltLow  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBrightnessHighFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBrightnessHigh  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBrightnessLowFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBrightnessLow  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBroadcastPin  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBroadcast  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBrushFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBrush  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBucketFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBucket  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBugFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBug  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBuilding  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBullseye  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalculatorFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalculator  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendarCheckFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendarCheck  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendarDateFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendarDate  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendarDayFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendarDay  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendarEventFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendarEvent  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendarFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendarMinusFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendarMinus  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendarMonthFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendarMonth  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendarPlusFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendarPlus  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendarRangeFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendarRange  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendarWeekFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendarWeek  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendarXFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendarX  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendar  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendar2CheckFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendar2Check  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendar2DateFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendar2Date  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendar2DayFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendar2Day  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendar2EventFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendar2Event  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendar2Fill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendar2MinusFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendar2Minus  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendar2MonthFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendar2Month  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendar2PlusFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendar2Plus  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendar2RangeFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendar2Range  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendar2WeekFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendar2Week  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendar2XFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendar2X  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendar2  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendar3EventFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendar3Event  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendar3Fill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendar3RangeFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendar3Range  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendar3WeekFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendar3Week  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendar3  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendar4Event  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendar4Range  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendar4Week  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCalendar4  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCameraFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCameraReelsFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCameraReels  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCameraVideoFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCameraVideoOffFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCameraVideoOff  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCameraVideo  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCamera  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCamera2  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCapslockFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCapslock  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCardChecklist  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCardHeading  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCardImage  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCardList  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCardText  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCaretDownFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCaretDownSquareFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCaretDownSquare  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCaretDown  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCaretLeftFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCaretLeftSquareFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCaretLeftSquare  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCaretLeft  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCaretRightFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCaretRightSquareFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCaretRightSquare  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCaretRight  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCaretUpFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCaretUpSquareFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCaretUpSquare  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCaretUp  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCartCheckFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCartCheck  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCartDashFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCartDash  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCartFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCartPlusFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCartPlus  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCartXFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCartX  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCart  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCart2  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCart3  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCart4  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCashStack  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCash  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCast  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChatDotsFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChatDots  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChatFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChatLeftDotsFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChatLeftDots  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChatLeftFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChatLeftQuoteFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChatLeftQuote  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChatLeftTextFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChatLeftText  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChatLeft  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChatQuoteFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChatQuote  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChatRightDotsFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChatRightDots  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChatRightFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChatRightQuoteFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChatRightQuote  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChatRightTextFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChatRightText  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChatRight  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChatSquareDotsFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChatSquareDots  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChatSquareFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChatSquareQuoteFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChatSquareQuote  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChatSquareTextFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChatSquareText  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChatSquare  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChatTextFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChatText  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChat  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCheckAll  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCheckCircleFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCheckCircle  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCheckSquareFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCheckSquare  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCheck  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCheck2All  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCheck2Circle  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCheck2Square  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCheck2  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChevronBarContract  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChevronBarDown  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChevronBarExpand  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChevronBarLeft  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChevronBarRight  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChevronBarUp  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChevronCompactDown  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChevronCompactLeft  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChevronCompactRight  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChevronCompactUp  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChevronContract  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChevronDoubleDown  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChevronDoubleLeft  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChevronDoubleRight  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChevronDoubleUp  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChevronDown  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChevronExpand  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChevronLeft  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChevronRight  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeChevronUp  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCircleFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCircleHalf  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCircleSquare  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCircle  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeClipboardCheck  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeClipboardData  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeClipboardMinus  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeClipboardPlus  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeClipboardX  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeClipboard  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeClockFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeClockHistory  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeClock  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudArrowDownFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudArrowDown  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudArrowUpFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudArrowUp  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudCheckFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudCheck  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudDownloadFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudDownload  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudDrizzleFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudDrizzle  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudFogFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudFog  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudFog2Fill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudFog2  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudHailFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudHail  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudHaze1  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudHazeFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudHaze  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudHaze2Fill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudLightningFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudLightningRainFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudLightningRain  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudLightning  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudMinusFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudMinus  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudMoonFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudMoon  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudPlusFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudPlus  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudRainFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudRainHeavyFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudRainHeavy  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudRain  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudSlashFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudSlash  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudSleetFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudSleet  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudSnowFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudSnow  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudSunFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudSun  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudUploadFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudUpload  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloud  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudsFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeClouds  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudyFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudy  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCodeSlash  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCodeSquare  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCode  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCollectionFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCollectionPlayFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCollectionPlay  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCollection  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeColumnsGap  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeColumns  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCommand  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCompassFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCompass  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeConeStriped  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCone  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeController  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCpuFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCpu  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCreditCard2BackFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCreditCard2Back  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCreditCard2FrontFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCreditCard2Front  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCreditCardFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCreditCard  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCrop  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCupFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCupStraw  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCup  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCursorFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCursorText  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCursor  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDashCircleDotted  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDashCircleFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDashCircle  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDashSquareDotted  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDashSquareFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDashSquare  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDash  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDiagram2Fill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDiagram2  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDiagram3Fill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDiagram3  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDiamondFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDiamondHalf  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDiamond  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDice1Fill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDice1  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDice2Fill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDice2  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDice3Fill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDice3  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDice4Fill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDice4  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDice5Fill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDice5  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDice6Fill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDice6  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDiscFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDisc  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDiscord  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDisplayFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDisplay  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDistributeHorizontal  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDistributeVertical  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDoorClosedFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDoorClosed  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDoorOpenFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDoorOpen  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDot  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDownload  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDropletFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDropletHalf  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDroplet  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEarbuds  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEaselFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEasel  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEggFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEggFried  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEgg  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEjectFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEject  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEmojiAngryFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEmojiAngry  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEmojiDizzyFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEmojiDizzy  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEmojiExpressionlessFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEmojiExpressionless  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEmojiFrownFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEmojiFrown  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEmojiHeartEyesFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEmojiHeartEyes  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEmojiLaughingFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEmojiLaughing  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEmojiNeutralFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEmojiNeutral  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEmojiSmileFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEmojiSmileUpsideDownFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEmojiSmileUpsideDown  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEmojiSmile  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEmojiSunglassesFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEmojiSunglasses  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEmojiWinkFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEmojiWink  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEnvelopeFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEnvelopeOpenFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEnvelopeOpen  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEnvelope  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEraserFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEraser  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeExclamationCircleFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeExclamationCircle  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeExclamationDiamondFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeExclamationDiamond  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeExclamationOctagonFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeExclamationOctagon  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeExclamationSquareFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeExclamationSquare  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeExclamationTriangleFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeExclamationTriangle  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeExclamation  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeExclude  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEyeFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEyeSlashFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEyeSlash  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEye  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEyedropper  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEyeglasses  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFacebook  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileArrowDownFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileArrowDown  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileArrowUpFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileArrowUp  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileBarGraphFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileBarGraph  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileBinaryFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileBinary  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileBreakFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileBreak  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileCheckFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileCheck  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileCodeFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileCode  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileDiffFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileDiff  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkArrowDownFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkArrowDown  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkArrowUpFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkArrowUp  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkBarGraphFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkBarGraph  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkBinaryFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkBinary  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkBreakFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkBreak  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkCheckFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkCheck  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkCodeFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkCode  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkDiffFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkDiff  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkEaselFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkEasel  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkExcelFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkExcel  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkFontFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkFont  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkImageFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkImage  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkLockFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkLock  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkLock2Fill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkLock2  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkMedicalFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkMedical  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkMinusFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkMinus  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkMusicFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkMusic  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkPersonFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkPerson  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkPlayFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkPlay  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkPlusFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkPlus  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkPostFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkPost  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkPptFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkPpt  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkRichtextFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkRichtext  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkRuledFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkRuled  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkSlidesFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkSlides  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkSpreadsheetFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkSpreadsheet  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkTextFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkText  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkWordFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkWord  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkXFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkX  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkZipFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkZip  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmark  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEaselFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEasel  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileExcelFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileExcel  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileFontFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileFont  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileImageFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileImage  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileLockFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileLock  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileLock2Fill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileLock2  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileMedicalFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileMedical  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileMinusFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileMinus  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileMusicFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileMusic  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFilePersonFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFilePerson  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFilePlayFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFilePlay  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFilePlusFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFilePlus  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFilePostFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFilePost  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFilePptFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFilePpt  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileRichtextFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileRichtext  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileRuledFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileRuled  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileSlidesFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileSlides  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileSpreadsheetFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileSpreadsheet  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileTextFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileText  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileWordFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileWord  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileXFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileX  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileZipFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileZip  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFile  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFilesAlt  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFiles  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFilm  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFilterCircleFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFilterCircle  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFilterLeft  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFilterRight  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFilterSquareFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFilterSquare  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFilter  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFlagFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFlag  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFlower1  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFlower2  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFlower3  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFolderCheck  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFolderFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFolderMinus  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFolderPlus  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFolderSymlinkFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFolderSymlink  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFolderX  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFolder  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFolder2Open  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFolder2  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFonts  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeForwardFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeForward  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFront  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFullscreenExit  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFullscreen  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFunnelFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFunnel  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeGearFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeGearWideConnected  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeGearWide  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeGear  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeGem  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeGeoAltFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeGeoAlt  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeGeoFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeGeo  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeGiftFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeGift  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeGithub  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeGlobe  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeGlobe2  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeGoogle  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeGraphDown  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeGraphUp  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeGrid1x2Fill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeGrid1x2  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeGrid3x2GapFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeGrid3x2Gap  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeGrid3x2  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeGrid3x3GapFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeGrid3x3Gap  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeGrid3x3  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeGridFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeGrid  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeGripHorizontal  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeGripVertical  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeHammer  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeHandIndexFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeHandIndexThumbFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeHandIndexThumb  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeHandIndex  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeHandThumbsDownFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeHandThumbsDown  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeHandThumbsUpFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeHandThumbsUp  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeHandbagFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeHandbag  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeHash  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeHddFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeHddNetworkFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeHddNetwork  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeHddRackFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeHddRack  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeHddStackFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeHddStack  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeHdd  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeHeadphones  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeHeadset  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeHeartFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeHeartHalf  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeHeart  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeHeptagonFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeHeptagonHalf  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeHeptagon  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeHexagonFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeHexagonHalf  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeHexagon  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeHourglassBottom  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeHourglassSplit  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeHourglassTop  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeHourglass  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeHouseDoorFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeHouseDoor  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeHouseFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeHouse  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeHr  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeHurricane  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeImageAlt  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeImageFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeImage  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeImages  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeInboxFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeInbox  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeInboxesFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeInboxes  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeInfoCircleFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeInfoCircle  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeInfoSquareFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeInfoSquare  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeInfo  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeInputCursorText  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeInputCursor  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeInstagram  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeIntersect  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeJournalAlbum  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeJournalArrowDown  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeJournalArrowUp  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeJournalBookmarkFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeJournalBookmark  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeJournalCheck  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeJournalCode  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeJournalMedical  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeJournalMinus  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeJournalPlus  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeJournalRichtext  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeJournalText  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeJournalX  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeJournal  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeJournals  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeJoystick  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeJustifyLeft  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeJustifyRight  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeJustify  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeKanbanFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeKanban  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeKeyFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeKey  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeKeyboardFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeKeyboard  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeLadder  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeLampFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeLamp  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeLaptopFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeLaptop  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeLayerBackward  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeLayerForward  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeLayersFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeLayersHalf  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeLayers  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeLayoutSidebarInsetReverse  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeLayoutSidebarInset  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeLayoutSidebarReverse  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeLayoutSidebar  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeLayoutSplit  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeLayoutTextSidebarReverse  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeLayoutTextSidebar  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeLayoutTextWindowReverse  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeLayoutTextWindow  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeLayoutThreeColumns  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeLayoutWtf  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeLifePreserver  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeLightbulbFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeLightbulbOffFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeLightbulbOff  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeLightbulb  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeLightningChargeFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeLightningCharge  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeLightningFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeLightning  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeLink45deg  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeLink  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeLinkedin  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeListCheck  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeListNested  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeListOl  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeListStars  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeListTask  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeListUl  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeList  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeLockFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeLock  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMailbox  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMailbox2  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMapFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMap  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMarkdownFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMarkdown  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMask  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMegaphoneFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMegaphone  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMenuAppFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMenuApp  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMenuButtonFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMenuButtonWideFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMenuButtonWide  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMenuButton  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMenuDown  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMenuUp  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMicFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMicMuteFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMicMute  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMic  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMinecartLoaded  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMinecart  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMoisture  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMoonFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMoonStarsFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMoonStars  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMoon  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMouseFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMouse  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMouse2Fill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMouse2  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMouse3Fill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMouse3  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMusicNoteBeamed  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMusicNoteList  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMusicNote  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMusicPlayerFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMusicPlayer  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeNewspaper  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeNodeMinusFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeNodeMinus  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeNodePlusFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeNodePlus  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeNutFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeNut  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeOctagonFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeOctagonHalf  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeOctagon  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeOption  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeOutlet  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePaintBucket  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePaletteFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePalette  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePalette2  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePaperclip  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeParagraph  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePatchCheckFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePatchCheck  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePatchExclamationFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePatchExclamation  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePatchMinusFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePatchMinus  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePatchPlusFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePatchPlus  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePatchQuestionFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePatchQuestion  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePauseBtnFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePauseBtn  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePauseCircleFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePauseCircle  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePauseFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePause  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePeaceFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePeace  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePenFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePen  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePencilFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePencilSquare  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePencil  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePentagonFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePentagonHalf  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePentagon  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePeopleFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePeople  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePercent  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePersonBadgeFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePersonBadge  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePersonBoundingBox  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePersonCheckFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePersonCheck  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePersonCircle  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePersonDashFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePersonDash  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePersonFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePersonLinesFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePersonPlusFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePersonPlus  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePersonSquare  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePersonXFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePersonX  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePerson  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePhoneFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePhoneLandscapeFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePhoneLandscape  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePhoneVibrateFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePhoneVibrate  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePhone  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePieChartFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePieChart  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePinAngleFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePinAngle  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePinFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePin  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePipFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePip  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePlayBtnFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePlayBtn  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePlayCircleFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePlayCircle  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePlayFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePlay  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePlugFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePlug  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePlusCircleDotted  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePlusCircleFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePlusCircle  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePlusSquareDotted  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePlusSquareFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePlusSquare  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePlus  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePower  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePrinterFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePrinter  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePuzzleFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePuzzle  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeQuestionCircleFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeQuestionCircle  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeQuestionDiamondFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeQuestionDiamond  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeQuestionOctagonFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeQuestionOctagon  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeQuestionSquareFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeQuestionSquare  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeQuestion  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeRainbow  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeReceiptCutoff  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeReceipt  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeReception0  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeReception1  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeReception2  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeReception3  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeReception4  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeRecordBtnFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeRecordBtn  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeRecordCircleFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeRecordCircle  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeRecordFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeRecord  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeRecord2Fill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeRecord2  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeReplyAllFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeReplyAll  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeReplyFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeReply  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeRssFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeRss  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeRulers  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSaveFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSave  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSave2Fill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSave2  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeScissors  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeScrewdriver  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSearch  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSegmentedNav  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeServer  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeShareFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeShare  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeShieldCheck  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeShieldExclamation  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeShieldFillCheck  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeShieldFillExclamation  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeShieldFillMinus  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeShieldFillPlus  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeShieldFillX  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeShieldFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeShieldLockFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeShieldLock  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeShieldMinus  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeShieldPlus  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeShieldShaded  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeShieldSlashFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeShieldSlash  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeShieldX  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeShield  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeShiftFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeShift  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeShopWindow  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeShop  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeShuffle  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSignpost2Fill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSignpost2  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSignpostFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSignpostSplitFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSignpostSplit  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSignpost  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSimFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSim  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSkipBackwardBtnFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSkipBackwardBtn  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSkipBackwardCircleFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSkipBackwardCircle  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSkipBackwardFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSkipBackward  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSkipEndBtnFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSkipEndBtn  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSkipEndCircleFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSkipEndCircle  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSkipEndFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSkipEnd  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSkipForwardBtnFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSkipForwardBtn  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSkipForwardCircleFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSkipForwardCircle  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSkipForwardFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSkipForward  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSkipStartBtnFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSkipStartBtn  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSkipStartCircleFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSkipStartCircle  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSkipStartFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSkipStart  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSlack  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSlashCircleFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSlashCircle  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSlashSquareFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSlashSquare  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSlash  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSliders  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSmartwatch  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSnow  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSnow2  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSnow3  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSortAlphaDownAlt  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSortAlphaDown  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSortAlphaUpAlt  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSortAlphaUp  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSortDownAlt  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSortDown  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSortNumericDownAlt  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSortNumericDown  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSortNumericUpAlt  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSortNumericUp  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSortUpAlt  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSortUp  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSoundwave  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSpeakerFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSpeaker  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSpeedometer  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSpeedometer2  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSpellcheck  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSquareFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSquareHalf  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSquare  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeStack  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeStarFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeStarHalf  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeStar  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeStars  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeStickiesFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeStickies  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeStickyFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSticky  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeStopBtnFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeStopBtn  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeStopCircleFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeStopCircle  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeStopFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeStop  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeStoplightsFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeStoplights  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeStopwatchFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeStopwatch  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSubtract  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSuitClubFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSuitClub  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSuitDiamondFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSuitDiamond  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSuitHeartFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSuitHeart  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSuitSpadeFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSuitSpade  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSunFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSun  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSunglasses  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSunriseFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSunrise  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSunsetFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSunset  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSymmetryHorizontal  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSymmetryVertical  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTable  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTabletFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTabletLandscapeFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTabletLandscape  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTablet  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTagFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTag  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTagsFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTags  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTelegram  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTelephoneFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTelephoneForwardFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTelephoneForward  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTelephoneInboundFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTelephoneInbound  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTelephoneMinusFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTelephoneMinus  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTelephoneOutboundFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTelephoneOutbound  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTelephonePlusFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTelephonePlus  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTelephoneXFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTelephoneX  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTelephone  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTerminalFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTerminal  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTextCenter  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTextIndentLeft  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTextIndentRight  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTextLeft  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTextParagraph  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTextRight  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTextareaResize  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTextareaT  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTextarea  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeThermometerHalf  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeThermometerHigh  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeThermometerLow  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeThermometerSnow  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeThermometerSun  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeThermometer  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeThreeDotsVertical  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeThreeDots  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeToggleOff  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeToggleOn  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeToggle2Off  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeToggle2On  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeToggles  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeToggles2  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTools  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTornado  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTrashFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTrash  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTrash2Fill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTrash2  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTreeFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTree  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTriangleFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTriangleHalf  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTriangle  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTrophyFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTrophy  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTropicalStorm  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTruckFlatbed  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTruck  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTsunami  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTvFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTv  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTwitch  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTwitter  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTypeBold  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTypeH1  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTypeH2  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTypeH3  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTypeItalic  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTypeStrikethrough  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTypeUnderline  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeType  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeUiChecksGrid  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeUiChecks  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeUiRadiosGrid  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeUiRadios  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeUmbrellaFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeUmbrella  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeUnion  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeUnlockFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeUnlock  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeUpcScan  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeUpc  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeUpload  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeVectorPen  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeViewList  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeViewStacked  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeVinylFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeVinyl  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeVoicemail  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeVolumeDownFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeVolumeDown  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeVolumeMuteFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeVolumeMute  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeVolumeOffFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeVolumeOff  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeVolumeUpFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeVolumeUp  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeVr  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeWalletFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeWallet  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeWallet2  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeWatch  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeWater  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeWhatsapp  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeWifi1  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeWifi2  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeWifiOff  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeWifi  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeWind  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeWindowDock  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeWindowSidebar  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeWindow  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeWrench  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeXCircleFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeXCircle  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeXDiamondFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeXDiamond  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeXOctagonFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeXOctagon  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeXSquareFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeXSquare  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeX  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeYoutube  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeZoomIn  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeZoomOut  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBank  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBank2  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBellSlashFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBellSlash  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCashCoin  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCheckLg  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCoin  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCurrencyBitcoin  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCurrencyDollar  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCurrencyEuro  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCurrencyExchange  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCurrencyPound  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCurrencyYen  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDashLg  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeExclamationLg  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkPdfFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFileEarmarkPdf  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFilePdfFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFilePdf  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeGenderAmbiguous  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeGenderFemale  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeGenderMale  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeGenderTrans  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeHeadsetVr  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeInfoLg  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMastodon  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMessenger  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePiggyBankFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePiggyBank  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePinMapFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePinMap  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePlusLg  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeQuestionLg  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeRecycle  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeReddit  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSafeFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSafe2Fill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSafe2  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSdCardFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSdCard  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSkype  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSlashLg  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTranslate  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeXLg  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSafe  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeApple  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMicrosoft  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeWindows  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBehance  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDribbble  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeLine  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMedium  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePaypal  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePinterest  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSignal  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSnapchat  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSpotify  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeStackOverflow  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeStrava  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeWordpress  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeVimeo  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeActivity  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEasel2Fill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEasel2  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEasel3Fill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEasel3  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFan  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeFingerprint  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeGraphDownArrow  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeGraphUpArrow  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeHypnotize  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMagic  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePersonRolodex  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePersonVideo  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePersonVideo2  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePersonVideo3  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePersonWorkspace  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeRadioactive  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeWebcamFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeWebcam  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeYinYang  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBandaidFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBandaid  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBluetooth  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBodyText  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBoombox  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBoxes  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDpadFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDpad  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEarFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEar  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEnvelopeCheck1  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEnvelopeCheckFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEnvelopeCheck  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEnvelopeDash1  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEnvelopeDashFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEnvelopeDash  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEnvelopeExclamation1  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEnvelopeExclamationFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEnvelopeExclamation  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEnvelopePlusFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEnvelopePlus  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEnvelopeSlash1  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEnvelopeSlashFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEnvelopeSlash  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEnvelopeX1  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEnvelopeXFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEnvelopeX  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeExplicitFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeExplicit  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeGit  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeInfinity  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeListColumnsReverse  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeListColumns  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMeta  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMortorboardFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMortorboard  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeNintendoSwitch  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePcDisplayHorizontal  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePcDisplay  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePcHorizontal  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePc  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePlaystation  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePlusSlashMinus  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeProjectorFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeProjector  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeQrCodeScan  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeQrCode  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeQuora  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeQuote  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeRobot  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSendCheckFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSendCheck  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSendDashFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSendDash  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSendExclamation1  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSendExclamationFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSendExclamation  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSendFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSendPlusFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSendPlus  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSendSlashFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSendSlash  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSendXFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSendX  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSend  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSteam  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTerminalDash1  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTerminalDash  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTerminalPlus  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTerminalSplit  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTicketDetailedFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTicketDetailed  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTicketFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTicketPerforatedFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTicketPerforated  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTicket  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTiktok  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeWindowDash  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeWindowDesktop  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeWindowFullscreen  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeWindowPlus  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeWindowSplit  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeWindowStack  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeWindowX  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeXbox  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeEthernet  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeHdmiFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeHdmi  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeUsbCFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeUsbC  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeUsbFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeUsbPlugFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeUsbPlug  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeUsbSymbol  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeUsb  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeBoomboxFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDisplayport1  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDisplayport  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeGpuCard  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMemory  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeModemFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeModem  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMotherboardFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMotherboard  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeOpticalAudioFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeOpticalAudio  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypePciCard  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeRouterFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeRouter  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSsdFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeSsd  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeThunderboltFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeThunderbolt  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeUsbDriveFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeUsbDrive  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeUsbMicroFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeUsbMicro  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeUsbMiniFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeUsbMini  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeCloudHaze2  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDeviceHddFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDeviceHdd  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDeviceSsdFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDeviceSsd  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeDisplayportFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMortarboardFill  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeMortarboard  // 0x0
  public    static  Sirenix.OdinInspector.SdfIconTypeTerminalX  // 0x0
METHODS:
END_CLASS

