public class Solution {
    public string IntToRoman(int num) {
        var map = new (int numberArb, string numberRim)[] 
        {
            (1000, "M"),
            (900, "CM"),
            (500, "D"),
            (400, "CD"),
            (100, "C"),
            (90, "XC"),
            (50, "L"),
            (40, "XL"),
            (10, "X"),
            (9, "IX"),
            (5, "V"),
            (4, "IV"),
            (1, "I")
        };

        var result = new System.Text.StringBuilder();

        foreach (var (number, symbol) in map) 
        {
            while (number <= num) 
            {
                result.Append(symbol);
                num -= number;
            }
        }

        return result.ToString();
    }
}