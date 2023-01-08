using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarEntryControl : MonoBehaviour
{
    [HideInInspector] public bool inCar;
    public Transform carExit;
    public GameObject carCam;
    public GameObject player;
    public RCC_CarControllerV3 car;
    // Start is called before the first frame update
    void Start()
    {
        
        car.canControl = false;
        //player.transform.position = carExit.position;
        car.canControl = false;
        carCam.SetActive(false);
        player.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z)) {
            Swap();

        }
    }

    public void Swap() {
        if (!inCar)
        {
            car.canControl = true;
            carCam.SetActive(true);
            player.SetActive(false);
            inCar = true;
        }
        else {
            player.transform.position = carExit.position;
            player.transform.rotation = carExit.rotation;
            car.canControl = false;
            carCam.SetActive(false);
            player.SetActive(true);
            inCar = false;
        }
    }
}
