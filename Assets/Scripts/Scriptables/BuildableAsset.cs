using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lunacat.Scriptables
{
    /// <summary>
    /// Category of objects that can be created by the player
    /// </summary>
    public class BuildableAsset : ScriptableObject
    {
        public const string ResourceFolder = "Buildables";

        [SerializeField]
        int cost = 0;

        [SerializeField]
        GameObject buildingHelper;

        [SerializeField]
        GameObject sceneObject;

    }

}
