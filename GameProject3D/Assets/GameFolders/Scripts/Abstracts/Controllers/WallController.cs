using GameProject3D.Controllers;
using GameProject3D.Managers;
using UnityEngine;

namespace GameProject3D.Abstracts.Controllers
{
    public abstract class WallController : MonoBehaviour 
    {
        private void OnCollisionEnter(Collision other)
        {
            PlayerController player =  other.collider.GetComponent<PlayerController>();

            if (player != null && player.CanMove) 
            {
                GameManager.Instance.GameOver();
            }
        }
    }

}
