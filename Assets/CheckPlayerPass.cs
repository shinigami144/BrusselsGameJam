using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPlayerPass : MonoBehaviour
{
    // Start is called before the first frame update
    public bool playerPass;
    [SerializeField]
    private bool lastChckPoint;
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
                LutinScript l = FindAnyObjectByType<LutinScript>();
                if (lastChckPoint)
                {
                    l.lutinCanbeCatch = true;
                }
                l.waitPlayer = false;
            }
        }
    }
}
