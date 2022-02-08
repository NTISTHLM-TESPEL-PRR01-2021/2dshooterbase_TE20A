using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  void Start()
  {

  }

  void Update()
  {
    float xMovement = Input.GetAxisRaw("Horizontal"); // -1 till +1

    Vector2 movement = new Vector2(xMovement, 0) * 0.02f;

    transform.Translate(movement);

  }
}
