using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjects : MonoBehaviour
{
    // since the cursor needs to be free to access the UI, wanted to implement something will give the game some use out of the mouse
    // hence why moving objects using your mouse, can help the player out while solving a puzzle.
    private Vector3 WhereTo;
    private float TheMouse;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        // using the main camera
        TheMouse = Camera.main.WorldToScreenPoint(this.transform.position).z;

        // the object I attache it to and the mouse pos.
        WhereTo = this.transform.position - GetMouseWorldPos();

    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;

        mousePoint.z = TheMouse;

        // 0, so that th object stops spinning;
        mousePoint.y = 0;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    private void OnMouseDrag()
    {
        // the Y is locked so that the object can only be dragged on the current or lower Y, this is in order to avoid clipping.
        transform.position = new Vector3(GetMouseWorldPos().x + WhereTo.x, transform.position.y, GetMouseWorldPos().z + WhereTo.z);
    }
}
