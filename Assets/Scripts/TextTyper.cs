using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TextTyper : MonoBehaviour
{
    public string[] str;
    private string tempStr = "";
    public Text Title;
    public AudioSource AudioSource;
    public AudioClip click;
    public float speed;
    public float speed2;
    public Image image;
    [Header("Please have the same amount of sprite than the amount of text dialogues :))))")]
    public Sprite[] sequenceOfImage;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AnimateText(str));
    }

    // Update is called once per frame
    void Update()
    {
        Title.text = tempStr;
    }
    IEnumerator AnimateText(string[] strComplete)
    {
        for (int j = 0; j < strComplete.Length; j++)
        {
            string dialogue = strComplete[j];
            while(!Input.anyKey)
            {
                yield return null;
                
            }
            image.sprite = sequenceOfImage[j];
            int i = 0;
            tempStr = "";
            yield return new WaitForSeconds(speed2);
            while (i < dialogue.Length)
            {
                AudioSource.pitch = Random.Range(0.9f, 1.1f);
                tempStr += dialogue[i++];
                AudioSource.PlayOneShot(click);
                yield return new WaitForSeconds(speed);
            }  
        }
        while(!Input.anyKey)
        {
            //finished dialogue
            SceneManager.LoadScene(1);
            yield return null;
            
        }
        
            
        
    }
}
