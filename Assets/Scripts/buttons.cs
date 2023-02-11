using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using GoogleMobileAds.Api;
using UnityEngine.Events;
using System;
//using GoogleMobileAds.Common;
using UnityEngine.SceneManagement;
public class buttons : MonoBehaviour
{
   // private InterstitialAd interstitial;
  //  string adUnitId = "ca-app-pub-9572656335524853/2236256925";
    public UnityEvent OnAdOpeningEvent;
    public UnityEvent OnAdClosedEvent;

    bool return_ads;
    bool Next_ads;
    bool Exit_main_ads;

    bool start_ads_in_main;
    bool start_ads_return;
    bool start_ads_next_lvl;




    private void Awake()
    {
       // IronSource.Agent.init("1384d3919");
       // IronSource.Agent.init("1384d3919", IronSourceAdUnits.INTERSTITIAL);
    }
    private void Start()
    {
       // IronSource.Agent.loadInterstitial();
       // IronSourceEvents.onInterstitialAdClosedEvent += InterstitialAdClosedEvent;
       // IronSourceEvents.onInterstitialAdOpenedEvent += InterstitialAdOpenedEvent;
        if (!PlayerPrefs.HasKey("Return_count")) { PlayerPrefs.SetInt("Return_count", 0); }
        if (Application.loadedLevel % 2 == 0)
        {
           // this.interstitial = new InterstitialAd(adUnitId);
           // AdRequest request = new AdRequest.Builder().Build();
           // this.interstitial.OnAdOpening += HandleOnAdOpened;
           // this.interstitial.OnAdClosed += HandleOnAdClosed;
          //  this.interstitial.LoadAd(request);
        }
        if (!PlayerPrefs.HasKey("LAST_LVL")) { PlayerPrefs.SetInt("LAST_LVL", 1); }
    }
    public void Play() 
    {
        if (PlayerPrefs.GetInt("LAST_LVL") < 100)
        {
            Application.LoadLevel(PlayerPrefs.GetInt("LAST_LVL") + 1);
        }
        else { Application.LoadLevel(100); }
    }
    public void Button_Return()
    {
        if (PlayerPrefs.GetInt("Return_count")>=5)
        {
            if (IronSource.Agent.isInterstitialReady())
            {
                return_ads = true;
                //this.interstitial.Show();
                start_ads_return = true;
                IronSource.Agent.showInterstitial();
                PlayerPrefs.SetInt("Return_count", 1);
            }
            else
            {
                PlayerPrefs.SetInt("Return_count", 1);
                Destroy_ball.lose1 = false;
                Application.LoadLevel(Application.loadedLevel);
            }
        }
        else
        {
            PlayerPrefs.SetInt("Return_count", PlayerPrefs.GetInt("Return_count") + 1);
            Destroy_ball.lose1 = false;
            Application.LoadLevel(Application.loadedLevel);
        }
    }
    public void Button_Menu()
    {
        if (Application.loadedLevel % 2 == 0)
        {
            if (IronSource.Agent.isInterstitialReady())
            {
                Exit_main_ads = true;
                start_ads_in_main = true;
                IronSource.Agent.showInterstitial();
                //this.interstitial.Show();
            }
            else
            {
                 Application.LoadLevel(0);
            }
        }
        else
        {
            Application.LoadLevel(0);
        }
    }
    public void Button_Next()
    {
        if (Application.loadedLevel % 2 == 0)
        {
            if (IronSource.Agent.isInterstitialReady())
            {
                Next_ads = true;
                start_ads_next_lvl = true;
                IronSource.Agent.showInterstitial();
                //this.interstitial.Show();
            }
            else
            {
               
                if (PlayerPrefs.GetInt("LAST_LVL") < 100)
                {
                     SceneManager.LoadScene(Convert.ToInt32(Application.loadedLevel) + 1);
                }
                else Application.LoadLevel(100);
            }
        }
        else
        {
            if (PlayerPrefs.GetInt("LAST_LVL") < 100)
            {
                 SceneManager.LoadScene(Convert.ToInt32(Application.loadedLevel) + 1);
            }
            else Application.LoadLevel(100);
        }
    }
    public void Button_Exit() { Application.Quit(); }
    public void Exit_No() { GameObject.Find("Exit_trigger").SetActive(false); }


    /*public void HandleOnAdOpened(object sender, EventArgs args)
    {
        GameObject.Find("Main Camera").GetComponent<AudioListener>().enabled = false;
    }

    public void HandleOnAdClosed(object sender, EventArgs args)
    {
        GameObject.Find("Main Camera").GetComponent<AudioListener>().enabled = true;
        interstitial.Destroy();
        if (Next_ads == true)
        {
            //Banner.destroy = true; 
            SceneManager.LoadScene(Convert.ToInt32(Application.loadedLevel) + 1);
            Next_ads = false;
        }
        if (Exit_main_ads == true)
        {
            //Banner.destroy = true; 
            SceneManager.LoadScene(0);
            Exit_main_ads = false;
        }
        if (return_ads == true)
        {
            //Banner.destroy = true; 
            SceneManager.LoadScene(Application.loadedLevel);
            return_ads = false;
        }


    }*/
    public void InterstitialAdOpenedEvent()
    {
        GameObject.Find("Main Camera").GetComponent<AudioListener>().enabled = false;
    }
    public void InterstitialAdClosedEvent()
    {
        GameObject.Find("Main Camera").GetComponent<AudioListener>().enabled = true;
        //interstitial.Destroy();
        if (start_ads_next_lvl == true)
        {
            if (Application.loadedLevel != 151) { Application.LoadLevel(Application.loadedLevel + 1); }
            if (Application.loadedLevel == 151) { Application.LoadLevel(151); }
            start_ads_next_lvl = false;
        }
        if (start_ads_in_main == true)
        {
            Application.LoadLevel(0);
            start_ads_in_main = false;
        }
        if (start_ads_return == true)
        {
            Application.LoadLevel(Application.loadedLevel);
            start_ads_return = false;
        }

    }
}


