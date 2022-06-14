using System.Collections.Generic;
using System.Linq;

namespace PetPikachu.Model
{
    public class SpriteModelPikachu : SpriteModel
    {
        public List<SpriteItem> Sprites { get; set; }

        //public enum SpriteType
        //{
        //    FRONT,
        //    FRONT_WALK_LEFT,
        //    FRONT_WALK_RIGHT,
        //    BACK,
        //    BACK_WALK_LEFT,
        //    BACK_WALK_RIGHT,
        //    LEFT_SIDE,
        //    LEFT_SIDE_WALK,
        //    RIGHT_SIDE,
        //    RIGHT_SIDE_WALK
        //}

        public List<SpriteItem> GetFrontSprites() =>
            Sprites.Where(x => x.Type == SpriteType.FRONT).ToList();

        public List<SpriteItem> GetFrontWalkSprites() =>
            Sprites.Where(x => x.Type == SpriteType.FRONT_WALK_LEFT || x.Type == SpriteType.FRONT_WALK_RIGHT).ToList();

        public List<SpriteItem> GetBackSprites() =>
            Sprites.Where(x => x.Type == SpriteType.BACK).ToList();

        public List<SpriteItem> GetBackWalkSprites() =>
            Sprites.Where(x => x.Type == SpriteType.BACK_WALK_LEFT || x.Type == SpriteType.BACK_WALK_RIGHT).ToList();

        public List<SpriteItem> GetLeftSideSprites() =>
            Sprites.Where(x => x.Type == SpriteType.LEFT_SIDE).ToList();

        public List<SpriteItem> GetLeftSideWalkSprites() =>
            Sprites.Where(x => x.Type == SpriteType.LEFT_SIDE_WALK || x.Type == SpriteType.LEFT_SIDE).ToList();

        public List<SpriteItem> GetRightSideSprites() =>
            Sprites.Where(x => x.Type == SpriteType.RIGHT_SIDE).ToList();

        public List<SpriteItem> GetRightSideWalkSprites() =>
            Sprites.Where(x => x.Type == SpriteType.RIGHT_SIDE_WALK || x.Type == SpriteType.RIGHT_SIDE).ToList();

        public class AnimationSet
        {
            public List<SpriteItem> Sprites { get; set; }
            //public 
        }
    }
}
