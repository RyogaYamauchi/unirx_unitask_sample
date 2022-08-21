using UniRx;
using UnityEngine;

namespace Sample
{
    public class Sample : MonoBehaviour
    {
        private void Start()
        {
            var subject = new Subject<int>(); // observer
            
            // 登録する　presenter
            subject.Subscribe(num => Debug.Log(num.ToString())).AddTo(this);
            
            // 通知する model
            subject.OnNext(1);
            subject.OnNext(2);
            subject.OnNext(3);
            subject.OnNext(4);
            subject.OnNext(5);
            subject.OnNext(6);
        }
    }
    
    
}
