using System;

namespace MultiFileManager.Common.Events
{
	/// <summary>
	/// The default implementation of the IReportProgressEventArgs interface.
	/// </summary>
	public class ReportProgressEventArgs : EventArgs, IReportProgressEventArgs
	{
		#region Construction
		
		/// <summary>
		/// ReportProgressEventArgs.
		/// </summary>
		/// <param name="progress"></param>
		public ReportProgressEventArgs(int progress)
		{
			if (progress < 0)
			{
				throw new ArgumentException("The progress parameter cannot be less than 0", "progress");
			}
			
			Progress = progress;
		}

		#endregion

		#region IReportProgressEventArgs Members		
		
		/// <summary>
		/// The Progress value to report.
		/// </summary>
		public int Progress
		{
			get;
			set;
		}
		
		#endregion
	}
}
