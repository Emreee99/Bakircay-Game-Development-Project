using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCameraYacht : MonoBehaviour
{
    public int requiredItems = 0;
    public GameObject yacht;
    public GameObject player; 

    private Camera mainCamera; 
    public Text totalItem;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform == player.transform)
        {
            if (player.GetComponent<PickUpItem>().inventory >= requiredItems)
            {
                mainCamera.transform.SetParent(yacht.transform);
                player.GetComponent<PlayerMovement>().enabled = false;
                yacht.GetComponent<YachtMovement>().enabled = true;
                totalItem.text = (player.GetComponent<PickUpItem>().inventory - 50).ToString();
            }
        }
    }
}
