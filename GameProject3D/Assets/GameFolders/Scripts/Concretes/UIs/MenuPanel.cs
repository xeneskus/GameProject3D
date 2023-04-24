using System.Collections;
using System.Collections.Generic;
using GameProject3D.Managers;
using UnityEngine;

namespace GameProject3D.UIs
{
    public class MenuPanel : MonoBehaviour
    {
       public void StartClicked()
       {
            GameManager.Instance.LoadLevelScene(1);
       }

        public void ExitClicked()
        {
            GameManager.Instance.Exit();
        }

    }

}
