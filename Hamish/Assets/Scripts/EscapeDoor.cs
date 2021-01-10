using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EscapeDoor : MonoBehaviour
{
    // the distance to the door
    public float theDistance;

    // related to UI: key that player has to press to open the door
    public GameObject Key;
    public GameObject KeyText;

    // the door
    public GameObject theDoor;

    [SerializeField] private KeyCode openDoorKey = KeyCode.Mouse0;

    // the door objective
    public GameObject EscapeObjective;
    public GameObject CompletedObjective;

    // Start is called before the first frame update
    void Start()
    {
        EscapeObjective.SetActive(true);
        CompletedObjective.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // using the distance already calculated in the RayCasting script
        theDistance = RayCasting.Distance;
    }

    // Hovering the mouse over will trigger the following:
    private void OnMouseOver()
    {
        if(theDistance <= 1 )
        {
            KeyText.GetComponent<Text>().text = "This leads me outside";
            Key.SetActive(true);
            KeyText.SetActive(true);
        }
        // the mouse as to be on top of the invisible trigger for this to be possible
        if (Input.GetKeyDown(openDoorKey))
        {
            if (theDistance <= 1)
            {
                // this.GetComponent<BoxCollider>().enabled = false;
                // theDoor.GetComponent<Animation>().Play("BedroomDoor");
                Key.SetActive(false);
                KeyText.SetActive(false);
               

                StartCoroutine(ResetTheKey());
            }
        }
    }

    private void OnMouseExit()
    {
        Key.SetActive(false);
        KeyText.SetActive(false);
    }

    IEnumerator ResetTheKey()
    {
        if (KeyStorage.lockedDoor == false)
        {
            // if the player doesnt have key:

            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
        else
        {
            // if the player has the key:

            // play the animation of the door opening
            theDoor.GetComponent<Animation>().Play("EscapeDoor");
            yield return new WaitForSeconds(0.5f);
            this.GetComponent<BoxCollider>().enabled = false;

            // completing the objective and setting it red
            Destroy(EscapeObjective);
            CompletedObjective.SetActive(true);

            SceneManager.LoadScene(2);
            // reset the key, so I can use it again for other doors
            KeyStorage.lockedDoor = false;


        }
    }
}
