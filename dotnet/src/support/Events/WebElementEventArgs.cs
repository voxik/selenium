// <copyright file="WebElementEventArgs.cs" company="Selenium Committers">
// Licensed to the Software Freedom Conservancy (SFC) under one
// or more contributor license agreements.  See the NOTICE file
// distributed with this work for additional information
// regarding copyright ownership.  The SFC licenses this file
// to you under the Apache License, Version 2.0 (the
// "License"); you may not use this file except in compliance
// with the License.  You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, either express or implied.  See the License for the
// specific language governing permissions and limitations
// under the License.
// </copyright>

using System;

namespace OpenQA.Selenium.Support.Events
{
    /// <summary>
    /// Provides data for events relating to elements.
    /// </summary>
    public class WebElementEventArgs : EventArgs
    {
        private IWebDriver driver;
        private IWebElement element;

        /// <summary>
        /// Initializes a new instance of the <see cref="WebElementEventArgs"/> class.
        /// </summary>
        /// <param name="driver">The WebDriver instance used for the action.</param>
        /// <param name="element">The element used for the action.</param>
        public WebElementEventArgs(IWebDriver driver, IWebElement element)
        {
            this.driver = driver;
            this.element = element;
        }

        /// <summary>
        /// Gets the WebDriver instance used for the action.
        /// </summary>
        public IWebDriver Driver
        {
            get { return this.driver; }
        }

        /// <summary>
        /// Gets the element used for the action.
        /// </summary>
        public IWebElement Element
        {
            get { return this.element; }
        }
    }
}
