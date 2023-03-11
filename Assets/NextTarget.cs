using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextTarget : MonoBehaviour
{
    public GameObject[] soundCues;

    public GameObject[] checkPoints;


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        Debug.Log(checkPoints[0]);

        if(other.name == checkPoints[0].name){
            soundCues[0].GetComponent<AudioSource>().Stop();
            soundCues[1].GetComponent<AudioSource>().Play();
        }else if(other.name == checkPoints[1].name){
            soundCues[2].GetComponent<AudioSource>().Play();
        }else if(other.name == checkPoints[2].name){
            soundCues[1].GetComponent<AudioSource>().Stop();
        }else if(other.name == checkPoints[3].name){
            soundCues[2].GetComponent<AudioSource>().Stop();
            soundCues[3].GetComponent<AudioSource>().Play();
        }else if(other.name == checkPoints[4].name){
            soundCues[3].GetComponent<AudioSource>().Stop();
            soundCues[4].GetComponent<AudioSource>().Play();
        }
    }
}
