using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointScript : MonoBehaviour
{
    [SerializeField]
    WayPointScript nextWayPoint;
    [SerializeField]
    public bool lockWayPoint;
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
        if(other.gameObject.GetComponent<LutinScript>().IsOriginalLutin())
        {
            other.gameObject.GetComponent<LutinScript>().nextWayPoint = this.nextWayPoint;
            other.gameObject.GetComponent<LutinScript>().waitPlayer = this.lockWayPoint;
        }
    }


}
