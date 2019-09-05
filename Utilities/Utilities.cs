using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utilities : MonoBehaviour
    // static class, don't want in scene or will break it
{       //with a static class, all methods need to be static
    //you can access static classes anywhere
    
    
         public static string ProcessText(string input)
         {
            
        // double is a number so we are trying for a number
        //can also be float, they both detect decimals
            double number;
            if (double.TryParse(input, out number)){
            return "number";
            

        }//returns words and numbers as a string
        else
        {
            return "word";
        } 
            
            //to get it to recognize both number and word
            //get it to split strings on " "
            //put strings into an array
            //go through array and do try parse for each
            //if it wordes icrement a number


        


    }
}
