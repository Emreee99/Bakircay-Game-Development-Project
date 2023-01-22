using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YachtToTrain : MonoBehaviour
{
    public int requiredItems = 0; // The number of items required to change the camera parent
    public GameObject train; // The car to change the camera parent to
    public GameObject yacht; // The player to change the camera parent from

    private Camera mainCamera; // The main camera
    //private int inventory = 5; // The player's inventory
    public Text totalItem;

    void Start()
    {
        // Get the main camera
        mainCamera = Camera.main;
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the player entered the trigger area
        if (other.transform == yacht.transform)
        {

            // Check if the player has enough items in their inventory
            if (yacht.GetComponent<PickUpItem>().inventory >= requiredItems)
            {
                
                train.GetComponent<TrainMovement>().enabled = true;
                totalItem.text = (yacht.GetComponent<PickUpItem>().inventory - 100).ToString();
            }
        }
    }
}
