using System.Collections;
using UnityEngine;
using UnityEngine.Advertisements;

public class BannerAds : MonoBehaviour
{

    public string bannerPlacement = "Banner";
    public bool testMode = true;
    public const string gameID = "3041336";

    void Start()
    {
        Advertisement.Initialize(gameID, testMode);
        StartCoroutine(ShowBannerWhenReady());
    }

    IEnumerator ShowBannerWhenReady()
    {
        while (!Advertisement.IsReady("Banner"))
        {
            yield return new WaitForSeconds(0.5f);
        }
        Advertisement.Banner.Show(bannerPlacement);
        Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
        yield return new WaitForSeconds(5.0f);
        Advertisement.Banner.Hide();
    }
}