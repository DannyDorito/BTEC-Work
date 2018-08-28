using UnityEngine;
using System.Collections;

public class EnterBossTrigger : MonoBehaviour
{
    public GameObject BossSidePlatformOpenTopLeft; //Sets the three objects used for the entrance
    public GameObject BossSidePlatformOpenBottomLeft;
    public GameObject BossSidePlatformClosedLeft;

    public GameObject Music;
    public AudioSource battleMusic;

    public bool playerHasEntered = false;

    void OnTriggerEnter2D(Collider2D col) //When the player enters the trigger
    {
        if (!playerHasEntered)
        {
            Destroy(BossSidePlatformOpenTopLeft); //Deletes the object
            Destroy(BossSidePlatformOpenBottomLeft); //Deletes the object
            BossSidePlatformClosedLeft.SetActive(true); //Enables the object

            Music.SetActive(false); //Disables the normal music
            battleMusic.Play(); //Plays the battle music

            playerHasEntered = true;
        }

        if (playerHasEntered)
        {

        }
    }
}