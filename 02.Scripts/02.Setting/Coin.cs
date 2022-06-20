using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {
    private UISprite A;

    public float Cooltime = 0.15f;
    private float cooltime = 0.8f;
	void Awake () {
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
        A.spriteName = "Coin1";
        yield return new WaitForSeconds(cooltime);
        A.spriteName = "Coin2";
        yield return new WaitForSeconds(Cooltime);
        A.spriteName = "Coin3";
        yield return new WaitForSeconds(Cooltime);
        A.spriteName = "Coin4";
        yield return new WaitForSeconds(Cooltime);
        StartCoroutine(ModeCheck());

    }
}
