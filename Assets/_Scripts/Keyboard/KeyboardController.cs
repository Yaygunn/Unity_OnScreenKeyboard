using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardController : MonoBehaviour
{
    [SerializeField] private KeyboardModel model;
    void Start()
    {
        
    }

    void Update()
    {
        SetKeyboardTransform();
    }

    private void SetKeyboardTransform()
    {
        // keyboard size
        float width = Screen.width * model.widthPercentage;
        float height = Screen.height * model.heightPercentage;

        model.rectTransform.sizeDelta = new Vector2(width, height);

        // keyboard position
        Vector2 pos = new Vector2(0, 0);

        pos.x = Screen.width / 2;
        pos.y = model.bottomOffset * Screen.height + height / 2;

        model.rectTransform.position = pos;

    }

}
