using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManagerScript : MonoBehaviour
{
    [SerializeField]
    private DoorWall doorToOpen;




    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TestCode());
    }


    IEnumerator TestCode()
    {
        doorToOpen.OpenDoor();
        yield return new WaitForSeconds(5);
        doorToOpen.CloseDoor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
