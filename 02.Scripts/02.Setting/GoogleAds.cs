using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;


public class GoogleAds : MonoBehaviour
{
    private InterstitialAd interstitial;
    private BannerView bannerView;

    private int Count = 0;
    void Awake()
    {
        // 전면 광고 id 등록
        interstitial = new InterstitialAd("ca-app-pub-6754544778509872/3828734548");
        bannerView = new BannerView("ca-app-pub-6754544778509872/2352001340", AdSize.SmartBanner, AdPosition.Bottom);

        // 애드몹 리퀘스트 초기화
        AdRequest request = new AdRequest.Builder()
            .AddTestDevice(AdRequest.TestDeviceSimulator)       // Simulator.
            .AddTestDevice("370E00F64FCEA81A")
            .AddTestDevice("3BF552BBAE363025") // My test device.
            .Build();

        // 애드몹 전면 광고 로드
        interstitial.LoadAd(request);
        bannerView.LoadAd(request);

        // 여기서부터 밑에 부분은 앱 실행 부분에 두면 광고가 안나온다. 실행 후 얼마 뒤로 미루자. 
        // 로드 되어 있다면 광고 보여줌
        StartCoroutine(ModeCheck());
    }
    void Start()
    {
        Count = PlayerPrefs.GetInt("Count", 0);
        int A = PlayerPrefs.GetInt("GoogleAds", 0);
        if(A ==0)
        {
            Count += 1;
            PlayerPrefs.SetInt("Count", Count);
        }

        if(Count > 3)
        {
            Count = 0;
            PlayerPrefs.SetInt("Count", 0);
            StartCoroutine(modeCheck());
        }
    }
    void OnDisable()
    {
        bannerView.Hide();
    }
    IEnumerator ModeCheck()
    {
        yield return new WaitForSeconds(2);
        bannerView.Show();
    }
    IEnumerator modeCheck()
    {
        yield return new WaitForSeconds(3);
        interstitial.Show();
    }
}
