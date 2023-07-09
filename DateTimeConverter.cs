using System;
using System.Globalization;
using UnityEngine;


/// <summary>
/// Set specific format to prevent errors which are caused when
/// convert datetime to string or string to datetime error.
/// </summary>
public class DateTimeConverter
{
    public static readonly CultureInfo StandardCultureInfo = new CultureInfo("ja-JP");

    public static DateTime StringToDateTime(string str)
    {
        DateTime result;

        DateTime.TryParse(str, StandardCultureInfo, DateTimeStyles.None, out result);
        
        return result;
    }

    public static string DateTimeToString(DateTime dateTime, string format = "yyyy/MM/dd HH:mm:ss")
    {
        CultureInfo.CurrentCulture = StandardCultureInfo;
        return dateTime.ToString(format);
    }

    /// <summary>
    /// Change the current UI culture to setted culture style
    /// </summary>
    /// <returns></returns>
    public static DateTime DateTimeNow() {
        CultureInfo.CurrentCulture = StandardCultureInfo;
        return DateTime.Now;
    }
}

