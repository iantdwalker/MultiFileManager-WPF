namespace FileRenamer.Model
{
	/// <summary>
	/// String value trim options available.
	/// </summary>
	public enum TrimType
	{
		/// <summary>
		/// Represents a string value trimmed prior to the position of the supplied trim string.
		/// </summary>
		TrimBeforeTrimString,

		/// <summary>
		/// Represents a string value trimmed by removing the supplied trim string.
		/// </summary>
		RemoveExactTrimString,

		/// <summary>
		/// Represents a string value trimmed after the position of the supplied trim string.
		/// </summary>
		TrimAfterTrimString
	}
}
