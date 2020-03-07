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
    /* Assignment 2 Code 
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
    */

    /* Assignment 4 Code */
        if(Input.GetKeyDown(KeyCode.Mouse0)) {
            Debug.Log("Left Click Occurred");
            RaycastHit hit;
            if(Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit)) {
                GameObject gothit = hit.collider.gameObject;
                CollectibleTreasure ct = gothit.GetComponent<CollectibleTreasure>();
                Debug.Log(gothit.name);
                CollectibleTreasure prefabOfClickedObject = Resources.Load<CollectibleTreasure>(ct.prefabName);
                inventory.inventoryItems.Add(prefabOfClickedObject);
                Destroy(hit.collider.gameObject);
                count++;
            OnClick4Text.text = "Vinish Kumar Total Score: " + calculateScore() + " Count: " + count;
            } else {
            Debug.Log("hit nothing");
            }

        }
        
        if(Input.GetKeyDown(KeyCode.Alpha4)) {
            Debug.Log("Total Score: " + calculateScore());
            OnClick4Text.text = "Vinish Kumar Total Score: " + calculateScore() + " Count: " + count;
        }
    }

    // from Nick's code
    float calculateScore() {
        List<CollectibleTreasure> collectibleTreasures = this.gameObject.GetComponent<TreasureHunterInventory>().inventoryItems;
        float totalScore=0;
        foreach(CollectibleTreasure treasure in collectibleTreasures) {
            totalScore += treasure.treasureValue;
        }
        currentTotalScore=totalScore;
        return totalScore;
    }
}
