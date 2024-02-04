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

}
