using UnityEngine;
using System.Collections;

public class MapSeoul2 : MonoBehaviour {
    private Transform Player;
    private int Dove;
    private int Check = 0;

    public GameObject main;
    public SpriteRenderer Main;
    public GameObject Car;

    public float CoolTime = 1;
    public float A = 0;
    private float distance;
    private float Distance;
    private float DistanceTime;

    private int level = 0;

    public Sprite Seoul1;
    public Sprite Seoul2;

    public Sprite Seoul3;
    public Sprite Seoul4;

    public Sprite Seoul5;
    public Sprite Seoul6;

    public GameObject pattern1;
    public GameObject pattern2;

    public GameObject God1;
    public GameObject God2;
    public GameObject God3;
    public GameObject God4;

    public GameObject[] CarObject = new GameObject[] { };

    void Awake()
    {
        Car.SetActive(false);
        RandomMap();
        RandomPattern();
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
        if(level ==0)
        {
            level = 1;
        }
        else
        {
            level = 0;
            Car.SetActive(false);
            RandomMap();
            RandomPattern();
            ReSet();
        }
    }

    void RandomMap()
    {
        float B = Random.Range(0, 3);
        if (B == 0)
        {
            StartCoroutine(MapOne());
        }
        else if (B == 1)
        {
            StartCoroutine(MapTwo());
        }
        else if (B == 2)
        {
            StartCoroutine(MapThree());
        }
    }
    void RandomPattern()
    {
        float A = Random.Range(0, 2);
        if (A == 0)
        {
            pattern1.SetActive(true);
            pattern2.SetActive(false);
        }
        else if (A == 1)
        {
            pattern1.SetActive(false);
            pattern2.SetActive(true);
        }
    }
    void RandomGod()
    {
        float A = Random.Range(0, 2);
        float B = Random.Range(0, 2);
        float C = Random.Range(0, 2);
        float D = Random.Range(0, 2);
        if(A ==0)
        {
            God1.SetActive(true);

        }
        else
        {
            God1.SetActive(false);
        }
        if (B == 0)
        {
            God2.SetActive(true);

        }
        else
        {
            God2.SetActive(false);
        }
        if (C == 0)
        {
            God3.SetActive(true);

        }
        else
        {
            God3.SetActive(false);
        }
        if (D == 0)
        {
            God4.SetActive(true);

        }
        else
        {
            God4.SetActive(false);
        }
    }

    IEnumerator MapOne()
    {
        Main.sprite = Seoul1;
        yield return new WaitForSeconds(CoolTime);
        Main.sprite = Seoul2;
        yield return new WaitForSeconds(CoolTime);
        StartCoroutine(MapOne());
    }
    IEnumerator MapTwo()
    {
        Main.sprite = Seoul3;
        yield return new WaitForSeconds(CoolTime);
        Main.sprite = Seoul4;
        yield return new WaitForSeconds(CoolTime);
        StartCoroutine(MapTwo());
    }
    IEnumerator MapThree()
    {
        Main.sprite = Seoul5;
        yield return new WaitForSeconds(CoolTime);
        Main.sprite = Seoul6;
        yield return new WaitForSeconds(CoolTime);
        StartCoroutine(MapThree());
    }

    IEnumerator ModeCheck()
    {
        distance = Vector3.Distance(Player.transform.position, transform.position);
        if (distance > Distance)
        {
            main.SetActive(false);
        }
        else
        {
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
