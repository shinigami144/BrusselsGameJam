using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LutinScript : MonoBehaviour
{
    [SerializeField]
    private WayPointScript _nextWayPoint;
    [SerializeField]
    private bool originalLutin;
    [SerializeField]
    private bool _waitPlayer;
    [SerializeField]
    private float speed;
    AudioSource myAudioSource;
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

    public void setOrignialLutin(bool isOriginal)
    {
        originalLutin = isOriginal;
    }

    [SerializeField]
    private List<AudioClip> audioList;

    [SerializeField]
    public float secondBetweenTwoLaught;
    // Start is called before the first frame update
    void Start()
    {
        waitPlayer = false;
        StartCoroutine(laughtOflutin());
        myAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!waitPlayer)
        {
            transform.position = Vector3.MoveTowards(transform.position, nextWayPoint.transform.position, speed * Time.deltaTime);
        }
    }
    public bool IsOriginalLutin()
    {
        return originalLutin;
    }

    
    IEnumerator laughtOflutin()
    {
        while (true)
        {
            GetComponent<AudioSource>().Play();
            yield return new WaitForSecondsRealtime(secondBetweenTwoLaught+(Random.value)*2);
            myAudioSource.clip = audioList[Random.Range(0, audioList.Count)];


        }
    }
}
