# Want to see what's changed?

[Changelog](https://github.com/steffenskov/StrongTypedId/blob/main/CHANGELOG.md)

# TruthyFalsey

Slim .Net package giving you Truthy and Falsey evaluation in C# similar to JavaScript.

This project is inspired by [Nick Chapsas' video on the topic on Youtube](https://www.youtube.com/watch?v=g-nfvnxLAVo).

# Installation

I recommend using the NuGet package: [TruthyFalsey](https://www.nuget.org/packages/TruthyFalsey) however feel free to
clone the source instead if that suits your needs better.

# Usage

Simply install the package in your project and you're good to go.

You'll now be able to evaluate truthy and falsey values in C# like this:

```csharp
User? user = await GetUserAsync();
int userAge = user?.Age ?? 0;

if (user)
{
    // User exists
}

if (!user)
{
    // User is null
}

if (userAge)
{
    // User age is different than 0
}

if (!userAge)
{
    // User age is exactly 0
}

```

The logic behind the above is essentially: "is the value different to what would be the default for the type".

So for any reference types (`class`, `record`) it becomes a null check.

For value types (`struct`, `enum`, `int`, etc.) it becomes a comparison to the default value.

The intention here is to mimic how javascript does it.

All of the above is archived by overriding these 3 operators via extension methods:

```csharp
public static bool operator true
public static bool operator false
public static bool operator !
```

# Documentation

Auto generated documentation via [DocFx](https://github.com/dotnet/docfx) is available
here: https://steffenskov.github.io/TruthyFalsey/