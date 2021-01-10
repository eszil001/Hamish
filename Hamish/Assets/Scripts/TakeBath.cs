using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TakeBath : MonoBehaviour
{
    // the main objective: similar to the collect food
    public GameObject BathObjective;
    public GameObject CompletedBath;


    // Start is called before the first frame update
    void Start()
    {
        // main obj as true, and the comepleted one as false for now
        BathObjective.SetActive(true);
        CompletedBath.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // if the player collides with the bath, it will trigger "wash"
        if(other.gameObject.tag == "Player")
        {
            StartCoroutine("Wash");
        }
    }

    IEnumerator Wash()
    {
        // after 2 seconds of the player sitting in the bath, will cause the objective to be completed and marked as red
        yield return new WaitForSeconds(2);
        // destroy the original objective for the new one
        Destroy(BathObjective);
        CompletedBath.SetActive(true);
    }
}
