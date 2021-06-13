using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

    public enum Scene
    {
        Lv1,
        Lv2,
        Lv3,
        Lv4
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

    public void LoadScene(Scene s)
    {
        SceneManager.LoadScene(s.ToString());
    }
}
