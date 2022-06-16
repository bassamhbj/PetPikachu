using PetPikachu.Model;
using System;
using System.Drawing;

namespace PetPikachu.Animation
{
    public interface IAnimationListerner
    {
        void AnimatePikachu(Bitmap sprite, AnimationManager.AninamtionType aninamtionType);
        void AnimateStatus(SpriteModel.SpriteItem sprite);

        void AnimatePikachuDebug(int animationIndex, int animationCount);
    }
}
