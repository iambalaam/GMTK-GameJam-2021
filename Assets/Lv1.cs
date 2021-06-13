using UnityEngine;

public class Lv1 : MonoBehaviour
{
    public Transform girl;
    public Transform balloon;

    void Update()
    {
        if ((girl.transform.position - balloon.transform.position).magnitude < 6)
        {
           LevelManager.instance.LoadScene(LevelManager.Scene.Lv2);
        }
    }
}
