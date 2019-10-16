using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameInfo 
{
    // Start is called before the first frame update
    public static int difficulty;
    public static string promptWord;

    public static int Difficulty
    {
        get { return difficulty; }
        set { difficulty = value; }
            
    }

    public static string PromptWord
    {
        get { return promptWord; }
        set { promptWord = value; }

    }

}
