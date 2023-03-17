using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Math = System.Math;
using System;

public class playerManager : MonoBehaviour
{



    public static double ore = 1000000000000000000000d;
    public static double ingot = 1000000000000000000000d;
    public static double money = 1000000000000000000000d;

    public static double moneyTotal = 0;
    public static double oreTotal = 0;
    public static double ingotTotal = 0;

    public static int weaponAmount = 1;
    public static double[] costNewWeapon = new double[] { 1000d, 5000d, 15000d, 50000d };
    public static int[] levelWeapon = new int[] { 0, 0, 0, 0, 0, };

    public static double[] CostWeapon = new double[] { 0, 0, 0, 0, 0, };
    public static double[] CostStartWeapon = new double[] { 5, 5, 5, 5, 5, };
    public static double[] CostMnojWeapon = new double[] { 1.15d, 1.15d, 1.15d, 1.15d, 1.15d, };
    public static int[] XBuyWeapon = new int[] { 1, 1, 1, 1, 1, };

    public static double[] incomeWeapon = new double[] { 0, 0, 0, 0, 0, };
    public static double[] incomeWeaponUp = new double[] { 0, 0, 0, 0, 0, };
    public static double[] incomePerLevelWeapon = new double[] { 1, 1, 1, 1, 1, };

    public static float[] SpeedWeapon = new float[] { 1f, 1f, 1f, 1f, 1f, };
    public static float[] SpeedWeaponUp = new float[] { 1f, 1f, 1f, 1f, 1f, };
    public static float[] BarWeapon = new float[] { 0, 0, 0, 0, 0, };
    public static float[] BarMaxWeapon = new float[] { 1f, 1f, 1f, 1f, 1f, };
    public static float[] BarMaxWeaponUp = new float[] { 1f, 1f, 1f, 1f, 1f, };

    //ore
    public static int oreAmount = 1;
    public static double[] costNewOre = new double[] { 1000d, 5000d, 15000d, 50000d };
    public static int[] levelOre = new int[] { 0, 0, 0, 0, 0, };

    public static double[] CostOre = new double[] { 0, 0, 0, 0, 0, };
    public static double[] CostStartOre = new double[] { 5, 5, 5, 5, 5, };
    public static double[] CostMnojOre = new double[] { 1.15d, 1.15d, 1.15d, 1.15d, 1.15d, };
    public static int[] XBuyOre = new int[] { 1, 1, 1, 1, 1, };

    public static double[] incomeOre = new double[] { 0, 0, 0, 0, 0, };
    public static double[] incomeOreUp = new double[] { 0, 0, 0, 0, 0, };
    public static double[] incomePerLevelOre = new double[] { 1, 1, 1, 1, 1, };

    public static float[] SpeedOre = new float[] { 1f, 1f, 1f, 1f, 1f, };
    public static float[] SpeedOreUp = new float[] { 1f, 1f, 1f, 1f, 1f, };
    public static float[] BarOre = new float[] { 0, 0, 0, 0, 0, };
    public static float[] BarMaxOre = new float[] { 1f, 1f, 1f, 1f, 1f, };
    public static float[] BarMaxOreUp = new float[] { 1f, 1f, 1f, 1f, 1f, };

    //ingots

    public static int IngotAmount = 1;
    public static double[] costNewIngot = new double[] { 1000d, 5000d, 15000d, 50000d };
    public static int[] levelIngot = new int[] { 0, 0, 0, 0, 0, };

    public static double[] CostIngot = new double[] { 0, 0, 0, 0, 0, };
    public static double[] CostStartIngot = new double[] { 5, 5, 5, 5, 5, };
    public static double[] CostMnojIngot = new double[] { 1.15d, 1.15d, 1.15d, 1.15d, 1.15d, };
    public static int[] XBuyIngot = new int[] { 1, 1, 1, 1, 1, };

    public static double[] incomeIngot = new double[] { 0, 0, 0, 0, 0, };
    public static double[] incomeIngotUp = new double[] { 0, 0, 0, 0, 0, };
    public static double[] incomePerLevelIngot = new double[] { 1, 1, 1, 1, 1, };

    public static float[] SpeedIngot = new float[] { 1f, 1f, 1f, 1f, 1f, };
    public static float[] SpeedIngotUp = new float[] { 1f, 1f, 1f, 1f, 1f, };
    public static float[] BarIngot = new float[] { 0, 0, 0, 0, 0, };
    public static float[] BarMaxIngot = new float[] { 1f, 1f, 1f, 1f, 1f, };
    public static float[] BarMaxIngotUp = new float[] { 1f, 1f, 1f, 1f, 1f, };






    public static int xBuy = 1;

    public static double[] oreUsedIncome = new double[] { 0, 0, 0, 0, 0, };
    public static int[] oreUsed = new int[] { 0, 0, 0, 0, 0, };

