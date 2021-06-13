using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    public AudioClip backgroundMusic;

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

        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = backgroundMusic;
        audio.Play();
    }

    public void LoadScene(Scene s)
    {
        SceneManager.LoadScene(s.ToString());
    }
}
