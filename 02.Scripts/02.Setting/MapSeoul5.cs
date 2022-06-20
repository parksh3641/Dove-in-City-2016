using UnityEngine;
using System.Collections;

public class MapSeoul5 : MonoBehaviour {
    private Transform Player;
    private int Dove;
    private int Check = 0;

    public int A = 0;
    public float cooltime = 0.8f;

    public GameObject main;
    public GameObject people;
    public SpriteRenderer Main;
    public GameObject Car;

    private float distance;
    private float Distance;
    private float DistanceTime;

    private int level = 0;

    public Sprite Seoul1;
    public Sprite Seoul2;

    public GameObject[] CarObject = new GameObject[] { };

    void Awake()
    {
        Car.SetActive(false);
        StartCoroutine(RandomMap());
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
        //PlayerCtrl.LevelUp += LevelUp;
        //GameManager.MapChange += LevelUp;
    }
    void OnDisable()
    {
        //PlayerCtrl.LevelUp -= LevelUp;
        //GameManager.MapChange -= LevelUp;
    }
    void LevelUp()
    {
        if (level == 0)
        {
            level = 1;
        }
        else
        {
            level = 0;
            ReSet();
        }
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
        if (distance > Distance)
        {
            people.SetActive(false);
        }
        else
        {
            people.SetActive(true);
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
