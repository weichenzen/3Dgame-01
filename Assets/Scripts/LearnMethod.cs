using UnityEngine;

namespace MyNamespace
{
    /// <summary>
    /// 學習方法、功能、函式
    /// Methon、Function
    /// </summary>
    public class LearnMethod : MonoBehaviour
    {
		// 方法必須在事件內呼叫才會執行
		private void Awake()
		{
			// 方法名稱();
			Test();
			Test();
		}

		// 方法
		// 語法：
		// 修飾詞 傳回資料類型 方法名稱 ()
		// {
		// }

		// void 無
		private void Test()
        {
            print("我是測試方法");
        }
		private void ShootFire()
		{
			print("球的屬性：火");
			print("播放音效：咻咻咻");
		}
		private void ShootThund()
		{
			print("球的屬性：電");
			print("播放音效：滋");
		}
    }
}
