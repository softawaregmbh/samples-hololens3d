using System;
using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class ShootBall : MonoBehaviour, IInputClickHandler
{
    public GameObject ball;
    public float force = 100;

    public void Start()
    {
        InputManager.Instance.PushModalInputHandler(gameObject);
    }

    public void OnInputClicked(InputEventData eventData)
    {
        var shot = Instantiate(ball);
        shot.transform.position = Camera.main.transform.position;

        shot.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * force);
    }
}
