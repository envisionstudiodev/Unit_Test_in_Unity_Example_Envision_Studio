using System.Collections;
using UnityEngine;

public class Unit : MonoBehaviour
{
    [SerializeField] private float moveSpeed; // Move speed
    private static bool _isMoving; // Is the unit moving?

    private void Start()
    {
        _isMoving = false;
    }

    // Move up
    public void MoveUp()
    {
        if (GetPosition().y >= Boundaries.BoundaryUp || _isMoving) return;
            
        var targetPosition = GetPosition() + Direction.Up;
        StartCoroutine(SmoothMove(targetPosition));
    }
        
    // Move down
    public void MoveDown()
    {
        if (GetPosition().y <= Boundaries.BoundaryDown || _isMoving) return;
            
        var targetPosition = GetPosition() + Direction.Down;
        StartCoroutine(SmoothMove(targetPosition));
    }
        
    // Move left
    public void MoveLeft()
    {
        if (GetPosition().x <= Boundaries.BoundaryLeft || _isMoving) return;
            
        var targetPosition = GetPosition() + Direction.Left;
        StartCoroutine(SmoothMove(targetPosition));
    }
        
    // Move right
    public void MoveRight()
    {
        if (GetPosition().x >= Boundaries.BoundaryRight || _isMoving) return;
            
        var targetPosition = GetPosition() + Direction.Right;
        StartCoroutine(SmoothMove(targetPosition));
    }
        
        
        
    // Move the unit smoothly 
    private IEnumerator SmoothMove(Vector3 targetPosition)
    {
        _isMoving = true;
        while (Vector3.Distance(transform.position, targetPosition) > 0.01f)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
            yield return null;
        }
        // Snap the position to the target position
        transform.position = targetPosition;
        _isMoving = false;
    }

    // Set position
    public void SetPosition(Vector3 position)
    {
        transform.position = position;
    }
        
    // Get position
    public Vector3 GetPosition()
    {
        return transform.position;
    }
    
    //Set move speed
    public void SetMoveSpeed(float speed)
    {
        moveSpeed = speed;
    }
        
}