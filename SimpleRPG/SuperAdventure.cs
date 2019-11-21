﻿using Engine;
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

        public SuperAdventure()
        {
            InitializeComponent();

            hitPointsTextBox.Text = _player.CurrentHitPoints.ToString();
            goldTextBox.Text = _player.Gold.ToString();
            experienceTextBox.Text = _player.ExperiencePoints.ToString();
            levelTextBox.Text = _player.Level.ToString();

        }

        
    }
}
