/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 * --------------------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using Concepts.Improvables;
using Concepts.SourceControl;
using Dolittle.Collections;
using Dolittle.Validation;
using Domain.Improvables;
using Machine.Specifications;

namespace Domain.Specs.for_Improvable.when_registering.when_validating
{

    [Subject(typeof(RegisterImprovableInputValidator))]
    public class and_the_improvable_name_is_invalid : given.an_input_validator_for<and_the_improvable_name_is_invalid>
    {
        protected static RegisterImprovable register;
        protected static IEnumerable<ValidationResult> results;

        Establish context = () => 
        {
            Action<RegisterImprovable> invalidation = _ => _.Name = ImprovableName.Empty;
            register = constants.get_command(new []{ invalidation});
        };

        Because of = () => results = input_validator.ValidateFor(register);

        It should_not_be_valid = () => results.ShouldBeInvalid();
        It should_indicate_that_the_improvable_name_is_invalid = () => results.ShouldHaveInvalidProperty(nameof(RegisterImprovable.Name));
    }   
}