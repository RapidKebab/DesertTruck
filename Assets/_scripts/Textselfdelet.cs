using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Textselfdelet : MonoBehaviour
{
    Text txt;
    bool destroyig=false;
    public float destroyTime;
    // Start is called before the first frame update
    void Start()
    {
        txt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (txt.text != ""&&!destroyig)
        {
            StartCoroutine(w8());
            destroyig = true;
        }
    }
    IEnumerator w8()
    {
        yield return new WaitForSeconds(destroyTime);
        txt.text = "";
        destroyig = false;
    }
}
