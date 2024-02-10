using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager 
{
    private static KeyManager instance;

    public static KeyManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new KeyManager();
            }
            return instance;
        }
    }

    public string Writing;


    public void KeyPressed(char key)
    {
        Writing += key;
    }

    public void BackSpaceKeyPressed()
    {
        if(Writing.Length > 0)
        {
            Writing = Writing.Substring(0, Writing.Length - 1);
        }
    }
}
