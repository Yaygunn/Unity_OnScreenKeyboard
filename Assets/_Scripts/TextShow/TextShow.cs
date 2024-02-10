using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextShow : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _textMeshPro;
    void Start()
    {
        SetText("sda");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetText(string text)
    {
        _textMeshPro.text = text;
    }
}
