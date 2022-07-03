using UnityEngine;
using System.Collections;

public class MapCastle : MonoBehaviour {
    private Transform Player;
    private int Dove;

    public int A = 0;
    private int B = 0;
    private int C = 0;
    public float cooltime = 0.5f;

    public SpriteRenderer MainA;
    public SpriteRenderer MainB;
    public SpriteRenderer MainC;

    public GameObject mainA;
    public GameObject mainB;
    public GameObject mainC;

    public GameObject Coin;

    private float distance;
    private float Distance;
    private float DistanceTime;

    public Sprite Castle1;
    public Sprite Castle2;
    public Sprite Castle3;
    public Sprite Castle4;
    public Sprite Castle5;

    public GameObject oldpeople;
    public GameObject people;

    public GameObject[] CoinObject = new GameObject[] { };

    void Awake()
    {
        CoinObject = GameObject.FindGameObjectsWithTag("Coin");
        ReSet();
        for (int i = 0; i < CoinObject.Length; i++)
        {
            CoinObject[i].GetComponent<BoxCollider2D>().size = new Vector2(1, 1);
        }

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
        MainA.sprite = Castle1;
        MainB.sprite = Castle1;
        //MainC.sprite = Castle1;
        yield return new WaitForSeconds(cooltime);
        MainA.sprite = Castle2;
        MainB.sprite = Castle2;
        //MainC.sprite = Castle2;
        yield return new WaitForSeconds(cooltime);
        MainA.sprite = Castle3;
        MainB.sprite = Castle3;
        //MainC.sprite = Castle3;
        yield return new WaitForSeconds(cooltime);
        MainA.sprite = Castle4;
        MainB.sprite = Castle4;
        //MainC.sprite = Castle4;
        yield return new WaitForSeconds(cooltime);
        MainA.sprite = Castle5;
        MainB.sprite = Castle5;
        //MainC.sprite = Castle5;
        yield return new WaitForSeconds(cooltime);
        StartCoroutine(RandomMap());
    }

    IEnumerator ModeCheck()
    {
        distance = Vector3.Distance(Player.transform.position, transform.position);
        //Debug.Log(distance.ToString());
        if (distance > 10)
        {
            mainA.SetActive(false);
            mainB.SetActive(false);
            //mainC.SetActive(false);
            Coin.SetActive(false);
            B = 0;

        }
        else
        {
            mainA.SetActive(true);
            mainB.SetActive(true);
            //mainC.SetActive(true);
            Coin.SetActive(true);
            if(B ==0)
            {
                B = 1;
                ReSet();
            }
        }
        yield return new WaitForSeconds(DistanceTime);
        StartCoroutine(ModeCheck());
    }
    void ReSet()
    {
        for (int i = 0; i < CoinObject.Length; i++)
        {
            CoinObject[i].SetActive(true);
            CoinObject[i].GetComponent<BoxCollider2D>().size = new Vector2(1, 1);
        }
        C = Random.Range(0, 2);
        if(C == 0)
        {
            people.SetActive(true);
            oldpeople.SetActive(true);
        }
        else if(C == 1)
        {
            people.SetActive(true);
            oldpeople.SetActive(false);
        }
        else if(C == 2)
        {
            people.SetActive(false);
            oldpeople.SetActive(true);
        }
    }
}
