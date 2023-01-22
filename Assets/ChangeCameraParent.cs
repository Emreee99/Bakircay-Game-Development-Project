using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCameraParent : MonoBehaviour
{
    public int requiredItems = 0; 
    public GameObject car; 
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
                mainCamera.transform.SetParent(car.transform);
                player.GetComponent<PlayerMovement>().enabled = false;
                car.GetComponent<CarMovement>().enabled = true;
                totalItem.text = (player.GetComponent<PickUpItem>().inventory - 10).ToString();
            }
        }
    }
}
