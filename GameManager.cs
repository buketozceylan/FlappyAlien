using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject startButton;
    public GameObject PauseButton;
    public GameObject ContinueButton;
    public GameObject MenuButton;
    public GameObject OkButton;
    public GameObject ShareButton;

    public Player player;
    public GameObject GetReady;
    public GameObject GameDone;
    public float countTimer = 3;
    void Start()
    {
        PauseButton.SetActive(true);
        ContinueButton.SetActive(false);
        MenuButton.SetActive(false);
        OkButton.SetActive(false);
        GameDone.SetActive(false);
        ShareButton.SetActive(false);
        Time.timeScale = 0;
    }

    void Update()
    {
        if ( player.isDead )
        {
            GameDone.SetActive(true);
            countTimer -= Time.unscaledDeltaTime;
        }

        if (countTimer < 0 )
        {
            RestartGame();
        }
        
    }

    public void StartGame(){

        startButton.SetActive(false);
        GetReady.SetActive(false);
        Time.timeScale = 1;
    }

    public void Pause(){

        PauseButton.SetActive(false);
        ContinueButton.SetActive(true);
        MenuButton.SetActive(true);
        OkButton.SetActive(true);
        GameDone.SetActive(false);
        GetReady.SetActive(false);
        ShareButton.SetActive(true);
        startButton.SetActive(false);

        Time.timeScale = 0;

        

    }
    public void Continue(){

        PauseButton.SetActive(true);
        ContinueButton.SetActive(false);
        MenuButton.SetActive(false);
        OkButton.SetActive(false);
        GameDone.SetActive(false);
        ShareButton.SetActive(false);
        startButton.SetActive(true);
        GetReady.SetActive(true);

    }
    public void GameOver(){

        Time.timeScale = 0;

    }

    public void MainMenu(){
        SceneManager.LoadScene(0);
    }

    public void RestartGame(){
        SceneManager.LoadScene(1);
    }
}
