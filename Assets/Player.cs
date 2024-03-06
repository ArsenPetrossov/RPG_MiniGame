using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Action HaveBoost;
    
    [SerializeField] private Outline _outline;
    private float _outlineOnValue = 2f;
    private bool _isHasBoost = false;
    public bool IsHasBoost { get; private set; }
    
    private void Awake()
    {
        IsHasBoost = _isHasBoost;
        _outline.GetComponent<Outline>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Boots"))
        {
            OutlineOn();
            BoostActive();
            
        }
    }

    private void BoostActive()
    {
        _isHasBoost = true;
        IsHasBoost = _isHasBoost;
    }

    private void OutlineOn() =>  _outline.OutlineWidth = _outlineOnValue;
   
}
