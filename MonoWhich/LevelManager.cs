using Microsoft.Xna.Framework.Graphics;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace GameGameHaa2
{
    class LevelManager
    {
        List<int> texTypes = new List<int>();
        List<Vector2> floorPos = new List<Vector2>();

        public LevelManager()
        {
            Debug.WriteLine("Got to LevelManager");
          
            for (int i = 0; i < 10; i++)
            {
                texTypes.Add(0);
                floorPos.Add(new Vector2(i * 64, 256));
            }
        }

        //public void Draw(SpriteBatch spriteBatch)
        //{
        //    for (int i = 0; i < 5; i++)
        //    {
        //        Debug.WriteLine("Got to LevelDrawer");
        //        spriteBatch.Begin();
        //        spriteBatch.Draw(floorTex, floorPos[i], Color.White);
        //        spriteBatch.Begin();
        //    }
        //}

        public List<Vector2> GetPotitions()
        {
            return floorPos;
        }

        public List<int> GetTextureTypes()
        {
            return texTypes;
        }
    }
}
