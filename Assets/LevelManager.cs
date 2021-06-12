using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

    private AsyncOperation _scene;

    public enum Scene
    {
        Lv1,
        Lv2
    }

    private void Awake()
    {
        // Singleton
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } else
        {
            Destroy(gameObject);
        }
    }

    public async void LoadScene(Scene s)
    {
        _scene = SceneManager.LoadSceneAsync(s.ToString());
        _scene.allowSceneActivation = false;
    }

    public async void NextScene()
    {
        _scene.allowSceneActivation = true;
    }

}
