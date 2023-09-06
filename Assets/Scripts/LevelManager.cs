using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum Scenes
{
    MainMenu,
    Game
}

public class LevelManager : MonoBehaviour
{
    public LevelManager Instance;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
        Instance = this;
        PlayScene(Scenes.MainMenu);
    }

    public static void PlayScene(Scenes sceneEnum)
    {
        SceneManager.LoadScene(sceneEnum.ToString());
    }
}
