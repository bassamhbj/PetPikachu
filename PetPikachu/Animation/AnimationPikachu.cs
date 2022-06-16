using System.Collections.Generic;
using System.Linq;
using PetPikachu.Model;

namespace PetPikachu.Animation
{
    public class AnimationPikachu : AnimationManager
    {
        private const int FPS = 8;
        private readonly SpriteModelPikachu _pikachu;
        
        private SpriteModelPikachu.AnimationSet _currentAnimation;
        private AninamtionType _currentAnimationType;
        private int _totalCycles = 0;
        private int _animationIndex = 0;

        public AnimationPikachu(SpriteModelPikachu pikachu, IAnimationListerner listerner) : base(listerner, FPS)
        {
            _pikachu = pikachu;
            _currentAnimation = _pikachu.AnimationSets.Where(x => x.Type == SpriteModelPikachu.AnimationType.FRONT_IDLE).FirstOrDefault();
            _currentAnimationType = GetAninamtionType(_currentAnimation.Type);
        }

        protected override void DoAnimation()
        {
            this._animationListerner.AnimatePikachuDebug(_animationIndex + 1, _currentAnimation.Sprites.Count);

            var sprite = _currentAnimation.Sprites[_animationIndex];
            _animationIndex += 1;
            _totalCycles += 1;

            this._animationListerner.AnimatePikachu(sprite.Image, _currentAnimationType);

            if(_animationIndex >= _currentAnimation.Sprites.Count) {
                _animationIndex = 0;
            }

            if(_totalCycles > _currentAnimation.Cycles) {
                _totalCycles = 0;
                _animationIndex = 0;
                _currentAnimation = _pikachu.GetNextAnmation();
                _currentAnimationType = GetAninamtionType(_currentAnimation.Type);
            }
        }

        private AninamtionType GetAninamtionType(SpriteModelPikachu.AnimationType pikachuAnimationType)
        {
            switch (pikachuAnimationType) {
                case SpriteModelPikachu.AnimationType.FRONT_IDLE:
                case SpriteModelPikachu.AnimationType.LEFT_IDLE:
                case SpriteModelPikachu.AnimationType.RIGHT_IDLE:
                case SpriteModelPikachu.AnimationType.BACK_IDLE: return AninamtionType.IDLE;

                case SpriteModelPikachu.AnimationType.FRONT_SHORT_WALK:
                case SpriteModelPikachu.AnimationType.FRONT_LONG_WALK: return AninamtionType.MOVE_FRONT;
                case SpriteModelPikachu.AnimationType.LEFT_SHORT_WALK:
                case SpriteModelPikachu.AnimationType.LEFT_LONG_WALK: return AninamtionType.MOVE_LEFT;
                case SpriteModelPikachu.AnimationType.RIGHT_SHORT_WALK:
                case SpriteModelPikachu.AnimationType.RIGHT_LONG_WALK: return AninamtionType.MOVE_RIGHT;
                case SpriteModelPikachu.AnimationType.BACK_SHORT_WALK:
                case SpriteModelPikachu.AnimationType.BACK_LONG_WALK: return AninamtionType.MOVE_BACK;

                case SpriteModelPikachu.AnimationType.LEFT_ROTATE:
                case SpriteModelPikachu.AnimationType.RIGHT_ROTATE: return AninamtionType.IDLE;
                default: return AninamtionType.IDLE;
            }
        }
    }
}
