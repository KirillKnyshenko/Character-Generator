using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void GetPlay()
    {
        FindObjectOfType<GameManager>().Play();
    }

    public void GetBack()
    {
        FindObjectOfType<GameManager>().Back();
    }

    public void StartGenerate()
    {
        FindObjectOfType<Generate>()._Generate();
    }
}
