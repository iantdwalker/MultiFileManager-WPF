using FileRenamer.Model;

namespace FileRenamer.Services
{
	/// <summary>
	/// An interface for objects that can trim a file name.
	/// </summary>
	public interface ITrimService
	{
		/// <summary>
		/// Trim the file name.
		/// </summary>
		/// <param name="fileName"></param>
		/// <param name="trimType"></param>
		/// <param name="trimString"></param>
		/// <returns>The new file name after trimming has been applied</returns>		
		string TrimFileName(string fileName, TrimType trimType, string trimString);
	}
}
