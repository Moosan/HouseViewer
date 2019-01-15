using UnityEngine;

public class PositionSave : MonoBehaviour {

    [SerializeField] private Transform _cameraOffseTransform;
    [SerializeField] private Transform _cameraTransform;
    /*
    private float _defaultOffsetRotation;
    private Vector3 _defaultOffsetVector3;

    private void Start()
    {
        _defaultOffsetRotation = _cameraOffseTransform.localEulerAngles.y;
        _defaultOffsetVector3 = _cameraOffseTransform.position;
    }
    */
    void OnApplicationPause(bool pauseStatus)
    {
        if (pauseStatus)
        {
            //カメラの位置保存
            _cameraOffseTransform.position = _cameraTransform.position;
            float roteY = _cameraTransform.localEulerAngles.y;
            _cameraOffseTransform.localEulerAngles += new Vector3(0f, roteY, 0f);
        }
    }
}
