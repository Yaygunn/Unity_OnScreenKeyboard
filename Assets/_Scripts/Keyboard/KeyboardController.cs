using Palmmedia.ReportGenerator.Core.Parser.Analysis;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardController : MonoBehaviour
{
    [SerializeField] private KeyboardModel model;
    void Start()
    {
        SetKeyboardTransform();
        CreateKeys();
        PlaceKeys();
    }

    void Update()
    {
        SetKeyboardTransform();
        PlaceKeys() ;
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

    private void CreateKeys()
    {
        for(int i = 0; i<model.lines.Length; i++)
        {
            for(int j=0; j< model.lines[i].Keys.Length; j++)
            {
                char key = model.lines[i].Keys[j];

                if(key == '.')
                {
                    Key KeyInstance = Instantiate(model.BackSpaceKey, model.rectTransform);
                }
                else
                {
                    Key KeyInstance = Instantiate(model.KeyPrefab, model.rectTransform);
                    KeyInstance.SetKey(key);
                }            
            }
        }
    }

    private void PlaceKeys()
    {
        int LineCount = model.lines.Length;

        float LineHeight = model.rectTransform.rect.height / LineCount;

        float keyHeight = LineHeight * model.KeyToLineRatio;

        float keyWidth = keyHeight * model.WidhtToHeightRatio;

        float xSpacing = model.xSpacing * LineHeight;

        int CurrentKeyIndex = 0;

        for(int i = 0; i < LineCount; i++)
        {
            float  halfKeyCount = (float)model.lines[i].Keys.Length / 2;

            bool ContainsBackSpace = model.lines[i].Keys.Contains(".");

            if (ContainsBackSpace)
            {
                halfKeyCount += model.BackSpaceKeyLineSlideLeft;
            }


            float startX = model.rectTransform.position.x - (keyWidth+xSpacing) * halfKeyCount + (keyWidth +xSpacing)/ 2;

            float lineY = model.rectTransform.position.y + model.rectTransform.rect.height / 2 - LineHeight / 2 - i * LineHeight;        

            for (int j = 0; j < model.lines[i].Keys.Length; j++)
            {
                float keyX = startX + j * (keyWidth + xSpacing);

                bool isBackSpaceKey = model.lines[i].Keys[j].Equals('.');
                if(isBackSpaceKey)
                {
                    keyX += model.ExtraBackSpaceSpacing * keyWidth;
                }

                Vector2 keyPosition = new Vector2(keyX, lineY);

                RectTransform keyRectTransform = model.rectTransform.GetChild(CurrentKeyIndex).GetComponent<RectTransform>();

                float thiskeyWidth = keyWidth;

                if(isBackSpaceKey)
                {
                    thiskeyWidth = keyWidth*model.BackSpaceKeySize;
                }

                keyRectTransform.position = keyPosition;

                keyRectTransform.sizeDelta = new Vector2(thiskeyWidth, keyHeight);

                CurrentKeyIndex++;
            }
        }
    }

}
