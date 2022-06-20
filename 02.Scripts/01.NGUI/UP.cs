using UnityEngine;
using System.Collections;

public class UP : MonoBehaviour
{
    public int Vector = 0;
    public int Value = 0;

    private bool Press;
    public float Cooltime = 0.5f;

    public Shop shop;

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
        if(Press == true)
        {
            if (Value == 0)
            {
                if(Vector ==0)
                {
                    shop.OneUp();
                    Cooltime -= 0.02f;
                }
                else
                {
                    shop.OneDown();
                    Cooltime -= 0.02f;
                }
            }
            else if(Value ==1)
            {
                if (Vector == 0)
                {
                    shop.ThreeUp();
                    Cooltime -= 0.02f;
                }
                else
                {
                    shop.ThreeDown();
                    Cooltime -= 0.02f;
                }
            }
        }
        else
        {
            Cooltime = 0.3f;
        }
        yield return new WaitForSeconds(Cooltime);
        StartCoroutine(ModeCheck());
    }
    void OnClick()
    {
        if (Value == 0)
        {
            if (Vector == 0)
            {
                shop.OneUp();
            }
            else
            {
                shop.OneDown();
            }
        }
        else if (Value == 1)
        {
            if (Vector == 0)
            {
                shop.ThreeUp();
            }
            else
            {
                shop.ThreeDown();
            }
        }
    }

    void OnPress(bool A)
    {
        if(A == true)
        {
            StartCoroutine(Wait());
        }
        else
        {
            StopAllCoroutines();
            StartCoroutine(ModeCheck());
            Press = false;
        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1f);
        Press = true;
    }
}
