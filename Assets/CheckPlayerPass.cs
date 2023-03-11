using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPlayerPass : MonoBehaviour
{
    // Start is called before the first frame update
    public bool playerPass;
    void Start()
    {
        playerPass = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (!this.playerPass)
            {
                playerPass = true;
                FindAnyObjectByType<LutinScript>().waitPlayer = false;
            }
        }
    }
}
