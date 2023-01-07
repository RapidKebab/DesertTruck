using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogBorder : MonoBehaviour
{
    public float maxBorder;
    public float minBorder;
    public float maxFogIntensity;
    public float minFogIntensity;
    private Verctor3 sunDistance;
    public Transform sunTransform;
    public Transform mapCenter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Verctor3.Distance(position, mapCenter.position) > minBorder)
    }
}
