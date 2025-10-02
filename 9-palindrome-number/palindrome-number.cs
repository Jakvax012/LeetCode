public class Solution {
    public bool IsPalindrome(int x) {
        // if is negative it is not palindrome
        if (x < 0) {
            return false;
        }

        String s = x.ToString();
        String rev = new String(s.Reverse().ToArray());
        return s == rev;

    }
}