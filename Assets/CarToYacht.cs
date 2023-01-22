using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarToYacht : MonoBehaviour
{
    public int requiredItems = 0; // The number of items required to change the camera parent
    public GameObject yacht; // The car to change the camera parent to
    public GameObject car; // The player to change the camera parent from

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
        if (other.transform == car.transform)
        {

            // Check if the player has enough items in their inventory
            if (car.GetComponent<PickUpItem>().inventory >= requiredItems)
            {
                // Change the camera parent
                mainCamera.transform.SetParent(yacht.transform);
                car.GetComponent<CarMovement>().enabled = false;
                yacht.GetComponent<YachtMovement>().enabled = true;
                totalItem.text = (car.GetComponent<PickUpItem>().inventory - 50).ToString();
            }
        }
    }
}
