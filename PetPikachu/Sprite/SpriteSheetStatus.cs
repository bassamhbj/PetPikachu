using PetPikachu.Model;
using System.Collections.Generic;

namespace PetPikachu.Sprite
{
    public class SpriteSheetStatus : SpriteSheet<SpriteModelStatus>
    {
        public SpriteSheetStatus()
            : base(
                  sheetPath: @"Assets/status_sprite_sheet.png",
                  spriteWidth: 64,
                  spriteHeight: 64
                )
        { }

        public override SpriteModelStatus GetSprites()
        {
            return new SpriteModelStatus() {
                Sprites = new List<SpriteModelStatus.SpriteItem>() {
                    new SpriteModelStatus.SpriteItem() {
                        Image = CropSpriteSheet(0, 0),
                        Type = SpriteModelStatus.SpriteType.EMPTY_BUBBLE
                    },
                    new SpriteModelStatus.SpriteItem() {
                        Image = CropSpriteSheet(0, 1),
                        Type = SpriteModelStatus.SpriteType.FACE_HAPPY
                    },
                    new SpriteModelStatus.SpriteItem() {
                        Image = CropSpriteSheet(0, 2),
                        Type = SpriteModelStatus.SpriteType.EXCLAMATION
                    },
                    new SpriteModelStatus.SpriteItem() {
                        Image = CropSpriteSheet(1, 0),
                        Type = SpriteModelStatus.SpriteType.QUESTION
                    },
                    new SpriteModelStatus.SpriteItem() {
                        Image = CropSpriteSheet(1, 1),
                        Type = SpriteModelStatus.SpriteType.SKULL
                    },
                    new SpriteModelStatus.SpriteItem() {
                        Image = CropSpriteSheet(1, 2),
                        Type = SpriteModelStatus.SpriteType.BOLT
                    },
                    new SpriteModelStatus.SpriteItem() {
                        Image = CropSpriteSheet(2, 0),
                        Type = SpriteModelStatus.SpriteType.FISH
                    },
                    new SpriteModelStatus.SpriteItem() {
                        Image = CropSpriteSheet(2, 1),
                        Type = SpriteModelStatus.SpriteType.HEART
                    },
                    new SpriteModelStatus.SpriteItem() {
                        Image = CropSpriteSheet(2, 2),
                        Type = SpriteModelStatus.SpriteType.SLEEP
                    }
                }
            };
        }
    }
}
