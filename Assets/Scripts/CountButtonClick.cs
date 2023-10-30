using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountButtonClick : MonoBehaviour
{
    private int _count = 0;
    private Text _text;
    private string _counterText = "Click : ";

    private void Start()
    {
        _text = GetComponentInChildren<Text>();
        _text.text = _counterText + _count;
    }

    public void CountClick()
    {
        _count++;
        _text.text = _counterText + _count;
    }
}
