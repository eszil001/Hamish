using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectTheFood : MonoBehaviour
{
    //GOAL: i want the hamster to collect he cheese, and turn the quest text to red

    // the main objective
    public GameObject FoodObjective;
    // the objective once done is red
    public GameObject CompletedObjective;


    // Start is called before the first frame update
    void Start()
    {
        // setting main to true, and when is done to false for now
        FoodObjective.SetActive(true);
        CompletedObjective.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        // if player touches the cheese, triggeres the coroutine
        if(other.gameObject.tag == "Player")
        {
            StartCoroutine("Wait");
        }
    }

    IEnumerator Wait()
    {
        // wait for 1 sec to destroy the quest and object and then set the quest to done
        yield return new WaitForSeconds(1);
        Destroy(FoodObjective);

        // destroys the gameobject the script is attached to
        Destroy(gameObject);
        CompletedObjective.SetActive(true);
    }


}
