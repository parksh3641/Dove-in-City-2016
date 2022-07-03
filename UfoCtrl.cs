using UnityEngine;
using System.Collections;

public class UfoCtrl : MonoBehaviour {

    public FollowCtrl Speed;
    public GameObject Beam;
    public Transform beam;
    public EdgeCollider2D edge;

    public Transform Player;

    private int Dove;
    private float x = 0.2f;
    private float distance;

    private bool Come = false;
    private bool Die = false;
    private bool Go = false;

    public float A = 0.015f;

    void Awake()
    {
        Speed = GetComponent<FollowCtrl>();

        beam.localScale = new Vector3(x, 1.0f, 1.0f);
        Beam.SetActive(false);
        edge.enabled = false;
    }
    void Start()
    {
    }
    void OnEnable()
    {
        GameManager.PlayerDie += PlayerDie;
        GameManager.GamePause += PlayerDie;
        GameManager.PlayerLive += PlayerLive;

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
        StartCoroutine(ModeCheck());
    }
    void OnDisable()
    {
        GameManager.PlayerDie -= PlayerDie;
        GameManager.GamePause -= PlayerDie;
        GameManager.PlayerLive -= PlayerLive;

        Go = false;
        x = 0.2f;
        Come = false;
        beam.localScale = new Vector3(x, 1.0f, 1.0f);
        Beam.SetActive(false);
        edge.enabled = false;

        StopAllCoroutines();
    }
    void PlayerDie()
    {
        Speed.Speed = 0;
    }
    void PlayerLive()
    {
        Speed.Speed = 1.5f;
    }
    void Update()
    {
        if(Go == true)
        {
            beam.localScale = new Vector3(x, 1.0f, 1.0f);
        }
    }
    IEnumerator ModeCheck()
    {
        distance = Vector3.Distance(Player.transform.position, transform.position);
        if (Die == false)
        {
            if (distance < 2f)
            {
                if (Come == false)
                {
                    //Debug.Log("접근");
                    Come = true;
                    Go = true;
                    Beam.SetActive(true);
                    StopAllCoroutines();
                    StartCoroutine(GoBeam());
                }
            }
        }
        yield return new WaitForSeconds(0.2f);
        StartCoroutine(ModeCheck());
    }
    IEnumerator GoBeam()
    {
        if(x < 1)
        {
            x += A;
        }
        else
        {
            edge.enabled = true;
            yield return new WaitForSeconds(3f);
            Go = false;
            x = 0.2f;
            Beam.SetActive(false);
            StopAllCoroutines();
            StartCoroutine(ModeCheck());
            Come = false;
        }
        yield return new WaitForSeconds(0.01f);
        StartCoroutine(GoBeam());
    }

    public void Enter()
    {
        Go = true;
        Beam.SetActive(true);
        StartCoroutine(GoBeam());
    }
}
