using UnityEngine;
using System.Collections;

public class MapSea : MonoBehaviour {
    private Transform Player;
    private int Dove;
    private int Check = 0;

    public int A = 0;
    public float cooltime = 0.8f;

    public GameObject main;
    public SpriteRenderer Main;

    private float distance;
    private float Distance;
    private float DistanceTime;

    public Sprite Seoul1;
    public Sprite Seoul2;
    void Awake()
    {
        Dove = PlayerPrefs.GetInt("Dove", 0);
        if (Dove == 0)
        {
            Player = GameObject.FindGameObjectWithTag("Black").GetComponent<Transform>();
        }
        else if (Dove == 1)
        {
            Player = GameObject.FindGameObjectWithTag("White").GetComponent<Transform>();
        }
        else if (Dove == 2)
        {
            Player = GameObject.FindGameObjectWithTag("Eagle").GetComponent<Transform>();
        }
        else if (Dove == 3)
        {
            Player = GameObject.FindGameObjectWithTag("Dori").GetComponent<Transform>();
        }
        StartCoroutine(RandomMap());
        if (A == 1)
        {
            StartCoroutine(ModeCheck());
        }
    }
    void Start()
    {
        Distance = GameManager.Distance;
        DistanceTime = GameManager.DistanceTime;
    }
    IEnumerator RandomMap()
    {
        Main.sprite = Seoul1;
        yield return new WaitForSeconds(cooltime);
        Main.sprite = Seoul2;
        yield return new WaitForSeconds(cooltime);
        StartCoroutine(RandomMap());
    }
    IEnumerator ModeCheck()
    {
        distance = Vector3.Distance(Player.transform.position, transform.position);
        //Debug.Log(distance.ToString());
        if (distance > Distance)
        {
            main.SetActive(false);
        }
        else
        {
            main.SetActive(true);
        }
        yield return new WaitForSeconds(DistanceTime);
        StartCoroutine(ModeCheck());
    }
}
