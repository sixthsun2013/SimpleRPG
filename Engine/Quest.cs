﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Quest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string NamePlural { get; set; }
        public string Description { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        public Item RewardItem { get; set; }

        public List<QuestCompletionItem> QuestCompletionItems { get; set; } = new List<QuestCompletionItem>();

        public Quest(int iD, string name, string namePlural, int rewardExperiencePoints, int rewardGold)
        {
            ID = iD;
            Name = name;
            NamePlural = namePlural;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;
        }
    }
}
