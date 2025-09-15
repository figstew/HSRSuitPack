using BepInEx;
using HarmonyLib;
using UnityEngine;
using ModelReplacement;
using System;
using System.Reflection;

namespace HSRSuitPack
{
    [BepInPlugin("com.figstew.hsrsuitpack", "HSR Suit Pack", "0.1.0")]
    [BepInDependency("meow.ModelReplacementAPI", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("x753.More_Suits", BepInDependency.DependencyFlags.HardDependency)]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            Assets.PopulateAssets();

            // Plugin startup logic

            ModelReplacementAPI.RegisterSuitModelReplacement("Mydei", typeof(MydeiReplacement));

            Harmony harmony = new Harmony("com.figstew.hsrsuitpack");
            harmony.PatchAll();
            Logger.LogInfo($"Plugin {"com.figstew.hsrsuitpack"} is loaded!");
        }
    }
    public static class Assets
    {
        // Replace mbundle with the Asset Bundle Name from your unity project 
        public static string mainAssetBundleName = "hsrsuitpackbundle";
        public static AssetBundle? MainAssetBundle = null;

        private static string GetAssemblyName() => Assembly.GetExecutingAssembly().GetName().Name.Replace(" ","_");
        public static void PopulateAssets()
        {
            if (MainAssetBundle == null)
            {
                Console.WriteLine(GetAssemblyName() + "." + mainAssetBundleName);
                using (var assetStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(GetAssemblyName() + "." + mainAssetBundleName))
                {
                    MainAssetBundle = AssetBundle.LoadFromStream(assetStream);
                }

            }
        }
    }

}