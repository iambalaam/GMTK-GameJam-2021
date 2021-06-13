using UnityEngine;
using UnityEngine.Animations.Rigging;
using UnityEngine.InputSystem;
using System.Collections;

public class Lv1 : MonoBehaviour
{
    public Transform girl;
    public Transform ballonAnchor;
    public TwoBoneIKConstraint constraint;
    public Transform flyUp;

    void Update()
    {
        float distance = (girl.transform.position - ballonAnchor.transform.position).magnitude;
        constraint.weight = (5 - distance) / 4;
        if (distance < 2.5)
        {
            StartCoroutine(FlyUp());
        }
    }

    private IEnumerator FlyUp ()
    {
        GetComponent<PlayerInput>().enabled = false;
        yield return new WaitForSeconds(1);

        LevelManager.instance.LoadScene(LevelManager.Scene.Lv2);
    }
}
