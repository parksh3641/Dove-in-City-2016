using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InventoryManager : MonoBehaviour
{
    private int UNIT;
    //메인 12345
    public UISprite MainAsp;
    public UISprite MainBsp;
    public UISprite MainCsp;
    public UISprite MainDsp;
    public UISprite MainEsp;
    public GameObject Ause;
    public GameObject Buse;
    public GameObject Cuse;
    public GameObject Duse;
    public GameObject Euse;
    public UILabel Alabel;
    public UILabel Blabel;
    public UILabel Clabel;
    public UILabel Dlabel;
    public UILabel Elabel;
    public GameObject Acancel;
    public GameObject Bcancel;
    public GameObject Ccancel;
    public GameObject Dcancel;
    public GameObject Ecancel;
    //몇번칸에 무슨아이템이 있는지 실시간저장 + 인게임시 이 정보 불러와서 배열및 아이템 생성
    private int Asave = 0;
    private int Bsave = 0;
    private int Csave = 0;
    private int Dsave = 0;
    private int Esave = 0;
    //아이템설명
    public UILabel ItemInfoOne;
    public UILabel ItemInfoTwo;
    public UILabel ItemInfoThree;
    public UILabel ItemInfoFour;
    public UILabel ItemInfoFive;
    //아이템 이미지 숫자값
    string Astring = "003_heart";
    string Bstring = "자석 ui";
    string Cstring = "미니 포션 ui";
    string Dstring = "1회용 해킹툴 ui";
    string Estring = "시간의 모래시계 ui";
    string Fstring = "디스코 뮤직박스 ui";
    string Gstring = "초능력 기압계 ui";
    string Hstring = "중국산 엔진오일 ui";

    string Kstring = "영구 해킹툴ui";

    string Ostring = "도라의 깃털 ui";
    //아이템 아이콘
    public UISprite Asp;
    public UISprite Bsp;
    public UISprite Csp;
    public UISprite Dsp;
    public UISprite Esp;
    public UISprite Fsp;
    public UISprite Gsp;
    public UISprite Hsp;

    public UISprite Ksp;

    public UISprite Dorisp;
    //
    public UILabel A;
    public UILabel B;
    public UILabel C;
    public UILabel D;
    public UILabel E;
    public UILabel F;
    public UILabel G;
    public UILabel H;

    public UILabel K;

    public UILabel O;
    //서브 아이템 갯수
    public int Anum;
    public int Bnum;
    public int Cnum;
    public int Dnum;
    public int Enum;

    public int Fnum;
    public int Gnum;
    public int Hnum;

    //public int Inum;
    //public int Jnum;

    public int Knum;

    public int DORI;
    //아이템이 차있는지 여부
    public int ItemValue;
    //받아온아이템번호
    private int ItemNumber = 0;
    //
    private int NoItem = 0;
    //
    //private bool End = false;
    //아이템 락
    public GameObject ALock;
    public GameObject BLock;
    public GameObject CLock;
    public GameObject DLock;
    public GameObject ELock;

    public GameObject FLock;
    public GameObject GLock;
    public GameObject HLock;

    //public GameObject ILock;
    //public GameObject JLock;

    public GameObject KLock;

    public GameObject DoriLock;

    //한번 락 풀린 뒤에는 쭉 풀림을 저장할 변수
    private int ALockNum;
    private int BLockNum;
    private int CLockNum;
    private int DLockNum;
    private int ELockNum;

    private int FLockNum;
    private int GLockNum;
    private int HLockNum;

    private int KLockNum;

    private int DoriLockNum;

    public GameObject Notion;
    public GameObject UpNotion;
    public GameObject DownNotion;
    public GameObject UpgradeNotion;
    public GameObject DoriNotion;

    public GameObject CoinNotion;
    public GameObject NumNotion;

    public GameObject UpgradeWindow;
    //강화
    public UILabel Titletxt;
    public UILabel NowLvtxt;
    public UILabel NextLvtxt;
    public UILabel NowAtxt;
    public UILabel NowBtxt;
    public UILabel NextAtxt;
    public UILabel NextBtxt;

    public UISprite Mainsp;
    public UISprite Numsp;
    public UILabel Numtxt;

    public UILabel Cointxt;

    //레벨표시
    private int ALv;
    private int BLv;

    public UILabel ALvtxt;
    public UILabel BLvtxt;

    public delegate void inventoryManager();
    public static event inventoryManager One, Two, Three, Four, Five, Six, Seven, Eight, Eleven, Fifteen, Click , Coin;

    void Awake()
    {
        //초기화
        ItemInfoOne.text = "이름 : ";
        ItemInfoTwo.text = "효과 : ";
        ItemInfoThree.text = "등급 : ";
        ItemInfoFour.text = "지속시간 : ";
        ItemInfoFive.text = "          착용할 아이템을 선택해주세요!          ";

        Acancel.SetActive(false);
        Bcancel.SetActive(false);
        Ccancel.SetActive(false);
        Dcancel.SetActive(false);
        Ecancel.SetActive(false);

        Ause.SetActive(false);
        Buse.SetActive(false);
        Cuse.SetActive(false);
        Duse.SetActive(false);
        Euse.SetActive(false);
        //////////////////////////////////////////
        //아이템 저장된 상태 불러오기
        Asave = PlayerPrefs.GetInt("Asave", 0);
        Bsave = PlayerPrefs.GetInt("Bsave", 0);
        Csave = PlayerPrefs.GetInt("Csave", 0);
        Dsave = PlayerPrefs.GetInt("Dsave", 0);
        Esave = PlayerPrefs.GetInt("Esave", 0);

        ItemArray();
        ////////////////////////////////////////////////
        UpgradeWindow.SetActive(false);
        ///////////////////////////////////////////
        //아이템갯수 불러오기
        Anum = PlayerPrefs.GetInt("Anum", 0);
        Bnum = PlayerPrefs.GetInt("Bnum", 0);
        Cnum = PlayerPrefs.GetInt("Cnum", 0);
        Dnum = PlayerPrefs.GetInt("Dnum", 0);
        Enum = PlayerPrefs.GetInt("Enum", 0);
        Fnum = PlayerPrefs.GetInt("Fnum", 0);
        Gnum = PlayerPrefs.GetInt("Gnum", 0);
        Hnum = PlayerPrefs.GetInt("Hnum", 0);

        Knum = PlayerPrefs.GetInt("Knum", 0);

        DORI = PlayerPrefs.GetInt("DORI", 0);
        ///////////////////////////////////////////////
        ALock.SetActive(false);
        BLock.SetActive(false);
        CLock.SetActive(false);
        DLock.SetActive(false);
        ELock.SetActive(false);
        FLock.SetActive(false);
        GLock.SetActive(false);
        HLock.SetActive(false);

        KLock.SetActive(false);

        DoriLock.SetActive(false);
        ///////////////////////////////////////////////      
        ALockNum = PlayerPrefs.GetInt("ALockNum", 0);
        BLockNum = PlayerPrefs.GetInt("BLockNum", 0);
        CLockNum = PlayerPrefs.GetInt("CLockNum", 0);
        DLockNum = PlayerPrefs.GetInt("DLockNum", 0);
        ELockNum = PlayerPrefs.GetInt("ELockNum", 0);
        FLockNum = PlayerPrefs.GetInt("FLockNum", 0);
        GLockNum = PlayerPrefs.GetInt("GLockNum", 0);
        HLockNum = PlayerPrefs.GetInt("HLockNum", 0);

        KLockNum = PlayerPrefs.GetInt("KLockNum", 0);
        if (KLockNum == 1)
        {
            Knum = 1;
            PlayerPrefs.SetInt("Knum", Knum);
        }
        DoriLockNum = PlayerPrefs.GetInt("DoriLockNum", 0);
    }

    void OnEnable()
    {
        UNIT = PlayerPrefs.GetInt("UNIT", 0);
        StartCoroutine(ModeCheck());
        StartCoroutine(Statecheck());
    }
    void OnDisable()
    {
        StopAllCoroutines();
    }

    IEnumerator ModeCheck()
    {
        A.text = Anum.ToString();
        B.text = Bnum.ToString();
        C.text = Cnum.ToString();
        D.text = Dnum.ToString();
        E.text = Enum.ToString();
        F.text = Fnum.ToString();
        G.text = Gnum.ToString();
        H.text = Hnum.ToString();

        ALv = PlayerPrefs.GetInt("ALv", ALv);
        ALvtxt.text = (ALv + 1).ToString();

        BLv = PlayerPrefs.GetInt("BLv", BLv);
        BLvtxt.text = (BLv + 1).ToString();

        Anum = PlayerPrefs.GetInt("Anum", 0);
        Bnum = PlayerPrefs.GetInt("Bnum", 0);

        if (Anum > 999)
        {
            Anum = 999;
            PlayerPrefs.SetInt("Anum", Anum);
        }
        if (Bnum > 999)
        {
            Bnum = 999;
            PlayerPrefs.SetInt("Bnum", Bnum);
        }
        if (Bnum > 999)
        {
            Bnum = 999;
            PlayerPrefs.SetInt("Bnum", Bnum);
        }
        if (Cnum > 999)
        {
            Cnum = 999;
            PlayerPrefs.SetInt("Cnum", Cnum);
        }
        if (Dnum > 999)
        {
            Dnum = 999;
            PlayerPrefs.SetInt("Dnum", Dnum);
        }
        if (Enum > 999)
        {
            Enum = 999;
            PlayerPrefs.SetInt("Enum", Enum);
        }
        if (Fnum > 999)
        {
            Fnum = 999;
            PlayerPrefs.SetInt("Fnum", Fnum);
        }
        if (Gnum > 999)
        {
            Gnum = 999;
            PlayerPrefs.SetInt("Gnum", Gnum);
        }
        if (Hnum > 999)
        {
            Hnum = 999;
            PlayerPrefs.SetInt("Hnum", Hnum);
        }

        K.text = Knum.ToString();
        if (Knum > 1)
        {
            Knum = 1;
            PlayerPrefs.SetInt("Knum", Knum);
        }

        O.text = DORI.ToString();
        yield return new WaitForSeconds(0.1f);
        StartCoroutine(ModeCheck());
    }
    IEnumerator Statecheck()
    {
        StateCheck(Anum, Asp, ALock, ALockNum, 1);
        StateCheck(Bnum, Bsp, BLock, BLockNum, 2);
        StateCheck(Cnum, Csp, CLock, CLockNum, 3);
        StateCheck(Dnum, Dsp, DLock, DLockNum, 4);
        StateCheck(Enum, Esp, ELock, ELockNum, 5);
        StateCheck(Fnum, Fsp, FLock, FLockNum, 6);
        StateCheck(Gnum, Gsp, GLock, GLockNum, 7);
        StateCheck(Hnum, Hsp, HLock, HLockNum, 8);

        StateCheck(Knum, Ksp, KLock, KLockNum, 11);

        StateCheck(DORI, Dorisp, DoriLock, DoriLockNum, 15);

        yield return new WaitForSeconds(0.5f);
        StartCoroutine(Statecheck());
    }

    void ItemArray() //아이템 상태 정리 + 정렬
    {
        if (Asave > 0)
        {
            ItemValue = 1;
            CancelCheck();
            NoItem = 1;
            PlayerPrefs.SetInt("NoItem", NoItem);
            if (Bsave > 0)
            {
                ItemValue = 2;
                CancelCheck();
                NoItem = 2;
                PlayerPrefs.SetInt("NoItem", NoItem);
                if (Csave > 0)
                {
                    ItemValue = 3;
                    CancelCheck();
                    NoItem = 3;
                    PlayerPrefs.SetInt("NoItem", NoItem);
                    if (Dsave > 0)
                    {
                        ItemValue = 4;
                        CancelCheck();
                        NoItem = 4;
                        PlayerPrefs.SetInt("NoItem", NoItem);
                        if (Esave > 0)
                        {
                            ItemValue = 5;
                            CancelCheck();
                            NoItem = 5;
                            PlayerPrefs.SetInt("NoItem", NoItem);
                            ItemArrayEnd();
                        }
                        else
                        {
                            ItemArrayEnd();
                        }
                    }
                    else
                    {
                        ItemArrayEnd();
                    }
                }
                else
                {
                    ItemArrayEnd();
                }
            }
            else
            {
                ItemArrayEnd();
            }
        }
        else
        {
            Asave = Bsave;
            Bsave = Csave;
            Csave = Dsave;
            Dsave = Esave;
            Esave = 0;
            if (Asave == 0)
            {
                Asave = Bsave;
                Bsave = Csave;
                Csave = Dsave;
                Dsave = 0;
                if (Asave == 0)
                {
                    Asave = Bsave;
                    Bsave = Csave;
                    Csave = 0;
                    if (Asave == 0)
                    {
                        Asave = Bsave;
                        Bsave = 0;
                    }
                }
            }
            int A = 0;
            if (Asave > 0)
            {
                A += 1;
            }
            if (Bsave > 0)
            {
                A += 1;
            }
            if (Csave > 0)
            {
                A += 1;
            }
            if (Dsave > 0)
            {
                A += 1;
            }
            if (Esave > 0)
            {
                A += 1;
            }
            //Debug.Log(A.ToString());
            if (A == 0)
            {
                ItemValue = 0;
                CancelCheck();
                NoItem = 0;
                PlayerPrefs.SetInt("NoItem", NoItem);
            }
            else if (A == 1)
            {
                ItemValue = 1;
                CancelCheck();
                NoItem = 1;
                PlayerPrefs.SetInt("NoItem", NoItem);
            }
            else if (A == 2)
            {
                ItemValue = 2;
                CancelCheck();
                NoItem = 2;
                PlayerPrefs.SetInt("NoItem", NoItem);
            }
            else if (A == 3)
            {
                ItemValue = 3;
                CancelCheck();
                NoItem = 3;
                PlayerPrefs.SetInt("NoItem", NoItem);
            }
            else if (A == 4)
            {
                ItemValue = 4;
                CancelCheck();
                NoItem = 4;
                PlayerPrefs.SetInt("NoItem", NoItem);
            }
            else if (A == 5)
            {
                ItemValue = 5;
                CancelCheck();
                NoItem = 5;
                PlayerPrefs.SetInt("NoItem", NoItem);
            }
            ItemArrayEnd();
        }
    }
    void ItemArrayEnd()
    {
        PlayerPrefs.SetInt("Asave", Asave);
        PlayerPrefs.SetInt("Bsave", Bsave);
        PlayerPrefs.SetInt("Csave", Csave);
        PlayerPrefs.SetInt("Dsave", Dsave);
        PlayerPrefs.SetInt("Esave", Esave);

        ItemSaveCheck(MainAsp, Asave, Alabel);
        ItemSaveCheck(MainBsp, Bsave, Blabel);
        ItemSaveCheck(MainCsp, Csave, Clabel);
        ItemSaveCheck(MainDsp, Dsave, Dlabel);
        ItemSaveCheck(MainEsp, Esave, Elabel);

    }

    void SaveCheck(int A)
    {
        if (A == 1)
        {
            PlayerPrefs.SetInt("ALockNum", 1);
        }
        else if (A == 2)
        {
            PlayerPrefs.SetInt("BLockNum", 1);
        }
        else if (A == 3)
        {
            PlayerPrefs.SetInt("CLockNum", 1);
        }
        else if (A == 4)
        {
            PlayerPrefs.SetInt("DLockNum", 1);
        }
        else if (A == 5)
        {
            PlayerPrefs.SetInt("ELockNum", 1);
        }
        else if (A == 6)
        {
            PlayerPrefs.SetInt("FLockNum", 1);
        }
        else if (A == 7)
        {
            PlayerPrefs.SetInt("GLockNum", 1);
        }
        else if (A == 8)
        {
            PlayerPrefs.SetInt("HLockNum", 1);
        }
        else if (A == 11)
        {
            PlayerPrefs.SetInt("KLockNum", 1);
        }
        else if (A == 15)
        {
            PlayerPrefs.SetInt("DoriLockNum", 1);
        }
    }

    public void StateCheck(int A, UISprite B, GameObject C, int D, int E)
    {
        if (A == 0)
        {
            B.color = new Color(B.color.r, B.color.g, B.color.b, 0.3f);
            if (D == 0)
            {
                C.SetActive(true);
            }
        }
        else
        {
            B.color = new Color(B.color.r, B.color.g, B.color.b, 1.0f);
            if (D == 0)
            {
                SaveCheck(E);
            }
        }
    } //0개시 아이템 흐리게
    public void ItemSaveCheck(UISprite A, int B, UILabel C)
    {
        if (B == 0)
        {
            A.enabled = false;
            C.enabled = true;
        }
        if (B == 1)
        {
            A.spriteName = Astring;
            C.enabled = false;
        }
        if (B == 2)
        {
            A.spriteName = Bstring;
            C.enabled = false;
        }
        if (B == 3)
        {
            A.spriteName = Cstring;
            C.enabled = false;
        }
        if (B == 4)
        {
            A.spriteName = Dstring;
            C.enabled = false;
        }
        if (B == 5)
        {
            A.spriteName = Estring;
            C.enabled = false;
        }
        if (B == 6)
        {
            A.spriteName = Fstring;
            C.enabled = false;
        }
        if (B == 7)
        {
            A.spriteName = Gstring;
            C.enabled = false;
        }
        if (B == 8)
        {
            A.spriteName = Hstring;
            C.enabled = false;
        }
        if (B == 11)
        {
            A.spriteName = Kstring;
            C.enabled = false;
        }
    } //세이브상태 관리

    public void SelectItem(int A)
    {
        Click();
        ItemNumber = A;
        if (A == 1)
        {
            One();
            ItemInfoOne.text = "이름 : 온전한하트";
            if (ALv == 0)
            {
                ItemInfoTwo.text = "효과 : HP 40% 회복";
            }
            else if (ALv == 1)
            {
                ItemInfoTwo.text = "효과 : HP 45% 회복";
            }
            else if (ALv == 2)
            {
                ItemInfoTwo.text = "효과 : HP 50% 회복";
            }
            else if (ALv == 3)
            {
                ItemInfoTwo.text = "효과 : HP 55% 회복";
            }
            else if (ALv == 4)
            {
                ItemInfoTwo.text = "효과 : HP 60% 회복";
            }
            else if (ALv == 5)
            {
                ItemInfoTwo.text = "효과 : HP 65% 회복";
            }
            else if (ALv == 6)
            {
                ItemInfoTwo.text = "효과 : HP 70% 회복";
            }
            else if (ALv == 7)
            {
                ItemInfoTwo.text = "효과 : HP 75% 회복";
            }
            ItemInfoThree.text = "등급 : 일반";
            ItemInfoFour.text = "지속시간 : 즉시";
            ItemInfoFive.text = "부작용 : 피가 반 이상 깎일 수도 있다\n";
            if (Anum > 0)
            {
                ItemCheck();
            }
            else
            {
                ItemCancel();
            }
        }
        else if (A == 2)
        {
            Two();
            ItemInfoOne.text = "이름 : 자석";
            ItemInfoTwo.text = "효과 : 만두 당겨오기";
            ItemInfoThree.text = "등급 : 일반";
            if (BLv == 0)
            {
                ItemInfoFour.text = "지속시간 : 15초";
            }
            else if (BLv == 1)
            {
                ItemInfoFour.text = "지속시간 : 16초";
            }
            else if (BLv == 2)
            {
                ItemInfoFour.text = "지속시간 : 17초";
            }
            else if (BLv == 3)
            {
                ItemInfoFour.text = "지속시간 : 18초";
            }
            else if (BLv == 4)
            {
                ItemInfoFour.text = "지속시간 : 19초";
            }
            else if (BLv == 5)
            {
                ItemInfoFour.text = "지속시간 : 20초";
            }
            else if (BLv == 6)
            {
                ItemInfoFour.text = "지속시간 : 21초";
            }
            else if (BLv == 7)
            {
                ItemInfoFour.text = "지속시간 : 22초";
            }
            ItemInfoFive.text = "부작용 : 돌을 끌어당길수도 있다\n";
            if (Bnum > 0)
            {
                ItemCheck();
            }
            else
            {
                ItemCancel();
            }
        }
        else if (A == 3)
        {
            Three();
            ItemInfoOne.text = "이름 : 미니포션";
            ItemInfoTwo.text = "효과 : 작아지기";
            ItemInfoThree.text = "등급 : 희귀";
            ItemInfoFour.text = "지속시간 : 15초";
            ItemInfoFive.text = "부작용 : 몸이 비 정상적으로 커질 수도\n있다";
            if (Cnum > 0)
            {
                ItemCheck();
            }
            else
            {
                ItemCancel();
            }
        }
        else if (A == 4)
        {
            Four();
            ItemInfoOne.text = "이름 : 1회용 해킹툴";
            ItemInfoTwo.text = "효과 : 스코어 2배";
            ItemInfoThree.text = "등급 : 일반";
            ItemInfoFour.text = "지속시간 : 20초";
            ItemInfoFive.text = "부작용 : 10초동안 10배의 스코어를\n획득할 수도 있다";
            if (Dnum > 0)
            {
                ItemCheck();
            }
            else
            {
                ItemCancel();
            }
        }
        else if (A == 5)
        {
            Five();
            ItemInfoOne.text = "이름 : 시간의 모래시계";
            ItemInfoTwo.text = "효과 : 3초전 위치로 돌아가기";
            ItemInfoThree.text = "등급 : 일반";
            ItemInfoFour.text = "지속시간 : 3초";
            ItemInfoFive.text = "부작용 : 5초동안 뒤로 질주할 수도 있다\n";
            if (Enum > 0)
            {
                ItemCheck();
            }
            else
            {
                ItemCancel();
            }
        }
        else if (A == 6)
        {
            Six();
            ItemInfoOne.text = "이름 : 디스코 뮤직박스";
            ItemInfoTwo.text = "효과 : 디스코 음악재생";
            ItemInfoThree.text = "등급 : 일반";
            ItemInfoFour.text = "지속시간 : 28초";
            ItemInfoFive.text = "부작용 : 술취한 주정뱅이들이 갑자기\n튀어나와 춤을 출 수도 있다";
            if (Fnum > 0)
            {
                ItemCheck();
            }
            else
            {
                ItemCancel();
            }
        }
        else if (A == 7)
        {
            Seven();
            ItemInfoOne.text = "이름 : 초능력 기압계";
            ItemInfoTwo.text = "효과 : 날씨 전환";
            ItemInfoThree.text = "등급 : 일반";
            ItemInfoFour.text = "지속시간 : 즉시";
            ItemInfoFive.text = "부작용 : 고막이 터져 사망할 수도 있다\n";
            if (Gnum > 0)
            {
                ItemCheck();
            }
            else
            {
                ItemCancel();
            }
        }
        else if (A == 8)
        {
            Eight();
            ItemInfoOne.text = "이름 : 중국산 엔진오일";
            ItemInfoTwo.text = "효과 : 차 속도 감소";
            ItemInfoThree.text = "등급 : 희귀";
            ItemInfoFour.text = "지속시간 : 15초";
            ItemInfoFive.text = "부작용 : 차 속도가 비정상적으로\n빨라질 수도 있다";
            if (Hnum > 0)
            {
                ItemCheck();
            }
            else
            {
                ItemCancel();
            }
        }
        else if (A == 11)
        {
            Eleven();
            ItemInfoOne.text = "이름 : 영구 해킹툴";
            ItemInfoTwo.text = "효과 : 스코어 2배";
            ItemInfoThree.text = "등급 : 전설";
            ItemInfoFour.text = "지속시간 : 20초";
            ItemInfoFive.text = "부작용 : 10초동안 10배의 스코어를\n획득할 수도 있다";
            if (Knum > 0)
            {
                ItemCheck();
            }
            else
            {
                ItemCancel();
            }
        }
        else if (A == 15)
        {
            Fifteen();
            ItemInfoOne.text = "이름 : 도라의 깃털";
            ItemInfoTwo.text = "효과 : 동료 부르기";
            ItemInfoThree.text = "등급 : 전설";
            ItemInfoFour.text = "지속시간 : 10초";
            ItemInfoFive.text = "부작용 : 누가 올지 알 수가 없다.\n만약 독수리가 온다면 ...";
            if (DORI > 0)
            {
                ItemCheck();
            }
            else
            {
                ItemCancel();
            }
        }
    } //아이템선택시 행동관리

    void ItemCheck()
    {
        if (ItemNumber > 0)
        {
            if (ItemValue == 0)
            {
                Ause.SetActive(true);
                Buse.SetActive(false);
                Cuse.SetActive(false);
                Duse.SetActive(false);
                Euse.SetActive(false);
            }
            else if (ItemValue == 1)
            {
                Ause.SetActive(false);
                Buse.SetActive(true);
                Cuse.SetActive(false);
                Duse.SetActive(false);
                Euse.SetActive(false);
            }
            else if (ItemValue == 2)
            {
                Ause.SetActive(false);
                Buse.SetActive(false);
                Cuse.SetActive(true);
                Duse.SetActive(false);
                Euse.SetActive(false);
            }
            else if (ItemValue == 3)
            {
                Ause.SetActive(false);
                Buse.SetActive(false);
                Cuse.SetActive(false);
                Duse.SetActive(true);
                Euse.SetActive(false);
            }
            else if (ItemValue == 4)
            {
                Ause.SetActive(false);
                Buse.SetActive(false);
                Cuse.SetActive(false);
                Duse.SetActive(false);
                Euse.SetActive(true);
            }
            else if (ItemValue == 5)
            {
                Ause.SetActive(false);
                Buse.SetActive(false);
                Cuse.SetActive(false);
                Duse.SetActive(false);
                Euse.SetActive(false);
            }
        }
    } //배치버튼 관리
    void CancelCheck()
    {
        if (ItemValue == 1)
        {
            Acancel.SetActive(true);
        }
        else if (ItemValue == 2)
        {
            Acancel.SetActive(false);
            Bcancel.SetActive(true);
        }
        else if (ItemValue == 3)
        {
            Bcancel.SetActive(false);
            Ccancel.SetActive(true);
        }
        else if (ItemValue == 4)
        {
            Ccancel.SetActive(false);
            Dcancel.SetActive(true);
        }
        else if (ItemValue == 5)
        {
            Dcancel.SetActive(false);
            Ecancel.SetActive(true);
        }
    } //취소버튼 관리
    void ItemCancel()
    {
        Ause.SetActive(false);
        Buse.SetActive(false);
        Cuse.SetActive(false);
        Duse.SetActive(false);
        Euse.SetActive(false);
    } //취소버튼 전부 해제

    public void AUSE()
    {
        Click();
        if (ItemNumber == 1)
        {
            if (Anum > 0)
            {
                AUse();
                Anum -= 1;
                PlayerPrefs.SetInt("Anum", Anum);
                Asave = 1;
                PlayerPrefs.SetInt("Asave", Asave);
                MainAsp.spriteName = Astring;
            }
        }
        if (ItemNumber == 2)
        {
            if (Bnum > 0)
            {
                AUse();
                Bnum -= 1;
                PlayerPrefs.SetInt("Bnum", Bnum);
                Asave = 2;
                PlayerPrefs.SetInt("Asave", Asave);
                MainAsp.spriteName = Bstring;
            }
        }
        if (ItemNumber == 3)
        {
            if (Cnum > 0)
            {
                AUse();
                Cnum -= 1;
                PlayerPrefs.SetInt("Cnum", Cnum);
                Asave = 3;
                PlayerPrefs.SetInt("Asave", Asave);
                MainAsp.spriteName = Cstring;
            }
        }
        if (ItemNumber == 4)
        {
            if (Dnum > 0)
            {
                AUse();
                Dnum -= 1;
                PlayerPrefs.SetInt("Dnum", Dnum);
                Asave = 4;
                PlayerPrefs.SetInt("Asave", Asave);
                MainAsp.spriteName = Dstring;
            }
        }
        if (ItemNumber == 5)
        {
            if (Enum > 0)
            {
                AUse();
                Enum -= 1;
                PlayerPrefs.SetInt("Enum", Enum);
                Asave = 5;
                PlayerPrefs.SetInt("Asave", Asave);
                MainAsp.spriteName = Estring;
            }
        }
        if (ItemNumber == 6)
        {
            if (Fnum > 0)
            {
                AUse();
                Fnum -= 1;
                PlayerPrefs.SetInt("Fnum", Fnum);
                Asave = 6;
                PlayerPrefs.SetInt("Asave", Asave);
                MainAsp.spriteName = Fstring;
            }
        }
        if (ItemNumber == 7)
        {
            if (Gnum > 0)
            {
                AUse();
                Gnum -= 1;
                PlayerPrefs.SetInt("Gnum", Gnum);
                Asave = 7;
                PlayerPrefs.SetInt("Asave", Asave);
                MainAsp.spriteName = Gstring;
            }
        }
        if (ItemNumber == 8)
        {
            if (Hnum > 0)
            {
                AUse();
                Hnum -= 1;
                PlayerPrefs.SetInt("Hnum", Hnum);
                Asave = 8;
                PlayerPrefs.SetInt("Asave", Asave);
                MainAsp.spriteName = Hstring;
            }
        }
        if (ItemNumber == 11)
        {
            if (Knum > 0)
            {
                AUse();
                Knum -= 1;
                PlayerPrefs.SetInt("Knum", Knum);
                PlayerPrefs.SetInt("KLockNum", 2);
                Asave = 11;
                PlayerPrefs.SetInt("Asave", Asave);
                MainAsp.spriteName = Kstring;
            }
        }
        if (ItemNumber == 15)
        {
            if (DORI > 0)
            {
                DoriNotion.SetActive(false);
                DoriNotion.SetActive(true);
            }
        }
        ItemCheck();
        CancelCheck();
    }
    public void BUSE()
    {
        Click();
        if (ItemNumber == 1)
        {
            if (Anum > 0)
            {
                BUse();
                Anum -= 1;
                PlayerPrefs.SetInt("Anum", Anum);
                Bsave = 1;
                PlayerPrefs.SetInt("Bsave", Bsave);
                MainBsp.spriteName = Astring;
            }
        }
        if (ItemNumber == 2)
        {
            if (Bnum > 0)
            {
                BUse();
                Bnum -= 1;
                PlayerPrefs.SetInt("Bnum", Bnum);
                Bsave = 2;
                PlayerPrefs.SetInt("Bsave", Bsave);
                MainBsp.spriteName = Bstring;
            }
        }
        if (ItemNumber == 3)
        {
            if (Cnum > 0)
            {
                BUse();
                Cnum -= 1;
                PlayerPrefs.SetInt("Cnum", Cnum);
                Bsave = 3;
                PlayerPrefs.SetInt("Bsave", Bsave);
                MainBsp.spriteName = Cstring;
            }
        }
        if (ItemNumber == 4)
        {
            if (Dnum > 0)
            {
                BUse();
                Dnum -= 1;
                PlayerPrefs.SetInt("Dnum", Dnum);
                Bsave = 4;
                PlayerPrefs.SetInt("Bsave", Bsave);
                MainBsp.spriteName = Dstring;
            }
        }
        if (ItemNumber == 5)
        {
            if (Enum > 0)
            {
                BUse();
                Enum -= 1;
                PlayerPrefs.SetInt("Enum", Enum);
                Bsave = 5;
                PlayerPrefs.SetInt("Bsave", Bsave);
                MainBsp.spriteName = Estring;
            }
        }
        if (ItemNumber == 6)
        {
            if (Fnum > 0)
            {
                BUse();
                Fnum -= 1;
                PlayerPrefs.SetInt("Fnum", Fnum);
                Bsave = 6;
                PlayerPrefs.SetInt("Bsave", Bsave);
                MainBsp.spriteName = Fstring;
            }
        }
        if (ItemNumber == 7)
        {
            if (Gnum > 0)
            {
                BUse();
                Gnum -= 1;
                PlayerPrefs.SetInt("Gnum", Gnum);
                Bsave = 7;
                PlayerPrefs.SetInt("Bsave", Bsave);
                MainBsp.spriteName = Gstring;
            }
        }
        if (ItemNumber == 8)
        {
            if (Hnum > 0)
            {
                BUse();
                Hnum -= 1;
                PlayerPrefs.SetInt("Hnum", Hnum);
                Bsave = 8;
                PlayerPrefs.SetInt("Bsave", Bsave);
                MainBsp.spriteName = Hstring;
            }
        }
        if (ItemNumber == 11)
        {
            if (Knum > 0)
            {
                BUse();
                Knum -= 1;
                PlayerPrefs.SetInt("Knum", Knum);
                PlayerPrefs.SetInt("KLockNum", 2);
                Bsave = 11;
                PlayerPrefs.SetInt("Bsave", Bsave);
                MainBsp.spriteName = Kstring;
            }
        }
        if (ItemNumber == 15)
        {
            if (DORI > 0)
            {
                DoriNotion.SetActive(false);
                DoriNotion.SetActive(true);
            }
        }
        ItemCheck();
        CancelCheck();
    }
    public void CUSE()
    {
        Click();
        if (ItemNumber == 1)
        {
            if (Anum > 0)
            {
                CUse();
                Anum -= 1;
                PlayerPrefs.SetInt("Anum", Anum);
                Csave = 1;
                PlayerPrefs.SetInt("Csave", Csave);
                MainCsp.spriteName = Astring;
            }
        }
        if (ItemNumber == 2)
        {
            if (Bnum > 0)
            {
                CUse();
                Bnum -= 1;
                PlayerPrefs.SetInt("Bnum", Bnum);
                Csave = 2;
                PlayerPrefs.SetInt("Csave", Csave);
                MainCsp.spriteName = Bstring;
            }
        }
        if (ItemNumber == 3)
        {
            if (Cnum > 0)
            {
                CUse();
                Cnum -= 1;
                PlayerPrefs.SetInt("Cnum", Cnum);
                Csave = 3;
                PlayerPrefs.SetInt("Csave", Csave);
                MainCsp.spriteName = Cstring;
            }
        }
        if (ItemNumber == 4)
        {
            if (Dnum > 0)
            {
                CUse();
                Dnum -= 1;
                PlayerPrefs.SetInt("Dnum", Dnum);
                Csave = 4;
                PlayerPrefs.SetInt("Csave", Csave);
                MainCsp.spriteName = Dstring;
            }
        }
        if (ItemNumber == 5)
        {
            if (Enum > 0)
            {
                CUse();
                Enum -= 1;
                PlayerPrefs.SetInt("Enum", Enum);
                Csave = 5;
                PlayerPrefs.SetInt("Csave", Csave);
                MainCsp.spriteName = Estring;
            }
        }
        if (ItemNumber == 6)
        {
            if (Fnum > 0)
            {
                CUse();
                Fnum -= 1;
                PlayerPrefs.SetInt("Fnum", Fnum);
                Csave = 6;
                PlayerPrefs.SetInt("Csave", Csave);
                MainCsp.spriteName = Fstring;
            }
        }
        if (ItemNumber == 7)
        {
            if (Gnum > 0)
            {
                CUse();
                Gnum -= 1;
                PlayerPrefs.SetInt("Gnum", Gnum);
                Csave = 7;
                PlayerPrefs.SetInt("Csave", Csave);
                MainCsp.spriteName = Gstring;
            }
        }
        if (ItemNumber == 8)
        {
            if (Hnum > 0)
            {
                CUse();
                Hnum -= 1;
                PlayerPrefs.SetInt("Hnum", Hnum);
                Csave = 8;
                PlayerPrefs.SetInt("Csave", Csave);
                MainCsp.spriteName = Hstring;
            }
        }
        if (ItemNumber == 11)
        {
            if (Knum > 0)
            {
                CUse();
                Knum -= 1;
                PlayerPrefs.SetInt("Knum", Knum);
                PlayerPrefs.SetInt("KLockNum", 2);
                Csave = 11;
                PlayerPrefs.SetInt("Csave", Csave);
                MainCsp.spriteName = Kstring;
            }
        }
        if (ItemNumber == 15)
        {
            if (DORI > 0)
            {
                DoriNotion.SetActive(false);
                DoriNotion.SetActive(true);
            }
        }
        ItemCheck();
        CancelCheck();
    }
    public void DUSE()
    {
        Click();
        if (ItemNumber == 1)
        {
            if (Anum > 0)
            {
                DUse();
                Anum -= 1;
                PlayerPrefs.SetInt("Anum", Anum);
                Dsave = 1;
                PlayerPrefs.SetInt("Dsave", Dsave);
                MainDsp.spriteName = Astring;
            }
        }
        if (ItemNumber == 2)
        {
            if (Bnum > 0)
            {
                DUse();
                Bnum -= 1;
                PlayerPrefs.SetInt("Bnum", Bnum);
                Dsave = 2;
                PlayerPrefs.SetInt("Dsave", Dsave);
                MainDsp.spriteName = Bstring;
            }
        }
        if (ItemNumber == 3)
        {
            if (Cnum > 0)
            {
                DUse();
                Cnum -= 1;
                PlayerPrefs.SetInt("Cnum", Cnum);
                Dsave = 3;
                PlayerPrefs.SetInt("Dsave", Dsave);
                MainDsp.spriteName = Cstring;
            }
        }
        if (ItemNumber == 4)
        {
            if (Dnum > 0)
            {
                DUse();
                Dnum -= 1;
                PlayerPrefs.SetInt("Dnum", Dnum);
                Dsave = 4;
                PlayerPrefs.SetInt("Dsave", Dsave);
                MainDsp.spriteName = Dstring;
            }
        }
        if (ItemNumber == 5)
        {
            if (Enum > 0)
            {
                DUse();
                Enum -= 1;
                PlayerPrefs.SetInt("Enum", Enum);
                Dsave = 5;
                PlayerPrefs.SetInt("Dsave", Dsave);
                MainDsp.spriteName = Estring;
            }
        }
        if (ItemNumber == 6)
        {
            if (Fnum > 0)
            {
                DUse();
                Fnum -= 1;
                PlayerPrefs.SetInt("Fnum", Fnum);
                Dsave = 6;
                PlayerPrefs.SetInt("Dsave", Dsave);
                MainDsp.spriteName = Fstring;
            }
        }
        if (ItemNumber == 7)
        {
            if (Gnum > 0)
            {
                DUse();
                Gnum -= 1;
                PlayerPrefs.SetInt("Gnum", Gnum);
                Dsave = 7;
                PlayerPrefs.SetInt("Dsave", Dsave);
                MainDsp.spriteName = Gstring;
            }
        }
        if (ItemNumber == 8)
        {
            if (Hnum > 0)
            {
                DUse();
                Hnum -= 1;
                PlayerPrefs.SetInt("Hnum", Hnum);
                Dsave = 8;
                PlayerPrefs.SetInt("Dsave", Dsave);
                MainDsp.spriteName = Hstring;
            }
        }
        if (ItemNumber == 11)
        {
            if (Knum > 0)
            {
                DUse();
                Knum -= 1;
                PlayerPrefs.SetInt("Knum", Knum);
                PlayerPrefs.SetInt("KLockNum", 2);
                Dsave = 11;
                PlayerPrefs.SetInt("Dsave", Dsave);
                MainDsp.spriteName = Kstring;
            }
        }
        if (ItemNumber == 15)
        {
            if (DORI > 0)
            {
                DoriNotion.SetActive(false);
                DoriNotion.SetActive(true);
            }
        }
        ItemCheck();
        CancelCheck();
    }
    public void EUSE()
    {
        Click();
        if (ItemNumber == 1)
        {
            if (Anum > 0)
            {
                EUse();
                Anum -= 1;
                PlayerPrefs.SetInt("Anum", Anum);
                Esave = 1;
                PlayerPrefs.SetInt("Esave", Esave);
                MainEsp.spriteName = Astring;
            }
        }
        if (ItemNumber == 2)
        {
            if (Bnum > 0)
            {
                EUse();
                Bnum -= 1;
                PlayerPrefs.SetInt("Bnum", Bnum);
                Esave = 2;
                PlayerPrefs.SetInt("Esave", Esave);
                MainEsp.spriteName = Bstring;
            }
        }
        if (ItemNumber == 3)
        {
            if (Cnum > 0)
            {
                EUse();
                Cnum -= 1;
                PlayerPrefs.SetInt("Cnum", Cnum);
                Esave = 3;
                PlayerPrefs.SetInt("Esave", Esave);
                MainEsp.spriteName = Cstring;
            }
        }
        if (ItemNumber == 4)
        {
            if (Dnum > 0)
            {
                EUse();
                Dnum -= 1;
                PlayerPrefs.SetInt("Dnum", Dnum);
                Esave = 4;
                PlayerPrefs.SetInt("Esave", Esave);
                MainEsp.spriteName = Dstring;
            }
        }
        if (ItemNumber == 5)
        {
            if (Enum > 0)
            {
                EUse();
                Enum -= 1;
                PlayerPrefs.SetInt("Enum", Enum);
                Esave = 5;
                PlayerPrefs.SetInt("Esave", Esave);
                MainEsp.spriteName = Estring;
            }
        }
        if (ItemNumber == 6)
        {
            if (Fnum > 0)
            {
                EUse();
                Fnum -= 1;
                PlayerPrefs.SetInt("Fnum", Fnum);
                Esave = 6;
                PlayerPrefs.SetInt("Esave", Esave);
                MainEsp.spriteName = Fstring;
            }
        }
        if (ItemNumber == 7)
        {
            if (Gnum > 0)
            {
                EUse();
                Gnum -= 1;
                PlayerPrefs.SetInt("Gnum", Gnum);
                Esave = 7;
                PlayerPrefs.SetInt("Esave", Esave);
                MainEsp.spriteName = Gstring;
            }
        }
        if (ItemNumber == 8)
        {
            if (Hnum > 0)
            {
                EUse();
                Hnum -= 1;
                PlayerPrefs.SetInt("Hnum", Hnum);
                Esave = 8;
                PlayerPrefs.SetInt("Esave", Esave);
                MainEsp.spriteName = Hstring;
            }
        }
        if (ItemNumber == 11)
        {
            if (Knum > 0)
            {
                EUse();
                Knum -= 1;
                PlayerPrefs.SetInt("Knum", Knum);
                PlayerPrefs.SetInt("KLockNum", 2);
                Esave = 11;
                PlayerPrefs.SetInt("Esave", Esave);
                MainEsp.spriteName = Kstring;
            }
        }
        if (ItemNumber == 15)
        {
            if (DORI > 0)
            {
                DoriNotion.SetActive(false);
                DoriNotion.SetActive(true);
            }
        }
        ItemCheck();
        CancelCheck();
    }

    void AUse()
    {
        Alabel.enabled = false;
        ItemValue = 1;
        MainAsp.enabled = true;
        NoItem += 1;
        PlayerPrefs.SetInt("NoItem", NoItem);
    }
    void BUse()
    {
        Blabel.enabled = false;
        ItemValue = 2;
        MainBsp.enabled = true;
        NoItem += 1;
        PlayerPrefs.SetInt("NoItem", NoItem);
    }
    void CUse()
    {
        Clabel.enabled = false;
        ItemValue = 3;
        MainCsp.enabled = true;
        NoItem += 1;
        PlayerPrefs.SetInt("NoItem", NoItem);
    }
    void DUse()
    {
        Dlabel.enabled = false;
        ItemValue = 4;
        MainDsp.enabled = true;
        NoItem += 1;
        PlayerPrefs.SetInt("NoItem", NoItem);
    }
    void EUse()
    {
        Elabel.enabled = false;
        ItemValue = 5;
        MainEsp.enabled = true;
        NoItem += 1;
        PlayerPrefs.SetInt("NoItem", NoItem);
    }

    public void ACANCEL()
    {
        Click();
        Acancel.SetActive(false);
        Alabel.enabled = true;
        ItemValue = 0;
        NoItem -= 1;
        PlayerPrefs.SetInt("NoItem", NoItem);
        if (Asave == 1)
        {
            MainAsp.enabled = false;
            Anum += 1;
            PlayerPrefs.SetInt("Anum", Anum);
        }
        else if (Asave == 2)
        {
            MainAsp.enabled = false;
            Bnum += 1;
            PlayerPrefs.SetInt("Bnum", Bnum);
        }
        else if (Asave == 3)
        {
            MainAsp.enabled = false;
            Cnum += 1;
            PlayerPrefs.SetInt("Cnum", Cnum);
        }
        else if (Asave == 4)
        {
            MainAsp.enabled = false;
            Dnum += 1;
            PlayerPrefs.SetInt("Dnum", Dnum);
        }
        else if (Asave == 5)
        {
            MainAsp.enabled = false;
            Enum += 1;
            PlayerPrefs.SetInt("Enum", Enum);
        }
        else if (Asave == 6)
        {
            MainAsp.enabled = false;
            Fnum += 1;
            PlayerPrefs.SetInt("Fnum", Fnum);
        }
        else if (Asave == 7)
        {
            MainAsp.enabled = false;
            Gnum += 1;
            PlayerPrefs.SetInt("Gnum", Gnum);
        }
        else if (Asave == 8)
        {
            MainAsp.enabled = false;
            Hnum += 1;
            PlayerPrefs.SetInt("Hnum", Hnum);
        }
        else if (Asave == 11)
        {
            MainAsp.enabled = false;
            Knum += 1;
            PlayerPrefs.SetInt("Knum", Knum);
            PlayerPrefs.SetInt("KLockNum", 1);
        }
        Asave = 0;
        PlayerPrefs.SetInt("Asave", Asave);
        ItemCheck();
    }
    public void BCANCEL()
    {
        Click();
        Acancel.SetActive(true);
        Bcancel.SetActive(false);
        Blabel.enabled = true;
        ItemValue = 1;
        NoItem -= 1;
        PlayerPrefs.SetInt("NoItem", NoItem);
        if (Bsave == 1)
        {
            MainBsp.enabled = false;
            Anum += 1;
            PlayerPrefs.SetInt("Anum", Anum);
        }
        else if (Bsave == 2)
        {
            MainBsp.enabled = false;
            Bnum += 1;
            PlayerPrefs.SetInt("Bnum", Bnum);
        }
        else if (Bsave == 3)
        {
            MainBsp.enabled = false;
            Cnum += 1;
            PlayerPrefs.SetInt("Cnum", Cnum);
        }
        else if (Bsave == 4)
        {
            MainBsp.enabled = false;
            Dnum += 1;
            PlayerPrefs.SetInt("Dnum", Dnum);
        }
        else if (Bsave == 5)
        {
            MainBsp.enabled = false;
            Enum += 1;
            PlayerPrefs.SetInt("Enum", Enum);
        }
        else if (Bsave == 6)
        {
            MainBsp.enabled = false;
            Fnum += 1;
            PlayerPrefs.SetInt("Fnum", Fnum);
        }
        else if (Bsave == 7)
        {
            MainBsp.enabled = false;
            Gnum += 1;
            PlayerPrefs.SetInt("Gnum", Gnum);
        }
        else if (Bsave == 8)
        {
            MainBsp.enabled = false;
            Hnum += 1;
            PlayerPrefs.SetInt("Hnum", Hnum);
        }
        else if (Bsave == 11)
        {
            MainBsp.enabled = false;
            Knum += 1;
            PlayerPrefs.SetInt("Knum", Knum);
            PlayerPrefs.SetInt("KLockNum", 1);
        }
        Bsave = 0;
        PlayerPrefs.SetInt("Bsave", Bsave);
        ItemCheck();
    }
    public void CCANCEL()
    {
        Click();
        Acancel.SetActive(false);
        Bcancel.SetActive(true);
        Ccancel.SetActive(false);
        Clabel.enabled = true;
        ItemValue = 2;
        NoItem -= 1;
        PlayerPrefs.SetInt("NoItem", NoItem);
        if (Csave == 1)
        {
            MainCsp.enabled = false;
            Anum += 1;
            PlayerPrefs.SetInt("Anum", Anum);
        }
        else if (Csave == 2)
        {
            MainCsp.enabled = false;
            Bnum += 1;
            PlayerPrefs.SetInt("Bnum", Bnum);
        }
        else if (Csave == 3)
        {
            MainCsp.enabled = false;
            Cnum += 1;
            PlayerPrefs.SetInt("Cnum", Cnum);
        }
        else if (Csave == 4)
        {
            MainCsp.enabled = false;
            Dnum += 1;
            PlayerPrefs.SetInt("Dnum", Dnum);
        }
        else if (Csave == 5)
        {
            MainCsp.enabled = false;
            Enum += 1;
            PlayerPrefs.SetInt("Enum", Enum);
        }
        else if (Csave == 6)
        {
            MainCsp.enabled = false;
            Fnum += 1;
            PlayerPrefs.SetInt("Fnum", Fnum);
        }
        else if (Csave == 7)
        {
            MainCsp.enabled = false;
            Gnum += 1;
            PlayerPrefs.SetInt("Gnum", Gnum);
        }
        else if (Csave == 8)
        {
            MainCsp.enabled = false;
            Hnum += 1;
            PlayerPrefs.SetInt("Hnum", Hnum);
        }
        else if (Csave == 11)
        {
            MainCsp.enabled = false;
            Knum += 1;
            PlayerPrefs.SetInt("Knum", Knum);
            PlayerPrefs.SetInt("KLockNum", 1);
        }
        Csave = 0;
        PlayerPrefs.SetInt("Csave", Csave);
        ItemCheck();
    }
    public void DCANCEL()
    {
        Click();
        Acancel.SetActive(false);
        Bcancel.SetActive(false);
        Ccancel.SetActive(true);
        Dcancel.SetActive(false);
        Dlabel.enabled = true;
        ItemValue = 3;
        NoItem -= 1;
        PlayerPrefs.SetInt("NoItem", NoItem);
        if (Dsave == 1)
        {
            MainDsp.enabled = false;
            Anum += 1;
            PlayerPrefs.SetInt("Anum", Anum);
        }
        else if (Dsave == 2)
        {
            MainDsp.enabled = false;
            Bnum += 1;
            PlayerPrefs.SetInt("Bnum", Bnum);
        }
        else if (Dsave == 3)
        {
            MainDsp.enabled = false;
            Cnum += 1;
            PlayerPrefs.SetInt("Cnum", Cnum);
        }
        else if (Dsave == 4)
        {
            MainDsp.enabled = false;
            Dnum += 1;
            PlayerPrefs.SetInt("Dnum", Dnum);
        }
        else if (Dsave == 5)
        {
            MainDsp.enabled = false;
            Enum += 1;
            PlayerPrefs.SetInt("Enum", Enum);
        }
        else if (Dsave == 6)
        {
            MainDsp.enabled = false;
            Fnum += 1;
            PlayerPrefs.SetInt("Fnum", Fnum);
        }
        else if (Dsave == 7)
        {
            MainDsp.enabled = false;
            Gnum += 1;
            PlayerPrefs.SetInt("Gnum", Gnum);
        }
        else if (Dsave == 8)
        {
            MainDsp.enabled = false;
            Hnum += 1;
            PlayerPrefs.SetInt("Hnum", Hnum);
        }
        else if (Dsave == 11)
        {
            MainDsp.enabled = false;
            Knum += 1;
            PlayerPrefs.SetInt("Knum", Knum);
            PlayerPrefs.SetInt("KLockNum", 1);
        }
        Dsave = 0;
        PlayerPrefs.SetInt("Dsave", Dsave);
        ItemCheck();
    }
    public void ECANCEL()
    {
        Click();
        Acancel.SetActive(false);
        Bcancel.SetActive(false);
        Ccancel.SetActive(false);
        Dcancel.SetActive(true);
        Ecancel.SetActive(false);
        Elabel.enabled = true;
        ItemValue = 4;
        NoItem -= 1;
        PlayerPrefs.SetInt("NoItem", NoItem);
        if (Esave == 1)
        {
            MainEsp.enabled = false;
            Anum += 1;
            PlayerPrefs.SetInt("Anum", Anum);
        }
        else if (Esave == 2)
        {
            MainEsp.enabled = false;
            Bnum += 1;
            PlayerPrefs.SetInt("Bnum", Bnum);
        }
        else if (Esave == 3)
        {
            MainEsp.enabled = false;
            Cnum += 1;
            PlayerPrefs.SetInt("Cnum", Cnum);
        }
        else if (Esave == 4)
        {
            MainEsp.enabled = false;
            Dnum += 1;
            PlayerPrefs.SetInt("Dnum", Dnum);
        }
        else if (Esave == 5)
        {
            MainEsp.enabled = false;
            Enum += 1;
            PlayerPrefs.SetInt("Enum", Enum);
        }
        else if (Esave == 6)
        {
            MainEsp.enabled = false;
            Fnum += 1;
            PlayerPrefs.SetInt("Fnum", Fnum);
        }
        else if (Esave == 7)
        {
            MainEsp.enabled = false;
            Gnum += 1;
            PlayerPrefs.SetInt("Gnum", Gnum);
        }
        else if (Esave == 8)
        {
            MainEsp.enabled = false;
            Hnum += 1;
            PlayerPrefs.SetInt("Hnum", Hnum);
        }
        else if (Esave == 11)
        {
            MainEsp.enabled = false;
            Knum += 1;
            PlayerPrefs.SetInt("Knum", Knum);
            PlayerPrefs.SetInt("KLockNum", 1);
        }
        Esave = 0;
        PlayerPrefs.SetInt("Esave", Esave);
        ItemCheck();
    }

    public void NotItem()
    {
        Click();
        Notion.SetActive(false);
        Notion.SetActive(true);
    }

    public void Exit()
    {
        Click();
        UpgradeWindow.SetActive(false);
    }
    public void Upgrade()
    {
        Click();
        if (ItemNumber == 0)
        {
            UpNotion.SetActive(false);
            UpNotion.SetActive(true);
        }
        else if (ItemNumber == 1)
        {
            Mainsp.spriteName = Astring;
            UpgradeWindow.SetActive(true);
            if (ALv == 0)
            {
                Numtxt.text = Anum.ToString() + "/20";
                Numsp.fillAmount = Anum * 0.05f;

                Titletxt.text = "레벨 1 하트";

                NowLvtxt.text = "레벨 1";
                NowAtxt.text = "Hp 40% 회복";
                NowBtxt.text = "지속시간 : 즉시";

                NextLvtxt.text = "레벨 2";
                NextAtxt.text = "Hp 45% 회복";
                NextBtxt.text = "지속시간 : 즉시";

                Cointxt.text = "5000";
            }
            else if (ALv == 1)
            {
                Numtxt.text = Anum.ToString() + "/40";
                Numsp.fillAmount = Anum * 0.025f;

                Titletxt.text = "레벨 2 하트";

                NowLvtxt.text = "레벨 2";
                NowAtxt.text = "Hp 45% 회복";
                NowBtxt.text = "지속시간 : 즉시";

                NextLvtxt.text = "레벨 3";
                NextAtxt.text = "Hp 50% 회복";
                NextBtxt.text = "지속시간 : 즉시";

                Cointxt.text = "10000";
            }
            else if (ALv == 2)
            {
                Numtxt.text = Anum.ToString() + "/100";
                Numsp.fillAmount = Anum * 0.01f;

                Titletxt.text = "레벨 3 하트";

                NowLvtxt.text = "레벨 3";
                NowAtxt.text = "Hp 50% 회복";
                NowBtxt.text = "지속시간 : 즉시";

                NextLvtxt.text = "레벨 4";
                NextAtxt.text = "Hp 55% 회복";
                NextBtxt.text = "지속시간 : 즉시";

                Cointxt.text = "25000";
            }
            else if (ALv == 3)
            {
                Numtxt.text = Anum.ToString() + "/200";
                Numsp.fillAmount = Anum * 0.005f;

                Titletxt.text = "레벨 4 하트";

                NowLvtxt.text = "레벨 4";
                NowAtxt.text = "Hp 55% 회복";
                NowBtxt.text = "지속시간 : 즉시";

                NextLvtxt.text = "레벨 5";
                NextAtxt.text = "Hp 60% 회복";
                NextBtxt.text = "지속시간 : 즉시";

                Cointxt.text = "50000";
            }
            else if (ALv == 4)
            {
                Numtxt.text = Anum.ToString() + "/400";
                Numsp.fillAmount = Anum * 0.0025f;

                Titletxt.text = "레벨 5 하트";

                NowLvtxt.text = "레벨 5";
                NowAtxt.text = "Hp 60% 회복";
                NowBtxt.text = "지속시간 : 즉시";

                NextLvtxt.text = "레벨 6";
                NextAtxt.text = "Hp 65% 회복";
                NextBtxt.text = "지속시간 : 즉시";

                Cointxt.text = "100000";
            }
            else if (ALv == 5)
            {
                Numtxt.text = Anum.ToString() + "/800";
                Numsp.fillAmount = Anum * 0.00125f;

                Titletxt.text = "레벨 6 하트";

                NowLvtxt.text = "레벨 6";
                NowAtxt.text = "Hp 65% 회복";
                NowBtxt.text = "지속시간 : 즉시";

                NextLvtxt.text = "레벨 7";
                NextAtxt.text = "Hp 70% 회복";
                NextBtxt.text = "지속시간 : 즉시";

                Cointxt.text = "250000";
            }
            else if (ALv == 6)
            {
                Numtxt.text = Anum.ToString() + "/0";
                Numsp.fillAmount = Anum * 1f;

                Titletxt.text = "레벨 7 하트";

                NowLvtxt.text = "레벨 7";
                NowAtxt.text = "Hp 70% 회복";
                NowBtxt.text = "지속시간 : 즉시";

                NextLvtxt.text = "레벨 Max";
                NextAtxt.text = "Hp 70% 회복";
                NextBtxt.text = "지속시간 : 즉시";

                Cointxt.text = "Max ";
            }
        }
        else if (ItemNumber == 2)
        {
            Mainsp.spriteName = Bstring;
            UpgradeWindow.SetActive(true);
            if (BLv == 0)
            {
                Numtxt.text = Bnum.ToString() + "/20";
                Numsp.fillAmount = Bnum * 0.05f;

                Titletxt.text = "레벨 1 자석";

                NowLvtxt.text = "레벨 1";
                NowAtxt.text = "만두 당겨오기";
                NowBtxt.text = "지속시간 : 15초";

                NextLvtxt.text = "레벨 2";
                NextAtxt.text = "만두 당겨오기";
                NextBtxt.text = "지속시간 : 16초";

                Cointxt.text = "5000";
            }
            else if(BLv == 1)
            {
                Numtxt.text = Bnum.ToString() + "/40";
                Numsp.fillAmount = Bnum * 0.025f;

                Titletxt.text = "레벨 2 자석";

                NowLvtxt.text = "레벨 2";
                NowAtxt.text = "만두 당겨오기";
                NowBtxt.text = "지속시간 : 16초";

                NextLvtxt.text = "레벨 3";
                NextAtxt.text = "만두 당겨오기";
                NextBtxt.text = "지속시간 : 17초";

                Cointxt.text = "10000";
            }
            else if (BLv == 2)
            {
                Numtxt.text = Bnum.ToString() + "/100";
                Numsp.fillAmount = Bnum * 0.01f;

                Titletxt.text = "레벨 3 자석";

                NowLvtxt.text = "레벨 3";
                NowAtxt.text = "만두 당겨오기";
                NowBtxt.text = "지속시간 : 17초";

                NextLvtxt.text = "레벨 4";
                NextAtxt.text = "만두 당겨오기";
                NextBtxt.text = "지속시간 : 18초";

                Cointxt.text = "25000";
            }
            else if (BLv == 3)
            {
                Numtxt.text = Bnum.ToString() + "/200";
                Numsp.fillAmount = Bnum * 0.005f;

                Titletxt.text = "레벨 4 자석";

                NowLvtxt.text = "레벨 4";
                NowAtxt.text = "만두 당겨오기";
                NowBtxt.text = "지속시간 : 18초";

                NextLvtxt.text = "레벨 5";
                NextAtxt.text = "만두 당겨오기";
                NextBtxt.text = "지속시간 : 19초";

                Cointxt.text = "50000";
            }
            else if (BLv == 4)
            {
                Numtxt.text = Bnum.ToString() + "/400";
                Numsp.fillAmount = Bnum * 0.0025f;

                Titletxt.text = "레벨 5 자석";

                NowLvtxt.text = "레벨 5";
                NowAtxt.text = "만두 당겨오기";
                NowBtxt.text = "지속시간 : 19초";

                NextLvtxt.text = "레벨 6";
                NextAtxt.text = "만두 당겨오기";
                NextBtxt.text = "지속시간 : 20초";

                Cointxt.text = "100000";
            }
            else if (BLv == 5)
            {
                Numtxt.text = Bnum.ToString() + "/800";
                Numsp.fillAmount = Bnum * 0.00125f;

                Titletxt.text = "레벨 6 자석";

                NowLvtxt.text = "레벨 6";
                NowAtxt.text = "만두 당겨오기";
                NowBtxt.text = "지속시간 : 20초";

                NextLvtxt.text = "레벨 7";
                NextAtxt.text = "만두 당겨오기";
                NextBtxt.text = "지속시간 : 21초";

                Cointxt.text = "250000";
            }
            else if (BLv == 6)
            {
                Numtxt.text = Bnum.ToString() + "/0";
                Numsp.fillAmount = Bnum * 1f;

                Titletxt.text = "레벨 7 자석";

                NowLvtxt.text = "레벨 7";
                NowAtxt.text = "만두 당겨오기";
                NowBtxt.text = "지속시간 : 21초";

                NextLvtxt.text = "레벨 Max";
                NextAtxt.text = "만두 당겨오기";
                NextBtxt.text = "지속시간 : 21초";

                Cointxt.text = "Max ";
            }
        }
        else
        {
            DownNotion.SetActive(false);
            DownNotion.SetActive(true);
        }
    }
    public void UpgradeOK()
    {
        Click();
        if (ItemNumber == 1)
        {
            if (ALv == 0)
            {
                if (Anum >= 20)
                {
                    if (UNIT >= 5000)
                    {
                        Coin();
                        UpgradeWindow.SetActive(false);
                        ALv += 1;
                        PlayerPrefs.SetInt("ALv", ALv);
                        Anum -= 20;
                        PlayerPrefs.SetInt("Anum", Anum);
                        UNIT -= 5000;
                        PlayerPrefs.SetInt("UNIT", UNIT);

                        ItemInfoTwo.text = "효과 : HP 45% 회복";
                        PlayerPrefs.SetInt("HEART", 1);

                        UpgradeNotion.SetActive(true);
                    }
                    else
                    {
                        CoinNotion.SetActive(false);
                        CoinNotion.SetActive(true);
                    }
                }
                else
                {
                    NumNotion.SetActive(false);
                    NumNotion.SetActive(true);
                }
            }
            else if (ALv == 1)
            {
                if (Anum >= 40)
                {
                    if (UNIT >= 10000)
                    {
                        Coin();
                        UpgradeWindow.SetActive(false);
                        ALv += 1;
                        PlayerPrefs.SetInt("ALv", ALv);
                        Anum -= 40;
                        PlayerPrefs.SetInt("Anum", Anum);
                        UNIT -= 10000;
                        PlayerPrefs.SetInt("UNIT", UNIT);

                        ItemInfoTwo.text = "효과 : HP 50% 회복";
                        PlayerPrefs.SetInt("HEART", 2);

                        UpgradeNotion.SetActive(true);
                    }
                    else
                    {
                        CoinNotion.SetActive(false);
                        CoinNotion.SetActive(true);
                    }
                }
                else
                {
                    NumNotion.SetActive(false);
                    NumNotion.SetActive(true);
                }
            }
            else if (ALv == 2)
            {
                if (Anum >= 100)
                {
                    if (UNIT >= 25000)
                    {
                        Coin();
                        UpgradeWindow.SetActive(false);
                        ALv += 1;
                        PlayerPrefs.SetInt("ALv", ALv);
                        Anum -= 100;
                        PlayerPrefs.SetInt("Anum", Anum);
                        UNIT -= 25000;
                        PlayerPrefs.SetInt("UNIT", UNIT);

                        ItemInfoTwo.text = "효과 : HP 55% 회복";
                        PlayerPrefs.SetInt("HEART", 3);

                        UpgradeNotion.SetActive(true);
                    }
                    else
                    {
                        CoinNotion.SetActive(false);
                        CoinNotion.SetActive(true);
                    }
                }
                else
                {
                    NumNotion.SetActive(false);
                    NumNotion.SetActive(true);
                }
            }
            else if (ALv == 3)
            {
                if (Anum >= 200)
                {
                    if (UNIT >= 50000)
                    {
                        Coin();
                        UpgradeWindow.SetActive(false);
                        ALv += 1;
                        PlayerPrefs.SetInt("ALv", ALv);
                        Anum -= 200;
                        PlayerPrefs.SetInt("Anum", Anum);
                        UNIT -= 50000;
                        PlayerPrefs.SetInt("UNIT", UNIT);

                        ItemInfoTwo.text = "효과 : HP 60% 회복";
                        PlayerPrefs.SetInt("HEART", 4);

                        UpgradeNotion.SetActive(true);
                    }
                    else
                    {
                        CoinNotion.SetActive(false);
                        CoinNotion.SetActive(true);
                    }
                }
                else
                {
                    NumNotion.SetActive(false);
                    NumNotion.SetActive(true);
                }
            }
            else if (ALv == 4)
            {
                if (Anum >= 400)
                {
                    if (UNIT >= 100000)
                    {
                        Coin();
                        UpgradeWindow.SetActive(false);
                        ALv += 1;
                        PlayerPrefs.SetInt("ALv", ALv);
                        Anum -= 400;
                        PlayerPrefs.SetInt("Anum", Anum);
                        UNIT -= 100000;
                        PlayerPrefs.SetInt("UNIT", UNIT);

                        ItemInfoTwo.text = "효과 : HP 65% 회복";
                        PlayerPrefs.SetInt("HEART", 5);

                        UpgradeNotion.SetActive(true);
                    }
                    else
                    {
                        CoinNotion.SetActive(false);
                        CoinNotion.SetActive(true);
                    }
                }
                else
                {
                    NumNotion.SetActive(false);
                    NumNotion.SetActive(true);
                }
            }
            else if (ALv == 5)
            {
                if (Anum >= 800)
                {
                    if (UNIT >= 250000)
                    {
                        Coin();
                        UpgradeWindow.SetActive(false);
                        ALv += 1;
                        PlayerPrefs.SetInt("ALv", ALv);
                        Anum -= 800;
                        PlayerPrefs.SetInt("Anum", Anum);
                        UNIT -= 250000;
                        PlayerPrefs.SetInt("UNIT", UNIT);

                        ItemInfoTwo.text = "효과 : HP 70% 회복";
                        PlayerPrefs.SetInt("HEART", 6);

                        UpgradeNotion.SetActive(true);
                    }
                    else
                    {
                        CoinNotion.SetActive(false);
                        CoinNotion.SetActive(true);
                    }
                }
                else
                {
                    NumNotion.SetActive(false);
                    NumNotion.SetActive(true);
                }
            }
        }
        else if(ItemNumber == 2)
        {
            if (BLv == 0)
            {
                if (Bnum >= 20)
                {
                    if (UNIT >= 5000)
                    {
                        Coin();
                        UpgradeWindow.SetActive(false);
                        BLv += 1;
                        PlayerPrefs.SetInt("BLv", BLv);
                        Bnum -= 20;
                        PlayerPrefs.SetInt("Bnum", Bnum);
                        UNIT -= 5000;
                        PlayerPrefs.SetInt("UNIT", UNIT);

                        ItemInfoFour.text = "지속시간 : 16초";
                        PlayerPrefs.SetInt("MAGNET", 1);

                        UpgradeNotion.SetActive(true);
                    }
                    else
                    {
                        CoinNotion.SetActive(false);
                        CoinNotion.SetActive(true);
                    }
                }
                else
                {
                    NumNotion.SetActive(false);
                    NumNotion.SetActive(true);
                }
            }
            else if (BLv == 1)
            {
                if (Bnum >= 40)
                {
                    if (UNIT >= 10000)
                    {
                        Coin();
                        UpgradeWindow.SetActive(false);
                        BLv += 1;
                        PlayerPrefs.SetInt("BLv", BLv);
                        Bnum -= 40;
                        PlayerPrefs.SetInt("Bnum", Bnum);
                        UNIT -= 10000;
                        PlayerPrefs.SetInt("UNIT", UNIT);

                        ItemInfoFour.text = "지속시간 : 17초";
                        PlayerPrefs.SetInt("MAGNET", 2);

                        UpgradeNotion.SetActive(true);
                    }
                    else
                    {
                        CoinNotion.SetActive(false);
                        CoinNotion.SetActive(true);
                    }
                }
                else
                {
                    NumNotion.SetActive(false);
                    NumNotion.SetActive(true);
                }
            }
            else if (BLv == 2)
            {
                if (Bnum >= 100)
                {
                    if (UNIT >= 25000)
                    {
                        Coin();
                        UpgradeWindow.SetActive(false);
                        BLv += 1;
                        PlayerPrefs.SetInt("BLv", BLv);
                        Bnum -= 100;
                        PlayerPrefs.SetInt("Bnum", Bnum);
                        UNIT -= 25000;
                        PlayerPrefs.SetInt("UNIT", UNIT);

                        ItemInfoFour.text = "지속시간 : 18초";
                        PlayerPrefs.SetInt("MAGNET", 3);

                        UpgradeNotion.SetActive(true);
                    }
                    else
                    {
                        CoinNotion.SetActive(false);
                        CoinNotion.SetActive(true);
                    }
                }
                else
                {
                    NumNotion.SetActive(false);
                    NumNotion.SetActive(true);
                }
            }
            else if (BLv == 3)
            {
                if (Bnum >= 200)
                {
                    if (UNIT >= 50000)
                    {
                        Coin();
                        UpgradeWindow.SetActive(false);
                        BLv += 1;
                        PlayerPrefs.SetInt("BLv", BLv);
                        Bnum -= 200;
                        PlayerPrefs.SetInt("Bnum", Bnum);
                        UNIT -= 50000;
                        PlayerPrefs.SetInt("UNIT", UNIT);

                        ItemInfoFour.text = "지속시간 : 19초";
                        PlayerPrefs.SetInt("MAGNET", 4);

                        UpgradeNotion.SetActive(true);
                    }
                    else
                    {
                        CoinNotion.SetActive(false);
                        CoinNotion.SetActive(true);
                    }
                }
                else
                {
                    NumNotion.SetActive(false);
                    NumNotion.SetActive(true);
                }
            }
            else if (BLv == 4)
            {
                if (Bnum >= 400)
                {
                    if (UNIT >= 100000)
                    {
                        Coin();
                        UpgradeWindow.SetActive(false);
                        BLv += 1;
                        PlayerPrefs.SetInt("BLv", BLv);
                        Bnum -= 400;
                        PlayerPrefs.SetInt("Bnum", Bnum);
                        UNIT -= 100000;
                        PlayerPrefs.SetInt("UNIT", UNIT);

                        ItemInfoFour.text = "지속시간 : 20초";
                        PlayerPrefs.SetInt("MAGNET", 5);

                        UpgradeNotion.SetActive(true);
                    }
                    else
                    {
                        CoinNotion.SetActive(false);
                        CoinNotion.SetActive(true);
                    }
                }
                else
                {
                    NumNotion.SetActive(false);
                    NumNotion.SetActive(true);
                }
            }
            else if (BLv == 5)
            {
                if (Bnum >= 800)
                {
                    if (UNIT >= 250000)
                    {
                        Coin();
                        UpgradeWindow.SetActive(false);
                        BLv += 1;
                        PlayerPrefs.SetInt("BLv", BLv);
                        Bnum -= 800;
                        PlayerPrefs.SetInt("Bnum", Bnum);
                        UNIT -= 250000;
                        PlayerPrefs.SetInt("UNIT", UNIT);

                        ItemInfoFour.text = "지속시간 : 20초";
                        PlayerPrefs.SetInt("MAGNET", 6);

                        UpgradeNotion.SetActive(true);
                    }
                    else
                    {
                        CoinNotion.SetActive(false);
                        CoinNotion.SetActive(true);
                    }
                }
                else
                {
                    NumNotion.SetActive(false);
                    NumNotion.SetActive(true);
                }
            }
        }
    }
}
