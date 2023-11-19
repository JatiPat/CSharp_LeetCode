public class Solution {
    public int StrStr(string haystack, string needle) {

        //https://learn.microsoft.com/en-us/dotnet/api/system.string.contains?view=net-7.0
        if(haystack.Contains(needle)){ //if the haystack has the needle
            return haystack.IndexOf(needle); //find its index and return it
        } else{
            return -1; //else return -1
        }

    }
}
