﻿/*---------------------------------------------------------------------------------------------
 *  This file is an automatically generated ReadModel Proxy
 *  
 *--------------------------------------------------------------------------------------------*/
import { ReadModel } from  '@dolittle/readmodels';

export class StepResult extends ReadModel
{
    constructor() {
        super();
        this.artifact = {
           id: '37219384-44d8-46b7-aa9f-d91c5c0586f9',
           generation: '1'
        };
        this.severity = {};
        this.project = '';
        this.file = '';
        this.line = 0;
        this.column = 0;
        this.code = '';
        this.message = '';
        this.originalLine = 0;
    }
}