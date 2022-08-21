using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;

namespace Sample
{
    public class SampleUniTask : MonoBehaviour
    {
        private async void Start()
        {
            // Monobehaviourからしか呼べない
            StartCoroutine(RunForCoroutine(num =>
            {
                Debug.Log(num);
            }));
            // どこでも呼べる
            var num = await RunForUniTask();
            Debug.Log(num);
        }

        private async UniTask<int> RunForUniTask()
        {
            Debug.Log("Start unitask");
            await UniTask.Delay(3000);
            Debug.Log("3秒経過");
            Debug.Log("End unitask");
            return 3;
        }

        private IEnumerator RunForCoroutine(Action<int> callback)
        {
            Debug.Log("Start coroutine");
            yield return StartCoroutine(WaitSecond(3));
            
            Debug.Log("3秒経過");
            Debug.Log("End coroutine");
            callback.Invoke(3);
        }

        private IEnumerator WaitSecond(int second)
        {
            yield return new WaitForSeconds(second);
        }
    }
}