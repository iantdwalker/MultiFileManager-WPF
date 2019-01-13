namespace MultiFileManager.Common.Events
{
	/// <summary>
	/// Provides an interface for
	/// EventArgs objects to report the status of an operation.
	/// </summary>
	public interface IReportStatusEventArgs
	{
		/// <summary>
		/// The Status string to report.
		/// </summary>
		string Status { get; set; }
	}
}
