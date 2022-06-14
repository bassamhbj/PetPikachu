using PetPikachu.Model;
using System;

namespace PetPikachu.Animation
{
    public interface IAnimationListerner
    {
        void AnimatePikachu(SpriteModel.SpriteItem sprite);
        void AnimateStatus(SpriteModel.SpriteItem sprite);
    }
}
