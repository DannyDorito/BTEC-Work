using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; //Allows the management of the scene

public class Controller2D : RaycastController //Uses the RaycastController.cs
{
    float maxClimbAngle = 80; //The maximum angle of climbing
    float maxDescendAngle = 80; //The maximum angle of decent

    public CollisionInfo collisions;
    [HideInInspector] //Hides vairiable in inspector
    public Vector2 playerInput;

    public override void Start() //When the game starts
    {
        base.Start(); //Runs the initial start
        collisions.faceDir = 1;

    }
    public void Move(Vector3 velocity, bool standingOnPlatform) //Overloads the below Move method
    {
        Move(velocity, Vector2.zero, standingOnPlatform);
    }
    public void Move(Vector3 velocity, Vector2 input, bool standingOnPlatform = false) //Moves the player according to the velocity
    {
        UpdateRaycastOrigins();
        collisions.Reset(); //Resets collisions each time it is called
        collisions.velocityOld = velocity;
        playerInput = input;

        if (velocity.x != 0)
        {
            collisions.faceDir = (int)Mathf.Sign(velocity.x);
        }

        if (velocity.y < 0)
        {
            DescendSlope(ref velocity);
        }

        HorizontalCollisions(ref velocity);
        if (velocity.y != 0)
        {
            VerticalCollisions(ref velocity);
        }

        transform.Translate(velocity); //Updates the velocity
        if (standingOnPlatform) //Allows jumping on platform
        {
            collisions.below = true;
        }
    }
    void HorizontalCollisions(ref Vector3 velocity) //Collision detection for horizontal movement
    {
        float directionX = collisions.faceDir;
        float rayLength = Mathf.Abs(velocity.x) + skinWidth;

        if (Mathf.Abs(velocity.x) < skinWidth)
        {
            rayLength = 2 * skinWidth;
        }

        for (int i = 0; i < horizontalRayCount; i++)
        {
            Vector2 rayOrigin = (directionX == -1) ? raycastOrigins.bottomLeft : raycastOrigins.bottomRight;
            rayOrigin += Vector2.up * (horizontalRaySpacing * i);
            RaycastHit2D hit = Physics2D.Raycast(rayOrigin, Vector2.right * directionX, rayLength, collisionMask);

            Debug.DrawRay(rayOrigin, Vector2.right * directionX * rayLength, Color.red); //Shows red ray lines, for debugging
            if (hit) //If a drawn ray hits an object
            {
                if (hit.distance == 0)
                {
                    continue; //Skip to the next ray, prevents player from being crushed
                }

                float slopeAngle = Vector2.Angle(hit.normal, Vector2.up);

                if (i == 0 && slopeAngle <= maxClimbAngle)
                {
                    if (collisions.descendingSlope) //Prevents errors when decending from one obstible to the next
                    {
                        collisions.descendingSlope = false;
                        velocity = collisions.velocityOld;
                    }
                    float distanceToSlopeStart = 0;
                    if (slopeAngle != collisions.slopeAngleOld) //Removes 'hovering' when climbing slopes
                    {
                        distanceToSlopeStart = hit.distance - skinWidth;
                        velocity.x -= distanceToSlopeStart * directionX;
                    }
                    ClimbSlope(ref velocity, slopeAngle);
                    velocity.x += distanceToSlopeStart * directionX;
                }

                if (!collisions.climbingSlope || slopeAngle > maxClimbAngle) //Allows the decent anf climbing of slopes
                {
                    velocity.x = (hit.distance - skinWidth) * directionX; //Ray distance
                    rayLength = hit.distance; //Prevents incorrect collison detection

                    if (collisions.climbingSlope)
                    {
                        velocity.y = Mathf.Tan(collisions.slopeAngle * Mathf.Deg2Rad) * Mathf.Abs(velocity.x);
                    }

                    collisions.left = directionX == -1;
                    collisions.right = directionX == 1;
                }
            }
        }
    }
    void VerticalCollisions(ref Vector3 velocity) //Collision detection for vertical movement
    {
        float directionY = Mathf.Sign(velocity.y);
        float rayLength = Mathf.Abs(velocity.y) + skinWidth;

        for (int i = 0; i < verticalRayCount; i++)
        {

            Vector2 rayOrigin = (directionY == -1) ? raycastOrigins.bottomLeft : raycastOrigins.topLeft;
            rayOrigin += Vector2.right * (verticalRaySpacing * i + velocity.x);
            RaycastHit2D hit = Physics2D.Raycast(rayOrigin, Vector2.up * directionY, rayLength, collisionMask);

            Debug.DrawRay(rayOrigin, Vector2.up * directionY * rayLength, Color.red); //Shows red ray lines, for debugging

            if (hit) //If a drawn ray hits an object
            {
                if (hit.collider.tag == "Through") //Allows jumping through platforms
                {
                    if (directionY == 1 || hit.distance == 0) //Prevents clipping through platforms and is moving up
                    {
                        continue;
                    }
                    if (collisions.fallingThroughPlatform)
                    {
                        continue;
                    }
                    if (playerInput.y == -1)
                    {
                        collisions.fallingThroughPlatform = true;
                        Invoke("ResetFallingThroughPlatform", .5f); //After .5 of a second, this method will be called
                        continue;
                    }
                }
                velocity.y = (hit.distance - skinWidth) * directionY; //Ray distance
                rayLength = hit.distance; //Prevents incorrect collison detection

                if (collisions.climbingSlope)
                {
                    velocity.x = velocity.y / Mathf.Tan(collisions.slopeAngle * Mathf.Deg2Rad) * Mathf.Sign(velocity.x);
                }

                collisions.below = directionY == -1;
                collisions.above = directionY == 1;
            }
        }
        if (collisions.climbingSlope)
        {
            float directionX = Mathf.Sign(velocity.x);
            rayLength = Mathf.Abs(velocity.x) + skinWidth;
            Vector2 rayOrigin = ((directionX == -1) ? raycastOrigins.bottomLeft : raycastOrigins.bottomRight) + Vector2.up * velocity.y;
            RaycastHit2D hit = Physics2D.Raycast(rayOrigin, Vector2.right * directionX, rayLength, collisionMask);

            if (hit)
            {
                float slopeAngle = Vector2.Angle(hit.normal, Vector2.up);
                if (slopeAngle != collisions.slopeAngle)
                {
                    velocity.x = (hit.distance - skinWidth) * directionX;
                    collisions.slopeAngle = slopeAngle;
                }
            }
        }
    }
    void ClimbSlope(ref Vector3 velocity, float slopeAngle) //Ability to climb verical objects
    {
        float moveDistance = Mathf.Abs(velocity.x);
        float climbVelocityY = Mathf.Sin(slopeAngle * Mathf.Deg2Rad) * moveDistance; //Allows the ability to jump

        if (velocity.y <= climbVelocityY)
        {
            velocity.y = climbVelocityY;
            velocity.x = Mathf.Cos(slopeAngle * Mathf.Deg2Rad) * moveDistance * Mathf.Sign(velocity.x);
            collisions.below = true; //Allows the ability to jump
            collisions.climbingSlope = true;
            collisions.slopeAngle = slopeAngle;
        }
    }
    void DescendSlope(ref Vector3 velocity) //Ability to decend vertical objects
    {
        float directionX = Mathf.Sign(velocity.x);
        Vector2 rayOrigin = (directionX == -1) ? raycastOrigins.bottomRight : raycastOrigins.bottomLeft;
        RaycastHit2D hit = Physics2D.Raycast(rayOrigin, -Vector2.up, Mathf.Infinity, collisionMask);

        if (hit)
        {
            float slopeAngle = Vector2.Angle(hit.normal, Vector2.up);
            if (slopeAngle != 0 && slopeAngle <= maxDescendAngle)
            {
                if (Mathf.Sign(hit.normal.x) == directionX) //Prevents the program from thinking it is going down a slope when decending
                {
                    if (hit.distance - skinWidth <= Mathf.Tan(slopeAngle * Mathf.Deg2Rad) * Mathf.Abs(velocity.x))
                    {
                        float moveDistance = Mathf.Abs(velocity.x);
                        float descendVelocityY = Mathf.Sin(slopeAngle * Mathf.Deg2Rad) * moveDistance; //Allows the ability to jump
                        velocity.x = Mathf.Cos(slopeAngle * Mathf.Deg2Rad) * moveDistance * Mathf.Sign(velocity.x);
                        velocity.y -= descendVelocityY;

                        collisions.slopeAngle = slopeAngle;
                        collisions.descendingSlope = true;
                        collisions.below = true;
                    }
                }
            }
        }
    }
    void ResetFallingThroughPlatform() //Resets the fallingThroughPlatform
    {
        collisions.fallingThroughPlatform = false;
    }

    public struct CollisionInfo //Stored collision information
    {
        public bool above, below;
        public bool left, right;

        public bool climbingSlope;
        public bool descendingSlope;
        public float slopeAngle, slopeAngleOld;
        public Vector3 velocityOld;
        public int faceDir;
        public bool fallingThroughPlatform;

        public void Reset() //Resets stored information
        {
            above = below = false;
            left = right = false;
            climbingSlope = false;
            descendingSlope = false;

            slopeAngleOld = slopeAngle;
            slopeAngle = 0;
        }
    }
}