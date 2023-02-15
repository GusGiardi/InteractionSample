using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractiveObject : MonoBehaviour
{
    [SerializeField] Renderer _myRenderer;
    [SerializeField] Color[] _colorList;
    [SerializeField] int _currentColor;
    public UnityEvent OnClick;

    private void Awake()
    {
        if (_currentColor >= _colorList.Length)
            _currentColor = 0;

        _myRenderer.material.color = _colorList[_currentColor];
    }

    public void ChangeColor()
    {
        _currentColor++;
        if (_currentColor >= _colorList.Length)
            _currentColor = 0;

        _myRenderer.material.color = _colorList[_currentColor];
    }
}
