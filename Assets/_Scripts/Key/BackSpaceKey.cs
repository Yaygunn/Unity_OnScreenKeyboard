using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackSpaceKey : Key
{
    private void Start()
    {
        //prevents parent start fire
    }
    public void BackSpaceButtonClicked()
    {
        KeyManager.Instance.BackSpaceKeyPressed();
    }

    public override void SetKey(char key)
    {
        //prevents parent setket fire
    }
}
