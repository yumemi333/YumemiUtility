using System;


public class TimeCountUtil
{
    /// <summary>
    /// Return remaining time in specified format
    /// </summary>
    /// <param name="endTime"></param>
    /// <param name="startTime"></param>
    /// <param name="format"></param>
    /// <returns></returns>
    public static string GetLeftDateTimeString(DateTime endTime, DateTime startTime, string format = "HH:mm:ss") {
        int leftTime = (int)(endTime - startTime).TotalSeconds;
        TimeSpan timeSpan = new TimeSpan(0, 0, leftTime);
        return new DateTime(0).Add(timeSpan).ToString(format);
    }
}
