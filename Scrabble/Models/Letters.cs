using System;
using System.Collections.Generic;

namespace Scrabble
{
  public class Letters
  {
    public bool isAlphabet(string word){
      foreach (char c in word)
    {
        if (!Char.IsLetter(c))
            return false;
    }
    return true;
    }
    public int calculateScore(string word){
        word = word.ToUpper();
         char[] array = word.ToCharArray();

         int score = 0;
         for (int i = 0; i < array.Length; i++){
           if (array[i] == 'A'||array[i] == 'E'||array[i] == 'I'||array[i] == 'O'||array[i] == 'U'||array[i] == 'L'||array[i] == 'N'||array[i] == 'R'||array[i] == 'S'||array[i] == 'T') {
             score+=1;
           } else if (array[i] == 'D'||array[i] == 'G'){
             score+=2;
           } else if (array[i] == 'B'||array[i] == 'C'||array[i] == 'M'||array[i] == 'P'){
             score+=3;
           } else if (array[i] == 'F'||array[i] == 'H'||array[i] == 'V'||array[i] == 'W'||array[i] == 'Y'){
             score+=4;
           } else if (array[i] == 'K'){
             score+=5;
           }else if (array[i]=='J'||array[i] == 'X') {
             score+=8;
           }else if (array[i]=='Q'||array[i] == 'Z') {
             score+=10;
           }
         }

         return score;
       }
     }
   }
