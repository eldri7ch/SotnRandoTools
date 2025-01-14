﻿using NSubstitute;
using SotnRandoTools.Configuration.Interfaces;
using SotnRandoTools.RandoTracker.Interfaces;
using System;
using Xunit;

namespace SotnRandoTools.RandoTracker.Tests.TrackerGraphicsEngineTests
{
    public class ChangeGraphicsShould
    {
        [Fact]
        public void ThrowArgumentNullException_WhenGraphicsArgumentIsNull()
        {
            //Arrange
            var mockedFormGraphics = Substitute.For<IGraphics>();
            var mockedToolConfig = Substitute.For<IToolConfig>();
            //Act
            TrackerGraphicsEngine trackerGraphicsEngine = new TrackerGraphicsEngine(mockedFormGraphics, mockedToolConfig);
            //Assert
            Assert.Throws<ArgumentNullException>(() => trackerGraphicsEngine.ChangeGraphics(null));
        }
    }
}
