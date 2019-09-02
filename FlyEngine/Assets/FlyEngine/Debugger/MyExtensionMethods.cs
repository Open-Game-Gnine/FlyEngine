using System.Text;
using UnityEngine;

public static class MyExtensionMethods
{
    public static void Identity(this Transform trans)
    {
        trans.localScale = Vector3.one;
        trans.localPosition = Vector3.zero;
        trans.localRotation = Quaternion.identity;
    }

    public static void Clear(this StringBuilder sb)
    {
        sb.Length = 0;
    }

    public static void AppendLineEx(this StringBuilder sb, string str = "")
    {
        sb.Append(str + "\r\n");
    }

    public static Vector3 vec3 = Vector3.zero;
}
