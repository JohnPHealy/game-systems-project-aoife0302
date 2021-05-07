using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    public GameObject Background;
    void Start()
    {
        Background.SetActive(false);
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Application Quit!");
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("HouseInterior");
    }
}
