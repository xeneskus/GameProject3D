using System.Collections;
using System.Collections.Generic;
using GameProject3D.Managers;
using UnityEngine;

namespace GameProject3D.Uis
{
    public class WinConditionPanel : MonoBehaviour
    {
        public void YesClick()
        {
            GameManager.Instance.LoadLevelScene(1);
        }
    }
}

