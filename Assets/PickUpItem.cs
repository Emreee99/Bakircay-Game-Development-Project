using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpItem : MonoBehaviour
{
    public float pickupDistance = 1f;
    public LayerMask pickupLayer;

    private Transform item;
    private Transform player;
    public int inventory = 0;
    public Text totalItem;









    void Start()
    {
        player = transform;
    }

    void Update()
    {
        if (item != null)
        {
            if (Vector3.Distance(player.position, item.position) < pickupDistance)
            {
                PickUp();
            }
        }
        else
        {
            FindNearestItem();
        }
    }

    void FindNearestItem()
    {
        GameObject[] items = GameObject.FindGameObjectsWithTag("Material");

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
        inventory++;
        totalItem.text = inventory.ToString();

        Destroy(item.gameObject);
        item = null;
    }

   
}
