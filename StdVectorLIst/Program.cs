using System;
using System.Collections;
using System.Collections.Generic;

namespace StdVectorLIst
{
    class Program
    {
        static void Main(string[] args)
        {
            // テクスチャ
            /*			struct TexRGBA
						{
							unsigned char R, G, B, A;
						};
						std::vector<TexRGBA> texturedata(256 * 256);
						for (auto& rgba : texturedata) {
							rgba.R = rand() % 256;
							rgba.G = rand() % 256;
							rgba.B = rand() % 256;
							rgba.A = 255;/アルファは1.0
						}
			*/


        public struct TexRGBA
        {
            public byte R, G, B, A;
        };
        Random random = new Random();
        List<TexRGBA> texturedata = new List<TexRGBA>();
        for (; ;) {
                    rgba.R = Random. % 256;
                    rgba.G = rand() % 256;
                    rgba.B = rand() % 256;
                    rgba.A = 255;
        }
    }
}


