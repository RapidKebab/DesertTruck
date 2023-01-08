using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carExit : MonoBehaviour
{
    public CarEntryControl ce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ce.inCar && Input.GetKeyDown(KeyCode.E))
            ce.Swap();
    }
}
