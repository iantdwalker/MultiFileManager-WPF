namespace FileRenamer.Model
{
	/// <summary>
	/// File extension options available.
	/// </summary>
	public enum ExtensionType
	{
		/// <summary>
		/// Represents a file extension using the exact extension input by the user.
		/// </summary>
		ExactExtension,

		/// <summary>
		/// Represents a file extension converted to lower case.
		/// </summary>
		LowerCaseExtension,

		/// <summary>
		/// Represents a file extension converted to upper case.
		/// </summary>
		UpperCaseExtension,

		/// <summary>
		/// Represents a file extension that has been removed.
		/// </summary>
		RemoveExtension
	}
}
