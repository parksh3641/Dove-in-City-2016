using UnityEngine;
using System.Collections;

public class Effect : MonoBehaviour {
    private UISprite A;

    public float Cooltime = 0.15f;
    void Awake()
    {
        A = GetComponent<UISprite>();
        StartCoroutine(ModeCheck());
    }
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
        A.spriteName = "후광효과1";
        yield return new WaitForSeconds(Cooltime);
        A.spriteName = "후광효과2";
        yield return new WaitForSeconds(Cooltime);
        StartCoroutine(ModeCheck());

    }
}
