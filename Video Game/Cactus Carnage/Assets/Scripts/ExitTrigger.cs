using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; //Allows the management of the scene

public class ExitTrigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col) //When the player enters the trigger
    {
        Player.totalCoins = Player.currentCoins; //Totals the amount of coins
        Debug.Log(Player.totalCoins);
        SceneManager.LoadScene("Level2"); //Loads the second scene
    }
}