using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class saveGame : MonoBehaviour
{

    private static Save sv = new Save();

    public static int save_on = 0;
    public static int load_on = 0;


    public static float save_time = 0f;
    public static float save_time_online = 0f;
    public static float load_time_online = 10f;


    //import export
    public static int amount_export_save = 0;
    public static string export_text = "";

    public static string save_string = "";


    private static int prov_amount;
    private static string[] all_slot = new string[5000];
    public static string import_string = "";


    //год мес€ц день час минута секунда
    public static int[] data_off = new int[] { 0, 0, 0, 0, 0, 0 };
    public static int[] data_off2 = new int[] { 0, 0, 0, 0, 0, 0 };
    public static int[] data_on = new int[] { 0, 0, 0, 0, 0, 0 };

    public static int[] mountD = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

    public static int prosh_sec;
    public static int cur_sec;
    public static int mount_day;
    public static int mount_dayC;
    public static int sec_in_off;



    public static int on_off_save = 0;

    public static int import_compl = 0;






    void Awake()
    {
        if (save_on == 0)
        {
            if (PlayerPrefs.HasKey("Save"))
            {
                sv = JsonUtility.FromJson<Save>(PlayerPrefs.GetString("Save"));

                load_gam();
            }
        }
    }




    private void Update()
    {
        //save_time += 1f * Time.deltaTime;

        if (save_time >= 1)
        {
            save_time = 0f;


            save_gam();

        }

        save_time_online += 1f * Time.deltaTime;
        load_time_online += 1f * Time.deltaTime;





    }




    public static void save_gam()
    {
        //Debug.Log("Save game");


        sv.money = playerManager.money;
        


        sv.learnOn = playerManager.learnOn;
        sv.musicOnOff = playerManager.musicOnOff;




        PlayerPrefs.SetString("Save", JsonUtility.ToJson(sv));

    }

    public static void load_gam()
    {
        Debug.Log("Load game");

        save_on = 1;

        playerManager.ore = sv.ore;
        playerManager.ingot = sv.ingot;
        playerManager.money = sv.money;

        playerManager.weaponAmount = sv.weaponAmount;
        playerManager.oreAmount = sv.oreAmount;
        playerManager.IngotAmount = sv.IngotAmount;

        for(int i = 0; i < 5; i++)
        {
            playerManager.levelWeapon[i] = sv.levelWeapon[i];
            playerManager.levelOre[i] = sv.levelOre[i];
            playerManager.levelIngot[i] = sv.levelIngot[i];

            playerManager.oreUsed[i] = sv.oreUsed[i];
            playerManager.IngotUsed[i] = sv.IngotUsed[i];
            playerManager.panelTypeWeapon[i] = sv.panelTypeWeapon[i];
        }

        playerManager.panelFragmentWeapon = sv.panelFragmentWeapon;

        for (int i = 0; i < 5; i++)
        {
            playerManager.SlotUsed[0, 0, i] = sv.SlotUsed0_0[i];
            playerManager.SlotUsed[0, 1, i] = sv.SlotUsed0_1[i];
            playerManager.SlotUsed[0, 2, i] = sv.SlotUsed0_2[i];
            playerManager.SlotUsed[0, 3, i] = sv.SlotUsed0_3[i];
            playerManager.SlotUsed[0, 4, i] = sv.SlotUsed0_4[i];
            playerManager.SlotUsed[0, 5, i] = sv.SlotUsed0_5[i];

            playerManager.SlotUsed[1, 0, i] = sv.SlotUsed1_0[i];
            playerManager.SlotUsed[1, 1, i] = sv.SlotUsed1_1[i];
            playerManager.SlotUsed[1, 2, i] = sv.SlotUsed1_2[i];
            playerManager.SlotUsed[1, 3, i] = sv.SlotUsed1_3[i];
            playerManager.SlotUsed[1, 4, i] = sv.SlotUsed1_4[i];
            playerManager.SlotUsed[1, 5, i] = sv.SlotUsed1_5[i];

            playerManager.SlotUsed[2, 0, i] = sv.SlotUsed2_0[i];
            playerManager.SlotUsed[2, 1, i] = sv.SlotUsed2_1[i];
            playerManager.SlotUsed[2, 2, i] = sv.SlotUsed2_2[i];
            playerManager.SlotUsed[2, 3, i] = sv.SlotUsed2_3[i];
            playerManager.SlotUsed[2, 4, i] = sv.SlotUsed2_4[i];
            playerManager.SlotUsed[2, 5, i] = sv.SlotUsed2_5[i];

            playerManager.SlotUsed[3, 0, i] = sv.SlotUsed3_0[i];
            playerManager.SlotUsed[3, 1, i] = sv.SlotUsed3_1[i];
            playerManager.SlotUsed[3, 2, i] = sv.SlotUsed3_2[i];
            playerManager.SlotUsed[3, 3, i] = sv.SlotUsed3_3[i];
            playerManager.SlotUsed[3, 4, i] = sv.SlotUsed3_4[i];
            playerManager.SlotUsed[3, 5, i] = sv.SlotUsed3_5[i];

            playerManager.SlotUsed[4, 0, i] = sv.SlotUsed4_0[i];
            playerManager.SlotUsed[4, 1, i] = sv.SlotUsed4_1[i];
            playerManager.SlotUsed[4, 2, i] = sv.SlotUsed4_2[i];
            playerManager.SlotUsed[4, 3, i] = sv.SlotUsed4_3[i];
            playerManager.SlotUsed[4, 4, i] = sv.SlotUsed4_4[i];
            playerManager.SlotUsed[4, 5, i] = sv.SlotUsed4_5[i];
        }



        for (int i = 0; i < 20; i++)
        {
            playerManager.fragnetOn[0, 0, i] = sv.fragnetOn0_0[i];
            playerManager.fragnetOn[0, 1, i] = sv.fragnetOn0_1[i];
            playerManager.fragnetOn[0, 2, i] = sv.fragnetOn0_2[i];

            playerManager.fragnetOn[1, 0, i] = sv.fragnetOn1_0[i];
            playerManager.fragnetOn[1, 1, i] = sv.fragnetOn1_1[i];
            playerManager.fragnetOn[1, 2, i] = sv.fragnetOn1_2[i];

            playerManager.fragnetOn[2, 0, i] = sv.fragnetOn2_0[i];
            playerManager.fragnetOn[2, 1, i] = sv.fragnetOn2_1[i];
            playerManager.fragnetOn[2, 2, i] = sv.fragnetOn2_2[i];

            playerManager.fragnetOn[3, 0, i] = sv.fragnetOn3_0[i];
            playerManager.fragnetOn[3, 1, i] = sv.fragnetOn3_1[i];
            playerManager.fragnetOn[3, 2, i] = sv.fragnetOn3_2[i];

            playerManager.fragnetOn[4, 0, i] = sv.fragnetOn4_0[i];
            playerManager.fragnetOn[4, 1, i] = sv.fragnetOn4_1[i];
            playerManager.fragnetOn[4, 2, i] = sv.fragnetOn4_2[i];

            playerManager.fragnetOn[5, 0, i] = sv.fragnetOn5_0[i];
            playerManager.fragnetOn[5, 1, i] = sv.fragnetOn5_1[i];
            playerManager.fragnetOn[5, 2, i] = sv.fragnetOn5_2[i];



        }
    



        for(int i = 0; i < 10; i++)
        {
            playerManager.oreOn[i] = sv.oreOn[i];
            playerManager.IngotOn[i] = sv.IngotOn[i];
        }

        for (int i = 0; i < 52; i++)
        {
            playerManager.questOn[i] = sv.questOn[i];
            playerManager.questLevel[i] = sv.questLevel[i];
            playerManager.questProgress[i] = sv.questLevel[i];
        }

        for (int i = 0; i < 33; i++)
        {
            playerManager.upgradeLevel[i] = sv.upgradeLevel[i];
            playerManager.upgradeLevelMax[i] = sv.upgradeLevelMax[i];
        }


        playerManager.learnOn = sv.learnOn;
        playerManager.musicOnOff = sv.musicOnOff;

        if (sv.money > 0f)
        {
            load_on = 1;
        }

    }













    [Serializable]
    public class Save
    {

        public double ore = 0;
        public double ingot = 0;
        public double money = 0;



        public int weaponAmount = 1;
        public int[] levelWeapon = new int[] { 0, 0, 0, 0, 0, };

        public int oreAmount = 1;
        public int[] levelOre = new int[] { 0, 0, 0, 0, 0, };

        public int IngotAmount = 1;
        public int[] levelIngot = new int[] { 0, 0, 0, 0, 0, };

        public int[] oreUsed = new int[] { 0, 0, 0, 0, 0, };

        public int[] IngotUsed = new int[] { 0, 0, 0, 0, 0, };

        //фрагменты
        public int[] panelTypeWeapon = new int[] { 0, 0, 0, 0, 0, };
        public int panelFragmentWeapon = 0;

        public int[] SlotUsed0_0 = new int[] { 0, 0, 0, };
        public int[] SlotUsed0_1 = new int[] { 0, 0, 0, };
        public int[] SlotUsed0_2 = new int[] { 0, 0, 0, };
        public int[] SlotUsed0_3 = new int[] { 0, 0, 0, };
        public int[] SlotUsed0_4 = new int[] { 0, 0, 0, };
        public int[] SlotUsed0_5 = new int[] { 0, 0, 0, };

        public int[] SlotUsed1_0 = new int[] { 0, 0, 0, };
        public int[] SlotUsed1_1 = new int[] { 0, 0, 0, };
        public int[] SlotUsed1_2 = new int[] { 0, 0, 0, };
        public int[] SlotUsed1_3 = new int[] { 0, 0, 0, };
        public int[] SlotUsed1_4 = new int[] { 0, 0, 0, };
        public int[] SlotUsed1_5 = new int[] { 0, 0, 0, };

        public int[] SlotUsed2_0 = new int[] { 0, 0, 0, };
        public int[] SlotUsed2_1 = new int[] { 0, 0, 0, };
        public int[] SlotUsed2_2 = new int[] { 0, 0, 0, };
        public int[] SlotUsed2_3 = new int[] { 0, 0, 0, };
        public int[] SlotUsed2_4 = new int[] { 0, 0, 0, };
        public int[] SlotUsed2_5 = new int[] { 0, 0, 0, };

        public int[] SlotUsed3_0 = new int[] { 0, 0, 0, };
        public int[] SlotUsed3_1 = new int[] { 0, 0, 0, };
        public int[] SlotUsed3_2 = new int[] { 0, 0, 0, };
        public int[] SlotUsed3_3 = new int[] { 0, 0, 0, };
        public int[] SlotUsed3_4 = new int[] { 0, 0, 0, };
        public int[] SlotUsed3_5 = new int[] { 0, 0, 0, };

        public int[] SlotUsed4_0 = new int[] { 0, 0, 0, };
        public int[] SlotUsed4_1 = new int[] { 0, 0, 0, };
        public int[] SlotUsed4_2 = new int[] { 0, 0, 0, };
        public int[] SlotUsed4_3 = new int[] { 0, 0, 0, };
        public int[] SlotUsed4_4 = new int[] { 0, 0, 0, };
        public int[] SlotUsed4_5 = new int[] { 0, 0, 0, };


        public int[] fragnetOn0_0 = new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
        public int[] fragnetOn0_1 = new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
        public int[] fragnetOn0_2 = new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };

        public int[] fragnetOn1_0 = new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
        public int[] fragnetOn1_1 = new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
        public int[] fragnetOn1_2 = new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };

        public int[] fragnetOn2_0 = new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
        public int[] fragnetOn2_1 = new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
        public int[] fragnetOn2_2 = new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };

        public int[] fragnetOn3_0 = new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
        public int[] fragnetOn3_1 = new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
        public int[] fragnetOn3_2 = new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };

        public int[] fragnetOn4_0 = new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
        public int[] fragnetOn4_1 = new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
        public int[] fragnetOn4_2 = new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };

        public int[] fragnetOn5_0 = new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
        public int[] fragnetOn5_1 = new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
        public int[] fragnetOn5_2 = new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };


        public int[] oreOn = new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
        public int[] IngotOn = new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, };

        public int[] questOn = new int[] { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
        public int[] questLevel = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
        public double[] questProgress = new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };

        public int[] upgradeLevel = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
        public int[] upgradeLevelMax = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };

        public int learnOn = 0;
        public int musicOnOff = 0;

    }


}
