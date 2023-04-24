using System.Collections;
using System.Collections.Generic;
using GameProject3D.Managers;
using UnityEngine;

namespace GameProject3D.Uis
{
    public class GameOverPanel : MonoBehaviour
    {

        
        public void YesClicked()
        {
            GameManager.Instance.LoadLevelScene();  
        }

        public void NoClicked()
        {
            GameManager.Instance.LoadMenuScene();
        }
    }
}

