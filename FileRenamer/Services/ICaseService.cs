using FileRenamer.Model;

namespace FileRenamer.Services
{
	/// <summary>
	/// ICaseService is an interface for objects
	/// that can modify the case of a string value.
	/// </summary>
	public interface ICaseService
	{
		/// <summary>
		/// Modify the case of an input string and return the new value.
		/// </summary>
		/// <param name="value"></param>
		/// <param name="caseType"></param>
		/// <returns>The new string value with the CaseType applied</returns>
		string ModifyCase(string value, CaseType caseType);
	}
}
