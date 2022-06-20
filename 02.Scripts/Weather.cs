using UnityEngine;
using System.Collections;

public class Weather : MonoBehaviour
{
    public UISprite Background;

    public GameObject RainStartBlack;
    public GameObject RainStopBlack;

    public GameObject RainStartWhite;
    public GameObject RainStopWhite;

    public GameObject RainStartEagle;
    public GameObject RainStopEagle;

    public GameObject RainStartDori;
    public GameObject RainStopDori;
    private int Dove;
    private int RainState = 0;
    private float alpha = 0f;

    void Start()
    {
        Dove = PlayerPrefs.GetInt("Dove", 0);
        StartCoroutine(ModeCheck());
    }

    void OnEnable()
    {
        GameUI.RainStop += RainStop;
        GameUI.RainStart += RainStart;
        GameManager.PlayerDie += AllStop;
    }
    void OnDisable()
    {
        GameUI.RainStop -= RainStop;
        GameUI.RainStart -= RainStart;
        GameManager.PlayerDie -= AllStop;
    }

    void AllStop()
    {
        RainState = 0;
        StopAllCoroutines();

        StartCoroutine(ModeCheck());
        StartCoroutine(AlphaDown());
    }
    void RainStop()
    {
        //Debug.Log("Rainstop");
        if (RainState == 1)
        {
            if (Dove == 0)
            {
                RainStartBlack.SetActive(false);

                RainStopBlack.SetActive(false);
                RainStopBlack.SetActive(true);
                RainState = 0;
                StartCoroutine(AlphaDown());
            }
            else if (Dove == 1)
            {
                RainStartWhite.SetActive(false);

                RainStopWhite.SetActive(false);
                RainStopWhite.SetActive(true);
                RainState = 0;
                StartCoroutine(AlphaDown());
            }
            else if (Dove == 2)
            {
                RainStartEagle.SetActive(false);

                RainStopEagle.SetActive(false);
                RainStopEagle.SetActive(true);
                RainState = 0;
                StartCoroutine(AlphaDown());
            }
            else if (Dove == 3)
            {
                RainStartDori.SetActive(false);

                RainStopDori.SetActive(false);
                RainStopDori.SetActive(true);
                RainState = 0;
                StartCoroutine(AlphaDown());
            }
        }
    }
    void RainStart()
    {
        //Debug.Log("Rainstart!!");
        if (RainState == 0)
        {
            alpha = 0;
            if (Dove == 0)
            {
                RainStopBlack.SetActive(false);

                RainStartBlack.SetActive(false);
                RainStartBlack.SetActive(true);
                RainState = 1;
                StartCoroutine(AlphaUp());
            }
            else if (Dove == 1)
            {
                RainStopWhite.SetActive(false);

                RainStartWhite.SetActive(false);
                RainStartWhite.SetActive(true);
                RainState = 1;
                StartCoroutine(AlphaUp());
            }
            else if (Dove == 2)
            {
                RainStopEagle.SetActive(false);

                RainStartEagle.SetActive(false);
                RainStartEagle.SetActive(true);
                RainState = 1;
                StartCoroutine(AlphaUp());
            }
            else if (Dove == 3)
            {
                RainStopDori.SetActive(false);

                RainStartDori.SetActive(false);
                RainStartDori.SetActive(true);
                RainState = 1;
                StartCoroutine(AlphaUp());
            }
        }
    }

    IEnumerator AlphaDown()
    {
        alpha -= 0.013f;
        if (alpha < 0)
        {
            alpha = 0;
            StopCoroutine(AlphaDown());
        }
        else
        {
            yield return new WaitForSeconds(0.1f);
            StartCoroutine(AlphaDown());
        }
    }
    IEnumerator AlphaUp()
    {
        alpha += 0.013f;
        if (alpha > 0.4f)
        {
            alpha = 0.4f;
            StopCoroutine(AlphaUp());
        }
        else
        {
            yield return new WaitForSeconds(0.1f);
            StartCoroutine(AlphaUp());
        }
    }

    IEnumerator ModeCheck()
    {
        Background.GetComponent<UISprite>().color = new Color(255, 255, 255, alpha);
        yield return new WaitForSeconds(0.1f);
        StartCoroutine(ModeCheck());
    }
}