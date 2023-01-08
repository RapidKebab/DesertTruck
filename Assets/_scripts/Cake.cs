using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cake : MonoBehaviour
{
    Rigidbody rb;
    public Text timer;
    public int damage;
    public int badEndThreshold;
    public GameObject[] disableWhenEnding;
    public GameObject[] goodEnding;
    public GameObject[] badEnding;
    public GameObject[] commonEnding;
    bool over = false;
    public GameObject enableWhenEnd;

    // Start is called before the first frame update
    void Start()
    {
        damage = 0;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == ("terrain")) { 
            damage++;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!over)
        {
            Debug.Log(other.gameObject.name);
            if (other.tag == ("goal"))
            {
                enableWhenEnd.SetActive(true);
                over = true;
                foreach (GameObject go in disableWhenEnding)
                {
                    go.SetActive(false);
                }
                foreach (GameObject go3 in commonEnding)
                {
                    go3.SetActive(true);
                }
                timer.text = Time.timeSinceLevelLoad.ToString("F2");
                if (damage > badEndThreshold)
                {
                    foreach (GameObject go1 in badEnding)
                    {
                        go1.SetActive(true);
                    }
                }
                else
                {
                    foreach (GameObject go2 in goodEnding)
                    {
                        go2.SetActive(true);
                    }
                }
            }
        }
    }

    IEnumerator end() {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(0);
    }
}
