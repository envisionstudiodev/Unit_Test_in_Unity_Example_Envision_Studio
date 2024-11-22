using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Unit playerUnit;
    void Update()
    {
        // Move Up
        if (Input.GetKeyDown(KeyCode.W))
        {
            playerUnit.MoveUp();
        }
            
        // Move Down
        if (Input.GetKeyDown(KeyCode.S))
        {
            playerUnit.MoveDown();
        }
            
        // Move Left
        if (Input.GetKeyDown(KeyCode.A))
        {
            playerUnit.MoveLeft();
        }
            
        // Move Right
        if (Input.GetKeyDown(KeyCode.D))
        {
            playerUnit.MoveRight();
        }
            
    }
}