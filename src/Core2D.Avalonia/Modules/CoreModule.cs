﻿// Copyright (c) Wiesław Šoltés. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System.Reflection;
using Autofac;
using Core2D.Editor;
using Core2D.Editor.Bounds;
using Core2D.Editor.Factories;

namespace Core2D.Avalonia.Modules
{
    /// <summary>
    /// Core components module.
    /// </summary>
    public class CoreModule : Autofac.Module
    {
        /// <inheritdoc/>
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProjectEditor>().As<ProjectEditor>().InstancePerLifetimeScope();
            builder.RegisterType<ProjectFactory>().As<IProjectFactory>().InstancePerLifetimeScope();
            builder.RegisterType<ShapeFactory>().As<IShapeFactory>().InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(typeof(ToolBase).GetTypeInfo().Assembly).As<ToolBase>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(typeof(PathToolBase).GetTypeInfo().Assembly).As<PathToolBase>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<HitTest>().As<HitTest>().InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(typeof(HitTestBase).GetTypeInfo().Assembly).As<HitTestBase>().AsSelf().InstancePerLifetimeScope();
        }
    }
}
