using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManagerScript : MonoBehaviour
{
    [SerializeField]
    private DoorWall doorToOpen;

    [SerializeField]
    GameObject prefabWayPoint;

    [SerializeField]
    GameObject prefabLutin;


    [SerializeField]
    GameObject player;
    [SerializeField]
    int numberOfLutin;
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(TestCode());
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

    public void endCinematiquePlay()
    {
        player.GetComponent<FPSController>().canMove = false;
        // Create X lutin 
        float angle = Mathf.Deg2Rad*(360 / numberOfLutin);
        for(int i = 0; i< numberOfLutin; ++i)
        {
            var instanceWayPoint = Instantiate<GameObject>(prefabWayPoint);
            instanceWayPoint.transform.position = player.transform.position + new Vector3(Mathf.Sin(i * angle) * 5, 0, Mathf.Cos(i * angle) * 5); ;
            instanceWayPoint.GetComponent<WayPointScript>().lockWayPoint = true;
            var instanceLutin = Instantiate<GameObject>(prefabLutin);
            instanceLutin.transform.position = player.transform.position + new Vector3(Mathf.Sin(i*angle) * 30, 0, Mathf.Cos(i*angle) *30);
            instanceLutin.GetComponent<LutinScript>().nextWayPoint = instanceWayPoint.GetComponent<WayPointScript>();


        }
        // CReate X WayPoint
    }

}
