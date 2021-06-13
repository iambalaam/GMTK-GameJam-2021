using UnityEngine;

public class Lv2 : MonoBehaviour
{
    public Transform girl;
    public Transform balloon;
    void Update()
    {
        if ((girl.transform.position - balloon.transform.position).magnitude < 5)
        {
            LevelManager.instance.LoadScene(LevelManager.Scene.Lv3);
        }
    }
}
