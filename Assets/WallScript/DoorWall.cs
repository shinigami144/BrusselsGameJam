using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorWall : MonoBehaviour
{
    [SerializeField]
    private float basePosition;
    [SerializeField]
    private float stopPosition;

    [SerializeField]
    private float openSpeed;
    // Start is called before the first frame update
    void Start()
    {
        basePosition = transform.position.y;
        stopPosition = transform.position.y - 1.5f;
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

    public void OpenDoor()
    {
        Debug.Log("LOL");
        StartCoroutine(OpenDoorAnimation());
    }

    public void CloseDoor()
    {

    }
}
