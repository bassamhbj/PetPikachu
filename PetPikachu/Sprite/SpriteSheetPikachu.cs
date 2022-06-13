using PetPikachu.Model;
using System.Collections.Generic;

namespace PetPikachu.Sprite
{
    public class SpriteSheetPikachu : SpriteSheet<SpriteModelPikachu>
    {
        public SpriteSheetPikachu()
            : base(
                  sheetPath: @"Assets/pikachu_sprite_sheet.png",
                  spriteWidth: 64,
                  spriteHeight: 64
                )
        { }

        public override SpriteModelPikachu GetSprites()
        {
            return new SpriteModelPikachu() {
                Sprites = new List<SpriteModelPikachu.SpriteItem>() {
                    new SpriteModelPikachu.SpriteItem() {
                        Image = CropSpriteSheet(0, 0),
                        Type = SpriteModelPikachu.SpriteType.FRONT
                    },
                    new SpriteModelPikachu.SpriteItem() {
                        Image = CropSpriteSheet(0, 1),
                        Type = SpriteModelPikachu.SpriteType.FRONT_WALK_LEFT
                    },
                    new SpriteModelPikachu.SpriteItem() {
                        Image = CropSpriteSheet(1, 0),
                        Type = SpriteModelPikachu.SpriteType.FRONT_WALK_RIGHT
                    },
                    new SpriteModelPikachu.SpriteItem() {
                        Image = CropSpriteSheet(1, 1),
                        Type = SpriteModelPikachu.SpriteType.BACK
                    },
                    new SpriteModelPikachu.SpriteItem() {
                        Image = CropSpriteSheet(2, 0),
                        Type = SpriteModelPikachu.SpriteType.BACK_WALK_LEFT
                    },
                    new SpriteModelPikachu.SpriteItem() {
                        Image = CropSpriteSheet(2, 1),
                        Type = SpriteModelPikachu.SpriteType.BACK_WALK_RIGHT
                    },
                    new SpriteModelPikachu.SpriteItem() {
                        Image = CropSpriteSheet(3, 0),
                        Type = SpriteModelPikachu.SpriteType.LEFT_SIDE
                    },
                    new SpriteModelPikachu.SpriteItem() {
                        Image = CropSpriteSheet(3, 1),
                        Type = SpriteModelPikachu.SpriteType.LEFT_SIDE_WALK
                    },
                    new SpriteModelPikachu.SpriteItem() {
                        Image = CropSpriteSheet(4, 0),
                        Type = SpriteModelPikachu.SpriteType.RIGHT_SIDE
                    },
                    new SpriteModelPikachu.SpriteItem() {
                        Image = CropSpriteSheet(4, 1),
                        Type = SpriteModelPikachu.SpriteType.RIGHT_SIDE_WALK
                    }
                }
            };
        }
    }
}
