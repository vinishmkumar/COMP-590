using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureHunter : MonoBehaviour
{
 
    public CollectibleTreasure[] collectibles;
    public TreasureHunterInventory inventory;
    float currentTotalScore;
    int count;
    public TextMesh GameWonText;
    public TextMesh OnClick4Text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1)) {
            if(!inventory.inventoryItems[0]) {
                inventory.inventoryItems[0] = collectibles[0];
                Debug.Log("Clicked on 1");
                count++;
            }
            else {
                Debug.Log("Clicked on 1");
            }
        }
        
        if(Input.GetKeyDown(KeyCode.Alpha2)) {
            if(!inventory.inventoryItems[1]) {
                inventory.inventoryItems[1] = collectibles[1];
                Debug.Log("Clicked on 2");
                count++;
            }
            else {
                Debug.Log("Clicked on 2");
            }
        }
    
        if(Input.GetKeyDown(KeyCode.Alpha3)) {
            if(!inventory.inventoryItems[2]) {
                 inventory.inventoryItems[2] = collectibles[2];
                 Debug.Log("Clicked on 3");
                 Debug.Log("YOU WON!");
                 GameWonText.text = "Vinish Kumar: YOU WON!";
                 count++;
            }
            else {
                Debug.Log("Clicked on 3");
            }
        }
        if(Input.GetKeyDown(KeyCode.Alpha4)) {
            Debug.Log("Total Score: " + calculateScore());
            OnClick4Text.text = "Total Score: " + calculateScore() + " Count: " + count;
        }
        
    }

    // from Nick's code
    float calculateScore() {
        CollectibleTreasure[] collectibleTreasures = this.gameObject.GetComponent<TreasureHunterInventory>().inventoryItems;
        float totalScore=0;
        foreach(CollectibleTreasure treasure in collectibleTreasures) {
            totalScore += treasure.treasureValue;
        }
        currentTotalScore=totalScore;
        return totalScore;
    }
}
