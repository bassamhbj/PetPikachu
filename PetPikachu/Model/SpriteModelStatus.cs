using System.Collections.Generic;
using System.Linq;

namespace PetPikachu.Model
{
    public class SpriteModelStatus : SpriteModel
    {
        public List<SpriteItem> Sprites { get; set; }

        //public enum SpriteType
        //{
        //    FACE_HAPPY,
        //    EXCLAMATION,
        //    QUESTION,
        //    SKULL,
        //    BOLT,
        //    FISH,
        //    HEART,
        //    SLEEP
        //}

        public SpriteItem GetEmptyBubble() => GetSprite(SpriteType.EMPTY_BUBBLE);

        public SpriteItem GetFaceHappy() => GetSprite(SpriteType.FACE_HAPPY);

        public SpriteItem GetExclamation() => GetSprite(SpriteType.EXCLAMATION);

        public SpriteItem GetQuestion() => GetSprite(SpriteType.QUESTION);

        public SpriteItem GetSkull () => GetSprite(SpriteType.SKULL);

        public SpriteItem GetBolt() => GetSprite(SpriteType.BOLT);

        public SpriteItem GetFish() => GetSprite(SpriteType.FISH);

        public SpriteItem GetHeart() => GetSprite(SpriteType.HEART);

        public SpriteItem GetSleep() => GetSprite(SpriteType.SLEEP);


        private SpriteItem GetSprite(SpriteType type) =>
            Sprites.Where(x => x.Type == type).FirstOrDefault();
    }
}
