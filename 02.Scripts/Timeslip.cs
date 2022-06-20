using UnityEngine;
using System.Collections;

public class Timeslip : MonoBehaviour {
    public Transform Player;

    public GameObject Target;

    public float Speed = 0.1f;

    private float TimingTime;
    private bool time = false;
    private bool Die = false;
    private bool talk = false;
    private int Stop = 0;

    void Start()
    {
        Speed = GameManager.bgspeed;
        TimingTime = GameManager.TimingTime;
        StartCoroutine(Wait());
    }
    void OnEnable()
    {
        SkillCtrl.Timeslip += TimeStart;
        PlayerCtrl.TimeslipEnd += TimeEnd;

        GodCtrl.TalkStart += TalkStart;
        Talk.TalkEnd += TalkEnd;

        GameManager.TalkStart += TalkStart;
        GameManager.PlayerDie += PlayerDie;
        GameManager.PlayerLive += PlayerLive;
    }
    void OnDisable()
    {
        SkillCtrl.Timeslip -= TimeStart;
        PlayerCtrl.TimeslipEnd -= TimeEnd;

        GodCtrl.TalkStart -= TalkStart;
        Talk.TalkEnd -= TalkEnd;

        GameManager.TalkStart -= TalkStart;
        GameManager.PlayerDie -= PlayerDie;
        GameManager.PlayerLive -= PlayerLive;
    }
    void TalkStart()
    {
        talk = true;
    }
    void TalkEnd()
    {
        talk = false;
    }

    void TimeStart()
    {
        time = false;
        StopAllCoroutines();
    }
    void TimeEnd()
    {
        StartCoroutine(Wait()); 
    }

    void PlayerDie()
    {
        Die = true;
    }
    void PlayerLive()
    {
        Die = false;
        if(Stop ==1)
        {
            StartCoroutine(ModeCheck());
        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(TimingTime - 1f);
        if(Die == false)
        {
            StartCoroutine(ModeCheck());
        }
        else
        {
            Stop = 1;
        }
    }
    IEnumerator ModeCheck()
    {
        if(Die == false)
        {
            if (talk == false)
            {
                Player = GameObject.FindGameObjectWithTag("Pos").GetComponent<Transform>();
                time = true;
            }
        }
        yield return new WaitForSeconds(1f);
        StartCoroutine(ModeCheck());
    }
    void Update()
    {
        if(Die == false)
        {
            if(talk == false)
            {
                if (time == true)
                {
                    transform.position = Vector3.MoveTowards(transform.position, Player.position, Speed);
                }
            }
        }
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag =="Pos")
        {
            coll.gameObject.SetActive(false);
            time = false;
        }
    }
}
