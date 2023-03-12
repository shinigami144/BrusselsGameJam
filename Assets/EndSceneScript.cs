using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndSceneScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    List<Sprite> cinematiqueImage;
    [SerializeField]
    UnityEngine.UI.Image backgroundImage;
    void Start()
    {
        float h = Screen.height;
        float w = Screen.width;
        backgroundImage.GetComponent<RectTransform>().sizeDelta = new Vector2(w, h);
        backgroundImage.GetComponent<RectTransform>().position = new Vector3(w / 2, h / 2);
        backgroundImage.color = new Color(0, 0, 0);
        StartCoroutine(Cinematique());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Cinematique()
    {
        // joueur audio Porte;
        yield return new WaitForSecondsRealtime(1);
        // attendre longeur audio
        // audio interupeteur
        backgroundImage.color = new Color(255, 255, 255);
    }


}
