using UnityEngine;
using UnityEngine.Monetization;

public class UnityAdsScript : MonoBehaviour
{
    string gameId = "3041336";
    bool testMode = true;
    
    void Start()
    {
        Monetization.Initialize(gameId, testMode);   
    }
}
