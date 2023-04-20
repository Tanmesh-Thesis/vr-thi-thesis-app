using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carforrward : MonoBehaviour
{
    // Start is called before the first frame update
    CharacterController controller;
    public float movementSpeed = 1.0f;
     public List<Transform> carPoints;
    private int currentTargetPoint = 1;
    public bool loopWalking = true;

    void Start()
    {
         controller = GetComponent<CharacterController>();

        this.gameObject.transform.position = carPoints[0].position;
        currentTargetPoint = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTargetPoint >= carPoints.Count)
        {
            return;
        }

        Vector3 endPoint = carPoints[currentTargetPoint].position;

        Vector3 direction = endPoint - this.gameObject.transform.position;

        if (direction.sqrMagnitude > 0.2f)
        {
            direction = direction.normalized;
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0.0f, targetAngle, 0.0f);
            controller.Move(direction * movementSpeed * Time.deltaTime);
        }
        else
        {
            currentTargetPoint++;
            if (currentTargetPoint >= carPoints.Count && loopWalking)
            {
                currentTargetPoint = 0;
            }
        }

    }
}
