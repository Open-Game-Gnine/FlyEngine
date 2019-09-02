using System;
using System.Text;

public static class StringBuilderCache 
{
    public static StringBuilder Acquire(int capacity = 256)
    {
        StringBuilder cache = StringBuilderCache._cache;
        if (cache != null && cache.Capacity >= capacity)
        {
            StringBuilderCache._cache = null;
            cache.Clear();
            return cache;
        }
        return new StringBuilder(capacity);
    }

    public static string GetStringAndRelease(StringBuilder sb)
    {
        string result = sb.ToString();
        StringBuilderCache.Release(sb);
        return result;
    }

    public static void Release(StringBuilder sb)
    {
        if (sb.Capacity <= 512)
        {
            StringBuilderCache._cache = sb;
        }
    }

    private const int MAX_BUILDER_SIZE = 512;
    [ThreadStatic]
    private static StringBuilder _cache = new StringBuilder();
}
