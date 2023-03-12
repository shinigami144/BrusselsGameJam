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

    [SerializeField]
    TMPro.TextMeshProUGUI text;
    void Start()
    {
        float h = Screen.height;
        float w = Screen.width;
        float ht = Screen.height/5;
        float wt = Screen.width/2;
        backgroundImage.GetComponent<RectTransform>().sizeDelta = new Vector2(w, h);
        backgroundImage.GetComponent<RectTransform>().position = new Vector3(w / 2, h / 2);
        backgroundImage.color = new Color(0, 0, 0);
        text.GetComponent<RectTransform>().sizeDelta = new Vector2(wt, ht);
        text.GetComponent<RectTransform>().position = new Vector3(wt/2, h-ht);
        text.gameObject.SetActive(false);
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
        text.gameObject.SetActive(true);
        yield return new WaitForSecondsRealtime(60);
        FindAnyObjectByType<GameManager>().LoadMainMenu();
    }


}
