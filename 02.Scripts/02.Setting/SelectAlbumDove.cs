using UnityEngine;
using System.Collections;

public class SelectAlbumDove : MonoBehaviour {
    private UISprite sprite;
    private float cooltime = 0.04f;
    private int Dove = 0;
    public int Num = 0;

    void OnEnable()
    {
        Select.DoveOne += DoveOne;
        Select.DoveTwo += DoveTwo;
        Select.DoveThree += DoveThree;
        Select.DoveFour += DoveFour;
        Select.DoveFive += DoveFive;
        sprite = GetComponent<UISprite>();
        Dove = PlayerPrefs.GetInt("Dove", 0);
        if(Num ==1)
        {
            if(Dove ==0)
            {
                StartCoroutine(black());
            }
        }
        else if(Num ==2)
        {
            if (Dove == 1)
            {
                StartCoroutine(white());
            }
        }
        else if (Num == 3)
        {
            if (Dove == 2)
            {
                StartCoroutine(eagle());
            }
        }
        else if (Num == 4)
        {
            if (Dove == 3)
            {
                StartCoroutine(dori());
            }
        }
        else if(Num ==5)
        {
            if(Dove ==4)
            {
                StartCoroutine(black());
            }
        }
    }
    void OnDisable()
    {
        Select.DoveOne -= DoveOne;
        Select.DoveTwo -= DoveTwo;
        Select.DoveThree -= DoveThree;
        Select.DoveFour -= DoveFour;
        Select.DoveFive -= DoveFive;
        StopAllCoroutines();
        if (Num == 1)
        {
            sprite.spriteName = "black_3";
        }
        else if (Num == 2)
        {
            sprite.spriteName = "White_3";
        }
        else if (Num == 3)
        {
            sprite.spriteName = "Eagle3";
        }
        else if (Num == 4)
        {
            sprite.spriteName = "c";
        }
    }

    void DoveOne()
    {
        if (Num == 1)
        {
            StopAllCoroutines();
            StartCoroutine(black());
        }
        else if (Num == 2)
        {
            StopAllCoroutines();
            sprite.spriteName = "White_3";
        }
        else if (Num == 3)
        {
            StopAllCoroutines();
            sprite.spriteName = "Eagle3";
        }
        else if (Num == 4)
        {
            StopAllCoroutines();
            sprite.spriteName = "c";
        }
        else if (Num == 5)
        {
            StopAllCoroutines();
            sprite.spriteName = "black_3";
        }
    }
    void DoveTwo()
    {
        if (Num == 1)
        {
            StopAllCoroutines();
            sprite.spriteName = "black_3";
        }
        else if (Num == 2)
        {
            StopAllCoroutines();
            StartCoroutine(white());
        }
        else if (Num == 3)
        {
            StopAllCoroutines();
            sprite.spriteName = "Eagle3";
        }
        else if (Num == 4)
        {
            StopAllCoroutines();
            sprite.spriteName = "c";
        }
        else if (Num == 5)
        {
            StopAllCoroutines();
            sprite.spriteName = "black_3";
        }
    }
    void DoveThree()
    {
        if (Num == 1)
        {
            StopAllCoroutines();
            sprite.spriteName = "black_3";
        }
        else if (Num == 2)
        {
            StopAllCoroutines();
            sprite.spriteName = "White_3";
        }
        else if (Num == 3)
        {
            StopAllCoroutines();
            StartCoroutine(eagle());
        }
        else if (Num == 4)
        {
            StopAllCoroutines();
            sprite.spriteName = "c";
        }
        else if (Num == 5)
        {
            StopAllCoroutines();
            sprite.spriteName = "black_3";
        }
    }
    void DoveFour()
    {
        if (Num == 1)
        {
            StopAllCoroutines();
            sprite.spriteName = "black_3";
        }
        else if (Num == 2)
        {
            StopAllCoroutines();
            sprite.spriteName = "White_3";
        }
        else if (Num == 3)
        {
            StopAllCoroutines();
            sprite.spriteName = "Eagle3";
        }
        else if (Num == 4)
        {
            StopAllCoroutines();
            StartCoroutine(dori());
        }
        else if (Num == 5)
        {
            StopAllCoroutines();
            sprite.spriteName = "black_3";
        }
    }
    void DoveFive()
    {
        if (Num == 1)
        {
            StopAllCoroutines();
            sprite.spriteName = "black_3";
        }
        else if (Num == 2)
        {
            StopAllCoroutines();
            sprite.spriteName = "White_3";
        }
        else if (Num == 3)
        {
            StopAllCoroutines();
            sprite.spriteName = "Eagle3";
        }
        else if (Num == 4)
        {
            StopAllCoroutines();
            sprite.spriteName = "c";
        }
        else if (Num == 5)
        {
            StopAllCoroutines();
            StartCoroutine(black());
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
