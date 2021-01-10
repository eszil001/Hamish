using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScript : MonoBehaviour
{
    public GameObject WinUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // if player touches the cheese, triggeres the coroutine
        if (other.gameObject.tag == "Player")
        {
            WinUI.gameObject.SetActive(true);
            
        }
    }
}
