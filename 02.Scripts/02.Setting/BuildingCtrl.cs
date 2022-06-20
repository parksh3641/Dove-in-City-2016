using UnityEngine;
using System.Collections;

public class BuildingCtrl : MonoBehaviour {
    private Transform Player;
    private Transform A;
    public GameObject Build; //아슬점수

    private int Dove;
    private float distance;
    public int Value = 0;

    private float EagleTime;

    private float shake = 0.01f;
    private float shakeTime = 0.08f;

    private bool eagle = false;
    private bool B = false;

    void Awake()
    {
        A = GetComponent<Transform>();
        if(Value ==0)
        {
            //Build = transform.FindChild("score").GetComponent<Transform>();
            //Build.localScale = new Vector3(0.0f, 0.0f, 0.0f);
            Build = transform.FindChild("score").gameObject;
            Build.SetActive(false);
        }
        Dove = PlayerPrefs.GetInt("Dove", 0);
        if (Dove == 0)
        {
            Player = GameObject.FindWithTag("Black").GetComponent<Transform>();
        }
        else if (Dove == 1)
        {
            Player = GameObject.FindWithTag("White").GetComponent<Transform>();
        }
        else if (Dove == 2)
        {
            Player = GameObject.FindWithTag("Eagle").GetComponent<Transform>();
        }
        else if (Dove == 3)
        {
            Player = GameObject.FindWithTag("Dori").GetComponent<Transform>();
        }
    }
    void Start()
    {
        EagleTime = GameManager.EagleTime;
    }
    void OnEnable()
    {
        PlayerCtrl.EagleTouch += EagleTouch;
        StartCoroutine(ModeCheck());
    }
    void OnDisable()
    {
        PlayerCtrl.EagleTouch -= EagleTouch;
        StopAllCoroutines();
    }
    void EagleTouch()
    {
        eagle = true;
        StartCoroutine(Shake());
        StartCoroutine(Eagletime());
    }
    IEnumerator Shake()
    {
        if(eagle == true)
        {
            if (B == true)
            {
                transform.position = new Vector3(A.position.x + shake, A.position.y, transform.position.z);
                yield return new WaitForSeconds(shakeTime);
                transform.position = new Vector3(A.position.x - shake, A.position.y, transform.position.z);
                yield return new WaitForSeconds(shakeTime);
                StartCoroutine(Shake());
            }
            else
            {
                yield return new WaitForSeconds(shakeTime);
                StartCoroutine(Shake());
            }
        }
        else
        {
            StopCoroutine(Shake());
        }
    }
    IEnumerator Eagletime()
    {
        yield return new WaitForSeconds(EagleTime);
        eagle = false;
    }

    IEnumerator ModeCheck()
    {
        distance = Vector3.Distance(Player.transform.position, transform.position);
        if (distance < 2.5f)
        {
            B = true;
        }
        else
        {
            B = false;
        }
        yield return new WaitForSeconds(0.2f);
        StartCoroutine(ModeCheck());
    }
}
