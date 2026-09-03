using System.Reflection.Metadata.Ecma335;

public class Solution {
    public bool solution(string s) {
        try
        {
            int.Parse(s);
        }
        catch
        {
            return false;
        }
        return s.Length == 4 || s.Length == 6 ? true : false;
    }
}