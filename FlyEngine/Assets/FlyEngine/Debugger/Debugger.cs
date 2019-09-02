using System;
using System.Text;
using UnityEngine;

public static class Debugger
{

    private static string GetLogFormat(string str)
    {
        StringBuilder stringBuilder = StringBuilderCache.Acquire(256);
        DateTime now = DateTime.Now;
        stringBuilder.Append(now.Hour);
        stringBuilder.Append(":");
        stringBuilder.Append(now.Minute);
        stringBuilder.Append(":");
        stringBuilder.Append(now.Second);
        stringBuilder.Append(".");
        stringBuilder.Append(now.Millisecond);
        stringBuilder.Append("-");
        stringBuilder.Append(Time.frameCount % 999);
        stringBuilder.Append(": ");
        stringBuilder.Append(str);
        return StringBuilderCache.GetStringAndRelease(stringBuilder);
    }


    public static void Log(string str)
    {
        str = Debugger.GetLogFormat(str);
        if (Debugger.useLog)
        {
            Debug.Log(str);
            return;
        }
        if (Debugger.logger != null)
        {
            Debugger.logger.Log(str, string.Empty, LogType.Log);
        }
    }


    public static void Log(object message)
    {
        Debugger.Log(message.ToString());
    }


    public static void Log(string str, object arg0)
    {
        string str2 = string.Format(str, arg0);
        Debugger.Log(str2);
    }


    public static void Log(string str, object arg0, object arg1)
    {
        string str2 = string.Format(str, arg0, arg1);
        Debugger.Log(str2);
    }


    public static void Log(string str, object arg0, object arg1, object arg2)
    {
        string str2 = string.Format(str, arg0, arg1, arg2);
        Debugger.Log(str2);
    }


    public static void Log(string str, params object[] param)
    {
        string str2 = string.Format(str, param);
        Debugger.Log(str2);
    }


    public static void LogWarning(string str)
    {
        str = Debugger.GetLogFormat(str);
        if (Debugger.useLog)
        {
            Debug.LogWarning(str);
            return;
        }
        if (Debugger.logger != null)
        {
            string stack = StackTraceUtility.ExtractStackTrace();
            Debugger.logger.Log(str, stack, LogType.Warning);
        }
    }


    public static void LogWarning(object message)
    {
        Debugger.LogWarning(message.ToString());
    }


    public static void LogWarning(string str, object arg0)
    {
        string str2 = string.Format(str, arg0);
        Debugger.LogWarning(str2);
    }


    public static void LogWarning(string str, object arg0, object arg1)
    {
        string str2 = string.Format(str, arg0, arg1);
        Debugger.LogWarning(str2);
    }


    public static void LogWarning(string str, object arg0, object arg1, object arg2)
    {
        string str2 = string.Format(str, arg0, arg1, arg2);
        Debugger.LogWarning(str2);
    }


    public static void LogWarning(string str, params object[] param)
    {
        string str2 = string.Format(str, param);
        Debugger.LogWarning(str2);
    }


    public static void LogError(string str)
    {
        str = Debugger.GetLogFormat(str);
        if (Debugger.useLog)
        {
            Debug.LogError(str);
            return;
        }
        if (Debugger.logger != null)
        {
            string stack = StackTraceUtility.ExtractStackTrace();
            Debugger.logger.Log(str, stack, LogType.Error);
        }
    }


    public static void LogError(object message)
    {
        Debugger.LogError(message.ToString());
    }


    public static void LogError(string str, object arg0)
    {
        string str2 = string.Format(str, arg0);
        Debugger.LogError(str2);
    }


    public static void LogError(string str, object arg0, object arg1)
    {
        string str2 = string.Format(str, arg0, arg1);
        Debugger.LogError(str2);
    }


    public static void LogError(string str, object arg0, object arg1, object arg2)
    {
        string str2 = string.Format(str, arg0, arg1, arg2);
        Debugger.LogError(str2);
    }


    public static void LogError(string str, params object[] param)
    {
        string str2 = string.Format(str, param);
        Debugger.LogError(str2);
    }


    public static void LogException(Exception e)
    {
        Debugger.threadStack = e.StackTrace;
        string logFormat = Debugger.GetLogFormat(e.Message);
        if (Debugger.useLog)
        {
            Debug.LogError(logFormat);
            return;
        }
        if (Debugger.logger != null)
        {
            Debugger.logger.Log(logFormat, Debugger.threadStack, LogType.Exception);
        }
    }


    public static void LogException(string str, Exception e)
    {
        Debugger.threadStack = e.StackTrace;
        str = Debugger.GetLogFormat(str + e.Message);
        if (Debugger.useLog)
        {
            Debug.LogError(str);
            return;
        }
        if (Debugger.logger != null)
        {
            Debugger.logger.Log(str, Debugger.threadStack, LogType.Exception);
        }
    }


    public static bool useLog = true;
    public static string threadStack = string.Empty;
    public static ILogger logger = null;
}
