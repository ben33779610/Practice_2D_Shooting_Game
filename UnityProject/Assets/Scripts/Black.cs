using UnityEngine;
using UnityEngine.UI;

public class Black : MonoBehaviour
{
	#region 練習區域 - 在此區域內練習

	[Header("血量文字")]
	public Text Hpreg;
	[Header("血量")]
	public int Hp ;

	public AudioSource aud;
	public AudioClip audc;
	/// <summary>
	/// 受傷 並且更新 血量 
	/// 判斷血量是否死亡
	/// </summary>
	public void Hurt()
	{
		Hp--;
		aud.PlayOneShot(audc);
		Hpreg.text = Hp.ToString();
		if (Hp == 0)	 Destroy(this.gameObject);		//死亡時消滅
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "子彈")  Hurt();	
	}

	private void Start()
	{
		Hp = 15;									//血量初始化
		Hpreg.text = Hp.ToString();
	}
	#endregion
}
