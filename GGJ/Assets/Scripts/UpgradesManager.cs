using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradesManager : MonoBehaviour
{

    [Header("Mole")]
    [SerializeField] Mole mole;
    [SerializeField] int moleLVL;
    public float molePrice;
    public float molePriceMod;
    public int moleWormLvlUpgrade;
    public int moleSpeedUpgrade;
    bool moleFirstPurchase;
    public void MoleUpgrade()
    {
        if (moleLVL % 2 == 0)
        {
            mole.wormMaxLVL += moleWormLvlUpgrade;
        }
        mole.killInterval -= moleSpeedUpgrade;
        GameManager.instance.score -= (int)molePrice;
        molePrice *= molePriceMod;
        if (moleFirstPurchase)
        {
            mole.gameObject.SetActive(true);
        }
        moleLVL++;
    }

    [Space(10)]

    [Header("Bird")]
    [SerializeField] Bird bird;
    [SerializeField] int birdLVL;
    public float birdPrice;
    public float birdPriceMod;
    public int birdDamageUpgrade;
    public int birdSpeedUpgrade;
    bool birdFirstPurchase;
    public void BirdUpgrade()
    {
        bird.strength += birdDamageUpgrade;
        bird.hitInterval -= birdSpeedUpgrade;
        GameManager.instance.score -= (int)birdPrice;
        birdPrice *= birdPriceMod;
        if (birdFirstPurchase)
        {
            bird.gameObject.SetActive(true);
        }
        birdLVL++;
    }

    [Space(10)]

    [Header("K300")]
    [SerializeField] Spray k300;
    [SerializeField] int k300LVL;
    public float kPrice;
    public float kPriceMod;
    public int kDamageUpgrade;
    public int kSpeedUpgrade;
    bool kFirstPurchase;
    public void K300Upgrade()
    {
       
        GameManager.instance.score -= (int)kPrice;
        kPrice *= kPriceMod;
        if (kFirstPurchase)
        {
            k300.gameObject.SetActive(true);
        }
        k300LVL++;
    }

    [Space(10)]

    [Header("Sprinkler")]
    [SerializeField] GameObject sprinkler;
    [SerializeField] int sprinklerLVL;
    public float sprinklerPrice;
    public float sprinklerPriceMod;
    public int sprinklerDamageUpgrade;
    public int sprinklerSpeedUpgrade;
    bool sprinklerFirstPurchase;
    public void SprinklerUpgrade()
    {
       
        GameManager.instance.score -= (int)sprinklerPrice;
        sprinklerPrice *= sprinklerPriceMod;
        if (sprinklerFirstPurchase)
        {
            //show model

        }
        sprinklerLVL++;
    }
}
