using UnityEngine;
using System.Collections;

public class CoinTrigger : MonoBehaviour
{
    public AudioSource pickupCoinSound; //Defines the sound

    void OnTriggerEnter2D(Collider2D col) //When the player enters the trigger
    {
        Player.currentCoins ++; //Adds to the total of current coins
        pickupCoinSound.Play(); //Plays the pickup sound
        Debug.Log(Player.currentCoins); //Prints the amount of coins the player has collected, for debugging
        Destroy(gameObject); //Finally deletes the coin
    }
}