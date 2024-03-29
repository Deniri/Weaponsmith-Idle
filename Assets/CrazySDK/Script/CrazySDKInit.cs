﻿using UnityEngine;

namespace CrazyGames
{
    class CrazySDKInit
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        static void OnRuntimeMethodLoad()
        {
            var sdk = CrazySDK.Instance; // Trigger init by calling instance
        }
    }
}