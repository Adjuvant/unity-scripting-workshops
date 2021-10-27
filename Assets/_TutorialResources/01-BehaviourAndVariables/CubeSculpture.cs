using UnityEngine;

public class CubeSculpture : MonoBehaviour
{
    private float speed = 2f;
    private readonly GameObject[] _objArr = new GameObject[5];

    private Vector3 _defPos = new Vector3(0, 0, 0);

    // Current rotation
    private float _cRot;

    // Use this for initialization
    private void Start()
    {
        _defPos = transform.localPosition;
        for (var i = 0; i < _objArr.Length; i++)
        {
            _objArr[i] = GameObject.CreatePrimitive(PrimitiveType.Cube);
            _objArr[i].transform.localScale = new Vector3(5, 5, 5);
            _objArr[i].transform.localPosition = transform.localPosition;
            _objArr[i].transform.Rotate(i, i, 0);
            _objArr[i].transform.parent = transform;
        }
    }

    private void Update()
    {
        _cRot += 0.05f;
        for (var i = 0; i < _objArr.Length; i++)
        {
            var x = _defPos.x + Mathf.Sin(_cRot) * speed * Time.deltaTime;
            var y = _defPos.y + Mathf.Cos(_cRot) * speed * Time.deltaTime;
            _objArr[i].transform.localPosition = new Vector3(x, y, _defPos.z);
            _objArr[i].transform.Rotate((i + 1) * Time.deltaTime, (i + 1) * speed * Time.deltaTime, (i + 1) * speed * 1.5f * Time.deltaTime);
        }
    }
}
