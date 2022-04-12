using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	//[SerializeField] float speed;           
	//private Rigidbody2D rb = null;

	private void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
	}


    /// <summary>
    /// 矢印キーで左右に移動するメソッド
    /// </summary>
    public void MoveArrowKey()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
			this.transform.Translate(-0.1f, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
		{
			this.transform.Translate(0.1f, 0.0f, 0.0f);

		}

		/*float horizontalKey = Input.GetAxis("Horizontal");

		//右入力
		if (horizontalKey > 0)
		{
			rb.velocity = new Vector2(speed, rb.velocity.y);
		}
		//左入力
		else if (horizontalKey < 0)
		{
			rb.velocity = new Vector2(-speed, rb.velocity.y);
		}
		//無入力
		else
		{
			rb.velocity = Vector2.zero;
		}*/
	}

    
}
