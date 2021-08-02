using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ChangeColor : MonoBehaviour
{
    private Material _gameObject;

    private void Start()
    {
        _gameObject = GetComponent<Material>();
        _gameObject.DOColor(Color.red, 2);
    }
       
}
