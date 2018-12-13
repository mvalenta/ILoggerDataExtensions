using System;
using System.Text;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace Microsoft.Extensions.Logging
{
    public static class ILoggerExtensions
    {
        public static void LogTraceData(this ILogger log, object obj, Exception ex = null, string note = "", [CallerMemberName] string memberName = "")
        {
            StringBuilder builder = new StringBuilder();
            if (memberName != "")
                builder.Append($"Error in function {memberName}. ");
            if (note != "")
                builder.Append($"Note: {note}. ");
            if (ex != null)
                builder.Append($"Exception: {ex.Message}, ");

            var json = JsonConvert.SerializeObject(obj,
                    Formatting.Indented,
                    new JsonSerializerSettings()
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    });
            var objName = obj.GetType().Name;
            builder.Append($"Object name: {objName}, Data: {json}");
            if (ex != null)
                log.LogTrace(ex, builder.ToString());
            else
                log.LogTrace(builder.ToString());
        }
        public static void LogDebugData(this ILogger log, object obj, Exception ex = null, string note = "", [CallerMemberName] string memberName = "")
        {
            StringBuilder builder = new StringBuilder();
            if (memberName != "")
                builder.Append($"Error in function {memberName}. ");
            if (note != "")
                builder.Append($"Note: {note}. ");
            if (ex != null)
                builder.Append($"Exception: {ex.Message}, ");

            var json = JsonConvert.SerializeObject(obj,
                    Formatting.Indented,
                    new JsonSerializerSettings()
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    });
            var objName = obj.GetType().Name;
            builder.Append($"Object name: {objName}, Data: {json}");
            if (ex != null)
                log.LogError(ex, builder.ToString());
            else
                log.LogError(builder.ToString());
        }
        public static void LogInformationData(this ILogger log, object obj, Exception ex = null, string note = "", [CallerMemberName] string memberName = "")
        {
            StringBuilder builder = new StringBuilder();
            if (memberName != "")
                builder.Append($"Error in function {memberName}. ");
            if (note != "")
                builder.Append($"Note: {note}. ");
            if (ex != null)
                builder.Append($"Exception: {ex.Message}, ");

            var json = JsonConvert.SerializeObject(obj,
                    Formatting.Indented,
                    new JsonSerializerSettings()
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    });
            var objName = obj.GetType().Name;
            builder.Append($"Object name: {objName}, Data: {json}");
            if (ex != null)
                log.LogInformation(ex, builder.ToString());
            else
                log.LogInformation(builder.ToString());
        }
        public static void LogWarningData(this ILogger log, object obj, Exception ex = null, string note = "", [CallerMemberName] string memberName = "")
        {
            StringBuilder builder = new StringBuilder();
            if (memberName != "")
                builder.Append($"Error in function {memberName}. ");
            if (note != "")
                builder.Append($"Note: {note}. ");
            if (ex != null)
                builder.Append($"Exception: {ex.Message}, ");

            var json = JsonConvert.SerializeObject(obj,
                    Formatting.Indented,
                    new JsonSerializerSettings()
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    });
            var objName = obj.GetType().Name;
            builder.Append($"Object name: {objName}, Data: {json}");
            if (ex != null)
                log.LogWarning(ex, builder.ToString());
            else
                log.LogWarning(builder.ToString());
        }
        public static void LogErrorData(this ILogger log, object obj, Exception ex = null, string note = "", [CallerMemberName] string memberName = "")
        {
            StringBuilder builder = new StringBuilder();
            if (memberName != "")
                builder.Append($"Error in function {memberName}. ");
            if (note != "")
                builder.Append($"Note: {note}. ");
            if (ex != null)
                builder.Append($"Exception: {ex.Message}, ");

            var json = JsonConvert.SerializeObject(obj,
                    Formatting.Indented,
                    new JsonSerializerSettings()
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    });
            var objName = obj.GetType().Name;
            builder.Append($"Object name: {objName}, Data: {json}");
            if (ex != null)
                log.LogError(ex, builder.ToString());
            else
                log.LogError(builder.ToString());
        }
        public static void LogCriticalData(this ILogger log, object obj, Exception ex = null, string note = "", [CallerMemberName] string memberName = "")
        {
            StringBuilder builder = new StringBuilder();
            if (memberName != "")
                builder.Append($"Error in function {memberName}. ");
            if (note != "")
                builder.Append($"Note: {note}. ");
            if (ex != null)
                builder.Append($"Exception: {ex.Message}, ");

            var json = JsonConvert.SerializeObject(obj,
                    Formatting.Indented,
                    new JsonSerializerSettings()
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    });
            var objName = obj.GetType().Name;
            builder.Append($"Object name: {objName}, Data: {json}");
            if (ex != null)
                log.LogCritical(ex, builder.ToString());
            else
                log.LogCritical(builder.ToString());
        }
    }
}