using UnityEngine;
using System.Collections;

public class MiniBlack : MonoBehaviour {
    private UISprite sprite;
    private float cooltime = 0.05f;

    public int Value = 0;
    

    void Awake()
    {
        sprite = GetComponent<UISprite>();
        if(Value ==0)
        {
            StartCoroutine(black());
        }
        else if(Value == 1)
        {
            StartCoroutine(white());
        }
        else if (Value == 2)
        {
            StartCoroutine(eagle());
        }
        else if (Value == 3)
        {
            StartCoroutine(dori());
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
    IEnumerator eagle()
    {
        sprite.spriteName = "Eagle1";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "Eagle2";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "Eagle3";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "Eagle4";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "Eagle5";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "Eagle6";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "Eagle5";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "Eagle4";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "Eagle3";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "Eagle2";
        yield return new WaitForSeconds(cooltime);
        StartCoroutine(eagle());
    }
    IEnumerator dori()
    {
        sprite.spriteName = "a";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "b";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "c";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "d";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "e";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "f";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "e";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "d";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "c";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "b";
        yield return new WaitForSeconds(cooltime);
        StartCoroutine(dori());
    }
}
