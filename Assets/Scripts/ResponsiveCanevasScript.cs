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
    // Start is called before the first frame update
    void Start()
    {
        float h = Screen.height;
        float w = Screen.width;
        float wTitle = w / 2;
        float hTitle = h / 5;
        float marginTitle = h / 20;
        float decalTitle = hTitle / 2 + marginTitle;
        backgrond.GetComponent<RectTransform>().sizeDelta = new Vector2(w, h);
        Title.GetComponent<RectTransform>().sizeDelta = new Vector2(wTitle, hTitle);
        Title.GetComponent<RectTransform>().position = new Vector3(w /2, h - decalTitle, 0);
        float hPlay = 15*h / 100;
        float wPlay = w / 2;
        float marginPlay = h / 20;
        float decalPlay = decalTitle + +marginTitle +hTitle/2 + marginPlay + hPlay/2;
        float decalQuit = decalPlay + marginPlay + hPlay/2 + marginPlay + hPlay / 2;
        play.GetComponent<RectTransform>().sizeDelta = new Vector2(wTitle, hTitle);
        play.GetComponent<RectTransform>().position = new Vector3(w / 2, h - decalPlay, 0);
        quit.GetComponent<RectTransform>().sizeDelta = new Vector2(wTitle, hTitle);
        quit.GetComponent<RectTransform>().position = new Vector3(w / 2, h - decalQuit, 0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
