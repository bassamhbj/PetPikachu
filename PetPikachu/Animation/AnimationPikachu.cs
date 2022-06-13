using System.Collections.Generic;
using System.Linq;
using PetPikachu.Model;

namespace PetPikachu.Animation
{
    public class AnimationPikachu : AnimationManager
    {
        private const int FPS = 8;
        private readonly SpriteModelPikachu _pikachu;
        private List<SpriteModelPikachu.SpriteItem> _currentAnimationSet;
        private SpriteModel.SpriteType _lastAnimation;

        public AnimationPikachu(SpriteModelPikachu pikachu, IAnimationListerner listerner) : base(listerner, FPS)
        {
            _pikachu = pikachu;
            _currentAnimationSet = _pikachu.GetLeftSideWalkSprites();
            _lastAnimation = _currentAnimationSet[0].Type;
        }

        protected override void DoAnimation()
        {
            var sprite = _currentAnimationSet.Where(x => x.Type != _lastAnimation).First();
            _lastAnimation = sprite.Type;

            this._animationListerner.AnimatePikachu(sprite);
        }
    }
}
