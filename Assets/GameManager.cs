using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private static GameManager _instance;
    public static GameManager instance
    {
        get
        {
            return _instance;
        }
    }
    private static GameObject gm;

    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
            Destroy(this);
        }
        else
        {
            _instance = this;
            gm = this.gameObject;
            DontDestroyOnLoad(gm);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ChangeScene(int id)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(id);
    }

    public void LoadMainMenu()
    {
        ChangeScene(0);
    }

    public void LoadControlsMenu()
    {
        ChangeScene(1);
    }
    public void LoadGame()
    {
        ChangeScene(2);
    }

    public void Quit()
    {
        Application.Quit();
    }

}
