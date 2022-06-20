using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MiniManager : MonoBehaviour {
    public UILabel Cointxt;
    public UILabel Touchtxt;
    public UILabel Autotxt;
    public UILabel Flytxt;

    private int TouchNum;
    private int AutoNum;
    private int CoinNum;
    private float FlyNum;

    //업그레이드(터치)
    private int TouchLv;
    private int TouchCoin; //터치가격
    private int TouchUp; //터치업글시 터치코인증가량
    private int TouchCoinUp;//터치업글시 가격증가량

    public UILabel TouchLvtxt; //레벨표시
    public UILabel TouchCointxt; //가격표시
    public UILabel TouchUptxt; //증가량표시

    //구구 업글
    private int BlackLv;
    private int BlackCoin;
    private int BlackUp;
    private int BlackCoinUp;

    public UILabel BlackLvtxt;
    public UILabel BlackCointxt;
    public UILabel BlackUptxt;

    //비둘기구출값 저장
    private int WhiteExit;
    private int EagleExit;
    //업글해제값
    public GameObject WhiteLock;
    public GameObject EagleLock;
    //동료비둘기해제값
    public GameObject DoveEagleLock;

    //메뉴
    public GameObject First;
    public GameObject Second;

    //알림
    public GameObject NotionDoveOk;
    public GameObject NotionDoveNo;
    public GameObject NotionCoin;

    private AudioSource source;
    public AudioClip click;
    public AudioClip coin;

    void Awake()
    {
        source = GetComponent<AudioSource>();
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        First.SetActive(true);
        Second.SetActive(false);
        NotionDoveOk.SetActive(false);
        NotionDoveNo.SetActive(false);
        NotionCoin.SetActive(false);
        //임시 초기화
        FirstStart();

        TouchNum = PlayerPrefs.GetInt("TouchNum", 0);
        AutoNum = PlayerPrefs.GetInt("AutoNum", 0);
        CoinNum = PlayerPrefs.GetInt("CoinNum", 0);

        TouchLv = PlayerPrefs.GetInt("TouchLv", 0);
        TouchCheck(); //저장된값 불러오기
        TouchCoin = PlayerPrefs.GetInt("TouchCoin", 0);
        TouchUp = PlayerPrefs.GetInt("TouchUp", 0);
        TouchCoinUp = PlayerPrefs.GetInt("TouchCoinUp", 0);

        BlackLv = PlayerPrefs.GetInt("BlackLv", 0);
        BlackCoin = PlayerPrefs.GetInt("BlackCoin", 0);
        BlackUp = PlayerPrefs.GetInt("BlackUp", 0);
        BlackCoinUp = PlayerPrefs.GetInt("BlackCoinUp", 0);

        WhiteExit = PlayerPrefs.GetInt("WhiteExit", 0);
        EagleExit = PlayerPrefs.GetInt("EagleExit", 0);

        StartCoroutine(ModeCheck());
        StartCoroutine(AutoCheck());
        StartCoroutine(FlyCheck());
    }
    void FirstStart() //초기화시키기
    {
        PlayerPrefs.SetInt("TouchNum", 1);
        PlayerPrefs.SetInt("AutoNum", 0);
        PlayerPrefs.SetInt("CoinNum", 0);

        //터치업글 초기화
        PlayerPrefs.SetInt("TouchLv", 1);
        PlayerPrefs.SetInt("TouchCoin", 10);
        PlayerPrefs.SetInt("TouchUp", 2);
        PlayerPrefs.SetInt("TouchCoinUp", 1);

        //구구 초기화
        PlayerPrefs.SetInt("BlackLv", 1);
        PlayerPrefs.SetInt("BlackCoin", 100);
        PlayerPrefs.SetInt("BlackUp", 10);
        PlayerPrefs.SetInt("BlackCoinUp", 10);
    }

    IEnumerator ModeCheck()
    {
        Touchtxt.text = TouchNum.ToString() + "원/클릭";
        Autotxt.text = AutoNum.ToString() +"원/초";

        yield return new WaitForSeconds(0.1f);
        StartCoroutine(ModeCheck());
    }
    IEnumerator AutoCheck()
    {
        CoinNum += AutoNum;
        yield return new WaitForSeconds(1f);
        StartCoroutine(AutoCheck());
    }
    IEnumerator FlyCheck()
    {
        Flytxt.text = "날아간 거리 : " + FlyNum.ToString("N2") + " M";
        FlyNum += 0.01f;
        yield return new WaitForSeconds(0.1f);
        StartCoroutine(FlyCheck());
    }

    void Update()
    {
        Cointxt.text = CoinNum.ToString() + "원";

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(4);
        }
    }

    void TouchCheck()
    {
        //다시시작시 여기서 그의 맞는 값으로 대입
    }
    public void Click()
    {
        source.PlayOneShot(coin, 0.75f);
        CoinNum += TouchNum; 
    }

    public void TouchUpgrade()
    {
        source.PlayOneShot(click, 0.75f);
        if (CoinNum >= TouchCoin)
        {
            TouchLv += 1;
            PlayerPrefs.SetInt("TouchLv", TouchLv); //나중에 다시 시작할때 불러올 값 저장하기
            //표시
            TouchLvtxt.text = "터치 Lv" + TouchLv.ToString();

            CoinNum -= TouchCoin;

            TouchNum += TouchUp; //터치할시 값이 증가함
            TouchUp += 2; //다음업글시 터치값 증가량
            TouchCoin += TouchCoinUp; //다음업글시 가격 증가량

            TouchCointxt.text = "비용: " + (TouchCoin + TouchCoinUp).ToString();
            TouchUptxt.text = "+" + TouchUp.ToString() + "/클릭";

            TouchCoinUp += 10;
        }
    }
    public void BlackUpgrade()
    {
        source.PlayOneShot(click, 0.75f);
        if (CoinNum >= BlackCoin)
        {
            BlackLv += 1;
            PlayerPrefs.SetInt("BlackLv", BlackLv); //나중에 다시 시작할때 불러올 값 저장하기
            //표시
            BlackLvtxt.text = "구구 Lv" + BlackLv.ToString();

            CoinNum -= BlackCoin;

            AutoNum += BlackUp; //터치할시 값이 증가함
            BlackUp += 5; //다음업글시 터치값 증가량
            BlackCoin += BlackCoinUp; //다음업글시 가격 증가량

            BlackCointxt.text = "비용: " + (BlackCoin + BlackCoinUp).ToString();
            BlackUptxt.text = "+" + BlackUp.ToString() + "/초";

            BlackCoinUp += 50;
        }
    }

    public void FirstWindow()
    {
        source.PlayOneShot(click, 0.75f);
        First.SetActive(true);
        Second.SetActive(false);
    }
    public void SecondWindow()
    {
        source.PlayOneShot(click, 0.75f);
        First.SetActive(false);
        Second.SetActive(true);
    }

    //구출
    public void Whiteexit()
    {
        if(CoinNum >= 10000)
        {
            CoinNum -= 10000;
            float A = Random.Range(0, 2);
            if(A ==0)
            {
                WhiteExit = 1;
                PlayerPrefs.SetInt("WhiteExit", WhiteExit);
            }
            else
            {

            }
        }
        else
        {
            NotionCoin.SetActive(false);
            NotionCoin.SetActive(true);
        }
    }

    public void Exit()
    {
        SceneManager.LoadScene(4);
    }
}
