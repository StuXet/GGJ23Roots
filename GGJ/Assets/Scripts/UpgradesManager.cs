using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradesManager : MonoBehaviour
{

    [Header("Mole")]
    [SerializeField] GameObject moleModel;
    public float molePrice;
    public float molePriceMod;
    public int moleDamageUpgrade;
    public int moleSpeedUpgrade;
    bool moleFirstPurchase;
    public void MoleUpgrade()
    {
        Bird.Instance.strength += moleDamageUpgrade;
        Bird.Instance.hitInterval -= moleSpeedUpgrade;
        GameManager.instance.score -= (int)molePrice;
        molePrice *= molePriceMod;
        if (moleFirstPurchase)
        {
            //show model
        }
    }

    [Space(10)]

    [Header("Bird")]
    [SerializeField] GameObject birdModel;
    public float birdPrice;
    public float birdPriceMod;
    public int birdDamageUpgrade;
    public int birdSpeedUpgrade;
    bool birdFirstPurchase;
    public void BirdUpgrade()
    {
        Bird.Instance.strength += birdDamageUpgrade;
        Bird.Instance.hitInterval -= birdSpeedUpgrade;
        GameManager.instance.score -= (int)birdPrice;
        birdPrice *= birdPriceMod;
        if (birdFirstPurchase)
        {
            //show model
        }
    }

    [Space(10)]

    [Header("K300")]
    [SerializeField] GameObject kModel;
    public float kPrice;
    public float kPriceMod;
    public int kDamageUpgrade;
    public int kSpeedUpgrade;
    bool kFirstPurchase;
    public void K300Upgrade()
    {
        Bird.Instance.strength += kDamageUpgrade;
        Bird.Instance.hitInterval -= kSpeedUpgrade;
        GameManager.instance.score -= (int)kPrice;
        kPrice *= kPriceMod;
        if (kFirstPurchase)
        {
            //show model

        }
    }

    [Space(10)]

    [Header("Sprinkler")]
    [SerializeField] GameObject sprinklerModel;
    public float sprinklerPrice;
    public float sprinklerPriceMod;
    public int sprinklerDamageUpgrade;
    public int sprinklerSpeedUpgrade;
    bool sprinklerFirstPurchase;
    public void SprinklerUpgrade()
    {
        Bird.Instance.strength += sprinklerDamageUpgrade;
        Bird.Instance.hitInterval -= sprinklerSpeedUpgrade;
        GameManager.instance.score -= (int)sprinklerPrice;
        sprinklerPrice *= sprinklerPriceMod;
        if (sprinklerFirstPurchase)
        {
            //show model

        }
    }
}
