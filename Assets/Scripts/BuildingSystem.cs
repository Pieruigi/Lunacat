using Lunacat.Scriptables;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lunacat
{
    public class BuildingSystem : MonoBehaviour
    {

        BuildableAsset currentAsset;

        public bool TryBuild(BuildableAsset asset)
        {
            currentAsset = asset;



            return true;
        }
    }

}
