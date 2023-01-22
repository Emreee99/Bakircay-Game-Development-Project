using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YachtToTrain : MonoBehaviour
{
    public int requiredItems = 0;
    public GameObject train;
    public GameObject yacht;

    private Camera mainCamera;
    public Text totalItem;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform == yacht.transform)
        {
            if (yacht.GetComponent<PickUpItem>().inventory >= requiredItems)
            {
                
                train.GetComponent<TrainMovement>().enabled = true;
                totalItem.text = (yacht.GetComponent<PickUpItem>().inventory - 100).ToString();
            }
        }
    }
}
