using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCameraParent : MonoBehaviour
{
    public int requiredItems = 0; // The number of items required to change the camera parent
    public GameObject car; // The car to change the camera parent to
    public GameObject player; // The player to change the camera parent from

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
        if (other.transform == player.transform)
        {
            
            // Check if the player has enough items in their inventory
            if (player.GetComponent<PickUpItem>().inventory >= requiredItems)
            {
                // Change the camera parent
                mainCamera.transform.SetParent(car.transform);
                player.GetComponent<PlayerMovement>().enabled = false;
                car.GetComponent<CarMovement>().enabled = true;
                totalItem.text = (player.GetComponent<PickUpItem>().inventory - 10).ToString();
            }
        }
    }
}
