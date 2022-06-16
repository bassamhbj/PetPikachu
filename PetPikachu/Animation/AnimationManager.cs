using PetPikachu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PetPikachu.Animation
{
    public abstract class AnimationManager
    {
        protected readonly IAnimationListerner _animationListerner;
        protected readonly SpriteModel _pikachuSpriteModel;

        private readonly int FPS = 8;

        public enum AninamtionType
        {
            IDLE,
            MOVE_FRONT,
            MOVE_LEFT,
            MOVE_RIGHT,
            MOVE_BACK
        }

        public AnimationManager(IAnimationListerner animationListerner, int fps)
        {
            _animationListerner = animationListerner;
            FPS = fps;
        }

        public async Task Animate(CancellationToken token)
        {
            var animationInterval = 1000 / FPS;

            while (true) {
                if (token.IsCancellationRequested)
                    break;

                DoAnimation();

                await Task.Delay(animationInterval);
            }
        }

        protected abstract void DoAnimation();

    }
}
