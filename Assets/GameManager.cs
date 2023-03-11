using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    private static GameObject gameManager;
    // Start is called before the first frame update
    public static GameManager gm
    {
        get
        {
            return instance;
        }
    }
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
            gameManager = this.gameObject;
            DontDestroyOnLoad(gameManager);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ChangeScene(int idScene)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(idScene);
    }

    public void LoadCommandMenu()
    {
        ChangeScene(1);
    }

    public void LoadMainMenu()
    {
        ChangeScene(0);
    }

    public void LoadGame()
    {
        ChangeScene(2);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
