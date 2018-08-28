using UnityEngine;
using System.Collections;

public class BossDeath : MonoBehaviour {

    public GameObject BossSidePlatformOpenTopRight; //Sets the three objects used for the entrance
    public GameObject BossSidePlatformOpenBottomRight;
    public GameObject BossSidePlatformClosedRight;

    void OnTriggerEnter2D(Collider2D col) //When the player enters the trigger
    {
        Destroy(BossSidePlatformClosedRight); //Deletes the object
        BossSidePlatformOpenBottomRight.SetActive(true); //Enables the object
        BossSidePlatformOpenTopRight.SetActive(true); //Enables the object
    }
}
