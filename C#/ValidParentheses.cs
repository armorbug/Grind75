public class Solution {
    public bool IsValid(string s) {
        Stack<char> stonks = new Stack<char>();

        foreach (char c in s)
        {
            switch(c){
                case '(':
                case '[':
                case '{':
                    stonks.Push(c);
                    break;
                case ')':
                    if (stonks.Count == 0 || stonks.Pop() != '(') return false;
                    break;
                case ']':
                    if (stonks.Count == 0 || stonks.Pop() != '[') return false;
                    break;
                case '}':
                    if (stonks.Count == 0 || stonks.Pop() != '{') return false;
                    break;

            }
        }
        return stonks.Count == 0;
    }
}