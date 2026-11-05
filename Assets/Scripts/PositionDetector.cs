using UnityEngine;
using UnityEngine.UIElements;

public class PositionDetector : MonoBehaviour
{
    public GameObject head;
    public GameObject handR;
    public GameObject handL;
    private float logTimer = 0f;
    private float logInterval = 1f;


    [Header("Tracked Position")]
    [SerializeField] private Vector3 headPosition;
    [SerializeField] private Vector3 handRPosition;
    [SerializeField] private Vector3 handLPosition;

    private void Update()
    {
        if (head != null)
        {
            headPosition = head.transform.position;
        }
        if (handR != null)
        {
            handRPosition = handR.transform.position;
        }
        if (handL != null)
        {
            handLPosition = handL.transform.position;
        }

        logTimer += Time.deltaTime;
        if(logTimer >= logInterval)
        {
            logTimer = 0f;

            Debug.Log(
                $"{headPosition}, {handLPosition}, {handRPosition}");
        }
        
    }
}
