using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ChangeButtonCollor : MonoBehaviour
{
    Image _button;
    private void Start()
    {
        _button = GetComponent<Image>();
    }

    private Color GetRandomCollor()
    {
        Color colorToChange = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        return colorToChange;
    }

    public void ChangeColor()
    {
        _button.color = GetRandomCollor();
    }
}
