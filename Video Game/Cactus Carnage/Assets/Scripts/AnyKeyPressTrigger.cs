using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AnyKeyPressTrigger : MonoBehaviour
{
    void Update() //Every frame
    {
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene("Level1"); //Loads the first level
        }
    }
}