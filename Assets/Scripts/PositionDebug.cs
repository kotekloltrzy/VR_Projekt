using UnityEngine;
using TMPro;

public class PositionDebug : MonoBehaviour
{
    [SerializeField] private TextMeshPro pozycja;
    

    private void Start()
    {
        if (PositionDetector.Instance != null)
        {
            PositionDetector.Instance.OnPositionChanged += UpdateUI;
        }
    }

    private void OnDisable()
    {
        if(PositionDetector.Instance != null)
        {
            PositionDetector.Instance.OnPositionChanged -= UpdateUI;
        }
    }

    private void UpdateUI()
    {
        PositionDetector detector = PositionDetector.Instance;

        pozycja.text = detector.GetHeadData().ToString() + "\n" 
            + detector.GetHandLData().ToString() + "\n" + detector.GetHandRData().ToString();
    }
}
