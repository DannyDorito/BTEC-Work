using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

[RequireComponent (typeof (Controller2D))] //Locked dependancy, cannot be removed from Unity
public class Player : MonoBehaviour 
{
	public float maxJumpHeight = 4; //Maximum  high the character can jump, default is 4
    public float minJumpHeight = 1; //Lowest high the character can jump, default is 1
    public float timeToJumpApex = .4f; //Time taken to reach the Apex of a jump, .4 of a second default
	float accelerationTimeAirborne = .2f; //Acceleration time when airborne, .2 of a second default
	float accelerationTimeGrounded = .1f; //Acceleration time when grounded, .1 of a second default
    float moveSpeed = 6; //Movement speed, default is 6

	public Vector2 wallJumpClimb; //Stores the three types of wall jumping
	public Vector2 wallJumpOff; //Stores the three types of wall jumping
	public Vector2 wallLeap; //Stores the three types of wall jumping
    public Vector3 currentPosition;

    public float wallSlideSpeedMax = 3; //Max speed when wall sliding, default is 3
    public float wallStickTime = .25f; //Time player is stuck to the wall, .25 of a second default
    float timeToWallUnstick;

	float gravity;
	float maxJumpVelocity; //Maximum jump velocity
    float minJumpVelocity;  //Lowest jump velocity
    Vector3 velocity; //Stores the player's current velocity
	float velocityXSmoothing; //Stores the smoothing rate

    public static int playerLives = 4; //Sets the playerLives

    public static int currentCoins = 0; //Sets the current amount of coins
    public static int totalCoins; 

    Controller2D controller;
	void Start() //When the game starts
	{
		controller = GetComponent<Controller2D> ();

		gravity = -(2 * maxJumpHeight) / Mathf.Pow (timeToJumpApex, 2); //Calcualtes the gravity on the object
		maxJumpVelocity = Mathf.Abs(gravity) * timeToJumpApex; //Calculates the jump velocity of the jump
        minJumpVelocity = Mathf.Sqrt(2 * Mathf.Abs(gravity) * minJumpHeight);
		//Debug.Log ("Gravity: " + gravity + "  Jump Velocity: " + maxJumpVelocity); //Prints gravity and maxJumpVelocity for debugging
	}
	void Update() //Update is called every frame
	{
        playerDeath();

        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")); //Gets current movement
        int wallDirX = (controller.collisions.left) ? -1 : 1; //Sets the direction of the wall jump

		float targetVelocityX = input.x * moveSpeed;
        velocity.x = Mathf.SmoothDamp(velocity.x, targetVelocityX, ref velocityXSmoothing, (controller.collisions.below) ? accelerationTimeGrounded : accelerationTimeAirborne); //Used to smooth out movement of the character

		bool wallSliding = false;
		if ((controller.collisions.left || controller.collisions.right) && !controller.collisions.below && velocity.y < 0)
		{
			wallSliding = true; //Enables wallSliding
			if (velocity.y < -wallSlideSpeedMax) 
			{
				velocity.y = -wallSlideSpeedMax; //Prevents going over the max speed
			}
			if (timeToWallUnstick > 0)
			{
				velocityXSmoothing = 0;
				velocity.x = 0;

				if (input.x != wallDirX && input.x != 0) 
				{
					timeToWallUnstick -= Time.deltaTime;
				}
				else 
				{
					timeToWallUnstick = wallStickTime;
				}
			}
			else 
			{
				timeToWallUnstick = wallStickTime;
			}
		}
		if (Input.GetKeyDown (KeyCode.Space)) //If Space is pressed, the player will jump
		{
            if (wallSliding)
			{
				if (wallDirX == input.x)
				{
					velocity.x = -wallDirX * wallJumpClimb.x;
					velocity.y = wallJumpClimb.y;
				}
				else if (input.x == 0)
				{
					velocity.x = -wallDirX * wallJumpOff.x;
					velocity.y = wallJumpOff.y;
				}
				else
				{
					velocity.x = -wallDirX * wallLeap.x;
					velocity.y = wallLeap.y;
				}
			}
			if (controller.collisions.below)
			{
				velocity.y = maxJumpVelocity;
			}
		}
        if (Input.GetKeyUp(KeyCode.Space)) //When space is released, allows the variation of jump heights
        {
            if (velocity.y > minJumpVelocity)
            {
                velocity.y = minJumpVelocity;
            }
        }
		velocity.y += gravity * Time.deltaTime;
		controller.Move (velocity * Time.deltaTime, input);

        if (controller.collisions.above || controller.collisions.below) //Stop if the player collides with an object
        {
            velocity.y = 0;
        }
    }
    public void playerDeath() //When health is 0
    {
        if (playerLives <= 0)
        {
            Debug.Log("Player Has Died");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);  //Reloads the scene
        }
        else
        {

        }
    }
}