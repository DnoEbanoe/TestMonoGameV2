﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGame.Db.Entity
{
    public class Animation
    {
        [Key]
        public Guid Id { get; set; }
        public List<AnimationFrame> Frames { get; set; }
        public string Name { get; set; }
    }
}
