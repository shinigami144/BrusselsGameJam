using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cotrolsMenuScript : MonoBehaviour
{
    [SerializeField]
    TMPro.TextMeshProUGUI Title;
    [SerializeField]
    UnityEngine.UI.Button next;
    [SerializeField]
    UnityEngine.UI.Image backgrond;
    [SerializeField]
    UnityEngine.UI.Image controlsImage;
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
        Title.GetComponent<RectTransform>().position = new Vector3(w / 2, h - decalTitle, 0);
        float wControlImage = w / 2;
        float hControlImage = h / 2;
        float hPlay = 15 * h / 100;
        float wPlay = w / 2;
        float marginPlay = h / 20;
        controlsImage.GetComponent<RectTransform>().sizeDelta = new Vector2(wControlImage,hControlImage);
        controlsImage.GetComponent<RectTransform>().position = new Vector2(w/2, h/2);
        next.GetComponent<RectTransform>().sizeDelta = new Vector2(wPlay, hPlay);
        next.GetComponent<RectTransform>().position = new Vector3(w / 2, marginPlay + hPlay / 2, 0);



    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
