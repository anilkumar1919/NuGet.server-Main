// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information. 
namespace NuGet.Server.Core.Infrastructure
{
    public interface ISettingsProvider
    {
        bool GetBoolSetting(string key, bool defaultValue);
        string GetStringSetting(string key, string defaultValue);
        int GetIntSetting(string key, int defaultValue);
    }
}
