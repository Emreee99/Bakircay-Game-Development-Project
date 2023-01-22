using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarToYacht : MonoBehaviour
{
    public int requiredItems = 0;
    public GameObject yacht;
    public GameObject car;

    private Camera mainCamera;
    public Text totalItem;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform == car.transform)
        {
            if (car.GetComponent<PickUpItem>().inventory >= requiredItems)
            {
                mainCamera.transform.SetParent(yacht.transform);
                car.GetComponent<CarMovement>().enabled = false;
                yacht.GetComponent<YachtMovement>().enabled = true;
                totalItem.text = (car.GetComponent<PickUpItem>().inventory - 50).ToString();
            }
        }
    }
}
