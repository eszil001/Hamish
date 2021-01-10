using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyStorage : MonoBehaviour
{

    public static bool lockedDoor = false;

    // public so I can see if its true or false
    public bool isKeyPicked;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isKeyPicked = lockedDoor;
    }
}
