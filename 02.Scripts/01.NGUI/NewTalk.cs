using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NewTalk : MonoBehaviour
{
    public UILabel DoveMsg;
    public UILabel DoveStateMsg;
    public UILabel LikeabilityMsg;
    public UILabel TalkClearMsg;
    public UILabel Unittxt;
    public UILabel BDtxt;
    public UILabel DoveName;

    public UISprite Likeabilitybar;

    public UILabel One;
    public UILabel Two;
    public UILabel Three;

    public GameObject TalkClear;

    public GameObject Notionlikeab;

    private int Dove;
    private int UNIT;
    private int SHRIMP;
    private int Likeability;
    private int screen =0;

    private int Mmute;
    private int Emute;
    //대화진전도 수치
    private int TalkValue; //0~17 현재 //18~ 과거 // ~미래
    //비둘기상태 수치
    private int DoveState;
    //호감도변화 수치
    private int Likestate;
    private int Like = 1;

    private AudioSource source;
    private AudioSource MainSource;
    public AudioClip Click;
    public AudioClip Coin;

    void Awake()
    {
        source = GetComponent<AudioSource>();
        MainSource = GameObject.Find("MainSong").GetComponent<AudioSource>();
        Notionlikeab.SetActive(false);

        TalkClear.SetActive(false);

        Dove = PlayerPrefs.GetInt("Dove", 0);
        if(Dove == 4)
        {
            DoveName.text = "알파 (5세)\n최초의비둘기";
            Dove = 0;
        }
        UNIT = PlayerPrefs.GetInt("UNIT", 0);
        SHRIMP = PlayerPrefs.GetInt("SHRIMP", 0);
        Mmute = PlayerPrefs.GetInt("Mmute", 0);
        Emute = PlayerPrefs.GetInt("Emute", 0);
        if(Mmute ==1)
        {
            source.enabled = false;
        }
        if(Emute ==1)
        {
            MainSource.enabled = false;
        }
        Likeability = 0;
        PlayerPrefs.SetInt("Likeability", Likeability);

        StartCoroutine(ModeCheck());
        StartTalk();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PlayerPrefs.SetString("Scene", "MainScene");
            SceneManager.LoadScene("LoadScene");
        }
    }
    IEnumerator ModeCheck()
    {
        Likeability = PlayerPrefs.GetInt("Likeability", 0);
        LikeabilityMsg.text = Likeability.ToString() + "/100";
        Likeabilitybar.fillAmount = Likeability * 0.01f;

        UNIT = PlayerPrefs.GetInt("UNIT", 0);
        SHRIMP = PlayerPrefs.GetInt("SHRIMP", 0);

        Unittxt.text = UNIT.ToString();
        BDtxt.text = SHRIMP.ToString();

        if(Likeability > 100)
        {
            Likeability = 100;
        }

        if (DoveState == 0)
        {
            DoveStateMsg.text = "비둘기상태 : 보통";
        }
        else if (DoveState == 1)
        {
            DoveStateMsg.text = "비둘기상태 : 좋음";
        }
        else if (DoveState == 2)
        {
            DoveStateMsg.text = "비둘기상태 : 화남";
        }
        else if (DoveState == 3)
        {
            DoveStateMsg.text = "비둘기상태 : 우울";
        }
        else if (DoveState == 4)
        {
            DoveStateMsg.text = "비둘기상태 : 호기심";
        }
        else if (DoveState == 5)
        {
            DoveStateMsg.text = "비둘기상태 : 기쁨";
        }
        else if (DoveState == 6)
        {
            DoveStateMsg.text = "비둘기상태 : 혼란";
        }
        else if (DoveState == 7)
        {
            DoveStateMsg.text = "비둘기상태 : 기대";
        }
        else if (DoveState == 8)
        {
            DoveStateMsg.text = "비둘기상태 : 간절";
        }
        else if (DoveState == 9)
        {
            DoveStateMsg.text = "비둘기상태 : 엄격 진지";
        }
        else if (DoveState == 10)
        {
            DoveStateMsg.text = "비둘기상태 : 엄격 진지 근엄";
        }
        else if (DoveState == 11)
        {
            DoveStateMsg.text = "비둘기상태 : 우월";
        }
        else if (DoveState == 12)
        {
            DoveStateMsg.text = "비둘기상태 : 현학적";
        }
        else if (DoveState == 13)
        {
            DoveStateMsg.text = "비둘기상태 : 약간 동정";
        }
        else if (DoveState == 14)
        {
            DoveStateMsg.text = "비둘기상태 : 근엄";
        }
        else if (DoveState == 15)
        {
            DoveStateMsg.text = "비둘기상태 : 더 화난";
        }
        else if (DoveState == 16)
        {
            DoveStateMsg.text = "비둘기상태 : 도발";
        }
        else if (DoveState == 17)
        {
            DoveStateMsg.text = "비둘기상태 : 부끄";
        }
        else if (DoveState == 18)
        {
            DoveStateMsg.text = "비둘기상태 : 위선적";
        }
        else if (DoveState == 19)
        {
            DoveStateMsg.text = "비둘기상태 : 빙의";
        }

        yield return new WaitForSeconds(0.1f);
        StartCoroutine(ModeCheck());
    }
    void StartTalk()
    {
        //초기화
        TalkClear.SetActive(false);
        TalkValue = 0;
        screen = 0;
        One.text = "\n현재에 대해 묻는다\n";
        Two.text = "\n과거에 대해 묻는다\n";
        Three.text = "\n미래에 대해 묻는다\n";

        if (Dove == 0)
        {
            if (Likeability <= 50)
            {
                DoveState = 0;
                DoveMsg.text = "\n\n안녕! 반가워!\n\n";
            }
        }
    }
    void LikeState()
    {
        screen = 1;
        One.text = " ";
        Two.text = " ";
        Three.text = " ";
        source.PlayOneShot(Coin, 0.75f);
        if (Likestate == 0) //호감도 1증가
        {
            if (Likeability < 100)
            {
                Likeability += Like;
                PlayerPrefs.SetInt("Likeability", Likeability);
            }
            else
            {
                Likeability = 100;
                PlayerPrefs.SetInt("Likeability", Likeability);
            }
            TalkClearMsg.text = "호감도 " + Like.ToString() + " 증가!";
        }
        else if(Likestate ==1) //호감도 1감소
        {
            if (Likeability > 0)
            {
                Likeability -= Like;
                PlayerPrefs.SetInt("Likeability", Likeability);
            }
            else
            {
                Likeability = 0;
                PlayerPrefs.SetInt("Likeability", Likeability);
            }
            TalkClearMsg.text = "호감도 " + Like.ToString() + " 감소!";
        }
        else if (Likestate == 2) //유닛500감소
        {
            if (UNIT >= 500)
            {
                UNIT -= (Like*500);
                PlayerPrefs.SetInt("UNIT", UNIT);
            }
            else
            {
                UNIT = 0;
                PlayerPrefs.SetInt("UNIT", UNIT);
            }
            TalkClearMsg.text = "UNIT " + (Like * 500).ToString() + " 감소!";
        }
        else if (Likestate == 3) //호감도 10증가
        {
            if (Likeability < 100)
            {
                Likeability += Like*10;
                PlayerPrefs.SetInt("Likeability", Likeability);
            }
            else
            {
                Likeability = 100;
                PlayerPrefs.SetInt("Likeability", Likeability);
            }
            TalkClearMsg.text = "호감도 " + (Like * 10).ToString() + " 증가!";
        }
        else if (Likestate == 4) //호감도 2증가
        {
            if (Likeability < 100)
            {
                Likeability += Like * 2;
                PlayerPrefs.SetInt("Likeability", Likeability);
            }
            else
            {
                Likeability = 100;
                PlayerPrefs.SetInt("Likeability", Likeability);
            }
            TalkClearMsg.text = "호감도 " + (Like * 2).ToString() + " 증가!";
        }
        else if(Likestate ==5)
        {
            if(SHRIMP >= 1)
            {
                SHRIMP -= 1;
                PlayerPrefs.SetInt("SHRIMP", SHRIMP);
                if (Likeability < 100)
                {
                    Likeability += Like * 10;
                    PlayerPrefs.SetInt("Likeability", Likeability);
                }
                else
                {
                    Likeability = 100;
                    PlayerPrefs.SetInt("Likeability", Likeability);
                }
                TalkClearMsg.text = "호감도 " + (Like * 10).ToString() + " 증가!";
            }
            else
            {
                TalkClearMsg.text = "새우깡이 없습니다!";
            }
        }
        else if (Likestate == 6) //호감도 2감소
        {
            if (Likeability > 0)
            {
                Likeability -= Like*2;
                PlayerPrefs.SetInt("Likeability", Likeability);
            }
            else
            {
                Likeability = 0;
                PlayerPrefs.SetInt("Likeability", Likeability);
            }
            TalkClearMsg.text = "호감도 " + (Like*2).ToString() + " 감소!";
        }
    }
    //대화 끝나고 나오는 상자 종료버튼
    public void Clear()
    {
        source.PlayOneShot(Click, 0.75f);
        StartTalk();
    }
    public void Exit()
    {
        PlayerPrefs.SetString("Scene", "MainScene");
        SceneManager.LoadScene("LoadScene");
    }
    public void OneBtn() //현재
    {
        if (screen == 0)
        {
            source.PlayOneShot(Click, 0.75f);
            if (TalkValue == 0)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 3;
                        DoveMsg.text = "\n\n배고파\n\n";
                        One.text = "\n그럼 치킨 먹을래?\n";
                        Two.text = "\n배고프면 먹이를 찾으면 되지!\n";
                        Three.text = "\n나도 배고파\n";
                        TalkValue = 1;
                    }
                }
            }
            else if (TalkValue == 1)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 4;
                        DoveMsg.text = "\n\n치킨이 뭔데?\n\n";
                        One.text = "\n닭을 튀김 옷에 입혀 튀기는 걸 치킨이라고 해\n";
                        Two.text = "\n한 입 먹어보면 알거야!\n";
                        Three.text = "\nC.h.i.c.k.e.n 이라고 하지\n";
                        TalkValue = 2;
                    }
                }
            }
            else if (TalkValue == 2)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 4;
                        DoveMsg.text = "\n\n튀김 옷? 새로나온 신상인가?\n\n";
                        One.text = "\n그럼 한번 입어볼래?\n";
                        Two.text = "\n치킨 집 앞에서 춤을 추면 입을 수 있을거야\n";
                        Three.text = "\n미안 비둘기 튀김은 맛 없을 거 같아..\n";
                        TalkValue = 3;
                    }
                }
            }
            else if (TalkValue == 3)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 5;
                        DoveMsg.text = "\n\n그걸 속을줄 알았냐\n멍청한 인간자식!\n";
                        One.text = "\n으윽 (생각보다 똑똑하다)\n";
                        Two.text = "\n하하하 이런 (한대 친다)\n";
                        Three.text = "";
                        TalkValue = 4;
                    }
                }
            }
            else if (TalkValue == 4)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 5;
                        DoveMsg.text = "\n\n호호호\n\n";
                        Likestate = 0;
                        LikeState();
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if(TalkValue ==6)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 5;
                        DoveMsg.text = "\n뛰는 인간 위에 나는 비둘기~\n(비둘기는 나의 주머니를 털어갔다)\n\n";
                        Likestate = 2;
                        LikeState();
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if (TalkValue == 7)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 5;
                        DoveMsg.text = "\n나름 정직한 인간이군\n하지만 현대 사회에서 정직은\n더이상 후라이드가 아니란다.\n후라이드? 후라이드 치킨?";
                        Likestate = 0;
                        LikeState();
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if (TalkValue == 8)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 5;
                        DoveMsg.text = "\n\n역시.. 인간은 다 똑같아!\n\n";
                        Likestate = 1;
                        LikeState();
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if (TalkValue == 9)
            {
                if (Likeability <= 50)
                {
                    DoveState = 8;
                    DoveMsg.text = "\n\n응? 이거 다~~ 거짓말인거 알지?\n\n";
                    One.text = "\n거짓말은 나빠요! (그냥 간다)\n";
                    Two.text = "\n응~ 몰라~\n";
                    Three.text = "\n(그냥 새우깡을 준다)\n(새우깡이 소비됩니다)\n";
                    TalkValue = 10;
                }
            }
            else if (TalkValue == 10)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 8;
                        DoveMsg.text = "\n어떤 성인이 죄없는 자만이\n돌로 칠 수 있다고 했음.\n인간중에 과연 죄없는 자가 있을까?\n크크....";
                        TalkClearMsg.text = "비둘기 상태:  현학적";
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if (TalkValue == 11)
            {
                if (Likeability <= 50)
                {
                    DoveState = 10;
                    DoveMsg.text = "\n\n그렇다면 문제를 내지.\n항목을 선택해 너의 지능을 증명하렴\n";
                    One.text = "\n과학\n";
                    Two.text = "\n비둘기학\n";
                    Three.text = "\n영화\n";
                    TalkValue = 12;
                }
            }
            else if (TalkValue == 12)
            {
                if (Likeability <= 50)
                {
                    DoveState = 11;
                    DoveMsg.text = "\n\n하늘은 왜 파란색일까요? 호호호호\n\n";
                    One.text = "\n우리의 눈은 적외선 영역만 볼 수 있기 때문\n";
                    Two.text = "\n태양빛이 지구 대기 분자와 부딪치기 때문\n";
                    Three.text = "\n자외선 양자 도약 상태일때\n에너지를 방출한 뒤 안정을 추구하기 때문\n";
                    TalkValue = 13;
                }
            }
            else if (TalkValue == 13)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 11;
                        DoveMsg.text = "\n\n새대가리녀석 호호호 새대가리? 동족이네?\n\n";
                        Likestate = 0;
                        LikeState();
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if (TalkValue == 14)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 7;
                        DoveMsg.text = "\n\n파...파브르..!\n\n";
                        Likestate = 4;
                        LikeState();
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if (TalkValue == 15)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 12;
                        DoveMsg.text = "\n\n영알못!!\n\n";
                        Likestate = 1;
                        LikeState();
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if (TalkValue == 16)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 4;
                        DoveMsg.text = "\n\n다이어트? 그게 뭐야?\n\n";
                        One.text = "\n먹을 수 있는데 안먹는거야\n";
                        Two.text = "\n식이요법과 운동을 병행하여\n지방을 줄이는걸 다이어트라고 한단다\n";
                        Three.text = "\n이루어 질 수 없는 신기루 같은 것이지\n";
                        TalkValue = 17;
                    }
                }
            }
            else if (TalkValue == 17)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 4;
                        DoveMsg.text = "\n먹을수 있는데 왜 안먹냐?\n생각보다 인간은 멍청하군!\n";
                        Likestate = 0;
                        LikeState();
                        TalkClear.SetActive(true);
                    }
                }
            }           
            else if (TalkValue == 19)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 11;
                        DoveMsg.text = "\n매트릭스 안에서 살고 있군.\n나는 백치들이 부러워.\n백치라는 단어는 암?\n";
                        One.text = "\n멍청한 새대가리녀석이!\n";
                        Two.text = "\n매트릭스? 그게 뭐야?\n";
                        Three.text = "\n넌 주먹 한방으로 죽일 수 있는 미물이야\n";
                        TalkValue = 20;
                    }
                }
            }
            else if (TalkValue == 20)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 2;
                        DoveMsg.text = "\n난 원래부터 새대가리로 태어났어!\n나보고 어쩌라는거야!\n인간 대가리 녀석아!\n";
                        One.text = "\n칭찬 고마워\n";
                        Two.text = "\n세상은 원래 불공평 하단다.\n";
                        Three.text = "\n미안.. (새우깡을 준다)\n";
                        TalkValue = 21;
                    }
                }
            }
            else if (TalkValue == 21)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 2;
                        DoveMsg.text = "\n\n으응..? 고맙긴\n\n";
                        Likestate = 0;
                        LikeState();
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if (TalkValue == 22)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 15;
                        DoveMsg.text = "\n인간은 본래 자유롭게 태어났지만\n도처에 쇠사슬에 묶여있다.\n주인을 자처하는 자는 그들보다 더한 노예이다\n라고 누가 말했지! 너도 노오예\n";
                        Likestate = 1;
                        LikeState();
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if (TalkValue == 23)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 5;
                        DoveMsg.text = "\n괴물과 싸우다 보면 어느순간\n괴물이 되어있는 나 자신을\n발견하게 되지... 인간이 바로 그 괴물이야!\n";
                        Likestate = 1;
                        LikeState();
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if (TalkValue == 24)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 4;
                        DoveMsg.text = "\n며칠 안지나서 도로에 쌓여\n청소부들이 과로사 한다는 그 꽃?\n호호\n";
                        Likestate = 1;
                        LikeState();
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if (TalkValue == 25)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 16;
                        DoveMsg.text = "\n\n주먹보다 나의 날갯짓이 더 가까이!\n(비둘기가  내 주머니를 털어갔다)\n";
                        Likestate = 1;
                        LikeState();
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if (TalkValue == 26)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 4;
                        DoveMsg.text = "\n괴물쥐?\n괴물을 사냥하는 인간은 그럼 뭐임?\n 마왕임? 마왕님 안녕하세요\n";
                        Likestate = 0;
                        LikeState();
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if (TalkValue == 27)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 17;
                        DoveMsg.text = "\n\n인간은 볼수록 유쾌하군 허허\n\n";
                        Likestate = 0;
                        LikeState();
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if (TalkValue == 28)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 14;
                        DoveMsg.text = "\n\n호호호 인간이 할말 아님\n\n";
                        Likestate = 1;
                        LikeState();
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if (TalkValue == 29)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 18;
                        DoveMsg.text = "\n약자 앞에선 솔직하고\n강자 앞에선 가식인 녀석!\n그게 현대 사회의 미덕이긴 하지\n";
                        Likestate = 0;
                        LikeState();
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if (TalkValue == 30)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 18;
                        DoveMsg.text = "\n휴먼 급식체각인부분 ㅇㅈ?솔직히 ㄱㅇㄷ ㅆㅇㄷ ㅎㅇㄷ ㄲㅇㄷ인 부분 ㅇㅈ? 반박시 아재 ㅇㅈ? ㄹㅇ 핵씹ㅇㅈ하는 부분이구여~ 말투 ㅍㅌㅊ? ㅇㅈ? 어, 씹ㅇㅈ~ 반박시 글알못인부분 ㅇㅈ? 네티즌: ㅇㅈ합니다.\n";
                        Likestate = 6;
                        LikeState();
                        TalkClear.SetActive(true);
                    }
                }
            }
        }
    }
    /// ///////////////////////
    public void TwoBtn() //과거
    {
        if (screen == 0)
        {
            source.PlayOneShot(Click, 0.75f);
            if(TalkValue == 0)
            {
                TalkValue = 18;
            }
            if (TalkValue == 1)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 2;
                        DoveMsg.text = "\n자기가 줄것 터럼 말하더니...\n역시 인간은 다 똑같아!\n";
                        One.text = "\n새우깡 줄라 했는데..\n";
                        Two.text = "\n멍청한 비둘기 녀석\n";
                        Three.text = "\n(새우깡을 준다)\n";
                        TalkValue = 9;
                    }
                }
            }
            else if (TalkValue == 2)
            {
                if (Likeability <= 50)
                {
                    DoveState = 7;
                    DoveMsg.text = "\n\n사주려는 건가?\n\n";
                    One.text = "\n그냥 길에서 주워 먹으렴!\n";
                    Two.text = "\n아니!!  싫은데?!\n";
                    Three.text = "\n따라와\n";
                    TalkValue = 8;
                }
            }
            else if (TalkValue == 3)
            {
                if (Likeability <= 50)
                {
                    DoveState = 5;
                    DoveMsg.text = "\n\n이렇게? (셔플 댄스를 춘다)\n\n";
                    One.text = "\n응 그대로 치킨집 앞으로 가\n";
                    Two.text = "\n미안 사실 닭을 튀긴걸 치킨이라고 해\n";
                    Three.text = "";
                    TalkValue = 6;
                }
            }
            else if (TalkValue == 4)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 5;
                        DoveMsg.text = "\n\n인간은 느려(현란하게 피했다)\n\n";
                        Likestate = 1;
                        LikeState();
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if (TalkValue == 6)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 5;
                        DoveMsg.text = "\n닭을..?! 퇴근후에 따끈따끈한\n닭다리 한입 차가운 맥주 한입...\n크... 잔인한 녀석들\n";
                        Likestate = 0;
                        LikeState();
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if (TalkValue == 7)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 5;
                        DoveMsg.text = "\n\n너는 지구의 기생충~\n\n";
                        Likestate = 1;
                        LikeState();
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if (TalkValue == 8)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 5;
                        DoveMsg.text = "\n강한 부정은\n사실 긍정이라고 하지.\n하지만 난 마음만 받겠다\n";
                        Likestate = 0;
                        LikeState();
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if (TalkValue == 9)
            {
                if (Likeability <= 50)
                {
                    DoveState = 9;
                    DoveMsg.text = "\n너는 인간의 잣대로 비둘기의 지능을\n평가할 수 있다고 생각하니?\n";
                    One.text = "\n응\n";
                    Two.text = "\n미안.. 치킨 먹을래?\n";
                    Three.text = "";
                    TalkValue = 11;
                }
            }
            else if (TalkValue == 10)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 8;
                        DoveMsg.text = "\n\n흐르는 강물처럼...\n\n";
                        Likestate = 1;
                        LikeState();
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if (TalkValue == 11)
            {
                if (Likeability <= 50)
                {
                    DoveState = 4;
                    DoveMsg.text = "\n\n치킨이 뭔데?\n\n";
                    One.text = "\n닭을 튀김 옷에 입혀 튀기는 걸 치킨이라고 해\n";
                    Two.text = "\n한 입 먹어보면 알거야!\n";
                    Three.text = "\nC.h.i.c.k.e.n 이라고 하지\n";
                    TalkValue = 2;
                }
            }
            else if (TalkValue == 12)
            {
                if (Likeability <= 50)
                {
                    DoveState = 7;
                    DoveMsg.text = "\n\n비둘기의 울음소리는 무엇일까요???\n\n";
                    One.text = "\n구굿－구－, 구굿－구\n";
                    Two.text = "\n구우우우..구우우우우\n";
                    Three.text = "\n스피오스피오스피오 매에에에에엠\n";
                    TalkValue = 14;
                }
            }
            else if (TalkValue == 13)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 11;
                        DoveMsg.text = "\n쫌... 아네? 나는 똑똑한척\n하는 사람이 제일 싫어!\n아니.. 그냥 사람이 싫어!\n";
                        Likestate = 1;
                        LikeState();
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if (TalkValue == 14)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 7;
                        DoveMsg.text = "\n\n그건 흰색 비둘기 소리잖아!\n\n";
                        Likestate = 1;
                        LikeState();
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if (TalkValue == 15)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 12;
                        DoveMsg.text = "\n\n영화좀 봤네!!! 보나마나 토렌트로 봤겠지!!!\n\n";
                        Likestate = 0;
                        LikeState();
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if (TalkValue == 16)
            {
                if (Likeability <= 50)
                {
                    DoveState = 6;
                    DoveMsg.text = "\n\n날 먹으려고 한거야?\n";
                    One.text = "\n응.. 미안 안 먹을게\n";
                    Two.text = "\n넌 기생충 덩어리야!\n";
                    Three.text = "\n너보단 닭이 맛있어 걱정마^^\n";
                    TalkValue = 7;
                }
            }
            else if (TalkValue == 17)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 4;
                        DoveMsg.text = "\n하루만 비둘기 체험 해볼래?\n원하는 몸을 가질지도.\n아니면 원하지 않던 병을 가질지도\n";
                        TalkClearMsg.text = "비둘기 상태: 우울";
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if (TalkValue == 18)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 14;
                        DoveMsg.text = "타락한 도시는 인간들이\n타락의 길을 선택한 결과야.\n하지만 나는 태초부터\n어.둠.에.서.태.어.났.지";
                        One.text = "\n인간의 도시는 타락하지 않았어!\n";
                        Two.text = "\n어디서 태어났는데?\n";
                        Three.text = "\n쓰다듬어도 되니?\n";
                        TalkValue = 19;
                    }
                }
            }
            else if (TalkValue == 19)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 17;
                        DoveMsg.text = "\n\n초면에 너무 많은걸 알려 하는군\n\n";
                        One.text = "\n사실 관심 없어\n";
                        Two.text = "\n부끄러워하지 말고 말해봐\n";
                        Three.text = "\n말투가 왜그래?\n";
                        TalkValue = 27;
                    }
                }
            }
            else if (TalkValue == 20)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 5;
                        DoveMsg.text = "\n\n그물망에 걸려있는 물고기 그건 바로 너!\n\n";
                        One.text = "\n넌 너무 오만해\n";
                        Two.text = "\n파닥파닥\n";
                        Three.text = "\n넌 왜이리 부정적이니? 세상은 생각보다 아름답단다\n";
                        TalkValue = 23;
                    }
                }
            }
            else if (TalkValue == 21)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 15;
                        DoveMsg.text = "\n그건 상류층들이 체제를\n유지하기 위한 변명일 뿐이야!\n";
                        One.text = "\n비둘기 기준으로 인간은 상류층이지 허허허\n";
                        Two.text = "\n너 튀겨먹어도 돼?\n";
                        Three.text = "\n나도 그렇게 생각해\n";
                        TalkValue = 22;
                    }
                }
            }
            else if (TalkValue == 22)
            {
                if (Likeability <= 50)
                {
                    DoveState = 6;
                    DoveMsg.text = "\n\n날 먹으려고 한거야?\n\n";
                    One.text = "\n응.. 미안 안 먹을게\n";
                    Two.text = "\n넌 기생충 덩어리야!\n";
                    Three.text = "\n너보단 닭이 맛있어 걱정마^^\n";
                    TalkValue = 7;
                }
            }
            else if (TalkValue == 23)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 5;
                        DoveMsg.text = "\n파닭? 얇게 썰린 파를 얹은 치킨에 새콤달콤한\n 오리엔탈 소스를 버무려 다리 먼저 깨어 물면..\n 그윽한 향내와 입안 가득 퍼지는\n고소함 달콤함 감칠맛.! 튀김의 바삭함.!! ";
                        Likestate = 0;
                        LikeState();
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if (TalkValue == 24)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 4;
                        DoveMsg.text = "\n\n나름 낭만적인 녀석이군..\n\n";
                        Likestate = 1;
                        LikeState();
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if (TalkValue == 25)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 4;
                        DoveMsg.text = "\n\n뉴트리아? 그게 뭐야?\n\n";
                        One.text = "\n괴물쥐야 사냥하면 정부에서 포상금을 주지\n";
                        Two.text = "\n미안 그말 취소할게\n";
                        Three.text = "\n너같은 지구의 쓰레기\n";
                        TalkValue = 26;
                    }
                }
            }
            else if (TalkValue == 26)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 4;
                        DoveMsg.text = "\n줏대없는 녀석!\n하긴 주입식 교육의 폐혜겠지!!\n";
                        Likestate = 1;
                        LikeState();
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if (TalkValue == 27)
            {
                if (Likeability <= 50)
                {
                    DoveState = 14;
                    DoveMsg.text = "\n나는 형제들과 전봇대 위에서 자랐어.\n그중 하나는 내가 알에서\n먼저 나와 먹어 치웠지\n";
                    One.text = "\n동족상잔을 자랑하니?\n";
                    Two.text = "\n그래 너 매우 쎈 녀석이야\n";
                    Three.text = "\n너때문에 전선 합선되서 인터넷 끊겼잖아!\n";
                    TalkValue = 28;
                }
            }
            else if (TalkValue == 28)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 14;
                        DoveMsg.text = "\n\n맞아.. 나는 왜이렇게 쓸데없이 강하지?\n\n";
                        Likestate = 0;
                        LikeState();
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if (TalkValue == 29)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 18;
                        DoveMsg.text = "\n\n엥? 난 저글링?\n\n";
                        TalkClearMsg.text = "비둘기 상태: 정체성 혼란";
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if (TalkValue == 30)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 19;
                        DoveMsg.text = "\n\n미안 잠시 뭔가가 빙의됐는데..\n\n";
                        TalkClearMsg.text = "비둘기 상태: 불쾌";
                        TalkClear.SetActive(true);
                    }
                }
            }
        }
    }
    /// //////////////////////////
    public void ThreeBtn() //미래
    {
        if (screen == 0)
        {
            source.PlayOneShot(Click, 0.75f);
            if (TalkValue == 1)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 13;
                        DoveMsg.text = "\n훗 하층 인간인가?\n하지만 내게 동정심이란 없다.\n";
                        One.text = "\n못먹는게 아니라 안먹는건데?\n인간은 다이어트 란걸 한단다\n";
                        Two.text = "\n너 튀겨먹어도 돼?\n";
                        Three.text = "\n돈좀 줘\n";
                        TalkValue = 16;
                    }
                }
            }
            else if (TalkValue == 2)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 4;
                        DoveMsg.text = "\n영어 잘하네 요즘은 글로벌 시대 아니겠냐?!\n인간들은 여권이 있어야 외국갈수 있다메?\n나는 그냥 날아가면 되는데 호호호\n";
                        TalkClearMsg.text = "비둘기 상태: 우월";
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if (TalkValue == 3)
            {
                if (Likeability <= 50)
                {
                    DoveState = 6;
                    DoveMsg.text = "\n\n날 먹으려고 한거야?\n\n";
                    One.text = "\n응.. 미안 안 먹을게\n";
                    Two.text = "\n넌 기생충 덩어리야!\n";
                    Three.text = "\n너보단 닭이 맛있어 걱정마^^\n";
                    TalkValue = 7;
                }
            }
            else if (TalkValue == 7)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 3;
                        DoveMsg.text = "\n\n닭녀석.. 잘나가네?\n\n";
                        TalkClearMsg.text = "비둘기가 우울해 합니다";
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if (TalkValue == 8)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 5;
                        DoveMsg.text = "\n\n응? 퍽!\n\n";
                        TalkClearMsg.text = "비둘기 상태: 추억이 새록새록";
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if (TalkValue == 9)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 5;
                        DoveMsg.text = "\n\n먹~튀~\n\n";
                        Likestate = 5;
                        LikeState();
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if (TalkValue == 10)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 8;
                        DoveMsg.text = "\n\n어쩌면.. 인간이 다 나쁜건\n아니라는 생각이... 들줄 알았냐?\n";
                        Likestate = 3;
                        LikeState();
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if (TalkValue == 12)
            {
                if (Likeability <= 50)
                {
                    DoveState = 12;
                    DoveMsg.text = "\n\n'Like tears in rain... time to die'\n는 어떤 영화의 명대사 일까요?\n";
                    One.text = "\n바람과 함께 사라지다\n";
                    Two.text = "\n블레이드 러너\n";
                    Three.text = "\n써스페리아\n";
                    TalkValue = 15;
                }
            }
            else if (TalkValue == 13)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 11;
                        DoveMsg.text = "\n\n뭔소린지 이해는 했냐? 나도 모르는데\n\n";
                        Likestate = 0;
                        LikeState();
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if (TalkValue == 14)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 7;
                        DoveMsg.text = "\n\n할머니 집 마루에 누워서\n 매미 소리 들으며 아이스티 한잔..\n크..";
                        Likestate = 0;
                        LikeState();
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if (TalkValue == 15)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 12;
                        DoveMsg.text = "\n\n영알못!!\n\n";
                        Likestate = 1;
                        LikeState();
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if (TalkValue == 16)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 13;
                        DoveMsg.text = "\n\n오다 주웠는데 가지던가\n\n";
                        Likestate = 1;
                        LikeState();
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if (TalkValue == 17)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 4;
                        DoveMsg.text = "\n\n사랑..?\n\n";
                        Likestate = 4;
                        LikeState();
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if (TalkValue == 20)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 16;
                        DoveMsg.text = "\n\n하하 너가 과연 천연기념물을\n건드릴 깡이 있을까?\n";
                        One.text = "\n법은 멀리있고 주먹은 가까이 있지\n";
                        Two.text = "\n넌 이제 유해동물이야 곧 뉴트리아 꼴 될거야\n";
                        Three.text = "\n미안..\n";
                        TalkValue = 25;
                    }
                }
            }
            else if (TalkValue == 21)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 5;
                        DoveMsg.text = "\n\n먹~튀~\n\n";
                        TalkClearMsg.text = "비둘기 상태: 기쁨";
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if (TalkValue == 22)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 15;
                        DoveMsg.text = "\n\n줏대 없는 자식!\n 그런 너가 조금 귀여워 보이....지 않아\n인간!";
                        Likestate = 0;
                        LikeState();
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if (TalkValue == 23)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 4;
                        DoveMsg.text = "\n\n대체 뭐가 아름답다는거야!\n\n";
                        One.text = "\n봄에 피는 벚꽃\n";
                        Two.text = "\n석양이 지는 붉은 바다\n";
                        Three.text = "\n독도는 우리땅!\n";
                        TalkValue = 24;
                    }
                }
            }
            else if (TalkValue == 24)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 4;
                        DoveMsg.text = "\n\n응? 느닷없는 국뽕\n\n";
                        Likestate = 6;
                        LikeState();
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if (TalkValue == 25)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 4;
                        DoveMsg.text = "\n\n줏대없는 녀석!\n하긴 주입식 교육의 폐혜겠지!!\n";
                        Likestate = 1;
                        LikeState();
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if (TalkValue == 26)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 4;
                        DoveMsg.text = "\n태평양엔 인간들이 만들어놓은 거대 쓰레기섬들이 있단다\n그곳은 우리의 소중한 안식처야 우리같은 철새들은\n그곳에서 쉬면서 라이터와 병뚜껑을 먹으며 끼니를 떼우지.\n근데  라이터 먹으면 배 아픈게 정상이지?";
                        Likestate = 0;
                        LikeState();
                        TalkClear.SetActive(true);
                    }
                }
            }
            else if (TalkValue == 27)
            {
                if (Likeability <= 50)
                {
                    DoveState = 19;
                    DoveMsg.text = "\n네 말투가 더 이상함\nㄱㅇㄷ이구연 ㅇㅈ? ㅇㅇㅈ\nㅇㄱㄹㅇ ㄹㅇㅍㅌ ㅂㅂㅂㄱ\n";
                    One.text = "\n미안.. 그만해줘!\n";
                    Two.text = "\n빙의 된거야?\n";
                    Three.text = "";
                    TalkValue = 30;
                }
            }
            else if (TalkValue == 28)
            {
                if (Likeability <= 50)
                {
                    DoveState = 18;
                    DoveMsg.text = "\n그 합선과 함께 나의 형제중 하나도\n인간의 야욕의 전선에 불살라 사라졌겠지.\n넌 생명이 중요해? 인터넷이 중요해?\n";
                    One.text = "\n인터넷\n";
                    Two.text = "\n퐈이어!\n";
                    Three.text = "\n천국에서 편하게 쉬고 있을거야\n";
                    TalkValue = 29;
                }
            }
            else if (TalkValue == 29)
            {
                if (Dove == 0) //검은비둘기
                {
                    if (Likeability <= 50)
                    {
                        DoveState = 18;
                        DoveMsg.text = "\n\n그럼 너도 전선 한웅큼 입안에 머금어 보시지\n\n";
                        Likestate = 1;
                        LikeState();
                        TalkClear.SetActive(true);
                    }
                }
            }
        }
    }

    public void LikeabilityUp()
    {
        source.PlayOneShot(Click, 0.75f);
        if(Likeability == 100)
        {

        }
        else
        {
            Notionlikeab.SetActive(false);
            Notionlikeab.SetActive(true);
        }
    }
}
