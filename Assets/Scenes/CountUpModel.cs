using UniRx;

namespace Sample
{
    public class CountUpModel
    {
        private ReactiveProperty<int> count = new ReactiveProperty<int>();

        public IReadOnlyReactiveProperty<int> Count => count;

        public void IncrementCount()
        {
            count.Value++;
        }

        public void Initialize()
        {
            count.Value = 0;
        }
    }
}