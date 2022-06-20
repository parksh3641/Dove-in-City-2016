using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadSelect : MonoBehaviour {
    public UILabel progressLabel;
    public UILabel Tip;
    public UISprite sprite;
    public int Number;
    private int A;

    void Start() {
        TipSetting();
        StartCoroutine(Load());
    }
    void TipSetting()
    {
        A = Random.Range(0, 28);
        if(A ==0)
        {
            Tip.text = "새로운 비둘기는\n언제나 환영이야!!!";
        }
        else if(A ==1)
        {
            Tip.text = "주머니에서 아이템을 강화해\n더 효율적으로 사용해보세요!";
        }
        else if(A ==2)
        {
            Tip.text = "완전히 피하는 것보단 \n덜 맞는게 낫습니다.";
        }
        else if(A ==3)
        {
            Tip.text = "독수리는 \n되도록 피하세요.";
        }
        else if (A == 4)
        {
            Tip.text = "검은 비둘기와 흰 비둘기는 서로를\n잡아 먹습니다. 동족인데도 말이죠!";
        }
        else if (A == 5)
        {
            Tip.text = "쿠폰은 메인화면에\n설정창에서 입력할 수 있습니다.";
        }
        else if (A == 6)
        {
            Tip.text = "독수리는 \n눈빛부터 거만합니다.";
        }
        else if (A == 7)
        {
            Tip.text = "가볼까 말까 할땐 가보세요.\n신기한 보물을 얻을지도 몰라요.";
        }
        else if (A == 8)
        {
            Tip.text = "메인화면의 비둘기를 \n몇번까지 클릭할 수 있을까요?";
        }
        else if (A == 9)
        {
            Tip.text = "게임이 어렵다면 주머니에서\n아이템을 장착하고 시작하세요.";
        }
        else if (A == 10)
        {
            Tip.text = "알에서만 나오는 \n아이템이 있습니다.";
        }
        else if (A == 11)
        {
            Tip.text = "쓰레기는 비둘기에겐\n좋은 양식입니다.";
        }
        else if (A == 12)
        {
            Tip.text = "흰 비둘기는 어둠을\n싫어한다는 소문이 있습니다.";
        }
        else if (A == 13)
        {
            Tip.text = "하늘을 날땐 기모찌해서 똥을 싸게되요\n-익명의 비둘기-";
        }
        else if (A == 14)
        {
            Tip.text = "한때 평화의 상징이었던 유해동물이여!\n-비둘기 똥을 맞은 시인-";
        }
        else if (A == 15)
        {
            Tip.text = "흰 비둘기가 나뭇가지를 물면 사람들이 만두를\n던져줍니다. 하지만, 돌을 던질수도 있어요.";
        }
        else if (A == 16)
        {
            Tip.text = "스킨은 비둘기를\n더욱 간지나게 만들어줍니다.";
        }
        else if (A == 17)
        {
            Tip.text = "강화를 통해 더욱\n강한 비둘기를 만들어보세요.";
        }
        else if (A == 18)
        {
            Tip.text = "비둘기마다\n날씨에 따른 변화가 있습니다.";
        }
        else if (A == 19)
        {
            Tip.text = "앨범에는 4종류의 비둘기말고도\n숨겨진 비둘기가 있다고 합니다.";
        }
        else if (A == 20)
        {
            Tip.text = "인도로 차가 다닐 수도 있습니다.\n뺑소니 조심하세요!";
        }
        else if (A == 21)
        {
            Tip.text = "최고 점수가 높을 수록\n그에 따른 숨겨진 효과가 있어요.";
        }
        else if (A == 22)
        {
            Tip.text = "가끔 가다 보면\n문워크 하는 사람이 있다고 해요.";
        }
        else if (A == 23)
        {
            Tip.text = "모든 아이템은\n각각의 부작용이 있습니다.";
        }
        else if (A == 24)
        {
            Tip.text = "비둘기마다 각각의 특징이 있습니다.\n둥지에 설명을 참고하세요!";
        }
        else if (A == 25)
        {
            Tip.text = "지하세계의 두더지는\n모두 몇마리 일까요?";
        }
        else if (A == 26)
        {
            Tip.text = "황금 알이라고 들어보셨나요?\n가끔씩 상점에서 판다는 소문이!";
        }
        else if (A == 27)
        {
            Tip.text = "숨겨진 곳에 코인이\n잔뜩 들어있다는 소문이 있습니다.";
        }
    }
    public void TipChange()
    {
        TipSetting();
    }
    IEnumerator Load()
    {
        AsyncOperation async = SceneManager.LoadSceneAsync(Number);
        while (!async.isDone)
        {
            float progress = async.progress * 100.0f;
            int pRounded = Mathf.RoundToInt(progress);
            sprite.fillAmount = async.progress;
            progressLabel.text = (pRounded.ToString() + "%");

            yield return true;
        }
    }
}
