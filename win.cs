using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winmenu : MonoBehaviour
{
    //load scene
    public void level()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + -4);
    }
}
