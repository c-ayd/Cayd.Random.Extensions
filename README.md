## About
This package extends the `System.Random` class for more random generators, such as generating random values for all numeric types with or without a range (`sbyte`, `byte`, `short`, `ushort`, `int`, `uint`, `long`, `ulong`, `float`, `double`, `decimal`) and generating a boolean value with or without a probability.

## How to Use
After installing the package and adding `Cayd.Random.Extensions` namespace to your code, you can start using the extensions method of the package.

A few example of how to use the library:
```csharp
using Cayd.Random.Extensions

Random rnd = new Random();

bool rndBool = rnd.NextBool(0.7);
decimal rndDecimal rnd.NextDecimal(100m, 1000000000m);
uint rndUint = rnd.NextUInt(100u, uint.MaxValue);
ulong rndUlong = rnd.NextULong(5000000uL);

// or for .Net 6 or higher, the static 'Shared' property can be used

bool rndBool = Random.Shared.NextBool(0.7);
decimal rndDecimal Random.Shared.NextDecimal(100m, 1000000000m);
uint rndUint = Random.Shared.NextUInt(100u, uint.MaxValue);
ulong rndUlong = Random.Shared.NextULong(5000000uL);
```

## Extensions
- Parameterless methods returns a random value between the type's min and max values.
- Methods with one parameter return a random value between 0 and the type's max value.
- Methods with two parameters return a random value within a specified range.

Type      | (No Parameter)     | Only Max              | Min and Max
----------|--------------------|-----------------------|-------------------------------
`sbyte`   | NextSByte()        | NextSByte(maxValue)   | NextSByte(minValue, maxValue)
`byte`    | NextByte()         | NextByte(maxValue)    | NextByte(minValue, maxValue)
`short`   | NextShort()        | NextShort(maxValue)   | NextShort(minValue, maxValue)
`ushort`  | NextUShort()       | NextUShort(maxValue)  | NextUShort(minValue, maxValue)
`int`     | NextInt()          | NextInt(maxValue)     | NextInt(minValue, maxValue)
`uint`    | NextUInt()         | NextUInt(maxValue)    | NextUInt(minValue, maxValue)
`long`    | NextLong()         | NextLong(maxValue)    | NextLong(minValue, maxValue)
`ulong`   | NextULong()        | NextULong(maxValue)   | NextULong(minValue, maxValue)
`float`   | NextFloat()        | NextFloat(maxValue)   | NextFloat(minValue, maxValue)
`double`  | NextDoubleLimits() | NextDouble(maxValue)  | NextDouble(minValue, maxValue)
`decimal` | NextDecimal()      | NextDecimal(maxValue) | NextDecimal(minValue, maxValue)

For boolean:
- The parameterless method returns a random boolean value with a 50% change of being `true`.
- The method with one parameter returns a random boolean value with a specified change of being `true`.

Type   | (No Parameter) | Probability
-------|----------------|----------------------
`bool` | NextBool()     | NextBool(probability)