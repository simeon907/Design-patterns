﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Flyweight
{
    public class Archer : Character
    {
        public Archer()
        {
            name = "Archer";
            image = new Image { Name = "archer_image.jpg", Base64 = "data:image/jpeg;base64,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" };
            hp = 50;
            speed = 60;
            damage = 15;
        }
    }
}
