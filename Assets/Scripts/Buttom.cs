using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttom : MonoBehaviour
{
    public void Resume()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Pause()
    {
        gameObject.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartScene()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Main Menu");
        Time.timeScale = 1f;
    }

    public void LoadPlay()
    {
        SceneManager.LoadScene("Play");
        Time.timeScale = 1f;
    }

    public void LoadShop()
    {
        SceneManager.LoadScene("Shop");
        Time.timeScale = 1f;
    }

    private void DisableObj()
    {
        gameObject.SetActive(false);
    }
}