    public static double[] IngotUsedIncome = new double[] { 0, 0, 0, 0, 0, };
    public static int[] IngotUsed = new int[] { 0, 0, 0, 0, 0, };

    //prestige
    public static double prestigePointsCurrent;
    public static double prestigePointsInProgress;

    //weapons
    public static int[] panelTypeWeapon = new int[] { 0, 0, 0, 0, 0, };
    public static int panelFragmentWeapon = 0;

    public static int[,,] SlotUsed = new int[,,] { { { 0, 0, 0, }, { 0, 0, 0, }, { 0, 0, 0, }, { 0, 0, 0, }, { 0, 0, 0, }, { 0, 0, 0, } }, { { 0, 0, 0, }, { 0, 0, 0, }, { 0, 0, 0, }, { 0, 0, 0, }, { 0, 0, 0, }, { 0, 0, 0, } }, { { 0, 0, 0, }, { 0, 0, 0, }, { 0, 0, 0, }, { 0, 0, 0, }, { 0, 0, 0, }, { 0, 0, 0, } }, { { 0, 0, 0, }, { 0, 0, 0, }, { 0, 0, 0, }, { 0, 0, 0, }, { 0, 0, 0, }, { 0, 0, 0, } }, { { 0, 0, 0, }, { 0, 0, 0, }, { 0, 0, 0, }, { 0, 0, 0, }, { 0, 0, 0, }, { 0, 0, 0, } }, };
    public static double[,] SlotUsedIncome = new double[,] { { 0, 0, 0, }, { 0, 0, 0, }, { 0, 0, 0, }, { 0, 0, 0, }, { 0, 0, 0, }, };

    
    //0-inactive 1-active 
    public static int[,,] fragnetOn = new int[,,] {
        { { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, }, { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, }, { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, }, },
        { { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, }, },
        { { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, }, },
        { { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, }, },
        { { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, }, },
        { { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, }, },
    };
    public static int[] oreOn = new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
    public static int[] IngotOn = new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, };








    //quests
    public static int questAmount = 51;
    public static int questAmountOn = 0;
    public static int[] questSlot = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
    public static int[] questOn = new int[] { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, };

    public static int[] questLevel = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
    public static int[] questLevelMax = new int[] { 99, 99, 99, 99, 99, 99, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 57, 57, 57, 57, 57, 57, 5, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, };
    public static double[] questProgress = new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
    public static double[] questProgressNeed = new double[] { 25, 25, 25, 50, 50, 50, 100, 125, 150, 175, 200, 225, 250, 275, 300, 100, 125, 150, 175, 200, 225, 250, 275, 300, 25, 25, 25, 25, 25, 25, 100, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, };
    public static double[] questProgressPerLevel = new double[] { 25, 25, 25, 50, 50, 50, 100, 125, 150, 175, 200, 225, 250, 275, 300, 100, 125, 150, 175, 200, 225, 250, 275, 300, 25, 25, 25, 25, 25, 25, 100, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, };

    
    public static double[] questProp = new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
    public static double[] questPropPer = new double[] { 25, 25, 25, 0, 0, 0, 0, 50, 100, 150, 200, 250, 300, 350, 400, 0, 50, 100, 150, 200, 250, 300, 350, 400, 25, 25, 25, 25, 25, 25, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, };





    //upgrades
    public static int upgradeAmount = 32;
    public static int upgradeAmountOn = 0;
    public static int[] upgradeSlot = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
    public static int[] upgradeSlotSort = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };

    public static int[] upgradeLevel = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
    public static int[] upgradeLevelMax = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };

    public static double[] upgradeCost = new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
    public static double[] upgradeCostSort = new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
    public static double[] upgradeCostStart = new double[] { 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, };
    public static double[] upgradeCostMnoj = new double[] { 1.5d, 1.5d, 1.5d, 1.5d, 1.5d, 1.5d, 1.5d, 1.5d, 1.5d, 1.5d, 1.5d, 1.5d, 1.5d, 1.5d, 1.5d, 1.5d, 1.5d, 1.5d, 1.5d, 1.5d, 1.5d, 1.5d, 1.5d, 1.5d, 1.5d, 1.5d, 1.5d, 1.5d, 1.5d, 1.5d, 1.5d, 1.5d, };



    //ads
    public static bool adSpeedActive;
    public static float adSpeedTimer;








    public static int learnOn = 0;
    public static int musicOnOff = 0;


    public static int numberPanelMain = 0;




    public static panelQuest _pQ;
    public static panelUpgrade _pU;
    public static panelPrestige _pP;

    public static tooltipButtonBuyWeapon _tooltipButtonBuyWeapon;
    public static TooltipButtonBuyOre _tooltipButtonBuyOre;
    public static TooltipButtonBuyIngot _tooltipButtonBuyIngot;
    public static tooltipQuest _tooltipQuest;
    public static tooltipUpgrade _tooltipUpgrade;



    private void Start()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

        UpdateOre();
        UpdateWeapon();
        UpdateIngot();
    }



    void FixedUpdate()
    {

        //������ ������ ������
        for(int i = 0; i < weaponAmount; i++)
        {
            if(levelWeapon[i] > 0)
            {
                BarWeapon[i] += SpeedWeapon[i] * Time.deltaTime;
                if(BarWeapon[i] >= BarMaxWeapon[i])
                {
                    BarWeapon[i] = 0f;
                    money += incomeWeapon[i];
                    moneyTotal += incomeWeapon[i];
                    //����� 2
                    if (questOn[2] > 0 && questLevel[2] < questLevelMax[2] && levelWeapon[i] >= questProp[2])
                    {
                        questProgress[2] += 1;
                        if (questProgress[2] >= questProgressNeed[2])
                        {
                            questProgress[2] = 0;
                            questLevel[2] += 1;
                            upgradeLevelMax[2] += 1;

                            UpdateQuest();
                            UpdateUpgrade();
                        }
                    }
                    //slots 24-29
                    for (int q = 24; q <= 29; q++)
                    {
                        if (questOn[q] > 0 && questLevel[q] < questLevelMax[q] && levelWeapon[i] >= questProp[q] && panelTypeWeapon[i] == q - 24)
                        {
                            questProgress[q] += 1;
                            if (questProgress[q] >= questProgressNeed[q])
                            {
                                questProgress[q] = 0;
                                questLevel[q] += 1;
                                upgradeLevelMax[26 + (q - 24)] += 1;

                                fragnetOn[q - 24, (questLevel[q] - 1) % 3, (questLevel[q] + 2) / 3] = 1;


                                UpdateQuest();
                                UpdateUpgrade();
                            }
                        }
                    }
                    //slot 30
                    if (questOn[30] > 0 && questLevel[30] < questLevelMax[30] && levelWeapon[i] >= questProp[30])
                    {
                        questProgress[30] += 1;
                        if (questProgress[30] >= questProgressNeed[30])
                        {
                            questProgress[30] = 0;
                            questLevel[30] += 1;

                            fragnetOn[questLevel[30], 0, 0] = 1;
                            fragnetOn[questLevel[30], 1, 0] = 1;
                            fragnetOn[questLevel[30], 2, 0] = 1;

                            questOn[24 + questLevel[30]] = 1;

                            UpdateQuest();
                        }
                    }
                }
            }
        }
        //ore
        for (int i = 0; i < oreAmount; i++)
        {
            if (levelOre[i] > 0)
            {
                BarOre[i] += SpeedOre[i] * Time.deltaTime;
                if (BarOre[i] >= BarMaxOre[i])
                {
                    BarOre[i] = 0f;
                    ore += incomeOre[i];
                    oreTotal += incomeWeapon[i];

                    //slot 0
                    if (questOn[0] > 0 && questLevel[0] < questLevelMax[0] && levelOre[i] >= questProp[0])
                    {
                        questProgress[0] += 1;
                        if(questProgress[0] >= questProgressNeed[0])
                        {
                            questProgress[0] = 0;
                            questLevel[0] += 1;
                            upgradeLevelMax[0] += 1;

                            UpdateQuest();
                            UpdateUpgrade();
                        }
                    }
                    //slots 6-14
                    for (int q = 6; q <= 14; q++)
                    {
                        if (questOn[q] > 0 && questLevel[q] < questLevelMax[q] && levelOre[i] >= questProp[q] && oreUsed[i] == q - 6)
                        {
                            questProgress[q] += 1;
                            if (questProgress[q] >= questProgressNeed[q])
                            {
                                questProgress[q] = 0;
                                questLevel[q] += 1;
                                oreOn[q - 5] = 1;
                                questOn[q + 1] = 1;

                                questOn[32 + (q - 6)] = 1;

                                UpdateQuest();
                            }
                        }
                    }
                    //slots 31-40
                    for (int q = 31; q <= 40; q++)
                    {
                        if (questOn[q] > 0 && questLevel[q] < questLevelMax[q] && levelOre[i] >= questProp[q] && oreUsed[i] == q - 31)
                        {
                            questProgress[q] += 1;
                            if (questProgress[q] >= questProgressNeed[q])
                            {
                                questProgress[q] = 0;
                                questLevel[q] += 1;
                                upgradeLevelMax[6 + (q - 31)] += 1;


                                UpdateQuest();
                                UpdateUpgrade();
                            }
                        }
                    }
                }
            }
        }
        //ingots
        for (int i = 0; i < IngotAmount; i++)
        {
            if (levelIngot[i] > 0)
            {
                BarIngot[i] += SpeedIngot[i] * Time.deltaTime;
                if (BarIngot[i] >= BarMaxIngot[i])
                {
                    BarIngot[i] = 0f;
                    ingot += incomeIngot[i];
                    ingotTotal += incomeWeapon[i];
                    //slot 1
                    if (questOn[1] > 0 && questLevel[1] < questLevelMax[1] && levelIngot[i] >= questProp[1])
                    {
                        questProgress[1] += 1;
                        if (questProgress[1] >= questProgressNeed[1])
                        {
                            questProgress[1] = 0;
                            questLevel[1] += 1;
                            upgradeLevelMax[1] += 1;

                            UpdateQuest();
                            UpdateUpgrade();
                        }
                    }
                    //slots 15-23
                    for (int q = 15; q <= 23; q++)
                    {
                        if (questOn[q] > 0 && questLevel[q] < questLevelMax[q] && levelIngot[i] >= questProp[q] && IngotUsed[i] == q - 15)
                        {
                            questProgress[q] += 1;
                            if (questProgress[q] >= questProgressNeed[q])
                            {
                                questProgress[q] = 0;
                                questLevel[q] += 1;
                                IngotOn[q - 14] = 1;
                                questOn[q + 1] = 1;

                                questOn[42 + (q - 15)] = 1;

                                UpdateQuest();
                            }
                        }
                    }
                    //slots 41-50
                    for (int q = 41; q <= 50; q++)
                    {
                        if (questOn[q] > 0 && questLevel[q] < questLevelMax[q] && levelIngot[i] >= questProp[q] && IngotUsed[i] == q - 41)
                        {
                            questProgress[q] += 1;
                            if (questProgress[q] >= questProgressNeed[q])
                            {
                                questProgress[q] = 0;
                                questLevel[q] += 1;
                                upgradeLevelMax[16 + (q - 41)] += 1;


                                UpdateQuest();
                                UpdateUpgrade();
                            }
                        }
                    }
                }
            }
        }

        // prestige
        prestigePointsInProgress = Math.Floor(Math.Pow((moneyTotal + oreTotal + ingotTotal) / 3 / 10000000d, 1d / 1.01d));


    }




    public static void UpdateWeapon()
    {
        for(int i = 0; i < weaponAmount; i++)
        {
            
            XBuyWeapon[i] = xBuy;

            
            CostWeapon[i] = CostStartWeapon[i] * Math.Pow(CostMnojWeapon[i], levelWeapon[i]);
            CostWeapon[i] = (Math.Pow(CostMnojWeapon[i], XBuyWeapon[i]) - 1d) / (CostMnojWeapon[i] - 1d) * CostWeapon[i];
            
            if (upgradeLevel[5] > 0)
            {
                CostWeapon[i] *= 1d * Math.Pow(0.9d, upgradeLevel[5]);
            }
            CostWeapon[i] = Math.Round(CostWeapon[i]);

            
            incomeWeapon[i] = incomePerLevelWeapon[i] * levelWeapon[i];
            incomeWeaponUp[i] = incomePerLevelWeapon[i] * (levelWeapon[i] + XBuyWeapon[i]);
            
            incomeWeapon[i] = incomeWeapon[i] * Math.Pow(2d, levelWeapon[i] / 25);
            incomeWeaponUp[i] = incomeWeaponUp[i] * Math.Pow(2d, (levelWeapon[i] + XBuyWeapon[i]) / 25);
            //income
            SlotUsedIncome[i, 0] = SlotUsed[i, panelTypeWeapon[i], 0] * 0.1d;
            SlotUsedIncome[i, 1] = SlotUsed[i, panelTypeWeapon[i], 1] * 0.1d;
            SlotUsedIncome[i, 2] = SlotUsed[i, panelTypeWeapon[i], 2] * 0.1d;
            incomeWeapon[i] *= 1d + SlotUsedIncome[i, 0] + SlotUsedIncome[i, 1] + SlotUsedIncome[i, 2];
            incomeWeaponUp[i] *= 1d + SlotUsedIncome[i, 0] + SlotUsedIncome[i, 1] + SlotUsedIncome[i, 2];
            //weapons
            if (upgradeLevel[2] > 0)
            {
                incomeWeapon[i] *= Math.Pow(2d, upgradeLevel[2]);
                incomeWeaponUp[i] *= Math.Pow(2d, upgradeLevel[2]);
            }


            
            SpeedWeapon[i] = 1f;
            SpeedWeaponUp[i] = 1f;
            
            for (int i2 = 0; i2 < 6; i2++)
            {
                if (upgradeLevel[26 + i2] > 0)
                {
                    SpeedWeapon[i] *= 1f * Mathf.Pow(1.1f, upgradeLevel[26 + i2]);
                    SpeedWeaponUp[i] *= 1f * Mathf.Pow(1.1f, upgradeLevel[26 + i2]);
                }
            }



            //bar
            BarMaxWeapon[i] = 1f;
            BarMaxWeaponUp[i] = 1f;
            BarMaxWeapon[i] = BarMaxWeapon[i] * Mathf.Pow(1.2f, levelWeapon[i] / 25);
            BarMaxWeaponUp[i] = BarMaxWeaponUp[i] * Mathf.Pow(1.2f, (levelWeapon[i] + XBuyWeapon[i]) / 25);

        }
    }

    public static void UpdateOre()
    {
        for (int i = 0; i < oreAmount; i++)
        {
            
            XBuyOre[i] = xBuy;

            //ore
            CostOre[i] = CostStartOre[i] * Math.Pow(CostMnojOre[i], levelOre[i]);
            CostOre[i] = (Math.Pow(CostMnojOre[i], XBuyOre[i]) - 1d) / (CostMnojOre[i] - 1d) * CostOre[i];
            //upgrade
            if (upgradeLevel[3] > 0)
            {
                CostOre[i] *= 1d * Math.Pow(0.9d, upgradeLevel[3]);
            }
            CostOre[i] = Math.Round(CostOre[i]);
            
            if (i == 0 && levelOre[i] == 0)
                CostOre[i] = 0;

            
            incomeOre[i] = incomePerLevelOre[i] * levelOre[i];
            incomeOreUp[i] = incomePerLevelOre[i] * (levelOre[i] + XBuyOre[i]);
            
            incomeOre[i] = incomeOre[i] * Math.Pow(2d, levelOre[i] / 25);
            incomeOreUp[i] = incomeOreUp[i] * Math.Pow(2d, (levelOre[i] + XBuyOre[i]) / 25);
            
            oreUsedIncome[i] = oreUsed[i] * 0.1d;
            incomeOre[i] *= 1d + oreUsedIncome[i];
            incomeOreUp[i] *= 1d + oreUsedIncome[i];
            
            if(upgradeLevel[0] > 0)
            {
                incomeOre[i] *= Math.Pow(2d, upgradeLevel[0]);
                incomeOreUp[i] *= Math.Pow(2d, upgradeLevel[0]);
            }

            
            SpeedOre[i] = 1f;
            SpeedOreUp[i] = 1f;
            
            for(int i2 = 0; i2 < 10; i2++)
            {
                if (upgradeLevel[6 + i2] > 0)
                {
                    SpeedOre[i] *= 1f * Mathf.Pow(1.1f, upgradeLevel[6 + i2]);
                    SpeedOreUp[i] *= 1f * Mathf.Pow(1.1f, upgradeLevel[6 + i2]);
                }
            }
            


            //ore bar
            BarMaxOre[i] = 1f;
            BarMaxOreUp[i] = 1f;
            BarMaxOre[i] = BarMaxOre[i] * Mathf.Pow(1.2f, levelOre[i] / 25);
            BarMaxOreUp[i] = BarMaxOreUp[i] * Mathf.Pow(1.2f, (levelOre[i] + XBuyOre[i]) / 25);

        }
    }

    public static void UpdateIngot()
    {
        for (int i = 0; i < IngotAmount; i++)
        {
            
            XBuyIngot[i] = xBuy;

            //costs
            CostIngot[i] = CostStartIngot[i] * Math.Pow(CostMnojIngot[i], levelIngot[i]);
            CostIngot[i] = (Math.Pow(CostMnojIngot[i], XBuyIngot[i]) - 1d) / (CostMnojIngot[i] - 1d) * CostIngot[i];
            
            if (upgradeLevel[4] > 0)
            {
                CostIngot[i] *= 1d * Math.Pow(0.9d, upgradeLevel[4]);
            }
            CostIngot[i] = Math.Round(CostIngot[i]);

            //income
            incomeIngot[i] = incomePerLevelIngot[i] * levelIngot[i];
            incomeIngotUp[i] = incomePerLevelIngot[i] * (levelIngot[i] + XBuyIngot[i]);
            
            incomeIngot[i] = incomeIngot[i] * Math.Pow(2d, levelIngot[i] / 25);
            incomeIngotUp[i] = incomeIngotUp[i] * Math.Pow(2d, (levelIngot[i] + XBuyIngot[i]) / 25);
            
            IngotUsedIncome[i] = IngotUsed[i] * 0.1d;
            incomeIngot[i] *= 1d + IngotUsedIncome[i];
            incomeIngotUp[i] *= 1d + IngotUsedIncome[i];
            
            if (upgradeLevel[1] > 0)
            {
                incomeIngot[i] *= Math.Pow(2d, upgradeLevel[1]);
                incomeIngotUp[i] *= Math.Pow(2d, upgradeLevel[1]);
            }


            
            SpeedIngot[i] = 1f;
            SpeedIngotUp[i] = 1f;
            
            for (int i2 = 0; i2 < 10; i2++)
            {
                if (upgradeLevel[16 + i2] > 0)
                {
                    SpeedIngot[i] *= 1f * Mathf.Pow(1.1f, upgradeLevel[16 + i2]);
                    SpeedIngotUp[i] *= 1f * Mathf.Pow(1.1f, upgradeLevel[16 + i2]);
                }
            }



            //bar
            BarMaxIngot[i] = 1f;
            BarMaxIngotUp[i] = 1f;
            BarMaxIngot[i] = BarMaxIngot[i] * Mathf.Pow(1.2f, levelIngot[i] / 25);
            BarMaxIngotUp[i] = BarMaxIngotUp[i] * Mathf.Pow(1.2f, (levelIngot[i] + XBuyIngot[i]) / 25);

        }
    }



    
    public static void UpdateQuest()
    {

        
        for(int i = 0; i < questAmount; i++)
        {
            questProp[i] = questPropPer[i] * questLevel[i];
            
            if (i >= 6 && i <= 23)
                questProp[i] = questPropPer[i];
        }

        
        questAmountOn = 0;
        for (int i = 0; i < questAmount; i++)
        {
            if(questOn[i] == 1 && questLevel[i] < questLevelMax[i])
            {
                questSlot[questAmountOn] = i;
                questAmountOn += 1;
            }
        }

        
        for(int i = 0; i < questAmount; i++)
        {
            questProgressNeed[i] = questProgressPerLevel[i] + questProgressPerLevel[i] * questLevel[i];
        }





        _pQ.UpdateAllSlot();
    }


    
    public static void UpdateUpgrade()
    {

        
        for (int i = 0; i < upgradeAmount; i++)
        {
            upgradeCost[i] = upgradeCostStart[i] * Math.Pow(upgradeCostMnoj[i], upgradeLevel[i]);
            upgradeCostSort[i] = upgradeCostStart[i] * Math.Pow(upgradeCostMnoj[i], upgradeLevel[i]);
        }

        for (int i = 0; i < 30; i++)
        {
            upgradeSlot[i] = -1;
            upgradeSlotSort[i] = -1;
        }
        
        upgradeAmountOn = 0;
        for (int i = 0; i < upgradeAmount; i++)
        {
            if (upgradeAmountOn < 30 && upgradeLevel[i] < upgradeLevelMax[i])
            {
                upgradeSlot[upgradeAmountOn] = i;
                upgradeAmountOn += 1;
            }
        }
        
        Array.Sort(upgradeCostSort, upgradeSlot, 0, upgradeAmountOn);


        _pU.UpdateAllSlot();
    }




    
    #region
    public static string Sign(double sign1, double sign2)
    {
        string ret = "";

        if (sign2 > sign1)
        {
            ret += " > <#21CB1E>";
        }
        else
        {
            if (sign2 < sign1)
            {
                ret += " < <#DE1616>";
            }
            else
            {
                ret += " = <#FFFFFF>";
            }
        }




        return (ret);
    }
    public static string Sign2(double sign1, double sign2)
    {
        string ret = "";

        if (sign2 > sign1)
        {
            ret += " > <#DE1616>";
        }
        else
        {
            if (sign2 < sign1)
            {
                ret += " < <#21CB1E>";
            }
            else
            {
                ret += " = <#FFFFFF>";
            }
        }




        return (ret);
    }
    #endregion

    
    #region
    public static string Timer00(float timer)
    {
        string ret = "";
        float min = Mathf.Floor(timer / 60f);
        float sec = Mathf.Round(timer - min * 60f);


        if (min < 10f)
            ret += "0";
        ret += min + ":";
        if (sec < 10f)
            ret += "0";
        ret += sec;

        return (ret);
    }
    #endregion

    
    #region
    public static int notation = 0;

    //Reduction 0
    private static string[] sokr = new string[] { "K", "M", "B", "T", "aa", "ab", "ac", "ad", "ae", "af", "ag", "ah", "ai", "aj", "ak", "al", "am", "an", "ao", "ap", "aq", "ar", "as", "at", "au", "av", "aw", "ax", "ay", "az", "ba", "bb", "bc", "bd", "be", "bf", "bg", "bh", "bi", "bj", "bk", "bl", "bm", "bn", "bo", "bp", "bq", "br", "bs", "bt", "bu", "bv", "bw", "bx", "by", "bz", "ca", "cb", "cc", "cd", "ce", "cf", "cg", "ch", "ci", "cj", "ck", "cl", "cm", "cn", "co", "cp", "cq", "cr", "cs", "ct", "cu", "cv", "cw", "cx", "cy", "cz", "da", "db", "dc", "dd", "de", "df", "dg", "dh", "di", "dj", "dk", "dl", "dm", "dn", "do", "dp", "dq", "dr", "ds", "dt" };
    public static string Reduction_0(double costs)
    {
        string ret = "Over";

        //alf
        if (notation == 0)
        {
            if (costs < 1000)
            {
                ret = costs.ToString("n0");
            }
            else
            {

                //ret = costs.tostring("g3"); 1.000e6 = 1 000 000
                double prov = 1000;
                int prov_n = 0;
                for (int i = 0; costs >= prov; i++)
                {
                    prov *= 1000;
                    prov_n = i;
                }
                ret = ((Math.Floor(costs / (prov / 1000000d))) / 1000).ToString("N1") + (sokr[prov_n]);
                //ret = ((Math.Floor(costs / (prov / 10000d))) / 1000).ToString("N3") + " e" + (prov_n + 6);
                //ret = (math.floor(costs / (prov / 10000d)) / 1000d).tostring(".00") + "e" + (prov_n + 6);
            }
        }

        //scientific
        if (notation == 1)
        {
            if (costs < 1000000)
            {
                ret = costs.ToString("n0");
            }
            else
            {

                //ret = costs.tostring("g3"); 1.000e6 = 1 000 000
                double prov = 1000000;
                int prov_n = 0;
                for (int i = 0; costs >= prov; i++)
                {
                    prov *= 10;
                    prov_n = i;
                }
                //ret = Math.Floor();
                ret = ((Math.Floor(costs / (prov / 10000d))) / 1000).ToString("N3") + "e" + (prov_n + 6);
                //ret = ((Math.Floor(costs / (prov / 10000d))) / 1000).ToString("N3") + " e" + (prov_n + 6);
                //ret = (math.floor(costs / (prov / 10000d)) / 1000d).tostring(".00") + "e" + (prov_n + 6);
            }
        }
        //scientific
        if (notation == 2)
        {
            if (costs < 1000000)
            {
                ret = costs.ToString("n0");
            }
            else
            {

                //ret = costs.tostring("g3"); 1.000e6 = 1 000 000
                double prov = 1000000;
                int prov_n = 0;
                int prov_eng = -1;
                for (int i = 0; costs >= prov; i++)
                {
                    prov *= 1000;
                    prov_n = i;
                }
                //for eng
                double prov2 = 1000000;
                for (int i = 0; costs >= prov2; i++)
                {
                    prov2 *= 10;
                    prov_eng += 1;
                    if (prov_eng > 2)
                        prov_eng = 0;
                }

                if (prov_eng == 0)
                    ret = ((Math.Floor(costs / (prov / 1000000d))) / 1000).ToString("N3") + "e" + (prov_n * 3 + 6);
                if (prov_eng == 1)
                    ret = ((Math.Floor(costs / (prov / 1000000d))) / 1000).ToString("N2") + "e" + (prov_n * 3 + 6);
                if (prov_eng == 2)
                    ret = ((Math.Floor(costs / (prov / 1000000d))) / 1000).ToString("N1") + "e" + (prov_n * 3 + 6);
                //ret = ((Math.Floor(costs / (prov / 10000d))) / 1000).ToString("N3") + " e" + (prov_n + 6);
                //ret = (math.floor(costs / (prov / 10000d)) / 1000d).tostring(".00") + "e" + (prov_n + 6);
            }
        }






        return (ret);
    }
    public static string Reduction_1(double costs)
    {
        string ret = "Over";

        //alf
        if (notation == 0)
        {
            if (costs < 1000)
            {
                ret = costs.ToString("n1");
            }
            else
            {

                //ret = costs.tostring("g3"); 1.000e6 = 1 000 000
                double prov = 1000;
                int prov_n = 0;
                for (int i = 0; costs >= prov; i++)
                {
                    prov *= 1000;
                    prov_n = i;
                }
                ret = ((Math.Floor(costs / (prov / 1000000d))) / 1000).ToString("N2") + (sokr[prov_n]);
                //ret = ((Math.Floor(costs / (prov / 10000d))) / 1000).ToString("N3") + " e" + (prov_n + 6);
                //ret = (math.floor(costs / (prov / 10000d)) / 1000d).tostring(".00") + "e" + (prov_n + 6);
            }
        }

        //scientific
        if (notation == 1)
        {
            if (costs < 1000000)
            {
                ret = costs.ToString("n0");
            }
            else
            {

                //ret = costs.tostring("g3"); 1.000e6 = 1 000 000
                double prov = 1000000;
                int prov_n = 0;
                for (int i = 0; costs >= prov; i++)
                {
                    prov *= 10;
                    prov_n = i;
                }
                //ret = Math.Floor();
                ret = ((Math.Floor(costs / (prov / 10000d))) / 1000).ToString("N3") + "e" + (prov_n + 6);
                //ret = ((Math.Floor(costs / (prov / 10000d))) / 1000).ToString("N3") + " e" + (prov_n + 6);
                //ret = (math.floor(costs / (prov / 10000d)) / 1000d).tostring(".00") + "e" + (prov_n + 6);
            }
        }
        //scientific
        if (notation == 2)
        {
            if (costs < 1000000)
            {
                ret = costs.ToString("n0");
            }
            else
            {

                //ret = costs.tostring("g3"); 1.000e6 = 1 000 000
                double prov = 1000000;
                int prov_n = 0;
                int prov_eng = -1;
                for (int i = 0; costs >= prov; i++)
                {
                    prov *= 1000;
                    prov_n = i;
                }
                //for eng
                double prov2 = 1000000;
                for (int i = 0; costs >= prov2; i++)
                {
                    prov2 *= 10;
                    prov_eng += 1;
                    if (prov_eng > 2)
                        prov_eng = 0;
                }

                if (prov_eng == 0)
                    ret = ((Math.Floor(costs / (prov / 1000000d))) / 1000).ToString("N3") + "e" + (prov_n * 3 + 6);
                if (prov_eng == 1)
                    ret = ((Math.Floor(costs / (prov / 1000000d))) / 1000).ToString("N2") + "e" + (prov_n * 3 + 6);
                if (prov_eng == 2)
                    ret = ((Math.Floor(costs / (prov / 1000000d))) / 1000).ToString("N1") + "e" + (prov_n * 3 + 6);
                //ret = ((Math.Floor(costs / (prov / 10000d))) / 1000).ToString("N3") + " e" + (prov_n + 6);
                //ret = (math.floor(costs / (prov / 10000d)) / 1000d).tostring(".00") + "e" + (prov_n + 6);
            }
        }






        return (ret);
    }
    public static string Reduction_2(double costs)
    {
        string ret = "Over";

        //alf
        if (notation == 0)
        {
            if (costs < 1000)
            {
                ret = costs.ToString("n2");
            }
            else
            {

                //ret = costs.tostring("g3"); 1.000e6 = 1 000 000
                double prov = 1000;
                int prov_n = 0;
                for (int i = 0; costs >= prov; i++)
                {
                    prov *= 1000;
                    prov_n = i;
                }
                ret = ((Math.Floor(costs / (prov / 1000000d))) / 1000).ToString("N2") + (sokr[prov_n]);
                //ret = ((Math.Floor(costs / (prov / 10000d))) / 1000).ToString("N3") + " e" + (prov_n + 6);
                //ret = (math.floor(costs / (prov / 10000d)) / 1000d).tostring(".00") + "e" + (prov_n + 6);
            }
        }

        //scientific
        if (notation == 1)
        {
            if (costs < 1000000)
            {
                ret = costs.ToString("n0");
            }
            else
            {

                //ret = costs.tostring("g3"); 1.000e6 = 1 000 000
                double prov = 1000000;
                int prov_n = 0;
                for (int i = 0; costs >= prov; i++)
                {
                    prov *= 10;
                    prov_n = i;
                }
                //ret = Math.Floor();
                ret = ((Math.Floor(costs / (prov / 10000d))) / 1000).ToString("N3") + "e" + (prov_n + 6);
                //ret = ((Math.Floor(costs / (prov / 10000d))) / 1000).ToString("N3") + " e" + (prov_n + 6);
                //ret = (math.floor(costs / (prov / 10000d)) / 1000d).tostring(".00") + "e" + (prov_n + 6);
            }
        }
        //scientific
        if (notation == 2)
        {
            if (costs < 1000000)
            {
                ret = costs.ToString("n0");
            }
            else
            {

                //ret = costs.tostring("g3"); 1.000e6 = 1 000 000
                double prov = 1000000;
                int prov_n = 0;
                int prov_eng = -1;
                for (int i = 0; costs >= prov; i++)
                {
                    prov *= 1000;
                    prov_n = i;
                }
                //for eng
                double prov2 = 1000000;
                for (int i = 0; costs >= prov2; i++)
                {
                    prov2 *= 10;
                    prov_eng += 1;
                    if (prov_eng > 2)
                        prov_eng = 0;
                }

                if (prov_eng == 0)
                    ret = ((Math.Floor(costs / (prov / 1000000d))) / 1000).ToString("N3") + "e" + (prov_n * 3 + 6);
                if (prov_eng == 1)
                    ret = ((Math.Floor(costs / (prov / 1000000d))) / 1000).ToString("N2") + "e" + (prov_n * 3 + 6);
                if (prov_eng == 2)
                    ret = ((Math.Floor(costs / (prov / 1000000d))) / 1000).ToString("N1") + "e" + (prov_n * 3 + 6);
                //ret = ((Math.Floor(costs / (prov / 10000d))) / 1000).ToString("N3") + " e" + (prov_n + 6);
                //ret = (math.floor(costs / (prov / 10000d)) / 1000d).tostring(".00") + "e" + (prov_n + 6);
            }
        }






        return (ret);
    }
    #endregion





}
