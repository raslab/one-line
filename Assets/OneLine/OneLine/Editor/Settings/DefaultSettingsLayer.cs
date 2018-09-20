﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OneLine.Settings {
    public class DefaultSettingsLayer : ISettings {
        public TernaryBoolean Enabled { 
            get { return TernaryBoolean.TRUE; } 
        }
    }
}