using System.Text;

public static class Extension
{
    public static string Replace(this string str, char oldChr, string newStr)
    {
        return str.Replace(oldChr.ToString(), newStr);
    }
}