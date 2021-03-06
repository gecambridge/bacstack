﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eto;
using Eto.Forms;
using BACnet.Core.Datalink;
using BACnet.Explorer.Core.Models;

namespace BACnet.Explorer.Core.Controls
{
    public class NetworkDatabaseSettings : DynamicLayout
    {
        private NetworkDatabaseProcess _process;
        private TextBox _name;
        private NumericUpDown _processId;
        private TextBox _databasePath;

        public NetworkDatabaseSettings(NetworkDatabaseProcess process)
        {
            _process = process;

            _name = new TextBox();
            _name.Bind(
                tb => tb.Text,
                _process,
                proc => proc.Name,
                DualBindingMode.TwoWay);

            _processId = new NumericUpDown();
            _processId.Bind(
                nud => nud.Value,
                _process,
                proc => proc.ProcessId,
                DualBindingMode.TwoWay);

            _databasePath = new TextBox();
            _databasePath.Bind(
                tb => tb.Text,
                _process,
                proc => proc.DatabasePath,
                DualBindingMode.TwoWay);

            this.AddRow(new Label() { Text = Constants.ProcessNameLabel }, _name);
            this.AddRow(new Label() { Text = Constants.ProcessIdLabel }, _processId);

            this.AddRow();
        }
    }
}
