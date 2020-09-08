using System;
using System.Linq;
public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {      
        string cleanPhoneNumber = new string (phoneNumber 
                                                .Where(c => char.IsDigit(c))
                                                .ToArray())                                    
                                            .TrimStart('1');
        // Why doesn't this work?
        // string cleanPhoneNumber = new string (phoneNumber  
        //                             .Where(c => char.IsDigit(c))
        //                             .ToArray()
        //                             .ToString()
        //                             .TrimStart('1'));

        if (cleanPhoneNumber.Length != 10)
        {
            throw new ArgumentException("Phone number must be 10 digits (or 11 with country code)");
        }        
        if (char.GetNumericValue(cleanPhoneNumber[0]) <2)
        {            
            throw new ArgumentException("First digit of area code must be 2-9");
        }
        if (char.GetNumericValue(cleanPhoneNumber[3]) <2)
        {
            throw new ArgumentException("First digit of the prefix must be 2-9");
        }
        return cleanPhoneNumber;
    }
}