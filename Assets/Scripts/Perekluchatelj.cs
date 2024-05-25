using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Perekluchatelj : MonoBehaviour
{
    public void ToFirstScene()
    {
        SceneManager.LoadScene("Pervij", LoadSceneMode.Single);
    }

    public void ToSecondScene()
    {
        SceneManager.LoadScene("Vtoroj", LoadSceneMode.Single);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
