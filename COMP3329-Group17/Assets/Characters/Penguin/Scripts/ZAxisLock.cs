using UnityEngine;

public class ZAxisLock : MonoBehaviour
{
    public float lockedZPosition = 12.0f; // The Z position you want to lock your character to

    void LateUpdate()
    {
        Vector3 position = transform.position;
        if (position.z != lockedZPosition)
        {
            position.z = lockedZPosition;
            transform.position = position; // Force the Z position
        }
    }
}