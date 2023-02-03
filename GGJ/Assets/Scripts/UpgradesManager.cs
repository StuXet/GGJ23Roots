using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradesManager : MonoBehaviour
{

    [Header("Mole")]
    public float molePrice;
    public float molePriceMod;
    public int moleDamageUpgrade;
    public int moleSpeedUpgrade;
    bool moleFirstPurchase;
    public void MoleUpgrade()
    {
        WormKiller.Instance.strength += moleDamageUpgrade;
        WormKiller.Instance.hitInterval -= moleSpeedUpgrade;
        GameManager.instance.score -= (int)molePrice;
        molePrice *= molePriceMod;
        if (moleFirstPurchase)
        {
            //show model
        }
    }

    [Space(10)]

    [Header("Bird")]
    public float birdPrice;
    public float birdPriceMod;
    public int birdDamageUpgrade;
    public int birdSpeedUpgrade;
    bool birdFirstPurchase;
    public void BirdUpgrade()
    {
        WormKiller.Instance.strength += birdDamageUpgrade;
        WormKiller.Instance.hitInterval -= birdSpeedUpgrade;
        GameManager.instance.score -= (int)birdPrice;
        birdPrice *= birdPriceMod;
        if (birdFirstPurchase)
        {
            //show model
        }
    }

    [Space(10)]

    [Header("K300")]
    public float kPrice;
    public float kPriceMod;
    public int kDamageUpgrade;
    public int kSpeedUpgrade;
    bool kFirstPurchase;
    public void K300Upgrade()
    {
        WormKiller.Instance.strength += kDamageUpgrade;
        WormKiller.Instance.hitInterval -= kSpeedUpgrade;
        GameManager.instance.score -= (int)kPrice;
        kPrice *= kPriceMod;
        if (kFirstPurchase)
        {
            //show model

        }
    }

    [Space(10)]

    [Header("Sprinkler")]
    public float sprinklerPrice;
    public float sprinklerPriceMod;
    public int sprinklerDamageUpgrade;
    public int sprinklerSpeedUpgrade;
    bool sprinklerFirstPurchase;
    public void SprinklerUpgrade()
    {
        WormKiller.Instance.strength += sprinklerDamageUpgrade;
        WormKiller.Instance.hitInterval -= sprinklerSpeedUpgrade;
        GameManager.instance.score -= (int)sprinklerPrice;
        sprinklerPrice *= sprinklerPriceMod;
        if (sprinklerFirstPurchase)
        {
            //show model

        }
    }
}
