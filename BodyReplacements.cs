using UnityEngine;
using ModelReplacement;

namespace HSRSuitPack
{
    public class MydeiReplacement : BodyReplacementBase
    {
        protected override GameObject? LoadAssetsAndReturnModel()
        { 
            string model_name = "Mydei";
            return Assets.MainAssetBundle?.LoadAsset<GameObject>(model_name);
        }
    }
}