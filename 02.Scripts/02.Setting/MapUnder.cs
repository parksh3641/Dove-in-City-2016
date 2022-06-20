using UnityEngine;
using System.Collections;

public class MapUnder : MonoBehaviour {
    private Transform Player;
    private int Dove;

    public int A = 0;
    private int B = 0;

    public GameObject main;

    public GameObject Coin;

    private float distance;
    private float Distance;
    private float DistanceTime;

    public GameObject[] CoinObject = new GameObject[] { };

    void Awake()
    {
        Distance = GameManager.Distance;
        DistanceTime = GameManager.DistanceTime;

        CoinObject = GameObject.FindGameObjectsWithTag("Coin");
        ReSet();
        for (int i = 0; i < CoinObject.Length; i++)
        {
            CoinObject[i].GetComponent<BoxCollider2D>().size = new Vector2(0.75f, 0.75f);
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
        if (A == 1)
        {
            StartCoroutine(ModeCheck());
        }
    }
    IEnumerator ModeCheck()
    {
        distance = Vector3.Distance(Player.transform.position, transform.position);
        if (distance > 10)
        {
            main.SetActive(false);
            Coin.SetActive(false);
            B = 0;

        }
        else
        {
            main.SetActive(true);
            Coin.SetActive(true);
            if (B == 0)
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
    }
}
