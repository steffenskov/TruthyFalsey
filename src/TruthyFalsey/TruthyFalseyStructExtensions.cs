// ReSharper disable UnusedType.Global
// ReSharper disable CheckNamespace

/// <summary>
///     Contains true and false operator for struct types
/// </summary>
[SuppressMessage("Design", "CA1050:Declare types in namespaces", Justification = "Extension is intended for anything w/o using statements being required.")]
public static class TruthyFalseyStructExtensions
{
	extension<T>(T)
		where T : struct
	{
		public static bool operator true(T item)
		{
			return !item.Equals(default(T));
		}

		public static bool operator false(T item)
		{
			return item.Equals(default(T));
		}

		public static bool operator !(T item)
		{
			return item.Equals(default(T));
		}
	}
}