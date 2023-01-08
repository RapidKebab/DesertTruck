using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    bool paused = false;
    public GameObject[] pauseMenu;
    // Update is called once per frame
    private void Start()
    {
        Time.timeScale = 1f;
    }

    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
            PauseSwap();


        if (Input.GetButtonDown("Submit") && paused)
        {
            Time.timeScale = 1;
            paused = false;
            foreach (GameObject m in pauseMenu)
            {
                m.SetActive(false);
            }
            SceneManager.LoadScene(0);
        }
    }

    public void PauseSwap()
    {
        {
            if (!paused && Time.timeScale > 0.01f)
            {
                Time.timeScale = 0.01f;
                paused = true;
                foreach (GameObject m in pauseMenu)
                {
                    m.SetActive(true);
                }
            }
            else if (paused)
            {
                Time.timeScale = 1;
                paused = false;
                foreach (GameObject m in pauseMenu)
                {
                    m.SetActive(false);
                }
            }
        }
    }
}