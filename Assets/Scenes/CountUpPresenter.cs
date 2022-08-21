using UniRx;

namespace Sample
{
    public class CountUpPresenter
    {
        private CountUpView _view;
        private CountUpModel _model;
        public CountUpPresenter(CountUpView view)
        {
            _view = view;
            _model = new CountUpModel();
        }

        public void Initialize()
        {
            Bind();
        }

        private void Bind()
        {
            // クリックしたときに処理を登録する
            _view.Button.OnClickAsObservable().Subscribe(_ => OnClick()).AddTo(_view);
            _model.Count.Subscribe(num => _view.UpdateCount(num)).AddTo(_view);
        }

        private void OnClick()
        {
            _model.IncrementCount();
        }
    }
}