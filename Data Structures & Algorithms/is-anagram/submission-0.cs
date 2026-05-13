public class Solution {
    public bool IsAnagram(string s, string t)
{
    if (s.Length !=t.Length ) return false;
    Dictionary<char,int> D = new Dictionary<char,int>();
    foreach (char letter in s)
    {
        if (D.ContainsKey(letter))
        {
            D[letter] += 1;

            
        }
        else
        {
            D[letter] = 1;
        }
    }
    foreach (var letter in t)
    {
        if (D.ContainsKey(letter))
        {
            D[letter]--;
        }
        else
        {
            D[letter]=1;
        }
        
    }
    foreach (var Value in D.Values)
    {
        if (Value !=0)
        {
            return false;
            
        }

    }
    return true;




}
}
