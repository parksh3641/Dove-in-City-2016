using UnityEngine;
using System.Collections;

public class CollectionManager : MonoBehaviour {
    private int screen = 0;

    public UILabel A;
    public UILabel B;
    public UILabel C;

    public int ALock = 0;
    public int BLock = 0;
    public int CLock = 0;
    public int DLock = 0;
    public int ELock = 0;
    public int FLock = 0;
    public int GLock = 0;
    public int HLock = 0;
    public int ILock = 0;
    public int JLock = 0;
    public int KLock = 0;
    public int LLock = 0;
    public int MLock = 0;
    public int NLock = 0;
    public int OLock = 0;
    public int PLock = 0;
    public int QLock = 0;
    public int RLock = 0;
    public int SLock = 0;
    public int TLock = 0;
    public int ULock = 0;
    public int VLock = 0;
    public int WLock = 0;
    public int XLock = 0;
    public int YLock = 0;
    public int ZLock = 0;
    public int AALock = 0;
    public int ABLock = 0;
    public int ACLock = 0;
    public int ADLock = 0;
    public int AELock = 0;

    public GameObject Alock;
    public GameObject Block;
    public GameObject Clock;
    public GameObject Dlock;
    public GameObject Elock;
    public GameObject Flock;
    public GameObject Glock;
    public GameObject Hlock;
    public GameObject Ilock;
    public GameObject Jlock;
    public GameObject Klock;
    public GameObject Llock;
    public GameObject Mlock;
    public GameObject Nlock;
    public GameObject Olock;
    public GameObject Plock;
    public GameObject Qlock;
    public GameObject RNlock;
    public GameObject Slock;
    public GameObject Tlock;
    public GameObject Ulock;
    public GameObject Vlock;
    public GameObject Wlock;
    public GameObject Xlock;
    public GameObject Ylock;
    public GameObject Zlock;
    public GameObject AAlock;
    public GameObject ABlock;
    public GameObject AClock;
    public GameObject ADIock;
    public GameObject AEIock;

    public GameObject LockNotion;

