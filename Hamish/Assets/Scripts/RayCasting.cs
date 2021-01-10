using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCasting : MonoBehaviour
{
    // check the player's distance to various objects
    public static float Distance;
    public float Target;


    // i find 3d reycast a lot easier to implement than 2D
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // simple player raycasting to find the distance between the player and objects around:
        RaycastHit Hit;

        // to find the distance:
        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Hit))
        {
            Target = Hit.distance;
            Distance = Target;
        }

    }
}
