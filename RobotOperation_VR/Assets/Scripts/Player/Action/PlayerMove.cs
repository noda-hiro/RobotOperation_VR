using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    private float speed = 300f;
    private Vector3 currentPos;
    private Gamepad currentPad;
    private Joystick currentStick;
    private Rigidbody rd;

    private void Start()
    {
        // rd = GetComponent<Rigidbody>();
        currentPad = Gamepad.current;
        currentStick = Joystick.current;
    }

    private void FixedUpdate()
    {
        Debug.Log(currentStick.stick.up.ReadValue()+"UP");
        Debug.Log(currentStick.stick.down.ReadValue()+"DOWN");
        Debug.Log(currentStick.stick.right.ReadValue()+"RIGHT");
        Debug.Log(currentStick.stick.left.ReadValue()+"LEFT");
    }

    /// <summary>
    /// 引数の値を自身の座標に加える
    /// </summary>
    /// <param name="gamePadValue">GamePadの入力値</param>
    private void UpdateCurrentPos(Vector3 gamePadValue)
    {
        Vector3 pos;
        pos.x = currentPos.x + gamePadValue.x;
        pos.y = currentPos.y;
        pos.z = currentPos.z + gamePadValue.y;
        rd.velocity = pos * speed * Time.deltaTime;
    }

}
