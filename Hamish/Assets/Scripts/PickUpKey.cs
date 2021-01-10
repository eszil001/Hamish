using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpKey : MonoBehaviour
{
    // the distance to the key
    public float theDistance;
    // the UI
    public GameObject Key;
    public GameObject KeyText;
    // the keyObject
    public GameObject theKey;

    // using key "E"
    [SerializeField] private KeyCode openDoorKey = KeyCode.Mouse0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // using the distance already calculated in the RayCasting script
        // same as the door script
        theDistance = RayCasting.Distance;
    }
    // taken from my OpenDoor script:

    private void OnMouseOver()
    {
        if (theDistance <= 1)
        {
            // changing the text UI to say "pick up key" when the player is hovering mouse over the key
            KeyText.GetComponent<Text>().text = "Pick up key";
            Key.SetActive(true);
            KeyText.SetActive(true);
        }

        if (Input.GetKeyDown(openDoorKey))
        {
            if (theDistance <= 1)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                Key.SetActive(false);
                KeyText.SetActive(false);
                theKey.SetActive(false);

                // picking up the key to open the door
                KeyStorage.lockedDoor = true;
            }
        }
    }

    private void OnMouseExit()
    {
        // whenthe mouse its not hovering over the trigger the text on screen won't appear.
        Key.SetActive(false);
        KeyText.SetActive(false);
    }
}
