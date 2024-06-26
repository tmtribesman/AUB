
public class HomeViewModel
{
    public int Number { get; set; }

    public bool IsPalindrome() 
    {
        // exclude negative numbers
        if (Number < 0) return false;  

        int reversed = 0; 
        int remainder; 
        int originalNum = Number; 

        while (Number != 0) 
        {
            remainder = Number % 10;
            reversed = reversed * 10 + remainder;
            Number /= 10;
        }

        // the number is palindrome if original and reversed are equal
        return originalNum == reversed;
    }
}

