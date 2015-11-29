using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace WSLA
{
	/// <summary>
	/// Summary description for StatusCodesListView.
	/// </summary>
	public class OperatingSystemsListView : QueryListView
	{
		public override String GetQuery(DateTime Date1, DateTime Date2)
		{
            String Result =

            "SELECT count([UserAgent]) AS [# Requests], \"Windows 95\" AS [Operating System]\n" +
            "FROM HTTPInfo\n" +
            "WHERE UserAgent LIKE \"%Windows 95%\" OR UserAgent LIKE \"%Windows 95%\";\n" +

            "UNION SELECT count([UserAgent]), \"Windows 98\" AS [Operating System]\n" +
            "FROM HTTPInfo\n" +
            "WHERE UserAgent LIKE \"%Windows 98%\" OR UserAgent LIKE \"%Win98%\";\n" +

            "UNION SELECT count([UserAgent]), \"Windows ME\" AS [Operating System]\n" +
            "FROM HTTPInfo\n" +
            "WHERE UserAgent LIKE \"%Win 9x 4.90%\" OR UserAgent LIKE \"%Windows NT 4.0%\" OR UserAgent LIKE \"%Windows NT 4.0;%\";\n" +

            "UNION SELECT count([UserAgent]) AS [# Requests], \"Windows 2000\" AS [Operating System]\n" +
            "FROM HTTPInfo\n" +
            "WHERE UserAgent LIKE \"%Windows 2000%\" OR\n" +
            "UserAgent LIKE \"%Windows NT 5.0)%\" OR UserAgent LIKE \"%Windows NT 5.0;%\";\n" +



            "UNION SELECT count([UserAgent]) AS [# Requests], \"Windows XP\" AS [Operating System]\n" +
            "FROM HTTPInfo\n" +
            "WHERE UserAgent LIKE \"%Windows NT 5.1%\" OR UserAgent LIKE \"%Windows NT 5.1;%\" OR UserAgent LIKE \"%Windows NT 5.2%\" OR UserAgent LIKE \"%Windows NT 5.2;%\";\n" +

            "UNION SELECT count([UserAgent]) AS [# Requests], \"Windows 8.1\" AS [Operating System]\n" +
            "FROM HTTPInfo\n" +
            "WHERE UserAgent LIKE \"%Windows NT 6.3%\" OR UserAgent LIKE \"%Windows NT 6.3;%\";\n" +

            "UNION SELECT count([UserAgent]) AS [# Requests], \"Windows 8\" AS [Operating System]\n" +
            "FROM HTTPInfo\n" +
            "WHERE UserAgent LIKE \"%Windows NT 6.2%\" OR UserAgent LIKE \"%Windows NT 6.2;%\";\n" +

            "UNION SELECT count([UserAgent]) AS [# Requests], \"Windows 7\" AS [Operating System]\n" +
            "FROM HTTPInfo\n" +
            "WHERE UserAgent LIKE \"%Windows NT 6.1%\" OR UserAgent LIKE \"%Windows NT 6.1;%\";\n" +
           
            " UNION SELECT count([UserAgent]) AS [# Requests], \"MacOSx\" AS [Operating System]\n" +
            "FROM HTTPInfo\n" +
            "WHERE UserAgent LIKE \"%Macintosh;%\" Or UserAgent LIKe \"%Mac%\";\n"+

            " UNION SELECT count([UserAgent]) AS [# Requests], \"iOS\" AS [Operating System]\n" +
            "FROM HTTPInfo\n" +
            "WHERE UserAgent LIKE \"%iPad%\" OR UserAgent LIKE \"%iPhone%\";\n"+
           
            "UNION SELECT count([UserAgent]) AS [# Requests], \"Linux\" AS [Operating System]\n" +
            "FROM HTTPInfo\n" +
            "WHERE UserAgent LIKE \"%Linux%\" OR UserAgent LIKE \"%Linux;%\";\n";
			
          
			return Result;
		}
	}
}
