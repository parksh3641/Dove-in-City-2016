using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MapSeoul1 : MonoBehaviour {
    //public Transform[] curve;

    public GameObject main;
    public SpriteRenderer Main;
    public GameObject Car;

    private Transform Player;

    private float distance;
    private float Distance;
    private float DistanceTime;

    private int Dove;
    private int Check =0;

    public Sprite Seoul1;
    public Sprite Seoul2;
    public Sprite Seoul3;
    public Sprite Seoul4;
    public Sprite Seoul5;

    public GameObject pattern1;
    public GameObject pattern2;
    public GameObject pattern3;
    public GameObject pattern4;
    public GameObject pattern5;

    public int A = 0;
    public int B = 0;

    private int level = 0;

    public GameObject[] CarObject = new GameObject[] { };
    void Awake()
    {
        Car.SetActive(false);

        if (B == 1)
        {
            RandomMap();
            RandomPattern();
        }
    }
    void Start()
    {
        Distance = GameManager.Distance;
        DistanceTime = GameManager.DistanceTime;
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

        if (A == 1)
        {
            StartCoroutine(ModeCheck());
        }
    }
    void OnEnable()
    {
        PlayerCtrl.LevelUp += LevelUp;
        GameManager.MapChange += LevelUp;
    }
    void OnDisable()
    {
        PlayerCtrl.LevelUp -= LevelUp;
        GameManager.MapChange -= LevelUp;
    }
    void LevelUp()
    {
        if(B == 1)
        {
            if(level ==0)
            {
                level = 1;
            }
            else
            {
                level = 0;
                RandomMap();
                RandomPattern();
                Car.SetActive(false);
                ReSet();
            }
        }
    }
    void RandomMap()
    {
        float A = Random.Range(0, 5);
        if(A ==0)
        {
            Main.sprite = Seoul1;
        }
        else if(A == 1)
        {
            Main.sprite = Seoul2;
        }
        else if (A == 2)
        {
            Main.sprite = Seoul3;
        }
        else if (A == 3)
        {
            Main.sprite = Seoul4;
        }
        else if (A == 4)
        {
            Main.sprite = Seoul5;
        }

    }
    void RandomPattern()
    {
        float A = Random.Range(1, 5);
        if(A == 0)
        {
            pattern1.SetActive(true);
            pattern2.SetActive(false);
            pattern3.SetActive(false);
            pattern4.SetActive(false);
            pattern5.SetActive(false);
        }
        else if(A ==1)
        {
            pattern1.SetActive(false);
            pattern2.SetActive(true);
            pattern3.SetActive(false);
            pattern4.SetActive(false);
            pattern5.SetActive(false);
        }
        else if (A == 2)
        {
            pattern1.SetActive(false);
            pattern2.SetActive(false);
            pattern3.SetActive(true);
            pattern4.SetActive(false);
            pattern5.SetActive(false);
        }
        else if (A == 3)
        {
            pattern1.SetActive(false);
            pattern2.SetActive(false);
            pattern3.SetActive(false);
            pattern4.SetActive(true);
            pattern5.SetActive(false);
        }
        else if (A == 4)
        {
            pattern1.SetActive(false);
            pattern2.SetActive(false);
            pattern3.SetActive(false);
            pattern4.SetActive(false);
            pattern5.SetActive(true);
        }
    }
    IEnumerator ModeCheck()
    {
        distance = Vector3.Distance(Player.transform.position, transform.position);
        if (distance > Distance)
        {
            main.SetActive(false);

            if (gameObject.transform.position.y < Player.position.y)
            {
                if(Check == 1)
                {
                    Check = 0;
                    B = 1;
                }
            }
        }
        else
        {
            Check = 1;
            main.SetActive(true);
            Car.SetActive(true);
        }
        yield return new WaitForSeconds(DistanceTime);
        StartCoroutine(ModeCheck());
    }
    void ReSet()
    {
        for (int i = 0; i < CarObject.Length; i++)
        {
            CarObject[i].SetActive(true);
        }
    }
}
