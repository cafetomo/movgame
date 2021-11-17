using movgame.Models.Maps;
using System;
using System.Collections.Generic;
using System.Text;

namespace movgame.Repository.InMemory
{
    public class InMemoryLandMarkRepository : ILandMarkRepository
    {
        public IDictionary<int, LandMark> Get()
        {
            var result = new Dictionary<int, LandMark>();
            result.Add(0, new LandMark
            {
                // データが固定になってしまうので本来は使用しない
                // 以下はJavaScriptの見本だが考え方は一緒
                // https://lets-csharp.com/pacman-js-complete/
                MarkRows = new string[] {
                    "＃＃＃＃＃＃＃＃＃＃＃＃",
                    "＃＠＿＿＿＿＃＃＿＿＠＃",
                    "＃＿＃＿＃＿＿＿＿＃＿＃",
                    "＃＿＃＿＃＃＿＃＃＃＿＃",
                    "＃＿＿＿＿＃＿＃＿＿＿＃",
                    "＃＃＿＿＿＿＿＃＿＃＃＃",
                    "＃＿＿＿＃＿＿＿＿＿＿＃",
                    "＃＿＃＿＃＃＃＿＃＃＿＃",
                    "＃＿＃＿＿＿＿＿＿＃＿＃",
                    "＃＿＃＃＿＃＿＃＿＃＿＃",
                    "＃＠＿＿＿＃＿＿＿＿○＃",
                    "＃＃＃＃＃＃＃＃＃＃＃＃",
                }
            });
            return result;
        }
    }
}
