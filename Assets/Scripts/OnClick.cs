using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnClick : MonoBehaviour
{
    public void Play()
    {
        Debug.Log("Exit pressed!");
        SceneManager.LoadScene("SampleScene");
    }
    public void ExitPressed()
    {
        Debug.Log("Exit pressed!");
        Application.Quit();

    }
    public void PlayAgainPressed()
    {
        SceneManager.LoadScene("SampleScene");

    }
}
