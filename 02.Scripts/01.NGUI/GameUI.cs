using UnityEngine;
using System.Collections;

public class GameUI : MonoBehaviour {
    public UILabel txtScore;
    public Transform txtscore;

    public UILabel txtHigh;

    public GameObject HighNotion;

    private int totScore;
    private int A = 0;
    private int totMiter;
    private int HighScore;
    private int High;
    private float Raincount;
    private float RainCount = 80;
    private int rain =0;

    private float HackingTime = 0;
    private float FuckHackingTime = 0;
    private int Hacking = 0;

    private bool StopScore;
    private bool Castle = false;
    private bool talk = false;
    private bool pause = false;

    public float Cooltime = 0.2f;

    public delegate void Gameui();
    public static event Gameui RainStart,RainStop;

    void Awake () {

        totScore = 0;
        totMiter = 0;
        PlayerPrefs.SetInt("TOT_Score", totScore); //초기화시키고
        PlayerPrefs.SetInt("TOT_Miter", totMiter);

        HighScore = PlayerPrefs.GetInt("TOT_High", 0); //불러오고

        DispScore(0);
        DispHigh(0);

        HackingTime = GameManager.HackingTime;
        FuckHackingTime = GameManager.FuckHackingTime;

        StartCoroutine(Miter());
    }
    //외부에서 오는 입력 받는곳
    void OnEnable()
    {
        GameManager.PlayerDie += PlayerDie;
        GameManager.GamePause += GamePause;
        GameManager.PlayerLive += PlayerLive;

        PlayerCtrl.Score50 += Score50;
        PlayerCtrl.Score100 += Score100;

        BirdCtrl.Score50 += Score50;
        EagleCtrl.Score100 += Score100;

        PlayerCtrl.CastleIn += CastleIn;
        PlayerCtrl.CastleOut += CastleOut;
        PlayerCtrl.ManDuPlus += ManDuPlus;

        Talk.UnderWorld += CastleIn;
        PlayerCtrl.UnderOut += CastleOut;

        PlayerCtrl.LevelUp += LevelUp;

        SkillCtrl.Hack += Hack;
        SkillCtrl.FuckHack += FuckHack;
        SkillCtrl.weather += WeatherChange;

        PeopleCtrl.Candy += Candy;

        GodCtrl.TalkStart += TalkStart;
        GameManager.TalkStart += TalkStart;
        Talk.TalkEnd += TalkEnd;
    }
    void OnDisable()
    {
        GameManager.PlayerDie -= PlayerDie;
        GameManager.GamePause -= GamePause;
        GameManager.PlayerLive -= PlayerLive;

        PlayerCtrl.Score50 -= Score50;
        PlayerCtrl.Score100 -= Score100;

        BirdCtrl.Score50 -= Score50;
        EagleCtrl.Score100 -= Score100;

        PlayerCtrl.CastleIn -= CastleIn;
        PlayerCtrl.CastleOut -= CastleOut;
        PlayerCtrl.ManDuPlus -= ManDuPlus;

        Talk.UnderWorld -= CastleIn;
        PlayerCtrl.UnderOut -= CastleOut;

        PlayerCtrl.LevelUp += LevelUp;

        SkillCtrl.Hack -= Hack;
        SkillCtrl.FuckHack -= FuckHack;
        SkillCtrl.weather -= WeatherChange;

        PeopleCtrl.Candy -= Candy;

        GodCtrl.TalkStart -= TalkStart;
        GameManager.TalkStart -= TalkStart;
        Talk.TalkEnd -= TalkEnd;
    }
    void WeatherChange()
    {
        if(rain ==1)
        {
            rain = 0;
            RainStop();
        }
        else
        {
            rain = 1;
            RainStart();
        }
    }

    void LevelUp()
    {
        if(Cooltime >= 0.02f)
        {
            Cooltime -= 0.01f;
            RainCount = RainCount + (RainCount * 0.08f);
        }
    }

    void PlayerDie()
    {
        StopScore = true;
        Raincount = 0;
        Hacking = 0;
        StopAllCoroutines();
    }
    void PlayerLive()
    {
        StopScore = false;
        if(pause == false)
        {
            StartCoroutine(Miter());
        }
        pause = false;
    }

    void TalkStart()
    {
        talk = true;
    }
    void TalkEnd()
    {
        talk = false;
    }

    void GamePause()
    {
        StopScore = true;
        pause = true;
    }

    void Candy()
    {
        DispScore(10);
    }
    void ManDuPlus()
    {
        DispScore(5);
    }

    void Score50()
    {
        if(Hacking ==0)
        {
            DispScore(10);
        }
        else if(Hacking ==1)
        {
            DispScore(10 * 2);
        }
        else if (Hacking == 2)
        {
            DispScore(10 * 5);
        }
    }
    void Score100()
    {
        if (Hacking == 0)
        {
            DispScore(20);
        }
        else if (Hacking == 1)
        {
            DispScore(20 * 2);
        }
        else if (Hacking == 2)
        {
            DispScore(20 * 5);
        }
    }

    void CastleIn()
    {
        Castle = true;
    }
    void CastleOut()
    {
        Castle = false;
    }

    void Hack()
    {
        Hacking = 1;
        StartCoroutine(hackingtime());
    }
    void FuckHack()
    {
        Hacking = 2;
        StartCoroutine(Fuckhackingtime());
    }

    IEnumerator hackingtime()
    {
        yield return new WaitForSeconds(HackingTime);
        Hacking = 0;
    }
    IEnumerator Fuckhackingtime()
    {
        yield return new WaitForSeconds(FuckHackingTime);
        Hacking = 0;
    }

    public void DispScore(int score)
    {
        totScore += score;
        txtScore.text = totScore.ToString();
        if(A ==1)
        {
            txtHigh.text = totScore.ToString();
        }
    }
    public void DispMiter(int miter)
    {
        totMiter += miter;
    }
    public void DispHigh(int High)
    {
        High += HighScore;
        txtHigh.text = High.ToString();
    }
    public void DispRain(int Rain)
    {
        Raincount += Rain;
        if (Raincount > RainCount)
        {
            Raincount = 0;
            RandomRain();
        }
    }

    void RandomRain()
    {
        float A = Random.Range(0, 2);
        if (A == 0)
        {
            RainStop();
        }
        else
        {
            RainStart();
        }
    }

    IEnumerator Miter()
    {
        if(StopScore == false)
        {
            if(talk == false)
            {
                DispMiter(1);
                DispScore(1);
                if (Castle == false)
                {
                    DispRain(1);
                }
                PlayerPrefs.SetInt("TOT_Miter", totMiter);
                PlayerPrefs.SetInt("TOT_Score", totScore);
            }
        }

        if(totScore > HighScore)
        {
            if(HighScore ==0)
            {

            }
            else
            {
                if (A == 0)
                {
                    A = 1;
                    HighNotion.SetActive(true);
                    txtScore.color = new Color(255, 0, 0);
                    txtscore.transform.localPosition = new Vector3(-40, 299, 0);
                    txtscore.transform.localScale = new Vector3(1.5f, 1.5f, 1);
                }
            }
        }
        yield return new WaitForSeconds(Cooltime);
        StartCoroutine(Miter());
    }

    public void RainStartControl()
    {
        rain = 1;
        RainStart();
    }
    public void RainStopControl()
    {
        rain = 0;
        RainStop();
    }

    public void Score()
    {
        DispScore(100);
    }
}
