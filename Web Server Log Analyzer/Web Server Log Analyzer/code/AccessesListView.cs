using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Net;

namespace WSLA
{
	public class AccessesListView : QueryListView
	{
		public override String GetQuery(DateTime Date1, DateTime Date2)
		{
			String Result =
                "SELECT Count(*) AS [No of Requests], Sum([HTTPInfo.Bytes]) AS [Downloads (bytes)], [IPAddress] AS [IP Address or Hostname]\n" +
				"FROM HTTPInfo\n" +
				"WHERE [HTTPInfo].[DT] >= " + GetSQLDate(Date1) + " AND [HTTPInfo].[DT] < " + GetSQLDate(Date2.AddDays(1)) + "\n" +
				"GROUP BY [IPAddress]\n" +
				"ORDER BY [IPAddress];";

			return Result;
		}
	}
}
