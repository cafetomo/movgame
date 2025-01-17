﻿using System;
using System.Collections.Generic;
using System.Text;

namespace movgame.Models.Characters
{
    public class BreadPlayer : Player
    {
        /// <summary>
        /// 
        /// </summary>
        private Breadcrumbs breadcrumbs;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="gameEngine"></param>
        /// <param name="breadcrumbs"></param>
        public BreadPlayer(GameEngine gameEngine, Breadcrumbs breadcrumbs) : base(gameEngine)
        {
            this.breadcrumbs = breadcrumbs;
        }

        public override bool Move()
        {
            var result = base.Move();
            if (Reached) breadcrumbs.Drop(Row, Col);
            return result;
        }

    }
}
