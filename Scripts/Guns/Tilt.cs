using UnityEngine;

public class Sway : MonoBehaviour
{
    [Header("Rotation")]
    public float rotationAmount = 4f;
    public float maxRotationAmount = 5f;
    public float smoothRotation = 12f;
    
    [Space]
    public bool rotationX = true, rotationY = true, rotationZ = true;

    private Vector3 initialPosition;
    private Quaternion initialRotation;

    private GunSystem gun;

    private float InputX, InputY;

    private void Start()
    {
        initialPosition = transform.localPosition;
        initialRotation = transform.localRotation;
    }

    private void Update()
    {
        CalculateSway();
        TiltSway();
    }

    private void CalculateSway()
    {
        InputX = Input.GetAxis("Mouse X");
        InputY = Input.GetAxis("Mouse Y");
    }

    private void TiltSway()
    {
        float tiltY = Mathf.Clamp(InputX * rotationAmount, -maxRotationAmount, maxRotationAmount);
        float tiltX = Mathf.Clamp(InputY * rotationAmount, -maxRotationAmount, maxRotationAmount);

        Quaternion finalRotation = Quaternion.Euler(new Vector3(rotationX ? -tiltX : 0f, rotationY ? tiltY : 0f, rotationZ ? tiltY : 0f));
            
        transform.localRotation = Quaternion.Slerp(transform.localRotation, finalRotation * initialRotation, smoothRotation * Time.deltaTime);
    }
}