using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    private Vector2 targetPosition;
    private bool isMoving = false;
    public LayerMask obstacleLayer;
    public float collisionRadius;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (!IsObstacle(targetPosition))
            {
                isMoving = true;
            }
        }

        if (isMoving)
        {
            MoveTowardsTarget();
        }
    }

    void MoveTowardsTarget()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

        if (targetPosition.x > transform.position.x)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0); 
        }
        else if (targetPosition.x < transform.position.x)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0); 
        }

        if (Vector2.Distance(transform.position, targetPosition) < 0.1f)
        {
            isMoving = false;
        }
    }

    bool IsObstacle(Vector2 position)
    {
        return Physics2D.OverlapCircle(position, collisionRadius, obstacleLayer) != null;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(targetPosition, collisionRadius);
    }

    public bool IsMoving()
    {
        return isMoving;
    }
}
