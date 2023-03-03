using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class allTextManager : MonoBehaviour
{


    public static string[] weaponName = new string[] { "Sword", "Dagger", "Sai", "Spear", "Hammer", "Mace", };

    public static string[] oreName = new string[] { "Copper", "Iron", "Aluminium", "Quicksilver", "Steel", "Silver", "Nickel", "Gold", "Bronze", "Uranium", };
    public static string[] ingotName = new string[] { "Copper", "Iron", "Aluminium", "Quicksilver", "Steel", "Silver", "Nickel", "Gold", "Bronze", "Uranium", };


    public static string[] questName = new string[] 
    { 
        "Mining", 
        "Smelting", 
        "Forging", 
        "Mining growth", 
        "Smelting growth", 
        "Forging growth",
        "Copper ore",
        "Iron ore",
        "Aluminium ore",
        "Quicksilver ore",
        "Steel ore",
        "Silver ore",
        "Nickel ore",
        "Gold ore",
        "Bronze ore",
        "Copper ingot",
        "Iron ingot",
        "Aluminium ingot",
        "Quicksilver ingot",
        "Steel ingot",
        "Silver ingot",
        "Nickel ingot",
        "Gold ingot",
        "Bronze ingot",
        "Sword", 
        "Dagger", 
        "Sai", 
        "Spear",
        "Hammer",
        "Mace",
        "Armory",

        "Mining Copper ore ",
        "Mining Iron ore ",
        "Mining Aluminium ore ",
        "Mining Quicksilver ore ",
        "Mining Steel ore ",
        "Mining Silver ore ",
        "Mining Nickel ore ",
        "Mining Gold ore ",
        "Mining Bronze ore ",
        "Mining Uranium ore ",

        "Smelting Copper ingot ",
        "Smelting Iron ingot ",
        "Smelting Aluminium ingot ",
        "Smelting Quicksilver ingot ",
        "Smelting Steel ingot ",
        "Smelting Silver ingot ",
        "Smelting Nickel ingot ",
        "Smelting Gold ingot ",
        "Smelting Bronze ingot ",
        "Smelting Uranium ingot ",

    };
    public static string[] questProp = new string[] 
    { 
        "Mine ore ", 
        "Smelting ignot ", 
        "Forging weapon ",
        "Upgrade mine ",
        "Upgrade furnace ",
        "Upgrade weapon ",
        "Mining Copper ore ",
        "Mining Iron ore ",
        "Mining Aluminium ore ",
        "Mining Quicksilver ore ",
        "Mining Steel ore ",
        "Mining Silver ore ",
        "Mining Nickel ore ",
        "Mining Gold ore ",
        "Mining Bronze ore ",
        "Smelting Copper ingot ",
        "Smelting Iron ingot ",
        "Smelting Aluminium ingot ",
        "Smelting Quicksilver ingot ",
        "Smelting Steel ingot ",
        "Smelting Silver ingot ",
        "Smelting Nickel ingot ",
        "Smelting Gold ingot ",
        "Smelting Bronze ingot ",
        "Forging Sword",
        "Forging Dagger",
        "Forging Sai",
        "Forging Spear",
        "Forging Hammer",
        "Forging Mace",
        "Forging weapon",

        "Mining Copper ore ",
        "Mining Iron ore ",
        "Mining Aluminium ore ",
        "Mining Quicksilver ore ",
        "Mining Steel ore ",
        "Mining Silver ore ",
        "Mining Nickel ore ",
        "Mining Gold ore ",
        "Mining Bronze ore ",
        "Mining Uranium ore ",

        "Smelting Copper ingot ",
        "Smelting Iron ingot ",
        "Smelting Aluminium ingot ",
        "Smelting Quicksilver ingot ",
        "Smelting Steel ingot ",
        "Smelting Silver ingot ",
        "Smelting Nickel ingot ",
        "Smelting Gold ingot ",
        "Smelting Bronze ingot ",
        "Smelting Uranium ingot ",



    };
    public static string[] questProp2 = new string[]
    {
        "+ level",
        "+ level",
        "+ level",
        "",
        "",
        "",
        "",
        "+ level",
        "+ level",
        "+ level",
        "+ level",
        "+ level",
        "+ level",
        "+ level",
        "+ level",
        "",
        "+ level",
        "+ level",
        "+ level",
        "+ level",
        "+ level",
        "+ level",
        "+ level",
        "+ level",

        "+ level",
        "+ level",
        "+ level",
        "+ level",
        "+ level",
        "+ level",
        "+ level",

        "+ level",
        "+ level",
        "+ level",
        "+ level",
        "+ level",
        "+ level",
        "+ level",
        "+ level",
        "+ level",
        "+ level",

        "+ level",
        "+ level",
        "+ level",
        "+ level",
        "+ level",
        "+ level",
        "+ level",
        "+ level",
        "+ level",
        "+ level",

    };

    public static string[] questReward = new string[]
    {
        "\n\n<#40C7C8>Reward:</color> upgrade",
        "\n\n<#40C7C8>Reward:</color> upgrade",
        "\n\n<#40C7C8>Reward:</color> upgrade",
        "\n\n<#40C7C8>Reward:</color> upgrade",
        "\n\n<#40C7C8>Reward:</color> upgrade",
        "\n\n<#40C7C8>Reward:</color> upgrade",

        "\n\n<#40C7C8>Reward:</color> Iron ore",
        "\n\n<#40C7C8>Reward:</color> Aluminium ore",
        "\n\n<#40C7C8>Reward:</color> Quicksilver ore",
        "\n\n<#40C7C8>Reward:</color> Steel ore",
        "\n\n<#40C7C8>Reward:</color> Silver ore",
        "\n\n<#40C7C8>Reward:</color> Nickel ore",
        "\n\n<#40C7C8>Reward:</color> Gold ore",
        "\n\n<#40C7C8>Reward:</color> Bronze ore",
        "\n\n<#40C7C8>Reward:</color> Uranium ore",

        "\n\n<#40C7C8>Reward:</color> Iron ingot",
        "\n\n<#40C7C8>Reward:</color> Aluminium ingot",
        "\n\n<#40C7C8>Reward:</color> Quicksilver ingot",
        "\n\n<#40C7C8>Reward:</color> Steel ingot",
        "\n\n<#40C7C8>Reward:</color> Silver ingot",
        "\n\n<#40C7C8>Reward:</color> Nickel ingot",
        "\n\n<#40C7C8>Reward:</color> Gold ingot",
        "\n\n<#40C7C8>Reward:</color> Bronze ingot",
        "\n\n<#40C7C8>Reward:</color> Uranium ingot",

        "\n\n<#40C7C8>Reward:</color> upgrade, Sword fragment",
        "\n\n<#40C7C8>Reward:</color> upgrade, Dagger fragment",
        "\n\n<#40C7C8>Reward:</color> upgrade, Sai fragment",
        "\n\n<#40C7C8>Reward:</color> upgrade, Spear fragment",
        "\n\n<#40C7C8>Reward:</color> upgrade, Hammer fragment",
        "\n\n<#40C7C8>Reward:</color> upgrade, Mace fragment",

        "\n\n<#40C7C8>Reward:</color> New weapon",

        "\n\n<#40C7C8>Reward:</color> upgrade",
        "\n\n<#40C7C8>Reward:</color> upgrade",
        "\n\n<#40C7C8>Reward:</color> upgrade",
        "\n\n<#40C7C8>Reward:</color> upgrade",
        "\n\n<#40C7C8>Reward:</color> upgrade",
        "\n\n<#40C7C8>Reward:</color> upgrade",
        "\n\n<#40C7C8>Reward:</color> upgrade",
        "\n\n<#40C7C8>Reward:</color> upgrade",
        "\n\n<#40C7C8>Reward:</color> upgrade",
        "\n\n<#40C7C8>Reward:</color> upgrade",

        "\n\n<#40C7C8>Reward:</color> upgrade",
        "\n\n<#40C7C8>Reward:</color> upgrade",
        "\n\n<#40C7C8>Reward:</color> upgrade",
        "\n\n<#40C7C8>Reward:</color> upgrade",
        "\n\n<#40C7C8>Reward:</color> upgrade",
        "\n\n<#40C7C8>Reward:</color> upgrade",
        "\n\n<#40C7C8>Reward:</color> upgrade",
        "\n\n<#40C7C8>Reward:</color> upgrade",
        "\n\n<#40C7C8>Reward:</color> upgrade",
        "\n\n<#40C7C8>Reward:</color> upgrade",

    };







    public static string[] upgradeName = new string[]
    {
        "Mining",
        "Smelting",
        "Forging",
        "Mining growth",
        "Smelting growth",
        "Forging growth",

        "Mining Copper ore ",
        "Mining Iron ore ",
        "Mining Aluminium ore ",
        "Mining Quicksilver ore ",
        "Mining Steel ore ",
        "Mining Silver ore ",
        "Mining Nickel ore ",
        "Mining Gold ore ",
        "Mining Bronze ore ",
        "Mining Uranium ore ",

        "Smelting Copper ingot ",
        "Smelting Iron ingot ",
        "Smelting Aluminium ingot ",
        "Smelting Quicksilver ingot ",
        "Smelting Steel ingot ",
        "Smelting Silver ingot ",
        "Smelting Nickel ingot ",
        "Smelting Gold ingot ",
        "Smelting Bronze ingot ",
        "Smelting Uranium ingot ",

        "Forging Sword",
        "Forging Dagger",
        "Forging Sai",
        "Forging Spear",
        "Forging Hammer",
        "Forging Mace",
        "Forging weapon",


    };
    public static string[] upgradeProp = new string[]
    {
        "Increases the amount of ore mined by 2 times",
        "Increases the number of smelting ingots by 2 times",
        "Increases profit from weapons sales by 2 times",
        "Reduces the cost of mines by 10%",
        "Reduces the cost of furnaces by 10%",
        "Reduces the cost of weapons by 10%",

        "Increases ore mining speed by 10%",
        "Increases ore mining speed by 10%",
        "Increases ore mining speed by 10%",
        "Increases ore mining speed by 10%",
        "Increases ore mining speed by 10%",
        "Increases ore mining speed by 10%",
        "Increases ore mining speed by 10%",
        "Increases ore mining speed by 10%",
        "Increases ore mining speed by 10%",
        "Increases ore mining speed by 10%",

        "Increases ingot smelting speed by 10%",
        "Increases ingot smelting speed by 10%",
        "Increases ingot smelting speed by 10%",
        "Increases ingot smelting speed by 10%",
        "Increases ingot smelting speed by 10%",
        "Increases ingot smelting speed by 10%",
        "Increases ingot smelting speed by 10%",
        "Increases ingot smelting speed by 10%",
        "Increases ingot smelting speed by 10%",
        "Increases ingot smelting speed by 10%",

        "Increases weapon selling speed by 15%",
        "Increases weapon selling speed by 15%",
        "Increases weapon selling speed by 15%",
        "Increases weapon selling speed by 15%",
        "Increases weapon selling speed by 15%",
        "Increases weapon selling speed by 15%",


    };
    


}
