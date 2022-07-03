using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MouseTouch : MonoBehaviour
{
    public GameObject Bird;
    private Transform A;

    private float Speed;
    private bool Die = false;
    private bool talk = false;
    private bool castle = false;

    private int posx = 360;
    private int posy = 640;

    private float movelimitx;

    void Start()
    {
        Speed = GameManager.Speed;
        Screen.SetResolution(posx, posy, true);
        A = Bird.transform;
    }
    //외부에서 오는 입력 받는곳
    void OnEnable()
    {
        GameManager.PlayerDie += PlayerDie;
        GameManager.GamePause += PlayerDie;
        GameManager.PlayerLive += PlayerLive;
        GameManager.TalkStart += TalkStart;

        SkillCtrl.Timeslip += PlayerDie;
        PlayerCtrl.TimeslipEnd += PlayerLive;

        PlayerCtrl.CastleIn += CastleIn;
        PlayerCtrl.CastleOut += CastleOut;
        PlayerCtrl.LevelUp += LevelUp;

        Talk.UnderWorld += CastleIn;
        PlayerCtrl.UnderOut += CastleOut;

        GodCtrl.TalkStart += TalkStart;
        Talk.TalkEnd += TalkEnd;
    }
    void OnDisable()
    {
        GameManager.PlayerDie -= PlayerDie;
        GameManager.GamePause -= PlayerDie;
        GameManager.PlayerLive -= PlayerLive;
        GameManager.TalkStart -= TalkStart;

        SkillCtrl.Timeslip -= PlayerDie;
        PlayerCtrl.TimeslipEnd -= PlayerLive;

        PlayerCtrl.CastleIn -= CastleIn;
        PlayerCtrl.CastleOut -= CastleOut;
        PlayerCtrl.LevelUp -= LevelUp;

        Talk.UnderWorld -= CastleIn;
        PlayerCtrl.UnderOut -= CastleOut;

        GodCtrl.TalkStart -= TalkStart;
        Talk.TalkEnd -= TalkEnd;
    }
    void CastleIn()
    {
        castle = true;
    }
    void CastleOut()
    {
        castle = false;
    }

    void LevelUp()
    {
        if(Speed < 1.0f)
        {
            Speed = Speed + (Speed * 0.02f);
        }
    }

    void TalkStart()
    {
        talk = true;
    }
    void TalkEnd()
    {
        talk = false;
    }

    void PlayerDie()
    {
        Die = true;
    }
    void PlayerLive()
    {
        Die = false;
    }

    void Update()
    {
        if (Die == false)
        {
            if(talk == false)
            {
                if (Input.touchCount > 0)
                {
                    Touch touch = Input.GetTouch(0);
                    Vector2 pos = touch.position;

                    //Debug.Log("x = " + pos.x + ", y = " + pos.y);

                    if (pos.y > posx * 0.2f) //맨 밑 20% 터치금지
                    {
                        if (pos.x >= posx * 0.5f) //오른쪽
                        {
                            if(castle == false)
                            {
                                A.transform.Translate(Speed * Time.deltaTime, 0, 0);
                            }
                            else
                            {
                                A.transform.Translate(0.7f * Time.deltaTime, 0, 0);
                            }
                        }
                        else //왼쪽
                        {
                            if (castle == false)
                            {
                                A.transform.Translate(-Speed * Time.deltaTime, 0, 0);
                            }
                            else
                            {
                                A.transform.Translate(-0.7f * Time.deltaTime, 0, 0);
                            }
                        }
                    }
                }
            }                  
        }
    }
}