using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradesManager : MonoBehaviour
{
    [Header("Mole")]
    [SerializeField] Mole mole;
    public Text moleLvlText;
    public Text molePriceText;
    public int moleLVL;
    public float molePrice;
    public float molePriceMod;
    public int moleWormLvlUpgrade;
    public int moleSpeedUpgrade;
    bool moleFirstPurchase = true;

    private void Start()
    {
        ShopUpdateText();
    }

    public void MoleUpgrade()
    {
        if (molePrice <= GameManager.instance.score)
        {
            print("mole");
            if (moleLVL % 2 == 0)
            {
                mole.wormMaxLVL += moleWormLvlUpgrade;
            }
            mole.killInterval -= moleSpeedUpgrade;
            GameManager.instance.score -= (int)molePrice;
            molePrice *= molePriceMod;
            Mathf.Round(molePrice);
            if (moleFirstPurchase)
            {
                mole.gameObject.SetActive(true);
            }
            ShopUpdateText();
            moleLVL++;
        }
    }

    [Space(10)]

    [Header("Bird")]
    [SerializeField] Bird bird;
    public Text birdLvlText;
    public Text birdPriceText;
    public int birdLVL;
    public float birdPrice;
    public float birdPriceMod;
    public int birdDamageUpgrade;
    public int birdSpeedUpgrade;
    bool birdFirstPurchase = true;
    public void BirdUpgrade()
    {
        if (birdPrice <= GameManager.instance.score)
        {
            print("bird");
            bird.strength += birdDamageUpgrade;
            bird.hitInterval -= birdSpeedUpgrade;
            GameManager.instance.score -= (int)birdPrice;
            birdPrice *= birdPriceMod;
            Mathf.Round(birdPrice);
            if (birdFirstPurchase)
            {
                bird.gameObject.SetActive(true);
            }
            ShopUpdateText();
            birdLVL++;
        }
    }

    [Space(10)]

    [Header("K300")]
    [SerializeField] Spray k300;
    public Text k300LvlText;
    public Text k300PriceText;
    public int k300LVL;
    public float kPrice;
    public float kPriceMod;
    public int kDamageUpgrade;
    public int kSpeedUpgrade;
    bool kFirstPurchase = true;
    public void K300Upgrade()
    {
        if (kPrice <= GameManager.instance.score)
        {
            print("k300");
            GameManager.instance.score -= (int)kPrice;
            kPrice *= kPriceMod;
            Mathf.Round(kPrice);
            if (kFirstPurchase)
            {
                k300.gameObject.SetActive(true);
            }
            ShopUpdateText();
            k300LVL++;
        }
    }

    [Space(10)]

    [Header("Sprinkler")]
    [SerializeField] Sprinkler sprinkler;
    public Text sprinklerLvlText;
    public Text sprinklerPriceText;
    public int sprinklerLVL;
    public float sprinklerPrice;
    public float sprinklerPriceMod;
    public int sprinklerDamageUpgrade;
    public int sprinklerSpeedUpgrade;
    bool sprinklerFirstPurchase = true;
    public void SprinklerUpgrade()
    {
        if (sprinklerPrice <= GameManager.instance.score)
        {
            print("sprink");
            GameManager.instance.wormSpeedDecreaser += sprinkler.wormSlower;
            GameManager.instance.score -= (int)sprinklerPrice;
            sprinklerPrice *= sprinklerPriceMod;
            Mathf.Round(sprinklerPrice);
            if (sprinklerFirstPurchase)
            {
                sprinkler.gameObject.SetActive(true);
            }
            ShopUpdateText();
            sprinklerLVL++;
        }
    }

    void ShopUpdateText()
    {
        moleLvlText.text = "LVL: " + moleLVL;
        molePriceText.text = "Price: " + molePrice;

        birdLvlText.text = "LVL: " + birdLVL;
        birdPriceText.text = "Price: " + birdPrice;

        k300LvlText.text = "LVL: " + k300LVL;
        k300PriceText.text = "Price: " + kPrice;

        sprinklerLvlText.text = "LVL: " + sprinklerLVL;
        sprinklerPriceText.text = "Price: " + sprinklerPrice;
    }
}
