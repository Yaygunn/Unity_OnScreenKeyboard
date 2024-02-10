using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] private char key;
    [SerializeField] private TextMeshProUGUI textMeshPro;

    public void ButtonClicked()
    {
        print(key);//change this
    }
    private void Start()
    {
        ShowKey();
    }
    public virtual void SetKey(char key)
    {
        this.key = key;
        ShowKey();
    }

    private void ShowKey()
    {
        textMeshPro.text=key.ToString();
    }
}
