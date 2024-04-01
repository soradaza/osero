using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveButton : MonoBehaviour
{
    public enum MoveDirection{
        X,
        Y,
        Z
    }
    public float Move = 1;
    public GameObject TargetObfect;
    public MoveDirection Direction;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnClick);
    }

    // Update is called once per frame
    void OnClick()
    {
        Vector3 Position = TargetObfect.transform.position;

        switch(Direction)
        {
            case MoveDirection.X:
            Position.x += Move;
            break;
            case MoveDirection.Y:
            Position.y += Move;
            break;
            case MoveDirection.Z:
            Position.z += Move;
            break;
        }

        TargetObfect.transform.position = Position;
    }
}
