using UnityEngine;
using ModelReplacement;

namespace HSRSuitPack
{
    public class AnaxaReplacement : BodyReplacementBase
    {
        protected override GameObject? LoadAssetsAndReturnModel()
        {
            string model_name = "Anaxa";
            return Assets.MainAssetBundle?.LoadAsset<GameObject>(model_name);
        }
    }

    public class KhaslanaReplacement : BodyReplacementBase
    {
        protected override GameObject? LoadAssetsAndReturnModel()
        { 
            string model_name = "Khaslana";
            return Assets.MainAssetBundle?.LoadAsset<GameObject>(model_name);
        }
    }
    
    public class MydeiReplacement : BodyReplacementBase
    {
        protected override GameObject? LoadAssetsAndReturnModel()
        {
            string model_name = "Mydei";
            return Assets.MainAssetBundle?.LoadAsset<GameObject>(model_name);
        }
    }

    public class PhainonReplacement : BodyReplacementBase
    {
        protected override GameObject? LoadAssetsAndReturnModel()
        {
            string model_name = "Phainon";
            return Assets.MainAssetBundle?.LoadAsset<GameObject>(model_name);
        }
    }
}