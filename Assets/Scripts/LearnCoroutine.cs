using UnityEngine;
using System.Collections;

namespace KID
{
	/// <summary>
	/// �ǲߨ�P�{��
	/// </summary>
	public class LearnCoroutine : MonoBehaviour
	{
		// �ϥΨ�P�{��
		// �@�ΡG���{�����ɶ�����
		// ����G
		// 1. �ޥΨt�ζ��X�R�W�Ŷ�
		// 2. �w�q�@�ӶǦ^ IEnumerator ����k
		// 3. �b��k���ϥ� yield return �ɶ��A�ɶ�����
		// 4. �ϥ� start COroutine �Ұ�

		private void Awake()
		{
			StartCoroutine(Test()); // �}�l��P�{��(��P�{�ǦW��())
		}

		private IEnumerator Test()
		{
			print("<color=#ff6666>�Ĥ@��</color>");

			yield return new WaitForSeconds(1);

			print("<color=#ff6666>�ĤG��</color>");

			yield return new WaitForSeconds(2);

			print("<color=#ff6666>�ĤT��</color>");
		}
	}
}

