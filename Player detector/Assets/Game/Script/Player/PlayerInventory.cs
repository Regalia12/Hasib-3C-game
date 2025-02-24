using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfCollectable {get; private set;}
    public UnityEvent<PlayerInventory> OnCollected;
    
    public void Collacted()
    {
        NumberOfCollectable++; 
        OnCollected.Invoke(this);
    }    
    
}
