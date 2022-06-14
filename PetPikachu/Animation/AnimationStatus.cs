using PetPikachu.Model;

namespace PetPikachu.Animation
{
    public class AnimationStatus : AnimationManager
    {
        private const int FPS = 1;
        private readonly SpriteModelStatus _status;
        private int _currentAnimationIndex = 0;

        public AnimationStatus(SpriteModelStatus status, IAnimationListerner listerner) : base(listerner, FPS)
        {
            _status = status;
        }

        protected override void DoAnimation()
        {
            var sprite = _status.Sprites[_currentAnimationIndex];

            if(_currentAnimationIndex < _status.Sprites.Count - 1) {
                _currentAnimationIndex += 1;
            } else {
                _currentAnimationIndex = 0;
            }

            this._animationListerner.AnimateStatus(sprite);
        }
    }
}
