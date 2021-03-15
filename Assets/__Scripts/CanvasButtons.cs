using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasButtons : MonoBehaviour
{
    private GameObject btnPlay, btnPause, btnRestart, btnHome;
    void Awake()
    {
        btnPlay = transform.Find("Play").gameObject;
        btnPause = transform.Find("Pause").gameObject;
        btnRestart = transform.Find("Restart").gameObject;
        btnHome = transform.Find("Home").gameObject;
        btnPause.SetActive(true);
        btnPlay.SetActive(false);
        btnRestart.SetActive(false);
        btnHome.SetActive(false);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
    public void PlayGame()
    {
        Time.timeScale = 1;
        btnPause.SetActive(true);
        btnPlay.SetActive(false);
        btnRestart.SetActive(false);
        btnHome.SetActive(false);
    }
    public void PauseGame()
    {
        Time.timeScale = 0;
        btnPause.SetActive(false);
        btnPlay.SetActive(true);
        btnRestart.SetActive(true);
        btnHome.SetActive(true);
    }
    public void ExitGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }

}
