﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Generated by JetBrains ErrorDescriptionGenerator
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using JetBrains.DataFlow;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Daemon;
using JetBrains.DocumentModel;
using JetBrains.ReSharper.Psi.Resolve;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.Util;
using JetBrains.ReSharper.Psi.CSharp.Tree;
using JetBrains.ReSharper.Daemon;
using JetBrains.ReSharper.Daemon.UsageChecking;

namespace DotZ.Zones.Inspections
{
  [JetBrains.Application.ShellComponent]
  class SeverityRegistrar1058356543Component
  {
    public SeverityRegistrar1058356543Component(Lifetime lifetime, JetBrains.ReSharper.Daemon.IQuickFixes table)
    {
      table.RegisterQuickFix<IncorrectReferenceError>(lifetime, h => new AddDependencyNearby(h), typeof(AddDependencyNearby), null, BeforeOrAfter.Before);
    }
  }
}