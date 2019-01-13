using System;

namespace MultiFileManager.Common.Events
{
	/// <summary>
	/// The default implementation of the IReportStatusEventArgs interface.
	/// </summary>
	public class ReportStatusEventArgs : EventArgs, IReportStatusEventArgs
	{
		#region Construction
		
		/// <summary>
		/// ReportStatusEventArgs.
		/// </summary>
		/// <param name="status"></param>
		public ReportStatusEventArgs(string status)
		{
			if (status == null)
			{
				throw new ArgumentNullException("status");
			}
			
			Status = status;
		}

		#endregion

		#region IReportStatusEventArgs Members		
		
		/// <summary>
		/// The Status string to report.
		/// </summary>
		public string Status
		{
			get;
			set;
		}
		
		#endregion
	}
}
