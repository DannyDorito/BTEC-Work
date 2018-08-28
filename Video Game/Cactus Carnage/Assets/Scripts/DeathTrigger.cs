using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; //Allows the management of the scene

public class DeathTrigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col) //When the player enters the trigger
    {
        Player.playerLives--; //Decreases lives by 0
        Player.currentCoins = 0; //Resets the current coins
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //Reloads the scene, works with any scene
    }
}