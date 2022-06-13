using PetPikachu.Model;
using System.Drawing;

namespace PetPikachu.Sprite
{
    public abstract class SpriteSheet<T> where T : SpriteModel
    {
        private readonly int _spriteWidth;
        private readonly int _spriteHeight;

        private readonly Image _sheet;

        public SpriteSheet(string sheetPath, int spriteWidth, int spriteHeight)
        {
            _sheet = Image.FromFile(sheetPath);
            _spriteWidth = spriteWidth;
            _spriteHeight = spriteHeight;
        }

        public abstract T GetSprites(); 

        protected Bitmap CropSpriteSheet(int row, int column) 
        {
            var spritePosition = new Point(
                _spriteWidth * column, // column -> x
                _spriteHeight * row    // row -> y
            );

            var sprite = new Bitmap(_spriteWidth, _spriteHeight);

            using (var g = Graphics.FromImage(sprite)) {
                var section = new RectangleF(spritePosition, new Size(sprite.Width, sprite.Height));
                g.DrawImage(_sheet, 0, 0, section, GraphicsUnit.Pixel);
            }

            return sprite;
        }
    }
}
