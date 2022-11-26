using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
     private float speed = 300f;
     private Vector3 currentPos;
     private Gamepad currentPad;
     private Rigidbody rd;

     // Start is called before the first frame update
     private void Start()
     {
          rd = GetComponent<Rigidbody>();
          currentPad = Gamepad.current;
     }

     // Update is called once per frame
     private void FixedUpdate()
     {
          UpdateCurrentPos(GetGameStickValue());
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

     /// <summary>
     /// GamePadの入力値を取得する
     /// </summary>
     /// <returns></returns>
     private Vector3 GetGameStickValue()
     {
          Vector2 stickValue = currentPad.leftStick.ReadValue();
          return stickValue;
     }

}
