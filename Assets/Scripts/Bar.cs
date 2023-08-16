using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar : MonoBehaviour
{
   
    public RectTransform foreground;
    public RectTransform background;

    [SerializeField]
    private float _maxWidth;

    private void OnEnable()
    {
      _maxWidth = background.rect.width;
    }
    void Start()
    {
        
    }

    public void SetBar(float currentValue, float maxValue)
    {
        float percentage = currentValue / _maxWidth;

        foreground.sizeDelta = new Vector2(percentage * _maxWidth, foreground.sizeDelta.y);
    }
    
}
