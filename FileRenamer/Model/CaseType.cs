namespace FileRenamer.Model
{
	/// <summary>
	/// String value case options available.
	/// </summary>
	public enum CaseType
	{
		/// <summary>
		/// Represent a string value in pascal case.
		/// Applies to new words only, such as 'Pascal Case.txt'.
		/// Does not apply to a single phrase with no spaces, such as 'Pascalcase.txt'.
		/// </summary>
		PascalCase,
		
		/// <summary>
		/// Represents a string value in lower case.
		/// </summary>
		LowerCase,

		/// <summary>
		/// Represents a string value in upper case.
		/// </summary>
		UpperCase
	}
}
