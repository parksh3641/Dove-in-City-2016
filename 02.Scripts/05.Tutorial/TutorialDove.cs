using UnityEngine;
using System.Collections;

public class TutorialDove : MonoBehaviour {
    public int Value = 0;
    private UISprite sprite;
    private float cooltime = 0.04f;

    void Awake()
    {
        sprite = GetComponent<UISprite>();
    }
    void OnEnable()
    {
        if (Value == 0)
        {
            StartCoroutine(black());
        }
        else if (Value == 1)
        {
            StartCoroutine(white());
        }
    }
    IEnumerator black()
    {
        sprite.spriteName = "black_1";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "black_2";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "black_3";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "black_4";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "black_5";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "black_6";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "black_5";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "black_4";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "black_3";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "black_2";
        yield return new WaitForSeconds(cooltime);
        StartCoroutine(black());
    }
    IEnumerator white()
    {
        sprite.spriteName = "White_1";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "White_2";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "White_3";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "White_4";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "White_5";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "White_6";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "White_5";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "White_4";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "White_3";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "White_2";
        yield return new WaitForSeconds(cooltime);
        StartCoroutine(white());
    }
}
