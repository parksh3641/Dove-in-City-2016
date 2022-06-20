using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class TutorialManager : MonoBehaviour {
    //대화
    public UILabel Talktxt;
    public Transform Talkbar;
    public GameObject Nextbar;
    private int TalkNumber = 0; //대화진전도
    public GameObject Vector;

    public GameObject MainUI;
    public GameObject SurUI;
    //선택하기
    public GameObject black;
    public GameObject white;
    public GameObject Yes;
    public GameObject No;
    public GameObject Right;
    public GameObject Left;
    private int Choice = 0;

    private int Dove;
    private int QuestNumber;

    //퀘스트바
    public GameObject Questbar;
    public UILabel Questtxt; //목표
    public UILabel Questing; //진행도
    private int CandyNum;
    private int ManDuNum;
    private int Tutorial;

    //선택시 생김
    public GameObject Black;
    public GameObject White;

    //일시정지
    public GameObject Pause;
    public GameObject Pausebtn;

    //외부
    public TutorialCam cam;

    //시작
    public GameObject Three;
    public GameObject Two;
    public GameObject One;
    public GameObject Go;

    //올리브
    private bool A = false;
    private int olive = 0;
    public GameObject Olive;
    public UILabel OliveLabel;
    public Transform Player;

    //스킬
    public UISprite skillFilter;
    public UILabel coolTimeCounter;
    private bool canUseSkill = false;
    private float CoolTime = 10;
    private float ResetTime = 10;
    private float currentCoolTime = 10;
    private int skilluse;

    private AudioSource source;
    public AudioClip Click;
    public AudioClip Coin;
    public AudioClip PowerUp;
    public AudioClip Boast;
    public AudioClip OliveHit;
    public AudioClip Oha;

    public GameObject PeopleNotion;
    public GameObject OliveNotion;
    public GameObject BlackNotion;
    public GameObject WhiteNotion;

    //아이템사용
    public UISprite Itembar;
    public UISprite Hpbar;
    private int ItemNumber = 0;

    public delegate void tutorialmanager();
    public static event tutorialmanager go , stop, SkillUse;

    void Awake()
    {
        source = GetComponent<AudioSource>();
        Time.timeScale = 1;
        Tutorial = PlayerPrefs.GetInt("Tutorial", 0);
        QuestNumber = PlayerPrefs.GetInt("QuestNumber", 0);

        skilluse = 0;

        MainUI.SetActive(false);
        Vector.SetActive(false);
        SurUI.SetActive(true);
        Talktxt.text = "튜토리얼에 진입하였습니다.\n\n\n";

        black.SetActive(false);
        white.SetActive(false);
        Yes.SetActive(false);
        No.SetActive(false);
        Right.SetActive(false);
        Left.SetActive(false);

        Three.SetActive(false);
        Two.SetActive(false);
        One.SetActive(false);
        Go.SetActive(false);

        Questbar.SetActive(false);
        Pause.SetActive(false);
        if (Tutorial == 0)
        {
            Pausebtn.SetActive(false);
        }
        else
        {
            Pausebtn.SetActive(true);
        }

        skillFilter.enabled = false;

        OliveNotion.SetActive(false);
        PeopleNotion.SetActive(false);

    }
    void Start()
    {
        Black.SetActive(false);
        White.SetActive(false);
    }
    void OnEnable()
    {
        TutorialPeople.Candy += Candy;
        TutorialCtrl.ManDu += ManDu;
        TutorialCtrl.OliveTreeIn += OliveTreeIn;
        TutorialCtrl.OliveTreeOut += OliveTreeOut;
        TutorialCtrl.OliveSkill += OliveSkill;
        TutorialCtrl.PeopleSkill += PeopleSkill;
    }
    void OnDisable()
    {
        TutorialPeople.Candy -= Candy;
        TutorialCtrl.ManDu -= ManDu;
        TutorialCtrl.OliveTreeIn -= OliveTreeIn;
        TutorialCtrl.OliveTreeOut -= OliveTreeOut;
        TutorialCtrl.OliveSkill -= OliveSkill;
        TutorialCtrl.PeopleSkill -= PeopleSkill;
    }
    void OliveTreeIn()
    {
        source.PlayOneShot(OliveHit, 0.75f);
    }
    void OliveTreeOut()
    {
        StartCoroutine(Oliveuse());
    }
    void Candy()
    {
        source.PlayOneShot(Coin, 0.75f);
        CandyNum += 1;
        Questing.text = "진행도 : " + CandyNum.ToString() + " / 5";
        if(CandyNum >= 5)
        {
            skilluse = 1;
            stop();
            SurUI.SetActive(true);
            Questing.text = "진행도 : 달성!";
            if (Tutorial ==0)
            {
                Talktxt.text = "\n퀘스트 완료\n\n";
            }
            else
            {
                Talktxt.text = "퀘스트 완료\n튜토리얼을 종료합니다.\n\n";
            }
        }
    }
    void ManDu()
    {
        source.PlayOneShot(Coin, 0.75f);
        ManDuNum += 1;
        Questing.text = "진행도 : " + ManDuNum.ToString() + " / 5";
        if (ManDuNum >= 5)
        {
            skilluse = 1;
            stop();
            SurUI.SetActive(true);
            Questing.text = "진행도 : 달성!";
            if (Tutorial == 0)
            {
                Talktxt.text = "\n퀘스트 완료\n\n";
            }
            else
            {
                Talktxt.text = "\n퀘스트 완료\n튜토리얼을 종료합니다.\n";
            }
        }
    }

    void OliveSkill()
    {
        source.PlayOneShot(Oha, 0.75f);
        OliveNotion.SetActive(false);
        OliveNotion.SetActive(true);
    }
    void PeopleSkill()
    {
        source.PlayOneShot(Oha, 0.75f);
        PeopleNotion.SetActive(false);
        PeopleNotion.SetActive(true);
    }

    public void Nextbtn()
    {
        source.PlayOneShot(Click, 0.75f);
        if (TalkNumber == 0)
        {
            TalkNumber = 1;
            Talktxt.text = "기본 적인 게임 플레이 방법을 배웁니다.\n\n\n";
        }
        else if (TalkNumber == 1)
        {
            TalkNumber = 2;
            Talktxt.text = "플레이 할 비둘기를 선택하세요.\n\n\n";
            black.SetActive(true);
            white.SetActive(true);
            Nextbar.SetActive(false);
        }
        else if (TalkNumber == 2)
        {
            TalkNumber = 4;
            Talktxt.text = "비둘기 선택은 메인화면 앨범에서\n언제든지 변경할 수 있습니다.\n\n";
        }
        else if (TalkNumber == 4)
        {
            TalkNumber = 5;
            Talktxt.text = "도심에서 살아가는 비둘기의 애환을\n체험하는 게임입니다.\n\n";
        }
        else if (TalkNumber == 5)
        {
            TalkNumber = 7;
            if (Choice == 0)
            {
                Talktxt.text = "구구는 어린아이의\n 사탕을 빼앗아 먹으며 생존합니다.\n어두운 날에만 흰 비둘기를\n잡아먹습니다.";
            }
            else
            {
                Talktxt.text = "루루가 나뭇가지를 들면\n사람들이 만두를 던져줍니다.\n맑은 날에만 검은 비둘기를\n잡아먹습니다. ";
            }
        }
        else if (TalkNumber == 7)
        {
            TalkNumber = 8;
            Talktxt.text = "\n왼쪽 터치시 왼쪽으로\n오른쪽 터치시 오른쪽으로\n이동합니다.";
            MainUI.SetActive(true);
            Talkbar.localPosition = new Vector3(0, 150, 0);
            Right.SetActive(true);
            Left.SetActive(true);
        }
        else if (TalkNumber == 8)
        {
            TalkNumber = 9;
            Talktxt.text = "\n시간이 경과되면 하트가 줄어듭니다.\n장애물을 피하고 먹이를 구해\n살아남아야 합니다.";
            Vector.SetActive(true);
            Vector.transform.localPosition = new Vector3(0, -255, 0);
            Right.SetActive(false);
            Left.SetActive(false);
        }
        else if (TalkNumber == 9)
        {
            TalkNumber = 10;
            Talktxt.text = "오른쪽 하단은 높이날기 스킬입니다.\n10초동안 1.5배의 속도로\n높은 고도를 날게 되며 지상에 있는\n사물들로부터 영향을 받지 않습니다.";
            Vector.transform.localPosition = new Vector3(130, -225, 0);
        }
        else if (TalkNumber == 10)
        {
            TalkNumber = 11;
            Talktxt.text = "\n왼쪽 하단에서\n착용 한 아이템을 사용합니다.\n";
            Vector.transform.localPosition = new Vector3(-120, -225, 0);
        }
        else if (TalkNumber == 11)
        {
            TalkNumber = 12;
            Talktxt.text = "\n퀘스트를 받았습니다.\n모험이 시작됩니다.\n";
            Questbar.SetActive(true);
            Vector.SetActive(false);
            if (Choice == 0)
            {
                Questtxt.text = "아이 사탕 5개 빼앗아먹기";
                Questing.text = "진행도 : " + CandyNum.ToString() + " / 5";
            }
            else
            {
                Questtxt.text = "만두 5개 받아먹기";
                Questing.text = "진행도 : " + ManDuNum.ToString() + " / 5";
            }
        }
        else if (TalkNumber == 12)
        {
            TalkNumber = 13;
            SurUI.SetActive(false);
            StartCoroutine(StartGame());
        }
        else if (TalkNumber == 13)
        {
            if(Tutorial == 0)
            {
                QuestNumber = 1;
                PlayerPrefs.SetInt("QuestNumber", QuestNumber);
            }
            PlayerPrefs.SetString("Scene", "MainScene");
            SceneManager.LoadScene("LoadScene");
        }
    }
    public void BlackChoice()
    {
        source.PlayOneShot(Click, 0.75f);
        Talktxt.text = "구구로 하시겠습니까?\n\n\n";
        Choice = 0;
        Yes.SetActive(false);
        No.SetActive(false);
        Yes.SetActive(true);
        No.SetActive(true);
    }
    public void WhiteChoice()
    {
        source.PlayOneShot(Click, 0.75f);
        Talktxt.text = "루루로 하시겠습니까?\n\n\n";
        Choice = 1;
        Yes.SetActive(false);
        No.SetActive(false);
        Yes.SetActive(true);
        No.SetActive(true);
    }
    public void YesBtn()
    {
        source.PlayOneShot(Coin, 0.75f);
        black.SetActive(false);
        white.SetActive(false);
        Yes.SetActive(false);
        No.SetActive(false);
        Nextbar.SetActive(true);
        if (Choice ==0)
        {
            Black.SetActive(true);
            cam.BirdCheck(0);
            Talktxt.text = "구구를 선택하셨습니다.\n\n\n";
            Dove = 0;
            PlayerPrefs.SetInt("Dove", Dove);
            Player = GameObject.FindWithTag("Black").GetComponent<Transform>();
        }
        else
        {
            White.SetActive(true);
            cam.BirdCheck(1);
            Talktxt.text = "루루를 선택하셨습니다.\n\n\n";
            Dove = 1;
            PlayerPrefs.SetInt("Dove", Dove);
            Player = GameObject.FindWithTag("White").GetComponent<Transform>();
        }
    }
    public void NoBtn()
    {
        source.PlayOneShot(Click, 0.75f);
        Talktxt.text = "플레이 할 비둘기를 선택하세요.\n\n\n";
        Yes.SetActive(false);
        No.SetActive(false);
    }
    public void pause()
    {
        source.PlayOneShot(Click, 0.75f);
        Pause.SetActive(true);
        source.Pause();
        Time.timeScale = 0;
    }
    public void pauseYes()
    {
        source.PlayOneShot(Click, 0.75f);
        Pause.SetActive(false);
        Time.timeScale = 1;
        source.UnPause();
    }
    public void pauseNo()
    {
        Time.timeScale = 1;
        PlayerPrefs.SetString("Scene", "MainScene");
        SceneManager.LoadScene("LoadScene");
    }

    void Update()
    {
        if (A == true)
        {
            if (Player.position.x >= 1.8f)
            {
                olive = 1;
            }
            else if (Player.position.x <= -1.8f)
            {
                olive = 2;
            }
            else
            {
                olive = 0;
            }

            if (Player.position.x > 0)
            {
                if (olive == 0)
                {
                    Olive.transform.localPosition = new Vector3(0, -20, 0);
                }
                else if (olive == 1)
                {
                    Olive.transform.localPosition = new Vector3((Player.position.x - 1.8f) * 315, -20, 0);
                }
            }
            else
            {
                if (olive == 0)
                {
                    Olive.transform.localPosition = new Vector3(0, -20, 0);
                }
                else if (olive == 2)
                {
                    Olive.transform.localPosition = new Vector3((Player.position.x + 1.8f) * 315, -20, 0);
                }
            }
        }
    }

    IEnumerator StartGame()
    {
        Three.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Three.SetActive(false);
        Two.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Two.SetActive(false);
        One.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        One.SetActive(false);
        Go.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Go.SetActive(false);

        canUseSkill = true;
        ItemNumber = 1;
        go();
        yield return new WaitForSeconds(1.5f);
        if(Dove ==0)
        {
            BlackNotion.SetActive(true);
        }
        else if(Dove ==1)
        {
            WhiteNotion.SetActive(true);
        }
    }

    public void UseSkill()
    {
        if (skilluse == 0)
        {
            if (canUseSkill == true)
            {
                SkillUse();
                skillFilter.enabled = true;
                skillFilter.fillAmount = 1;
                StartCoroutine(Cooltime());
                StartCoroutine(Skilluse());
                canUseSkill = false;
                PlayerPrefs.SetInt("TutorialSkill", 1);
            }
        }
    }
    IEnumerator Skilluse()
    {
        source.PlayOneShot(PowerUp, 0.75f);
        yield return new WaitForSeconds(2f);
        source.PlayOneShot(Boast, 0.75f);
    }
    IEnumerator Cooltime()
    {
        while (skillFilter.fillAmount > 0)
        {
            skillFilter.fillAmount -= 1 * Time.smoothDeltaTime / CoolTime;

            yield return null;
        }
        PlayerPrefs.SetInt("TutorialSkill", 0);
        ResetTime = 10;
        currentCoolTime = 10;
        StartCoroutine(SkillReset());
        StartCoroutine(CoolTimeCounter());
        yield break;
    }
    IEnumerator SkillReset()
    {
        while (skillFilter.fillAmount < 1)
        {
            skillFilter.fillAmount += 1 * Time.smoothDeltaTime / ResetTime;

            yield return null;

        }
        canUseSkill = true;
        skillFilter.enabled = false;
    }
    IEnumerator CoolTimeCounter()
    {
        if (currentCoolTime > 0)
        {
            currentCoolTime -= 1;
            coolTimeCounter.text = currentCoolTime.ToString();

            yield return new WaitForSeconds(1f);
            StartCoroutine(CoolTimeCounter());
        }
        else
        {
            coolTimeCounter.text = " ";
            StopCoroutine(CoolTimeCounter());
        }
    }

    IEnumerator Oliveuse()
    {
        Olive.SetActive(true);
        A = true;
        OliveLabel.text = "5";
        yield return new WaitForSeconds(1f);
        OliveLabel.text = "4";
        yield return new WaitForSeconds(1f);
        OliveLabel.text = "3";
        yield return new WaitForSeconds(1f);
        OliveLabel.text = "2";
        yield return new WaitForSeconds(1f);
        OliveLabel.text = "1";
        yield return new WaitForSeconds(1f);
        OliveLabel.text = "0";
        yield return new WaitForSeconds(0.1f);
        A = false;
        Olive.SetActive(false);
    }

    public void ItemUse()
    {
        if (ItemNumber == 1)
        {
            source.PlayOneShot(Coin, 0.75f);
            ItemNumber = 0;
            Itembar.enabled = false;
            Hpbar.fillAmount = 1.0f;
        }
    }
}
