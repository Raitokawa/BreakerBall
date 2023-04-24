using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class IngameMenu : MonoBehaviour
{
    public GameObject continueButton;
    public GameObject pausePanel;
    public GameObject losePanrl;


    private void Start()
    {
        Time.timeScale = 1f;
    }

    public void OnClickPauseButton()
    {
        
        pausePanel.SetActive(true);
        Time.timeScale = 0f;

        

    }

    public void OnClickContinueButton()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1f;

        
    }
    public void OnRestartGameButton(string sceneName)
    {

        SceneManager.LoadScene(sceneName);

        Time.timeScale = 1f;
    }
    public void OnClickBackToMenuButton(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        pausePanel.SetActive(false);
      

    }

    public void ShowUILooseGame()
    {
        losePanrl.SetActive(true);
        Time.timeScale = 0f;

        
    }
    public void RestartGameAtLose(string sceneName)
    {

        SceneManager.LoadScene(sceneName);
        losePanrl.SetActive(false);
        Time.timeScale = 1f;
    }
    public void BackToMenuAtLose(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        losePanrl.SetActive(false);
       
    }

    
 
}

