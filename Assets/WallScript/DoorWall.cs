using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorWall : MonoBehaviour
{
    private float basePosition;
    private float stopPosition;

    [SerializeField]
    private float openSpeed;
    // Start is called before the first frame update
    void Start()
    {
        basePosition = transform.position.y;
        stopPosition = transform.position.y - 2f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator OpenDoorAnimation()
    {
        while(transform.position.y > stopPosition)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - openSpeed, transform.position.z);
            yield return new WaitForSeconds(openSpeed/100);
        }
    }
    IEnumerator CloseDoorAnimation()
    {
        while (transform.position.y < basePosition)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + openSpeed, transform.position.z);
            yield return new WaitForSeconds(openSpeed / 100);
        }
    }

    public void OpenDoor()
    {
        Debug.Log("LOL OPEN");
        StartCoroutine(OpenDoorAnimation());
    }

    public void CloseDoor()
    {
        Debug.Log("LOL END");
        StartCoroutine(CloseDoorAnimation());
    }
}
