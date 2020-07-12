// Copyright (c) Microsoft Corporation. All rights reserved.
//
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

using Windows.ApplicationModel.Core;

namespace CoreWindowExample
{
    class ViewSource : IFrameworkViewSource
    {
        public IFrameworkView CreateView()
        {
            return new App();
        }
    }
}
