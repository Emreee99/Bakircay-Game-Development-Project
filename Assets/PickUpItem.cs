using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpItem : MonoBehaviour
{
    public float pickupDistance = 1f; // The distance at which the character can pick up the item
    public LayerMask pickupLayer; // The layer of the item to pick up

    private Transform item; // The item to pick up
    private Transform player; // The character's transform
    public int inventory = 0; // The character's inventory
    public Text totalItem;









    void Start()
    {
        // Get the character's transform
        player = transform;
    }

    void Update()
    {
        // Check if the player is close to an item
        if (item != null)
        {
            // Check if the player is close enough to pick up the item
            if (Vector3.Distance(player.position, item.position) < pickupDistance)
            {
                // Pick up the item
                PickUp();
            }
        }
        else
        {
            // Find the nearest item
            FindNearestItem();
        }
    }

    void FindNearestItem()
    {
        // Find all items in the scene
        GameObject[] items = GameObject.FindGameObjectsWithTag("Material");

        // Find the nearest item
        float minDistance = float.MaxValue;
        foreach (GameObject itemObject in items)
        {
            float distance = Vector3.Distance(player.position, itemObject.transform.position);
            if (distance < minDistance)
            {
                minDistance = distance;
                item = itemObject.transform;
            }
        }

    }

    void PickUp()
    {
        // Add the item to the character's inventory
        inventory++;
        totalItem.text = inventory.ToString();

        // Do something with the inventory (e.g., display the new inventory count)
        // ...

        // Destroy the item
        Destroy(item.gameObject);
        item = null;
    }

   
}
