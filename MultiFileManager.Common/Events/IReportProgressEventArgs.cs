namespace MultiFileManager.Common.Events
{
	/// <summary>
	/// Provides an interface for
	/// EventArgs objects to report the progress of an operation.
	/// </summary>
	public interface IReportProgressEventArgs
	{
		/// <summary>
		/// The Progress value to report.
		/// </summary>
		int Progress { get; set; }
	}
}
