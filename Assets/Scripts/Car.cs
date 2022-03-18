using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Car : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float speedGain = 0.1f;

    [SerializeField] private float turnSpeed = 200f;

    private int inputValue;
    
     
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        speed += speedGain * Time.deltaTime;
        
        transform.Rotate(new Vector3(0, inputValue * turnSpeed , 0) * Time.deltaTime);
    }

    public void Turn(int value)
    {
        inputValue = value;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene(0);
        }
    }
}
