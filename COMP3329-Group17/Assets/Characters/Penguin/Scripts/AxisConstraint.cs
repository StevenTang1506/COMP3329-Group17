using UnityEngine;

public class ZAxisLock : MonoBehaviour
{
    public float lockedZPosition; // The Z position you want to lock your character to
    public float minimumYPosition; // Minimum Y position for the penguin

    void LateUpdate()
    {
        Vector3 position = transform.position;
        if (position.z != lockedZPosition)
        {
            position.z = lockedZPosition;
            transform.position = position; // Force the Z position
        }
        if (position.y <= minimumYPosition)
        {
            position.y = minimumYPosition;
            transform.position = position; // Force the Y position
        }
    }
}