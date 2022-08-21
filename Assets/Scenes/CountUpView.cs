using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace Sample
{
    public class CountUpView : MonoBehaviour
    {
        [SerializeField] private Text _text;
        [SerializeField] private Button _button;

        // クリックイベントを外部にIObservableとして公開する
        public Button Button => _button;
        private void Start()
        {
            var presenter = new CountUpPresenter(this);
            presenter.Initialize();
        }

        public void UpdateCount(int count)
        {
            _text.text = count.ToString();
        }
    }
}