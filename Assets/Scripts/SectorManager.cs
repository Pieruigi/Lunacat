using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lunacat
{
    public class SectorManager : Singleton<SectorManager>
    {
        public const float SectorSize = 20;
        public const int SectorCount = 9;

        [SerializeField]
        List<GameObject> sectors;

        [SerializeField]
        GameObject sectorPrefab;

        [SerializeField]
        int sectorPrice;

        protected override void Awake()
        {
            base.Awake();    

        }

        private void Start()
        {
            // Create sectors
            int sqrt = (int)Mathf.Sqrt(SectorCount);
            float offset = (sqrt / 2) * SectorSize;
            for (int i = 0; i < SectorCount; i++)
            {
                sectors.Add(Instantiate(sectorPrefab, transform));
                // Place in the world
                GameObject s = sectors[sectors.Count - 1];
                float x = ((i % sqrt) * SectorSize) - offset;
                float z = (-(i / sqrt) * SectorSize) + offset;
                s.transform.localPosition = new Vector3(x, 0, z);
                s.transform.localRotation = Quaternion.identity;
            }
        }

        public void BuySector(GameObject sector)
        {
            
            if(FinanceManager.Instance.Balance < sectorPrice)
            {
                Debug.LogWarning("No enough money to buy a new sector.");
                return;
            }

            Sector s = sector.GetComponent<Sector>();
            if (s.Owned)
            {
                Debug.LogWarning("You have already bought this sector.");
                return;
            }

            FinanceManager.Instance.Pay(sectorPrice);
            sector.GetComponent<Sector>().Unlock();
        }

        public int GetSectorId(GameObject sector)
        {
            return sectors.IndexOf(sector);
        }
    }

}
