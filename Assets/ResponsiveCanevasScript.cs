using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResponsiveCanevasScript : MonoBehaviour
{

    [SerializeField]
    TMPro.TextMeshProUGUI Title;
    [SerializeField]
    UnityEngine.UI.Button play;
    [SerializeField]
    UnityEngine.UI.Button quit;
    [SerializeField]
    UnityEngine.UI.Image backgrond;
    [SerializeField]
    UnityEngine.UI.Button command;
    // Start is called before the first frame update

    void Start()
    {
        float h = Screen.height;
        float w = Screen.width;
        backgrond.GetComponent<RectTransform>().sizeDelta = new Vector2(w, h);
        float Th = h / 5;
        float Tw = w / 2;
        float marginTitle = h / 40;
        float decalTitle = marginTitle+Th/2;
        Title.GetComponent<RectTransform>().sizeDelta = new Vector2(Tw, Th);
        Title.GetComponent<RectTransform>().position = new Vector3(w / 2,h-decalTitle, 0) ;
        float Bh = 15*h / 100;
        float Bw = w / 4;
        float marginButton = h/10;
        float decalButtonPlay = 1.5f*decalTitle+marginButton + Bh;
        play.GetComponent<RectTransform>().sizeDelta = new Vector2(Bw, Bh);
        play.GetComponent<RectTransform>().position = new Vector3(w / 2, h-decalButtonPlay, 0);
        float decalButtonQuit = decalButtonPlay + marginButton + Bh;
        quit.GetComponent<RectTransform>().sizeDelta = new Vector2(Bw, Bh);
        quit.GetComponent<RectTransform>().position = new Vector3(w / 2, h- decalButtonQuit, 0);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
