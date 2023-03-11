using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnTrigger : MonoBehaviour
{
    public GameObject soundSource;

    private AudioSource aSource;

    // Start is called before the first frame update
    void Start()
    {
        aSource = soundSource.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "sand"){
            aSource.Play();
        }else if(other.tag == "snakeStop"){
            aSource.Stop();
        }
    }
}
