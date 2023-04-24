using System.Collections;
using System.Collections.Generic;
using GameProject3D.Managers;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameProject3D.Controllers
{
    public class FinishFloorController : MonoBehaviour
    {
        [SerializeField] GameObject _finishFireWork;
        [SerializeField] GameObject _finishLight;

        private void OnCollisionEnter(Collision collision)
        {
            PlayerController player = collision.collider.GetComponent<PlayerController>();

            if (player == null || !player.CanMove) return; 


            if (collision.GetContact(0).normal.y == -1)
            {
                _finishFireWork.gameObject.SetActive(true);
                _finishLight.gameObject.SetActive(true);
                GameManager.Instance.MissionSucced();
            }
            else
            {
                GameManager.Instance.GameOver();
            }

        }
    }

}

