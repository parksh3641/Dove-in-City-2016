using UnityEngine;
using System.Collections;

public class Egg : MonoBehaviour {

    public Transform A;
    private int B =0;
    private bool C = false;
    public float Cooltime = 0.1f;
    void OnEnable()
    {
        StartCoroutine(ModeCheck());
    }
    void OnDisable()
    {
        StopAllCoroutines();
    }
    IEnumerator ModeCheck()
    {
        if(C == false)
        {
            if (B < 10)
            {
                B += 1;
            }
            else
            {
                C = true;
            }
        }
        else
        {
            if(B > -10)
            {
                B -= 1;
            }
            else
            {
                C = false;
            }
        }
        //Debug.Log(B.ToString());
        A.rotation = Quaternion.Euler(0, 0, B);
        yield return new WaitForSeconds(Cooltime);
        StartCoroutine(ModeCheck());
    }

    void OnClick()
    {
        A.rotation = Quaternion.Euler(0, 0, 0);
        StopAllCoroutines();
    }
}
