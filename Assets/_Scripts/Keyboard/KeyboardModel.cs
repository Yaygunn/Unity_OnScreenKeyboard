using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardModel : MonoBehaviour
{
    [SerializeField] public RectTransform rectTransform;

    [Header("Size")]
    [Range(0f, 1f)]
    [SerializeField] public float widthPercentage;
    [Range(0f, 1f)]
    [SerializeField] public float heightPercentage;
    [Range(0f, 0.5f)]
    [SerializeField] public float bottomOffset;

    [Header("Keyboard Lines")]
    [SerializeField] public S_KeyboardLine[] lines;

    [Header("Key Size")]
    [Range(0f, 1f)]
    [SerializeField] public float KeyToLineRatio;
    [Range(0f, 1f)]
    [SerializeField] public float WidhtToHeightRatio;
    [Range(0f, 1f)]
    [SerializeField] public float xSpacing;
    [Range(0f, 2f)]
    [SerializeField] public float ExtraBackSpaceSpacing;
    [Range(1f, 3f)]
    [SerializeField] public float BackSpaceKeySize;
    [Range(0f, 3f)]
    [SerializeField] public float BackSpaceKeyLineSlideLeft;

    [Header("Prefabs")]
    [SerializeField] public Key KeyPrefab;
    [SerializeField] public BackSpaceKey BackSpaceKey;


}
