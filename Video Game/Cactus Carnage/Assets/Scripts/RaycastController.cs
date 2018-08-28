using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; //Allows the management of the scene

[RequireComponent(typeof(BoxCollider2D))] //Locked dependancy, cannot be removed from 
public class RaycastController : MonoBehaviour
{
    public LayerMask collisionMask; //Defines the collision mask

    public const float skinWidth = .015f; //Constant value of skinWidth
    public int horizontalRayCount = 4; //Amount of horizontal rays, default value is 4
    public int verticalRayCount = 4; //Amount of vertical rays, default value is 4

    [HideInInspector] //Hides vairiable in inspector
    public float horizontalRaySpacing;

    [HideInInspector] //Hides vairiable in inspector
    public float verticalRaySpacing;

    [HideInInspector] //Hides vairiable in inspector
    public BoxCollider2D collider; //Ignore warning
    public RaycastOrigins raycastOrigins;
    public virtual void Awake() //Called before start
    {
        collider = GetComponent<BoxCollider2D>(); //Calls CalculateRaySpacing
    }
    public virtual void Start()
    {
        CalculateRaySpacing();
    }
    public void UpdateRaycastOrigins() //Updates the origins of the raycasting 
    {
        Bounds bounds = collider.bounds;
        bounds.Expand(skinWidth * -2); //Reduces the size of the bound

        raycastOrigins.bottomLeft = new Vector2(bounds.min.x, bounds.min.y); //Defines the bottom left origin point (0,0)
        raycastOrigins.bottomRight = new Vector2(bounds.max.x, bounds.min.y); //Defines the bottom right origin point (max,0)
        raycastOrigins.topLeft = new Vector2(bounds.min.x, bounds.max.y);  //Defines the top left origin point (0,max)
        raycastOrigins.topRight = new Vector2(bounds.max.x, bounds.max.y); //Defines the top right origin point (max,max)
    }
    public void CalculateRaySpacing() //Calculates the space between the rays
    {
        Bounds bounds = collider.bounds;
        bounds.Expand(skinWidth * -2); //Reduces the size of the bound

        horizontalRayCount = Mathf.Clamp(horizontalRayCount, 2, int.MaxValue);
        verticalRayCount = Mathf.Clamp(verticalRayCount, 2, int.MaxValue);

        horizontalRaySpacing = bounds.size.y / (horizontalRayCount - 1);
        verticalRaySpacing = bounds.size.x / (verticalRayCount - 1);
    }
    public struct RaycastOrigins //Defines where the raycasting is from
    {
        public Vector2 topLeft, topRight;
        public Vector2 bottomLeft, bottomRight;
    }
}