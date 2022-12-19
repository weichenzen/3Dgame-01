using UnityEngine;

namespace KID
{
	/// <summary>
	/// �ǲ� Unity �������
	/// Unity �}�o�o
	/// </summary>
	public class LearnDataType : MonoBehaviour
	{
		// �y�k�G
		// �׹��� ������� ���W�� ���w �w�]��;

		#region �C��P�y��
		// �C��P�y�� Color & Vector
		[Header("�C��")]
		public Color color1;

		public Color colorRed = Color.red;
		public Color colorYellow = Color.yellow;
		public Color colorGray = Color.gray;

		// Color(���A��A�šA�z����) - 0 ~ 1
		public Color colorCustom1 = new Color(0.5f, 0.5f, 0);
		public Color colorCustom2 = new Color(0, 0.5f, 0.5f, 0.5f);

		[Header("�y��")]
		public Vector2 v2;
		public Vector3 v3;
		public Vector4 v4;

		public Vector2 v20ne = Vector2.one;
		public Vector2 v2Custom = new Vector2(999, 1);
	#endregion

	// ���
	public Sprite image;            // �Ϥ�
	public AudioClip sound;         // ���֡B����
	public Material mat;            // ����y
	public GameObject prefab;       // �w�m��
	public GameObject sceneObject;  // �����W������
	}
}