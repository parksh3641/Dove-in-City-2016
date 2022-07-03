using UnityEngine;
using System.Collections;

public class FollowCam : MonoBehaviour {
    public Transform Bird;
    public Transform Panel;

    public float x = 3.35f;
    public float y;
    public float BirdWhich;
    public float shake = 0.01f;
    private float SkillTime;
    private float CamCoolTime;
    public static float Cam = 1;
    private int Dove;

    private bool Shaking = false;
    private bool CamUp = false;
    private bool Die = false;

    private bool Under = false;
    private bool Castle = false;
    private bool castle = false;

    void Start () {
        Dove = PlayerPrefs.GetInt("Dove", 0);
        if(Dove ==0)
        {
            Bird = GameObject.FindGameObjectWithTag("Black").GetComponent<Transform>();
        }
        else if(Dove ==1)
        {
            Bird = GameObject.FindGameObjectWithTag("White").GetComponent<Transform>();
        }
        else if (Dove == 2)
        {
            Bird = GameObject.FindGameObjectWithTag("Eagle").GetComponent<Transform>();
        }
        else if (Dove == 3)
        {
            Bird = GameObject.FindGameObjectWithTag("Dori").GetComponent<Transform>();
        }
        SkillTime = GameManager.SkillTime;
        CamCoolTime = SkillTime * 0.5f;
    }

	void LateUpdate () {
        Camera.main.orthographicSize = Cam;
        Panel.transform.localScale = new Vector3(Cam, Cam, 1);
        if (Shaking == false)
        {
            if(castle == false)
            {
                transform.position = new Vector3(Bird.position.x, (Bird.position.y + BirdWhich), transform.position.z);
            }
            //transform.position = Bird.position - Vector3.forward;
        }
        if(Under == false)
        {
            if(Castle == false)
            {
                transform.position = new Vector3(Mathf.Clamp(transform.position.x, -x, x),Mathf.Clamp(transform.position.y, -y, y), 0);
            }
            else
            {
                transform.position = new Vector3(Mathf.Clamp(transform.position.x, -30.6f, -29.4f),Mathf.Clamp(transform.position.y, -y, y), 0);
            }
        }
        else
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -47.12f, -42.92f),Mathf.Clamp(transform.position.y, -y, y), 0);
        }
    }
    //외부에서 오는 입력 받는곳
    void OnEnable()
    {
        GameManager.PlayerDie += PlayerDie;
        GameManager.PlayerLive += PlayerLive;
        GameManager.FollowHit += HeartMinus;

        PlayerCtrl.CastleIn += CastleIn;
        PlayerCtrl.CastleOut += CastleOut;

        SkillCtrl.SkillUse += SkillUse;

        Talk.UnderWorld += UnderWorld;
        PlayerCtrl.UnderOut += UnderOut;
    }
    void OnDisable()
    {
        GameManager.PlayerDie -= PlayerDie;
        GameManager.PlayerLive -= PlayerLive;
        GameManager.FollowHit -= HeartMinus;

        PlayerCtrl.CastleIn -= CastleIn;
        PlayerCtrl.CastleOut -= CastleOut;

        SkillCtrl.SkillUse -= SkillUse;

        Talk.UnderWorld -= UnderWorld;
        PlayerCtrl.UnderOut -= UnderOut;
    }
    void PlayerDie()
    {
        CamUp = false;
        Die = true;
    }
    void PlayerLive()
    {
        Die = false;
    }

    void HeartMinus()
    {
        StartCoroutine(Shake());
    }

    void SkillUse()
    {
        StartCoroutine(CamCooltime());
    }

    void CastleIn()
    {
        StopAllCoroutines();
        Castle = true;
        castle = true;
        transform.position = new Vector3(-30, -1.5f, 0);
        StartCoroutine(CastleSettingA());
    }
    void CastleOut()
    {
        StopAllCoroutines();
        castle = true;
        StartCoroutine(CastleSettingB());
    }

    void UnderWorld()
    {
        Under = true;
    }
    void UnderOut()
    {
        StopAllCoroutines();
        castle = true;
        StartCoroutine(UnderSetting());
    }

    IEnumerator CastleSettingA() //들어올때
    {
        yield return new WaitForSeconds(1.05f);
        castle = false;
    }
    IEnumerator CastleSettingB() //나갈때
    {
        yield return new WaitForSeconds(2.0f);
        castle = false;
        Castle = false;
    }
    IEnumerator UnderSetting()
    {
        yield return new WaitForSeconds(2.0f);
        Under = false;
        castle = false;
    }
    IEnumerator Shake()
    {
        Shaking = true;
        transform.position = new Vector3(Bird.position.x + shake, (Bird.position.y + BirdWhich), transform.position.z);
        yield return new WaitForSeconds(shake*1.5f);
        transform.position = new Vector3(Bird.position.x - shake, (Bird.position.y + BirdWhich), transform.position.z);
        yield return new WaitForSeconds(shake*1.5f);
        transform.position = new Vector3(Bird.position.x + shake, (Bird.position.y + BirdWhich), transform.position.z);
        yield return new WaitForSeconds(shake*1.5f);
        transform.position = new Vector3(Bird.position.x - shake, (Bird.position.y + BirdWhich), transform.position.z);
        yield return new WaitForSeconds(shake*1.5f);
        Shaking = false;
    }
    IEnumerator CamCooltime()
    {
        CamUp = true;
        StartCoroutine(SkillCam());
        yield return new WaitForSeconds(CamCoolTime);
        CamUp = false;
    }
    IEnumerator SkillCam()
    {
        if(CamUp == true)
        {
            if(Cam <= 1.3f)
            {
                Cam += 0.001f;
                GameManager.movelimitx += 0.0006f;
            }
            yield return new WaitForSeconds(0.01f);
            StartCoroutine(SkillCam());
        }
        else
        {
            if (Die == false)
            {
                if (Cam > 1)
                {
                    Cam -= 0.001f;
                    GameManager.movelimitx -= 0.0006f;
                    yield return new WaitForSeconds(0.01f);
                    StartCoroutine(SkillCam());
                }
                else
                {
                    StopCoroutine(SkillCam());
                }
            }
            else
            {
                if (Cam > 1)
                {
                    Cam -= 0.002f;
                    GameManager.movelimitx -= 0.0012f;
                    yield return new WaitForSeconds(0.01f);
                    StartCoroutine(SkillCam());
                }
                else
                {
                    GameManager.movelimitx = 3.8f;
                    StopCoroutine(SkillCam());
                }
            }
        }
    }
}
