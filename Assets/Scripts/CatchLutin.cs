using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchLutin : MonoBehaviour
{
    LevelManagerScript lvM;
    // Start is called before the first frame update
    void Start()
    {
        lvM = FindAnyObjectByType<LevelManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.gameObject.tag == "Lutin")
        {
            lvM.endCinematiquePlay();
            Destroy(hit.gameObject);
        }
    }
}
