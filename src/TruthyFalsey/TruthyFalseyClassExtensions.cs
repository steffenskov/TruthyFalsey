// ReSharper disable UnusedType.Global
// ReSharper disable CheckNamespace

/// <summary>
///     Contains true and false operator for class types (essentially anything that inherits object)
/// </summary>
[SuppressMessage("Design", "CA1050:Declare types in namespaces", Justification = "Extension is intended for anything w/o using statements being required.")]
public static class TruthyFalseyClassExtensions
{
	extension(object)
	{
		public static bool operator true(object? item)
		{
			return item is not null;
		}

		public static bool operator false(object? item)
		{
			return item is null;
		}

		public static bool operator !(object? item)
		{
			return item is null;
		}
	}
}