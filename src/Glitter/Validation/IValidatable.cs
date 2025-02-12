/*
   Copyright 2023 tacosontitan and contributors

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

namespace Glitter.Validation;

/// <summary>
/// Defines methods for providing basic validation.
/// </summary>
public interface IValidatable
{
    /// <summary>
    /// Validates the implementing instance.
    /// </summary>
    void Validate();

    /// <summary>
    /// Attempts to validate the implementing instance.
    /// </summary>
    /// <returns><see langword="true"/> if the validation was successful; otherwise, <see langword="false"/>.</returns>
    bool TryValidate();
}
