using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lunacat
{
    public class Sector : MonoBehaviour
    {
        [SerializeField]
        bool owned = false;
        public bool Owned
        {
            get { return owned; }
        }


        public void Unlock()
        {
            owned = true;
        }

        private void Start()
        {
            if (!GameManager.Instance.IsNewGame())
                LoadOldGame();
            else
                InitNewGame();
        }

        void LoadOldGame()
        {

        }

        void InitNewGame()
        {
            
            int index = SectorManager.Instance.GetSectorId(gameObject);
            Debug.Log($"Index:{index}");
            if (index == SectorManager.SectorCount / 2)
            {
                owned = true;
            }
          
        }
    }

}
