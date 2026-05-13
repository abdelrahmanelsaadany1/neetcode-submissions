public class Solution {
public bool IsPalindrome(string s)
{

    string clean = "";
    foreach (char c in s)
    {
        if (char.IsLetterOrDigit(c))
            clean += char.ToLower(c);
    }
    s = clean;
    int left = 0;
    int right = s.Length-1;
    while (left < right)
    {
        if (s[left] != s[right]) 
            {
                return false;         
            }
        else
        {
            left++;
            right--;
        }

    }
    return true;


}
}
