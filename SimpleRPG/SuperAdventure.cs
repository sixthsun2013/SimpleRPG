using Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleRPG
{
    public partial class SuperAdventure : Form
    {
        private Player _player = new Player(20, 10, 0, 10, 1);
        private Monster _currentMonster;

        public SuperAdventure()
        {
            InitializeComponent();

            _player.Inventory.Add(new InventoryItem(World.ItemByID(World.ITEM_ID_RUSTY_SWORD), 1));
            MoveTo(World.LocationByID(World.LOCATION_ID_HOME));

            hitPointsTextBox.Text = _player.CurrentHitPoints.ToString();
            goldTextBox.Text = _player.Gold.ToString();
            experienceTextBox.Text = _player.ExperiencePoints.ToString();
            levelTextBox.Text = _player.Level.ToString();

        }

        private void MoveTo(Location newLocation)
        {
            //Does the location have any required items
            if (newLocation.ItemRequiredToEnter != null)
            {
                bool playerHasRequiredItem = false;

                // See if the player has the required item in their inventory
                foreach (var item in _player.Inventory)
                {
                    if (item.Details.ID == newLocation.ItemRequiredToEnter.ID)
                    {
                        // We found the required item
                        playerHasRequiredItem = true;
                        break; // Exit out of the foreach loop
                    }
                }

                if (!playerHasRequiredItem)
                {
                    // We didn't find the required item in their inventory, so display a message and stop trying to move
                    messagesRichTextBox.Text = $"You must have a {newLocation.ItemRequiredToEnter.Name} to enter this location." + Environment.NewLine;
                    return;
                }
            }

            // Update the player's current location
            _player.CurrentLocation = newLocation;

            // Show/hide available movement buttons
            //northButton.Visible = (newLocation.LocationToNorth != null);
            //eastButton.Visible = (newLocation.LocationToNorth != null);
            //southButton.Visible = (newLocation.LocationToNorth != null);
            //westButton.Visible = (newLocation.LocationToNorth != null);

            // Display current location name and description
            locationRichTextBox.Text = newLocation.Name + Environment.NewLine;
            locationRichTextBox.Text += newLocation.Description + Environment.NewLine;

            // Completely heal the player
            _player.CurrentHitPoints = _player.MaximumHitPoints;

            // Update Hit Points in UI
            hitPointsTextBox.Text = _player.CurrentHitPoints.ToString();

            // Does the location have a quest?
            if (newLocation.QuestAvailableHere != null)
            {
                // See if the player already has the quest, and if they've completed it
                bool playerAlreadyHasQuest = false;
                bool playerAlreadyCompletedQuest = false;

                foreach (PlayerQuest playerQuest in _player.Quests)
                {
                    if (playerQuest.Details.ID == newLocation.QuestAvailableHere.ID)
                    {
                        playerAlreadyHasQuest = true;

                        if (playerQuest.IsCompleted)
                        {
                            playerAlreadyCompletedQuest = true;
                        }
                    }
                }

                // See if the player already has the quest
                if (playerAlreadyHasQuest)
                {
                    // If the player has not completed the quest yet
                    if (!playerAlreadyCompletedQuest)
                    {
                        // See if the player has all the items needed to complete the quest
                        bool playerHasAllItemsToCompleteQuest = true;

                        foreach (QuestCompletionItem qci in newLocation.QuestAvailableHere.QuestCompletionItems)
                        {
                            bool foundItemInPlayersInventory = false;

                            // Check each item in the player's inventory, to see if they have it, and enough of it
                            foreach (InventoryItem ii in _player.Inventory)
                            {
                                // The player has this item in their inventory
                                if (ii.Details.ID == qci.Details.ID)
                                {
                                    foundItemInPlayersInventory = true;

                                    if (ii.Quantity < qci.Quantity)
                                    {
                                        // The player does not have enough of this item to complete the quest
                                        playerHasAllItemsToCompleteQuest = false;

                                        // There is no reason to continue checking for the other quest completion items
                                        break;
                                    }

                                    // We found the item, so don't check the rest of the player's inventory
                                    break;
                                }
                            }

                            // If we didn't find the required item, set our variable and stop looking for other items
                            if (!foundItemInPlayersInventory)
                            {
                                // The player does not have this item in their inventory
                                playerHasAllItemsToCompleteQuest = false;

                                // There is no reason to continue checking for the other quest completion items
                                break;
                            }
                        }

                        // The player has all items required to complete the quest
                        if (playerHasAllItemsToCompleteQuest)
                        {
                            // Display message
                            messagesRichTextBox.Text += Environment.NewLine;
                            messagesRichTextBox.Text += "You complete the '" + newLocation.QuestAvailableHere.Name + "' quest." + Environment.NewLine;

                            // Remove quest items from inventory
                            foreach (QuestCompletionItem qci in newLocation.QuestAvailableHere.QuestCompletionItems)
                            {
                                foreach (InventoryItem ii in _player.Inventory)
                                {
                                    if (ii.Details.ID == qci.Details.ID)
                                    {
                                        // Subtract the quantity from the player's inventory that was needed to complete the quest
                                        ii.Quantity -= qci.Quantity;
                                        break;
                                    }
                                }
                            }

                            // Give quest rewards
                            messagesRichTextBox.Text += "You receive: " + Environment.NewLine;
                            messagesRichTextBox.Text += newLocation.QuestAvailableHere.RewardExperiencePoints.ToString() + " experience points" + Environment.NewLine;
                            messagesRichTextBox.Text += newLocation.QuestAvailableHere.RewardGold.ToString() + " gold" + Environment.NewLine;
                            messagesRichTextBox.Text += newLocation.QuestAvailableHere.RewardItem.Name + Environment.NewLine;
                            messagesRichTextBox.Text += Environment.NewLine;

                            _player.ExperiencePoints += newLocation.QuestAvailableHere.RewardExperiencePoints;
                            _player.Gold += newLocation.QuestAvailableHere.RewardGold;

                            // Add the reward item to the player's inventory
                            bool addedItemToPlayerInventory = false;

                            foreach (InventoryItem ii in _player.Inventory)
                            {
                                if (ii.Details.ID == newLocation.QuestAvailableHere.RewardItem.ID)
                                {
                                    // They have the item in their inventory, so increase the quantity by one
                                    ii.Quantity++;

                                    addedItemToPlayerInventory = true;

                                    break;
                                }
                            }

                            // They didn't have the item, so add it to their inventory, with a quantity of 1
                            if (!addedItemToPlayerInventory)
                            {
                                _player.Inventory.Add(new InventoryItem(newLocation.QuestAvailableHere.RewardItem, 1));
                            }

                            // Mark the quest as completed
                            // Find the quest in the player's quest list
                            foreach (PlayerQuest pq in _player.Quests)
                            {
                                if (pq.Details.ID == newLocation.QuestAvailableHere.ID)
                                {
                                    // Mark it as completed
                                    pq.IsCompleted = true;

                                    break;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                // The player does not already have the quest
                MoveTo(World.LocationByID(World.QUEST_ID_CLEAR_ALCHEMIST_GARDEN));
                //var quest = World.QuestByID(World.QUEST_ID_CLEAR_ALCHEMIST_GARDEN).ID;
                //newLocation.QuestAvailableHere.ID = quest;

                // Display the messages
                messagesRichTextBox.Text += "You receive the " + newLocation.QuestAvailableHere.Name + " quest." + Environment.NewLine;
                //messagesRichTextBox.Text += newLocation.QuestAvailableHere.Description + Environment.NewLine;
                messagesRichTextBox.Text += "To complete it, return with:" + Environment.NewLine;
                foreach (QuestCompletionItem qci in newLocation.QuestAvailableHere.QuestCompletionItems)
                {
                    if (qci.Quantity == 1)
                    {
                        messagesRichTextBox.Text += qci.Quantity.ToString() + " " + qci.Details.Name + Environment.NewLine;
                    }
                    else
                    {
                        messagesRichTextBox.Text += qci.Quantity.ToString() + " " + qci.Details.NamePlural + Environment.NewLine;
                    }
                }
                messagesRichTextBox.Text += Environment.NewLine;

                // Add the quest to the player's quest list
                _player.Quests.Add(new PlayerQuest(newLocation.QuestAvailableHere));
            }

            // Does the location have a monster?
            if (newLocation.MonsterLivingHere != null)
            {
                messagesRichTextBox.Text += "You see a " + newLocation.MonsterLivingHere.Name + Environment.NewLine;

                // Make a new monster, using the values from the standard monster in the World.Monster list
                Monster standardMonster = World.MonsterByID(newLocation.MonsterLivingHere.ID);

                _currentMonster = new Monster(standardMonster.ID, standardMonster.Name, standardMonster.MaximumDamage,
                    standardMonster.RewardExperiencePoints, standardMonster.RewardGold, standardMonster.CurrentHitPoints, standardMonster.MaximumHitPoints);

                foreach (LootItem lootItem in standardMonster.LootTable)
                {
                    _currentMonster.LootTable.Add(lootItem);
                }

                weaponsComboBox.Visible = true;
                potionsComboBox.Visible = true;
                useWeaponButton.Visible = true;
                usePotionButton.Visible = true;
            }
            else
            {
                _currentMonster = null;

                weaponsComboBox.Visible = false;
                potionsComboBox.Visible = false;
                useWeaponButton.Visible = false;
                usePotionButton.Visible = false;
            }

            // Refresh player's inventory list
            InventoryDataGridView.RowHeadersVisible = false;

            InventoryDataGridView.ColumnCount = 2;
            InventoryDataGridView.Columns[0].Name = "Name";
            InventoryDataGridView.Columns[0].Width = 197;
            InventoryDataGridView.Columns[1].Name = "Quantity";

            InventoryDataGridView.Rows.Clear();

            foreach (InventoryItem inventoryItem in _player.Inventory)
            {
                if (inventoryItem.Quantity > 0)
                {
                    InventoryDataGridView.Rows.Add(new[] { inventoryItem.Details.Name, inventoryItem.Quantity.ToString() });
                }
            }

            // Refresh player's quest list
            questsDataGridView.RowHeadersVisible = false;

            questsDataGridView.ColumnCount = 2;
            questsDataGridView.Columns[0].Name = "Name";
            questsDataGridView.Columns[0].Width = 197;
            questsDataGridView.Columns[1].Name = "Done?";

            questsDataGridView.Rows.Clear();

            foreach (PlayerQuest playerQuest in _player.Quests)
            {
                questsDataGridView.Rows.Add(new[] { playerQuest.Details.Name, playerQuest.IsCompleted.ToString() });
            }

            // Refresh player's weapons combobox
            List<Weapon> weapons = new List<Weapon>();

            foreach (InventoryItem inventoryItem in _player.Inventory)
            {
                if (inventoryItem.Details is Weapon)
                {
                    if (inventoryItem.Quantity > 0)
                    {
                        weapons.Add((Weapon)inventoryItem.Details);
                    }
                }
            }

            if (weapons.Count == 0)
            {
                // The player doesn't have any weapons, so hide the weapon combobox and "Use" button
                weaponsComboBox.Visible = false;
                useWeaponButton.Visible = false;
            }
            else
            {
                weaponsComboBox.DataSource = weapons;
                weaponsComboBox.DisplayMember = "Name";
                weaponsComboBox.ValueMember = "ID";

                weaponsComboBox.SelectedIndex = 0;
            }

            // Refresh player's potions combobox
            List<HealingPotion> healingPotions = new List<HealingPotion>();

            foreach (InventoryItem inventoryItem in _player.Inventory)
            {
                if (inventoryItem.Details is HealingPotion)
                {
                    if (inventoryItem.Quantity > 0)
                    {
                        healingPotions.Add((HealingPotion)inventoryItem.Details);
                    }
                }
            }

            if (healingPotions.Count == 0)
            {
                // The player doesn't have any potions, so hide the potion combobox and "Use" button
                potionsComboBox.Visible = false;
                usePotionButton.Visible = false;
            }
            else
            {
                potionsComboBox.DataSource = healingPotions;
                potionsComboBox.DisplayMember = "Name";
                potionsComboBox.ValueMember = "ID";

                potionsComboBox.SelectedIndex = 0;
            }
        }

        private void northButton_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToNorth);
        }

        private void eastButton_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToEast);
        }

        private void southButton_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToSouth);
        }

        private void westButton_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToWest);
        }

        private void useWeaponButton_Click(object sender, EventArgs e)
        {

        }

        private void usePotionButton_Click(object sender, EventArgs e)
        {

        }
    }
}
