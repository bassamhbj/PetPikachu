using System;
using System.Collections.Generic;
using System.Linq;

namespace PetPikachu.Model
{
    public class SpriteModelPikachu : SpriteModel
    {
        public List<SpriteItem> Sprites { get; set; }
        public List<AnimationSet> AnimationSets { get; set; }

        public enum AnimationType
        {
            FRONT_IDLE,
            LEFT_IDLE,
            RIGHT_IDLE,
            BACK_IDLE,

            FRONT_SHORT_WALK,
            FRONT_LONG_WALK,
            LEFT_SHORT_WALK,
            LEFT_LONG_WALK,
            RIGHT_SHORT_WALK,
            RIGHT_LONG_WALK,
            BACK_SHORT_WALK,
            BACK_LONG_WALK,

            LEFT_ROTATE,
            RIGHT_ROTATE
        }

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

        public override void InitAnimationSet()
        {
            if(Sprites == null || Sprites.Count == 0) {
                throw new ArgumentNullException("Sprites have not been initialized");
            }

            // FRONT_IDLE
            var frontIdle = new AnimationSet() {
                Type = AnimationType.FRONT_IDLE,
                Cycles = 16,
                Sprites = new List<SpriteItem>() {
                    Sprites.Where(x => x.Type == SpriteType.FRONT).FirstOrDefault()
                }
            };

            // LEFT_IDLE
            var leftIdle = new AnimationSet() {
                Type = AnimationType.LEFT_IDLE,
                Cycles = 16,
                Sprites = new List<SpriteItem>() {
                    Sprites.Where(x => x.Type == SpriteType.LEFT_SIDE).FirstOrDefault()
                }
            };

            // RIGHT_IDLE
            var rightIdle = new AnimationSet() {
                Type = AnimationType.RIGHT_IDLE,
                Cycles = 16,
                Sprites = new List<SpriteItem>() {
                    Sprites.Where(x => x.Type == SpriteType.RIGHT_SIDE).FirstOrDefault()
                }
            };

            // BACK_IDLE
            var backIdle = new AnimationSet() {
                Type = AnimationType.BACK_IDLE,
                Cycles = 16,
                Sprites = new List<SpriteItem>() {
                    Sprites.Where(x => x.Type == SpriteType.BACK).FirstOrDefault()
                }
            };

            // FRONT_SHORT_WALK
            var frontShortWalk = new AnimationSet() {
                Type = AnimationType.FRONT_SHORT_WALK,
                Cycles = 10,
                Sprites = new List<SpriteItem>() {
                    Sprites.Where(x => x.Type == SpriteType.FRONT).FirstOrDefault(),
                    Sprites.Where(x => x.Type == SpriteType.FRONT_WALK_LEFT).FirstOrDefault(),
                    Sprites.Where(x => x.Type == SpriteType.FRONT_WALK_RIGHT).FirstOrDefault()
                }
            };

            // FRON_LONG_WALK
            var frontLongWalk = new AnimationSet() {
                Type = AnimationType.FRONT_LONG_WALK,
                Cycles = 20,
                Sprites = new List<SpriteItem>() {
                    Sprites.Where(x => x.Type == SpriteType.FRONT).FirstOrDefault(),
                    Sprites.Where(x => x.Type == SpriteType.FRONT_WALK_LEFT).FirstOrDefault(),
                    Sprites.Where(x => x.Type == SpriteType.FRONT_WALK_RIGHT).FirstOrDefault()
                }
            };

            // LEFT_SHORT_WALK
            var leftShortWalk = new AnimationSet() {
                Type = AnimationType.LEFT_SHORT_WALK,
                Cycles = 10,
                Sprites = new List<SpriteItem>() {
                    Sprites.Where(x => x.Type == SpriteType.LEFT_SIDE).FirstOrDefault(),
                    Sprites.Where(x => x.Type == SpriteType.LEFT_SIDE_WALK).FirstOrDefault()
                }
            };

            // LEFT_LONG_WALK
            var leftLongWalk = new AnimationSet() {
                Type = AnimationType.LEFT_LONG_WALK,
                Cycles = 20,
                Sprites = new List<SpriteItem>() {
                    Sprites.Where(x => x.Type == SpriteType.LEFT_SIDE).FirstOrDefault(),
                    Sprites.Where(x => x.Type == SpriteType.LEFT_SIDE_WALK).FirstOrDefault()
                }
            };

            // RIGHT_SHORT_WALK
            var rightShortWalk = new AnimationSet() {
                Type = AnimationType.RIGHT_SHORT_WALK,
                Cycles = 10,
                Sprites = new List<SpriteItem>() {
                    Sprites.Where(x => x.Type == SpriteType.RIGHT_SIDE).FirstOrDefault(),
                    Sprites.Where(x => x.Type == SpriteType.RIGHT_SIDE_WALK).FirstOrDefault()
                }
            };

            // RIGHT_LONG_WALK
            var rightLongWalk = new AnimationSet() {
                Type = AnimationType.RIGHT_LONG_WALK,
                Cycles = 20,
                Sprites = new List<SpriteItem>() {
                    Sprites.Where(x => x.Type == SpriteType.RIGHT_SIDE).FirstOrDefault(),
                    Sprites.Where(x => x.Type == SpriteType.RIGHT_SIDE_WALK).FirstOrDefault()
                }
            };

            // BACK_SHORT_WALK
            var backShortWalk = new AnimationSet() {
                Type = AnimationType.BACK_SHORT_WALK,
                Cycles = 10,
                Sprites = new List<SpriteItem>() {
                    Sprites.Where(x => x.Type == SpriteType.BACK).FirstOrDefault(),
                    Sprites.Where(x => x.Type == SpriteType.BACK_WALK_RIGHT).FirstOrDefault(),
                    Sprites.Where(x => x.Type == SpriteType.BACK_WALK_LEFT).FirstOrDefault()
                }
            };

            // BACK_LONG_WALK
            var backLongWalk = new AnimationSet() {
                Type = AnimationType.BACK_LONG_WALK,
                Cycles = 20,
                Sprites = new List<SpriteItem>() {
                    Sprites.Where(x => x.Type == SpriteType.BACK).FirstOrDefault(),
                    Sprites.Where(x => x.Type == SpriteType.BACK_WALK_RIGHT).FirstOrDefault(),
                    Sprites.Where(x => x.Type == SpriteType.BACK_WALK_LEFT).FirstOrDefault()
                }
            };

            // LEFT_ROTATE
            var leftRotate = new AnimationSet() {
                Type = AnimationType.LEFT_ROTATE,
                Cycles = 1,
                Sprites = new List<SpriteItem>() {
                    Sprites.Where(x => x.Type == SpriteType.FRONT).FirstOrDefault(),
                    Sprites.Where(x => x.Type == SpriteType.LEFT_SIDE).FirstOrDefault(),
                    Sprites.Where(x => x.Type == SpriteType.BACK).FirstOrDefault(),
                    Sprites.Where(x => x.Type == SpriteType.RIGHT_SIDE).FirstOrDefault(),
                    Sprites.Where(x => x.Type == SpriteType.FRONT).FirstOrDefault()
                }
            };

            // RIGHT_ROTATE
            var rightRotate = new AnimationSet() {
                Type = AnimationType.RIGHT_ROTATE,
                Cycles = 1,
                Sprites = new List<SpriteItem>() {
                    Sprites.Where(x => x.Type == SpriteType.FRONT).FirstOrDefault(),
                    Sprites.Where(x => x.Type == SpriteType.RIGHT_SIDE).FirstOrDefault(),
                    Sprites.Where(x => x.Type == SpriteType.BACK).FirstOrDefault(),
                    Sprites.Where(x => x.Type == SpriteType.LEFT_SIDE).FirstOrDefault(),
                    Sprites.Where(x => x.Type == SpriteType.FRONT).FirstOrDefault()
                }
            };

            AnimationSets = new List<AnimationSet>() {
                frontIdle,
                leftIdle,
                rightIdle,
                backIdle,

                frontShortWalk,
                frontLongWalk,
                leftShortWalk,
                leftLongWalk,
                rightShortWalk,
                rightLongWalk,
                backShortWalk,
                backLongWalk,

                leftRotate,
                rightRotate
            };
        }

        public AnimationSet GetNextAnmation()
        {
            var index = new Random().Next(0, AnimationSets.Count - 1);

            return AnimationSets[index];
        }

        public class AnimationSet
        {
            public List<SpriteItem> Sprites { get; set; }
            public AnimationType Type { get; set; }
            public int Cycles { get; set; }
        }
    }
}
