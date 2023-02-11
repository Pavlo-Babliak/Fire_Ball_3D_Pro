using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//using GoogleMobileAds.Api;

public class Win_Lose_Exit_trigger : MonoBehaviour
{
    public GameObject [] Win_Lose_Exit_triger = new GameObject[3];
    public int count;

    //private BannerView bannerView;
    // public static string adUnitId = "ca-app-pub-9572656335524853/6367073620";
    private void Awake()
    {
        //IronSource.Agent.init("1384d3919");
        IronSource.Agent.init("1384d3919", IronSourceAdUnits.BANNER);
        Destroy1.Win = false;
        Destroy_ball.lose = false;
        Destroy_ball.lose1 = false;
        Win_Lose_Exit_triger[0].active = false;
        Win_Lose_Exit_triger[1].active = false;
        Win_Lose_Exit_triger[2].active = false;
    }
    public void Start()
    {
        IronSource.Agent.loadBanner(IronSourceBannerSize.SMART, IronSourceBannerPosition.BOTTOM);
        LoadBanner();
        //MobileAds.Initialize(initStatus => { });
        //this.RequestBanner();
    }
    /* private void RequestBanner()
     {
             this.bannerView = new BannerView(adUnitId, AdSize.IABBanner, AdPosition.Bottom);
             AdRequest request = new AdRequest.Builder().Build();
             this.bannerView.LoadAd(request);
     }*/
   

    private void LoadBanner()
    {
        IronSource.Agent.loadBanner(IronSourceBannerSize.SMART, IronSourceBannerPosition.BOTTOM);
    }
    void Update()
    {
        if (Destroy1.Win == true && Win_Lose_Exit_triger[1].active == false)
        {
            Win_Lose_Exit_triger[0].active = true;
            Destroy1.Win = false;
           // bannerView.Destroy(); this.bannerView.Destroy();
            if (Application.loadedLevel >= PlayerPrefs.GetInt("LAST_LVL")) { PlayerPrefs.SetInt("LAST_LVL", Application.loadedLevel); }
            
        }
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Win_Lose_Exit_triger[2].active = true; 
            }
        }
        if (Destroy_ball.lose==true && Win_Lose_Exit_triger[0].active == false) {Win_Lose_Exit_triger[1].active = true;
            //bannerView.Destroy(); this.bannerView.Destroy(); 
            Destroy_ball.lose = false; }
    }
}
