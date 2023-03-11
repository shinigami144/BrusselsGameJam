using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextTarget : MonoBehaviour
{
    public GameObject[] soundCues;

    public GameObject[] checkPoints;

    public AudioClip sandWalk;

    public AudioClip normalWalk;

    public AudioClip waterWalk;

    AudioSource walkSound;

    void Start(){
        walkSound = GetComponent<AudioSource>();
        walkSound.clip = normalWalk;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        
        if(other.tag == "sand"){
            walkSound.clip = sandWalk;
        }else if(other.tag == "water"){
            walkSound.clip = waterWalk;
        }else if(other.tag == "normal"){
            walkSound.clip = normalWalk;
        }

    }


}
