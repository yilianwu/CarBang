using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]

    public class CarUserControl : MonoBehaviour
    {

		[SerializeField] private GameObject lefthand;
        private CarController m_Car; // the car controller we want to use

		float v=1000.0f;
		float h=0.0f;


        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }


        private void FixedUpdate()
        {
            // pass the input to the car!
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            //float v = CrossPlatformInputManager.GetAxis("Vertical");


			if (Input.GetKeyDown ("w")) {
				v = 1000.0f;
			}
			if (Input.GetKeyDown ("s")) {
				v = -2000.0f;
			}
#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            m_Car.Move(h, v, v, handbrake);
#else
            m_Car.Move(h, v, v, 0f);
#endif
        }
    }
}
