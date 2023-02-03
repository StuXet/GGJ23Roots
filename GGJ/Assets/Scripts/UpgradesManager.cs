using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradesManager : MonoBehaviour
{

    [Header("Mole")]
    public int molePrice;
    public int moleDamageUpgrade;
    public int moleSpeedUpgrade;
    bool moleFirstPurchase;
    public void MoleUpgrade()
    {

    }

    [Space(10)]

    [Header("Bird")]
    public int birdPrice;
    public int birdDamageUpgrade;
    public int birdSpeedUpgrade;
    bool birdFirstPurchase;
    public void BirdUpgrade()
    {

    }

    [Space(10)]

    [Header("K300")]
    public int kPrice;
    public int kDamageUpgrade;
    public int kSpeedUpgrade;
    bool kFirstPurchase;
    public void K300Upgrade()
    {

    }

    [Space(10)]

    [Header("Sprinkler")]
    public int sprinklerPrice;
    public int sprinklerDamageUpgrade;
    public int sprinklerSpeedUpgrade;
    bool sprinklerFirstPurchase;
    public void SprinklerUpgrade()
    {

    }
}
