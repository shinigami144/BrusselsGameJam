using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsMenu : MonoBehaviour
{
    [SerializeField]
    TMPro.TextMeshProUGUI Title;
    [SerializeField]
    UnityEngine.UI.Image Controls;
    [SerializeField]
    UnityEngine.UI.Button next;
    [SerializeField]
    UnityEngine.UI.Image backgrond;
    // Start is called before the first frame update
    void Start()
    {
        float h = Screen.height;
        float w = Screen.width;
        backgrond.GetComponent<RectTransform>().sizeDelta = new Vector2(w, h);
        float Th = h / 5;
        float Tw = w / 2;
        float marginTitle = h / 40;
        float decalTitle = marginTitle + Th / 2;
        Title.GetComponent<RectTransform>().sizeDelta = new Vector2(Tw, Th);
        Title.GetComponent<RectTransform>().position = new Vector3(w / 2, h - decalTitle, 0);
        float Bh = 15 * h / 100;
        float Bw = w / 4;
        float marginButton = h / 10;
        float decalButtonPlay = 1.5f * decalTitle + marginButton + Bh;
        next.GetComponent<RectTransform>().sizeDelta = new Vector2(Bw, Bh);
        next.GetComponent<RectTransform>().position = new Vector3(w / 2,  Bh, 0);

        Controls.GetComponent<RectTransform>().sizeDelta = new Vector2(w, h / 2);
        Controls.GetComponent<RectTransform>().position = new Vector3(w/2, h/2, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
