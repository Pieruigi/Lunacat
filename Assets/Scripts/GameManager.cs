using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lunacat
{
    public class GameManager : Singleton<GameManager>
    {
        bool newGame = true;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public bool IsNewGame()
        {
            return newGame;
        }

        public void StartNewGame()
        {
            newGame = true;
        }

        public void LoadSavedGame()
        {
            newGame = false;
        }
    }


}
