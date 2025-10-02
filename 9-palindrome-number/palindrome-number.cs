public class Solution {
    public bool IsPalindrome(int x) {
        String s = x.ToString();
        String rev = new String(s.Reverse().ToArray());
        return s == rev;
    }
}