    public GameObject Inf;
    void Start()
    {
        Inf.SetActive(false);
        //ALock = PlayerPrefs.GetInt("ALock", 0);
        //BLock = PlayerPrefs.GetInt("BLock", 0);
        //CLock = PlayerPrefs.GetInt("CLock", 0);
        //DLock = PlayerPrefs.GetInt("DLock", 0);
        //ELock = PlayerPrefs.GetInt("ELock", 0);
        //FLock = PlayerPrefs.GetInt("FLock", 0);
        //GLock = PlayerPrefs.GetInt("GLock", 0);
        //HLock = PlayerPrefs.GetInt("HLock", 0);
        //ILock = PlayerPrefs.GetInt("ILock", 0);
        //JLock = PlayerPrefs.GetInt("JLock", 0);
        //KLock = PlayerPrefs.GetInt("KLock", 0);
        //LLock = PlayerPrefs.GetInt("LLock", 0);
        //MLock = PlayerPrefs.GetInt("MLock", 0);
        //NLock = PlayerPrefs.GetInt("NLock", 0);

        //LockCheck(ALock, Alock);
        //LockCheck(BLock, Block);
        //LockCheck(CLock, Clock);
        //LockCheck(DLock, Dlock);
        //LockCheck(ELock, Elock);
        //LockCheck(FLock, Flock);
        //LockCheck(GLock, Glock);
        //LockCheck(HLock, Hlock);
        //LockCheck(ILock, Ilock);
        //LockCheck(JLock, Jlock);
        //LockCheck(KLock, Klock);
        //LockCheck(LLock, Llock);
        //LockCheck(MLock, Mlock);
        //LockCheck(NLock, Nlock);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
           if(screen ==1)
            {
                Exit();
            }
        }
    }
    void LockCheck(int A , GameObject B)
    {
        if(A ==0)
        {
            B.SetActive(true);
        }
        else
        {
            B.SetActive(false);
        }
    }
    public void UnLockCheck(int A) //락번호
    {
        if(A ==1)
        {
            ALock = 1;
            Alock.SetActive(false);
            PlayerPrefs.SetInt("ALock", 1);
        }
        else if(A == 2)
        {
            BLock = 1;
            Block.SetActive(false);
            PlayerPrefs.SetInt("BLock", 1);
        }
        else if (A == 3)
        {
            CLock = 1;
            Clock.SetActive(false);
            PlayerPrefs.SetInt("CLock", 1);
        }
        else if (A == 4)
        {
            DLock = 1;
            Dlock.SetActive(false);
            PlayerPrefs.SetInt("DLock", 1);
        }
        else if (A == 5)
        {
            ELock = 1;
            Elock.SetActive(false);
            PlayerPrefs.SetInt("ELock", 1);
        }
        else if (A == 6)
        {
            FLock = 1;
            Flock.SetActive(false);
            PlayerPrefs.SetInt("FLock", 1);
        }
        else if (A == 7)
        {
            GLock = 1;
            Glock.SetActive(false);
            PlayerPrefs.SetInt("GLock", 1);
        }
        else if (A == 8)
        {
            HLock = 1;
            Hlock.SetActive(false);
            PlayerPrefs.SetInt("HLock", 1);
        }
        else if (A == 9)
        {
            ILock = 1;
            Ilock.SetActive(false);
            PlayerPrefs.SetInt("ILock", 1);
        }
    }
    void OnDisbale()
    {
        Inf.SetActive(false);
    }
    public void Lock()
    {
        LockNotion.SetActive(false);
        LockNotion.SetActive(true);
    }
    void select()
    {
        screen = 1;
        Select.screen = 3;
        Inf.SetActive(true);
    }
    public void Selected()
    {
        if (screen == 0)
        {
            select();
            A.text = "닭둘기";
            B.text = "\n";
            C.text = "\n\n\n";
        }
    }
    public void SelectedA()
    {
        if(screen ==0)
        {
            if (ALock == 1)
            {
                select();
                A.text = "실족사";
                B.text = "   건물에 부딪쳐 사망한다.   ";
                C.text = "한치 앞을 예상할 수 없는게\n삶이라지만 바로 앞에 있는건\n보고 다닙시다.";
            }
        }
    }
    public void SelectedB()
    {
        if(screen ==0)
        {
            if (BLock == 1)
            {
                select();
                A.text = "배고파서 사망";
                B.text = "육지에서 매 초마다\n떨어지는 hp 때문에 사망한다.";
                C.text = "배고파서 죽는 삶 만큼\n허무한게 있을까요.\n배불러서 죄송합니다.";
            }
        }
    }
    public void SelectedC()
    {
        if(screen ==0)
        {
            if (CLock == 1)
            {
                select();
                A.text = "자연사";
                B.text = "육지에서 매 초마다\n떨어지는 hp 때문에 사망한다.";
                C.text = "시간의 순리에 따라 죽는건\n자연스러운 이치입니다.\n나무의 거름이나 되세요.";
            }
        }
    }
    public void SelectedD()
    {
        if (screen == 0)
        {
            if (DLock == 1)
            {
                select();
                A.text = "차에 깔리고 뭉개져 사망";
                B.text = "   차에 부딪쳐 사망한다.   ";
                C.text = "차보다 약한\n동물의 순리입니다!\n억울하면 강해지세요.";
            }
        }
    }
    public void SelectedE()
    {
        if (screen == 0)
        {
            if (ELock == 1)
            {
                select();
                A.text = "돌에 쳐맞아 사망";
                B.text = "사람이 던진 돌에 맞고\n사망한다.";
                C.text = "죄가 없는자 돌로 치라고\n하셨지만, 현실은\n강자가 돌로 칩니다.";
            }
        }
    }
    public void SelectedF()
    {
        if (screen == 0)
        {
            if (FLock == 1)
            {
                select();
                A.text = "약물 중독으로 사망";
                B.text = "온전한 하트 부작용으로\n사망한다.";
                C.text = "\n약물중독은 1899-0893\n";
            }
        }
    }
    public void SelectedG()
    {
        if (screen == 0)
        {
            if (GLock == 1)
            {
                select();
                A.text = "술취한 주정뱅이를 잘못 건드려 사망";
                B.text = "술취한 주정뱅이에게\n맞아 사망한다.";
                C.text = "술취한 주정뱅이를 보면\n국번없이 112번으로\n신고바랍니다.";
            }
        }
    }
    public void SelectedH()
    {
        if (screen == 0)
        {
            if (HLock == 1)
            {
                select();
                A.text = "시간의 순리를 역행해 사망";
                B.text = "시간의 모래시계의\n부작용으로 뒤로 가다가 사망한다.";
                C.text = "후진을 그렇게 밖에 못해!?!\n하여튼 이래서 운전면허를\n쉽게 주면 안된다니까!";
            }
        }
    }
    public void SelectedI()
    {
        if (screen == 0)
        {
            if (ILock == 1)
            {
                select();
                A.text = "고막이 터져 사망";
                B.text = "초능력 기압계의 부작용으로 고막이 터져 사망한다";
                C.text = "바깥귀와 가운데귀의 경계에\n위치하는 두께 0.1mm의 얇고\n투명한 막을 잃었습니다.";
            }
        }
    }
    public void SelectedJ()
    {
        if (screen == 0)
        {
            if (JLock == 1)
            {
                select();
                A.text = "디스코의 영혼을 담아 사망";
                B.text = "디스코 뮤직박스를 듣는 중에 사망한다.";
                C.text = "\n갈땐 가더라도 디스코 한판은 괜찮잖아?\n";
            }
        }
    }
    public void SelectedK()
    {
        if (screen == 0)
        {
            if (KLock == 1)
            {
                select();
                A.text = "날아다니는 쓰레기에 맞아 사망";
                B.text = "높이날기를 하는 중에\n장애물 비둘기에 맞아 사망한다.";
                C.text = "네 맞습니다.\n비둘기는 날아다니는\n쓰레기입니다.";
            }
        }
    }
    public void SelectedL()
    {
        if (screen == 0)
        {
            if (LLock == 1)
            {
                select();
                A.text = "건물이 움직이는 환각에 속아 사망";
                B.text = "독수리에게 맞아 출혈이 발생\n했을 때 건물에 맞아 사망한다.";
                C.text = "건물이 움직였다고요?\n푸훕! 뻥치지 마세요.\n거짓말인거 다 안다구요!";
            }
        }
    }
    public void SelectedM()
    {
        if (screen == 0)
        {
            if (MLock == 1)
            {
                select();
                A.text = "시뻘건 세상의 부조리에 사망";
                B.text = "독수리에게 맞아 출혈이\n발생했을 때 차에 맞아 사망한다.";
                C.text = "더러운 세상!\n나 다시 돌아갈래!\n캬아아아아악!";
            }
        }
    }
    public void SelectedN()
    {
        if (screen == 0)
        {
            if (NLock == 1)
            {
                select();
                A.text = "주정뱅이의 깽판에 사망";
                B.text = "독수리에게 맞아 출혈이 발생했을 때 10배\n속도의 술취한 주정뱅이에게 맞아 사망한다.";
                C.text = "주정뱅이의 깽판을\n가만히 놔두면 더 심해집니다.\n주먹의 규율로 참교육 시키세요.";
            }
        }
    }
    public void SelectedO()
    {
        if (screen == 0)
        {
            if (OLock == 1)
            {
                select();
                A.text = "마도로스가 새우깡을 주려는 와중에 배에 맞아 사망";
                B.text = "    배에 맞아사망한다.    ";
                C.text = "배에 머리를 쳐박고\n죽는것도 쉽지 않은 일입니다.";
            }
        }
    }
    public void SelectedP()
    {
        if (screen == 0)
        {
            if (PLock == 1)
            {
                select();
                A.text = "허황된 속세의 재물들을 눈앞에 두고 숨막혀 사망";
                B.text = "  숭례문 내부에서 사망한다.  ";
                C.text = "고대의 재물들은\n함부로 손대는게 아닙니다.";
            }
        }
    }
    public void SelectedQ()
    {
        if (screen == 0)
        {
            if (QLock == 1)
            {
                select();
                A.text = "영광스런 국보1호에 맞아서 사망";
                B.text = " 숭례문에 맞아서 사망한다 ";
                C.text = "\n영광스러운 죽음이었다.\n";
            }
        }
    }
    public void SelectedR()
    {
        if (screen == 0)
        {
            if (RLock == 1)
            {
                select();
                A.text = "포류되어 사망";
                B.text = "바다 한가운데에서 매 초마다\n떨어지는 hp 때문에 사망한다.";
                C.text = "\n김씨?\n";
            }
        }
    }
    public void SelectedS()
    {
        if (screen == 0)
        {
            if (SLock == 1)
            {
                select();
                A.text = "해탈";
                B.text = "이어하기 10번 이상 한뒤\n사망한다.";
                C.text = "그 오기와 패기로는\n   뭐든지 할 수 있을겁니다.   ";
            }
        }
    }
    public void SelectedT()
    {
        if (screen == 0)
        {
            if (TLock == 1)
            {
                select();
                A.text = "돌연사";
                B.text = "위아래로 폰을 30번 흔들면 사망한다.";
                C.text = "\n무엇이 연상되십니까?\n";
            }
        }
    }
    public void SelectedU()
    {
        if (screen == 0)
        {
            if (ULock == 1)
            {
                select();
                A.text = "UFO에게 납치되어 행방불명";
                B.text = "UFO에게 납치되어\n행방불명 된다.";
                C.text = "UFO에게 납치됐는데 사람들이 믿지 않는다구요? 살아남은 것만으로도 감사하게 생각하세요.";
            }
        }
    }
    public void SelectedV()
    {
        if (screen == 0)
        {
            if (VLock == 1)
            {
                select();
                A.text = "외계인에게 맞아 사망";
                B.text = "날아다니는 외계인에게 맞아 사망한다.";
                C.text = "지구에 올 정도의 기술력을 가진 외계인에겐 인간는 미개한 존재입니다. 미지와의 조우에서 납치 한번쯤은 당해줄 수 있잖아요?";
            }
        }
    }
    public void SelectedW()
    {
        if (screen == 0)
        {
            if (WLock == 1)
            {
                select();
                A.text = "앤트맨 코스하다 사망";
                B.text = "미니포션의 효과로 몸이\n작아진 상태에서 사망한다.";
                C.text = "안전을 위해서 슈퍼 히어로를\n   따라하..하...하일 하이드라!   ";
            }
        }
    }
    public void SelectedX()
    {
        if (screen == 0)
        {
            if (XLock == 1)
            {
                select();
                A.text = "이상한 나라의 조류가 되어 사망";
                B.text = "미니포션 부작용 중\n거대한 몸집이 되어 사망한다.";
                C.text = "이래서 비만은\n   만병의 근원이라는 겁니다.   ";
            }
        }
    }
    public void SelectedY()
    {
        if (screen == 0)
        {
            if (YLock == 1)
            {
                select();
                A.text = "산신령의 박치기에 맞아 사망";
                B.text = "산신령이 날아다닐 때 박치기를 맞고 사망한다. ";
                C.text = "산신령은 날아다닐때 앞이 잘\n안 보인다고 합니다.\n라식수술 알아봐야 겠어요.";
            }
        }
    }
    public void SelectedZ()
    {
        if (screen == 0)
        {
            if (ZLock == 1)
            {
                select();
                A.text = "산신령에게 밉보여 사망";
                B.text = "산신령과의 대화에서 비위를 맞추지 못해 사망한다.";
                C.text = "산신령은 늙었지만\n정신은 애새끼 입니다.";
            }
        }
    }
    public void SelectedAA()
    {
        if (screen == 0)
        {
            if (AALock == 1)
            {
                select();
                A.text = "두더지에게 쳐맞아 사망";
                B.text = "두더지가 갑자기 튀어나올때 맞고 사망한다.";
                C.text = "\n갑툭튀\n";
            }
        }
    }
    public void SelectedAB()
    {
        if (screen == 0)
        {
            if (ABLock == 1)
            {
                select();
                A.text = "두더지에게 밉보여 사망";
                B.text = "두더지와의 대화에서 비위를 맞추지 못해 사망한다.";
                C.text = "두더지는 괴물입니다. 땅속의 심연을 너무 오랫동안 바라본 나머지 심연 또한 두더지를 바라봤으니까요.";
            }
        }
    }
    public void SelectedAC()
    {
        if (screen == 0)
        {
            if (ACLock == 1)
            {
                select();
                A.text = "거대한 사람에게 짓밟혀 사망";
                B.text = "숭례문 안에 있는 거대한 사람을 피하지 못해 짓밟혀 사망한다.";
                C.text = "크다고 다 좋은건\n        아니더라구요.        ";
            }
        }
    }
    public void SelectedAD()
    {
        if (screen == 0)
        {
            if (ADLock == 1)
            {
                select();
                A.text = "착한척 하다가 산신령에게 팔콘펀치를 맞고 사망";
                B.text = "산신령에게 팔콘펀치를\n맞고 사망한다.";
                C.text = "궁극의 기술..!\n            팔콘 펀치!            ";
            }
        }
    }
    public void SelectedAE()
    {
        if (screen == 0)
        {
            if (AELock == 1)
            {
                select();
                A.text = "두더지를 쓰다듬다 사망";
                B.text = "두더지와의 대화중에\n사망한다.";
                C.text = "아버지가 부먹충과 두더지는 절대로 믿지 말라 하셨습니다.";
            }
        }
    }
    public void Exit()
    {
        screen = 0;
        Select.screen = 2;
        Inf.SetActive(false);
    }
}
