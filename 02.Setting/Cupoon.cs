using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class Cupoon : MonoBehaviour {
    public UISprite black;
    public UILabel input;
    public UILabel MainNickName;

    private string Input;
    private string Cupoon1 = "201610108"; //다이아50
    private string Cupoon2 = "589632147"; //다이아50
    private string Cupoon3 = "543761892"; //다이아100
    private string Cupoon4 = "945678321"; //다이아100
    private string Cupoon5 = "958736412"; //다이아200
    private string Cupoon6 = "697413258"; //코인50000
    private string Cupoon7 = "498673512"; //코인50000
    private string Cupoon8 = "698325741"; //코인100000
    private string Cupoon9 = "164379852"; //코인100000

    private string Cupoon10 = "289734165"; //도라의깃털999 + 마일리지99

    //인맥 전용 쿠폰
    private string CupoonVip = "721019108"; //다이아10000
    private string CupoonVVip = "031419108"; //다이아100000
    private string CupoonGold = "784951623"; //황금 알 오픈
    private string CupoonHidden = "326159487"; //히든 오픈

    private int cupoon1;
    private int cupoon2;
    private int cupoon3;
    private int cupoon4;
    private int cupoon5;
    private int cupoon6;
    private int cupoon7;
    private int cupoon8;
    private int cupoon9;
    private int cupoon10;
    private int cupoonVip;
    private int cupoonVVip;
    private int cupoonGold;
    private int cupoonHidden;

    private int BD;
    private int UNIT;

    private int InputNum;
    private int Cupoon1Num;
    private int Cupoon2Num;
    private int Cupoon3Num;
    private int Cupoon4Num;
    private int Cupoon5Num;
    private int Cupoon6Num;
    private int Cupoon7Num;
    private int Cupoon8Num;
    private int Cupoon9Num;
    private int Cupoon10Num;
    private int CupoonVipNum;
    private int CupoonVVipNum;
    private int CupoonGoldNum;
    private int CupoonHiddenNum;

    private int Tutorial;

    private AudioSource source;
    public AudioClip Click;

    public GameObject CupoonGet;
    public GameObject CupoonFail;
    public GameObject CupoonNo;
    public UILabel CupoonName; //어떤 아이템인지 설명
    private int CupponNameNum;

    //닉네임
    public GameObject NickNameChange;
    public GameObject Notion;
    public GameObject NickExit;
    public UILabel mainlabel;
    public UILabel titlelabel;
    public UILabel NickNameinput;
    private string NickNameInput;
    private int NickNameNum;

    void Awake () {
        source = GetComponent<AudioSource>();

        Cupoon1Num = int.Parse(Cupoon1);
        Cupoon2Num = int.Parse(Cupoon2);
        Cupoon3Num = int.Parse(Cupoon3);
        Cupoon4Num = int.Parse(Cupoon4);
        Cupoon5Num = int.Parse(Cupoon5);
        Cupoon6Num = int.Parse(Cupoon6);
        Cupoon7Num = int.Parse(Cupoon7);
        Cupoon8Num = int.Parse(Cupoon8);
        Cupoon9Num = int.Parse(Cupoon9);
        Cupoon10Num = int.Parse(Cupoon10);
        CupoonVipNum = int.Parse(CupoonVip);
        CupoonVVipNum = int.Parse(CupoonVVip);
        CupoonGoldNum = int.Parse(CupoonGold);
        CupoonHiddenNum = int.Parse(CupoonHidden);

        CupoonGet.SetActive(false);
        CupoonFail.SetActive(false);
        CupoonNo.SetActive(false);
        NickExit.SetActive(false);

        Tutorial = PlayerPrefs.GetInt("Tutorial", 0);
        BD = PlayerPrefs.GetInt("BD", 0);
        UNIT = PlayerPrefs.GetInt("UNIT", 0);

        cupoon1 = PlayerPrefs.GetInt("cupoon1", 0);
        cupoon2 = PlayerPrefs.GetInt("cupoon2", 0);
        cupoon3 = PlayerPrefs.GetInt("cupoon3", 0);
        cupoon4 = PlayerPrefs.GetInt("cupoon4", 0);
        cupoon5 = PlayerPrefs.GetInt("cupoon5", 0);
        cupoon6 = PlayerPrefs.GetInt("cupoon6", 0);
        cupoon7 = PlayerPrefs.GetInt("cupoon7", 0);
        cupoon8 = PlayerPrefs.GetInt("cupoon8", 0);
        cupoon9 = PlayerPrefs.GetInt("cupoon9", 0);
        cupoon10 = PlayerPrefs.GetInt("cupoon10", 0);
        cupoonVip = PlayerPrefs.GetInt("cupoonVip", 0);
        cupoonVVip = PlayerPrefs.GetInt("cupoonVVip", 0);
        cupoonGold = PlayerPrefs.GetInt("cupoonGold", 0);
        cupoonHidden = PlayerPrefs.GetInt("cupoonHidden", 0);

        black.enabled = false;

        if (Tutorial == 2)
        {
            MainNickName.text = PlayerPrefs.GetString("NickName");
        }
    }

    void OnEnable()
    {
        Select.Nick += Nick;
    }
    void OnDisable()
    {
        Select.Nick -= Nick;

    }

    void Nick()
    {
        Tutorial = PlayerPrefs.GetInt("Tutorial", 0);
        if (Tutorial ==1)
        {
            NickNameChange.SetActive(true);
            Select.screen = 2;
            black.enabled = true;
            black.alpha = 0.4f;
            titlelabel.text = "닉네임 입력";
            mainlabel.text = "게임에서 사용할 닉네임을 입력해주세요(4자~6자)\n[주의] 간혹 인식 못하는 글자가 있을 수 있습니다";
        }
    }

    public void Enter()
    {
        source.PlayOneShot(Click, 0.75f);
        PlayerPrefs.SetString("Input", input.text);
        Input = PlayerPrefs.GetString("Input");
        CupponNameNum = Input.Length;
        if (CupponNameNum < 9)
        {
            Notion.SetActive(false);
            Notion.SetActive(true);
        }
        else
        {
            InputNum = int.Parse(Input);
            if (InputNum == Cupoon1Num)
            {
                if (cupoon1 == 0)
                {
                    CupoonGet.SetActive(true);
                    CupoonName.text = "다이아 50 쿠폰";
                    BD += 50;
                    PlayerPrefs.SetInt("BD", BD);
                    cupoon1 = 1;
                    PlayerPrefs.SetInt("cupoon1", 1);
                }
                else
                {
                    CupoonNo.SetActive(true);
                }
            }
            else if (InputNum == Cupoon2Num)
            {
                if (cupoon2 == 0)
                {
                    CupoonGet.SetActive(true);
                    CupoonName.text = "다이아 50 쿠폰";
                    BD += 50;
                    PlayerPrefs.SetInt("BD", BD);
                    cupoon2 = 1;
                    PlayerPrefs.SetInt("cupoon2", 1);
                }
                else
                {
                    CupoonNo.SetActive(true);
                }
            }
            else if (InputNum == Cupoon3Num)
            {
                if (cupoon3 == 0)
                {
                    CupoonGet.SetActive(true);
                    CupoonName.text = "다이아 100 쿠폰";
                    BD += 100;
                    PlayerPrefs.SetInt("BD", BD);
                    cupoon3 = 1;
                    PlayerPrefs.SetInt("cupoon3", 1);
                }
                else
                {
                    CupoonNo.SetActive(true);
                }
            }
            else if (InputNum == Cupoon4Num)
            {
                if (cupoon4 == 0)
                {
                    CupoonGet.SetActive(true);
                    CupoonName.text = "다이아 100 쿠폰";
                    BD += 100;
                    PlayerPrefs.SetInt("BD", BD);
                    cupoon4 = 1;
                    PlayerPrefs.SetInt("cupoon4", 1);
                }
                else
                {
                    CupoonNo.SetActive(true);
                }
            }
            else if (InputNum == Cupoon5Num)
            {
                if (cupoon5 == 0)
                {
                    CupoonGet.SetActive(true);
                    CupoonName.text = "다이아 200 쿠폰";
                    BD += 200;
                    PlayerPrefs.SetInt("BD", BD);
                    cupoon5 = 1;
                    PlayerPrefs.SetInt("cupoon5", 1);
                }
                else
                {
                    CupoonNo.SetActive(true);
                }
            }
            else if (InputNum == Cupoon6Num)
            {
                if (cupoon6 == 0)
                {
                    CupoonGet.SetActive(true);
                    CupoonName.text = "코인 50000 쿠폰";
                    UNIT += 50000;
                    PlayerPrefs.SetInt("UNIT", UNIT);
                    cupoon6 = 1;
                    PlayerPrefs.SetInt("cupoon6", 1);
                }
                else
                {
                    CupoonNo.SetActive(true);
                }
            }
            else if (InputNum == Cupoon7Num)
            {
                if (cupoon7 == 0)
                {
                    CupoonGet.SetActive(true);
                    CupoonName.text = "코인 50000 쿠폰";
                    UNIT += 50000;
                    PlayerPrefs.SetInt("UNIT", UNIT);
                    cupoon7 = 1;
                    PlayerPrefs.SetInt("cupoon7", 1);
                }
                else
                {
                    CupoonNo.SetActive(true);
                }
            }
            else if (InputNum == Cupoon8Num)
            {
                if (cupoon8 == 0)
                {
                    CupoonGet.SetActive(true);
                    CupoonName.text = "코인 100000 쿠폰";
                    UNIT += 100000;
                    PlayerPrefs.SetInt("UNIT", UNIT);
                    cupoon8 = 1;
                    PlayerPrefs.SetInt("cupoon8", 1);
                }
                else
                {
                    CupoonNo.SetActive(true);
                }
            }
            else if (InputNum == Cupoon9Num)
            {
                if (cupoon9 == 0)
                {
                    CupoonGet.SetActive(true);
                    CupoonName.text = "코인 100000 쿠폰";
                    UNIT += 100000;
                    PlayerPrefs.SetInt("UNIT", UNIT);
                    cupoon9 = 1;
                    PlayerPrefs.SetInt("cupoon7", 1);
                }
                else
                {
                    CupoonNo.SetActive(true);
                }
            }
            else if (InputNum == Cupoon10Num)
            {
                if (cupoon10 == 0)
                {
                    CupoonGet.SetActive(true);
                    CupoonName.text = "도라의깃털 999개";
                    PlayerPrefs.SetInt("DORI", 999);
                    PlayerPrefs.SetInt("Mileage", 99);
                    cupoon10 = 1;
                    PlayerPrefs.SetInt("cupoon10", 1);
                }
                else
                {
                    CupoonNo.SetActive(true);
                }
            }
            else if (InputNum == CupoonVipNum)
            {
                if (cupoonVip == 0)
                {
                    CupoonGet.SetActive(true);
                    CupoonName.text = "다이아 10000 쿠폰 [Vip전용]";
                    BD += 10000;
                    PlayerPrefs.SetInt("BD", BD);
                    cupoonVip = 1;
                    PlayerPrefs.SetInt("cupoonVip", 1);
                }
                else
                {
                    CupoonNo.SetActive(true);
                }
            }
            else if (InputNum == CupoonVVipNum)
            {
                if (cupoonVVip == 0)
                {
                    CupoonGet.SetActive(true);
                    CupoonName.text = "다이아 99999 쿠폰 [VVip전용]";
                    BD = 99999;
                    PlayerPrefs.SetInt("BD", BD);
                    cupoonVVip = 1;
                    PlayerPrefs.SetInt("cupoonVVip", 1);
                }
                else
                {
                    CupoonNo.SetActive(true);
                }
            }
            else if (InputNum == CupoonGoldNum)
            {
                if (cupoonGold == 0)
                {
                    CupoonGet.SetActive(true);
                    CupoonName.text = "황금 알 오픈";
                    cupoonGold = 1;
                    PlayerPrefs.SetInt("cupoonGold", 1);
                    PlayerPrefs.SetInt("GoldEgg", 1);
                }
                else
                {
                    CupoonNo.SetActive(true);
                }
            }
            else if (InputNum == CupoonHiddenNum)
            {
                if (cupoonHidden == 0)
                {
                    CupoonGet.SetActive(true);
                    CupoonName.text = "히든 캐릭터 오픈";
                    cupoonHidden = 1;
                    PlayerPrefs.SetInt("cupoonHidden", 1);
                    PlayerPrefs.SetInt("DoveHidden", 1);
                }
                else
                {
                    CupoonNo.SetActive(true);
                }
            }
            else
            {
                CupoonFail.SetActive(true);
            }
        }
    }
    public void NickNameEnter()
    {
        source.PlayOneShot(Click, 0.75f);
        PlayerPrefs.SetString("NameCheck", NickNameinput.text);
        NickNameInput = PlayerPrefs.GetString("NameCheck");
        NickNameNum = NickNameInput.Length;

        if(NickNameNum >= 4)
        {
            PlayerPrefs.SetString("NickName", NickNameinput.text);
            MainNickName.text = PlayerPrefs.GetString("NickName");
            NickNameChange.SetActive(false);
            Tutorial = 2;
            PlayerPrefs.SetInt("Tutorial", Tutorial);
            if(Select.screen == 2)
            {
                Select.screen = 0;
            }
            else if(Select.screen == 3)
            {
                Select.screen = 1;
            }
            black.enabled = false;
        }
        else
        {
            Notion.SetActive(false);
            Notion.SetActive(true);
        }
    }

    public void Exit()
    {
        source.PlayOneShot(Click, 0.75f);
        CupoonGet.SetActive(false);
        CupoonFail.SetActive(false);
        CupoonNo.SetActive(false);
    }
    public void NameExit()
    {
        source.PlayOneShot(Click, 0.75f);
        NickNameChange.SetActive(false);
        if (Tutorial == 1)
        {
            black.enabled = false;
        }
        Select.screen = 1;
    }

    public void NickNamechange()
    {
        source.PlayOneShot(Click, 0.75f);
        NickNameChange.SetActive(true);
        titlelabel.text = "이름 변경";
        mainlabel.text = "변경할 닉네임을 입력해주세요\n(4자~6자)";
        NickExit.SetActive(true);
        Select.screen = 3;
        black.enabled = true;
        black.alpha = 0.4f;
    }
}
