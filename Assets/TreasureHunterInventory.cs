using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureHunterInventory : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        inventoryItems = new List<CollectibleTreasure>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // from Nick's in-class code
    public List<CollectibleTreasure> inventoryItems;
}
