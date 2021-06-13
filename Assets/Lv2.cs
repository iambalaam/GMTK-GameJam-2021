using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lv2 : MonoBehaviour
{
    public Transform girl;
    public Transform balloon;
    void Update()
    {
        Debug.Log((girl.transform.position - balloon.transform.position).magnitude);
        if ((girl.transform.position - balloon.transform.position).magnitude < 5)
        {
            LevelManager.instance.LoadScene(LevelManager.Scene.Lv3);
        }
    }
}
