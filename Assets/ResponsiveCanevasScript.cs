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
        backgrond.GetComponent<RectTransform>().sizeDelta = new Vector2(w, h);
        Title.GetComponent<RectTransform>().sizeDelta = new Vector2(w / 2, h / 4);
        Title.GetComponent<RectTransform>().position = new Vector3(w / 5, h / 5, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
