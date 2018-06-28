using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class uiManager : MonoBehaviour
{
    public Button[] Menubuttons;
    public Text scoretext;
    float score;
    bool GameActive = true;
    private AudioSource UISound;
 



    // Use this for initialization
    void Start()
    {
        UISound = GetComponent<AudioSource>();

        score = 0;
        scoretext.text = "SCORE : " + score;

        InvokeRepeating("ScoreUpdater", 1f, 0.5f);
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {

        scoretext.text = "SCORE : " + score;





    }

    void ScoreUpdater()
    {
       
        if (GameActive == true)
        {
            score += 1f;

        }

    }
    public void Pause()
    {
        if (GameActive == true)
        {
            if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
            }
            else
            {
                Time.timeScale = 0;
            }
        }
    }


    public void GameOverActivated()
    {
        UISound.Play();
        GameActive = false;

        foreach (Button button in Menubuttons)
        {

            button.gameObject.SetActive(true);
        }





    }
    public void Restart()
    {
        SceneManager.LoadScene(0);

    }


    public void Quit()
    {

        Application.Quit();
    }


   
}


    

