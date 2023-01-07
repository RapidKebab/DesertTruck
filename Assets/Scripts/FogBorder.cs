using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogBorder : MonoBehaviour
{
    public float maxBorder;
    public float minBorder;
    public float maxFogIntensity;
    public float minFogIntensity;
    private Vector3 sunDistance;
    public Transform sunTransform;
    public Transform mapCenter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int lol;
        if (Vector3.Distance(this.gameObject.transform.position, mapCenter.position) > minBorder)
            lol = 5;
    }
}
