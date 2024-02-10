using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextShow : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _textMeshPro;
    private void OnEnable()
    {
        KeyManager.Instance.WritingChanged += SetText;
    }
    private void OnDisable()
    {
        KeyManager.Instance.WritingChanged -= SetText;
    }


    private void SetText(string text)
    {
        _textMeshPro.text = text;
    }
}
