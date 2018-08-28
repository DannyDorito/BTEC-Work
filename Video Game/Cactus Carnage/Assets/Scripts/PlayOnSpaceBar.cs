using UnityEngine;
using System.Collections;

public class PlayOnSpaceBar : MonoBehaviour
{
    public AudioSource jumpSound; //Defines the sound

    void Update() //Updates every frame
    {
        if (Input.GetKeyDown(KeyCode.Space)) //If space is pressed, play the jump sound
        {
            jumpSound.Play(); //Plays the sound
        }
	}
}