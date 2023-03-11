using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LutinScript : MonoBehaviour
{
    [SerializeField]
    private WayPointScript _nextWayPoint;

    private bool _waitPlayer;
    [SerializeField]
    private float speed;

    public bool waitPlayer{
        get {
            return _waitPlayer;
        }
        set
        {
            _waitPlayer = value;
        }

    }

    public WayPointScript nextWayPoint
    {
        get
        {
            return _nextWayPoint;
        }
        set
        {
            _nextWayPoint = value;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        waitPlayer = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!waitPlayer)
        {
            transform.position = Vector3.MoveTowards(transform.position, nextWayPoint.transform.position, speed * Time.deltaTime);
        }
    }
}
