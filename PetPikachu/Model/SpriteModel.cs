using System;
using System.Drawing;

namespace PetPikachu.Model
{
    public abstract class SpriteModel
    {
        // This need to be optimized.
        // I want to separate the sprite type within each model class
        public enum SpriteType
        {
            EMPTY_BUBBLE,
            FACE_HAPPY,
            EXCLAMATION,
            QUESTION,
            SKULL,
            BOLT,
            FISH,
            HEART,
            SLEEP,
            FRONT,
            FRONT_WALK_LEFT,
            FRONT_WALK_RIGHT,
            BACK,
            BACK_WALK_LEFT,
            BACK_WALK_RIGHT,
            LEFT_SIDE,
            LEFT_SIDE_WALK,
            RIGHT_SIDE,
            RIGHT_SIDE_WALK
        }

        public abstract void InitAnimationSet();

        public class SpriteItem
        {
            public Bitmap Image { get; set; }
            public SpriteType Type { get; set; }
        }
    }
}
