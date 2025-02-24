using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI collectableText;
    void Start()
    {
        collectableText = GetComponent<TextMeshProUGUI>();
    }
    
    public void UpdateCollectable (PlayerInventory playerInventory)
    {
        collectableText.text = playerInventory. NumberOfCollectable. ToString();
    }
}
