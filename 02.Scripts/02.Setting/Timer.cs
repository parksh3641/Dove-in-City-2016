using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

    public UILabel AdsTime;

    private int Minute = 0;
    private int Second = 30;

    public delegate void timer();
    public static event timer BoxOpen;

    void Start () {
        //PlayerPrefs.SetString("Minute", System.DateTime.Now.ToString("mm"));
        StartCoroutine(TIMER());
    }
    void OnEnable()
    {
        UnityAdsHelper.UNITGet += UNITGet;
    }
    void OnDisable()
    {
        UnityAdsHelper.UNITGet -= UNITGet;
    }
    void UNITGet()
    {
        Minute = 0;
        Second = 30;
        StartCoroutine(TIMER());
    }

    IEnumerator TIMER()
    {
        if (Second >= 10)
        {
            AdsTime.text = Minute.ToString() + ":" + Second.ToString();
        }
        else if(Second < 10)
        {
            AdsTime.text = Minute.ToString() + ":0" + Second.ToString();
        }

        if(Minute == 0)
        {
            if(Second == 0)
            {
                AdsTime.text = "클릭!";
                BoxOpen();
                StopCoroutine(TIMER());
            }
        }

        if (Minute > 0)
        {
            if (Second == 0)
            {
                Minute -= 1;
                Second = 59;
                yield return new WaitForSeconds(1f);
                StartCoroutine(TIMER());
            }
            else if (Second > 0)
            {
                Second -= 1;
                yield return new WaitForSeconds(1f);
                StartCoroutine(TIMER());
            }
        }
        else if (Minute == 0)
        {
            if (Second == 0)
            {
                BoxOpen();
            }
            else if (Second > 0)
            {
                Second -= 1;
                yield return new WaitForSeconds(1f);
                StartCoroutine(TIMER());
            }
        }
    }
}
