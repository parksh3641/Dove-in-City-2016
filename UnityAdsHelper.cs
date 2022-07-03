using UnityEngine;
using UnityEngine.Advertisements;

public class UnityAdsHelper : MonoBehaviour
{
    public int RewardNumber; //0은 보석주는 광고 //1은 이어하기광고
    private int UNIT;
    private int BD;
    private int ConNum = 5;
    public UILabel txtCon;

    private int AdsNumber;

    public delegate void Ads();
    public static event Ads Continue , UNITGet;

    void Awake()
    {
        AdsNumber = PlayerPrefs.GetInt("AdsNumber", 0);
        BD = PlayerPrefs.GetInt("BD", 0);
        if (RewardNumber == 1)
        {
            txtCon.text = "남은횟수 : " + ConNum.ToString();
        }
    }
    //public void ShowRewardedAd()
    //{
    //    if (Advertisement.IsReady("rewardedVideo"))
    //    {
    //        if (RewardNumber == 0)
    //        {
    //            var options = new ShowOptions { resultCallback = HandleShowResult };
    //            Advertisement.Show("rewardedVideo", options);
    //        }
    //        else if (RewardNumber == 1)
    //        {
    //            if (ConNum > 0)
    //            {
    //                ConNum -= 1;
    //                txtCon.text = "남은횟수 : " + ConNum.ToString();
    //                var options = new ShowOptions { resultCallback = HandleShowResult };
    //                Advertisement.Show("rewardedVideo", options);
    //            }
    //            else
    //            {
    //                Debug.Log("광고보기 제한!");
    //            }
    //        }
    //    }
    //}

    //private void HandleShowResult(ShowResult result)
    //{
    //    switch (result)
    //    {
    //        case ShowResult.Finished:
    //            Debug.Log("The ad was successfully shown.");
    //            if (RewardNumber == 0)
    //            {
    //                int A = Random.Range(15, 31);
    //                BD += A;
    //                PlayerPrefs.SetInt("BD", BD);
    //                AdsNumber += 1;
    //                PlayerPrefs.SetInt("AdsNumber", AdsNumber);
    //                UNITGet();
    //            }
    //            else if (RewardNumber == 1)
    //            {
    //                Continue();
    //            }
    //            break;
    //        case ShowResult.Skipped:
    //            Debug.Log("The ad was skipped before reaching the end.");
    //            break;
    //        case ShowResult.Failed:
    //            Debug.LogError("The ad failed to be shown.");
    //            break;
    //    }
    //}
}